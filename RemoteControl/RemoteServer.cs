using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Swarm;
using MissionPlanner.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MissionPlanner.RemoteControl
{
    public class RemoteServer
    {
        private class StateObject
        {
            // Size of receive buffer.  
            public const int BufferSize = 1024;

            // Receive buffer.  
            public byte[] buffer = new byte[BufferSize];

            // Received data string.
            public StringBuilder sb = new StringBuilder();

            // Client socket.
            public Socket workSocket = null;
        }
        private ManualResetEvent allDone = new ManualResetEvent(false);
        private MainV2 _targetForm;

        private FormationControl formationControl;


        public RemoteServer(MainV2 targetForm)
        {
            _targetForm = targetForm;

            Thread threadRemoteTcpServer = new Thread(new ThreadStart(StartListening));
            threadRemoteTcpServer.Start();
        }

        public void StartListening()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            //IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPAddress ipAddress = new IPAddress(new byte[] { 0, 0, 0, 0 });
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);

                while (true)
                {
                    allDone.Reset();

                    CustomMessageBox._NoDialogMode = true;
                    Console.WriteLine("Waiting for a connection...");
                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback),
                        listener);

                    allDone.WaitOne();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();
        }

        public void AcceptCallback(IAsyncResult ar)
        {
            allDone.Set();

            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            try
            {
                int bytesRead = handler.EndReceive(ar);

                if (bytesRead > 0)
                {
                    //state.sb.Clear();
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    content = state.sb.ToString();

                    if (content.IndexOf("<EOF>") > -1)
                    {
                        content = content.Replace("<EOF>", "");
                        state.sb.Clear();
                        string response = ParseContent(content);
                        Send(handler, response);

                    }
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
                }
            }
            catch
            {
                return;
            }
        }

        private void Send(Socket handler, String data)
        {
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), handler);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket handler = (Socket)ar.AsyncState;

                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                //handler.Shutdown(SocketShutdown.Both);
                //handler.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private string ParseContent(string content)
        {
            string response = "";
            try
            {
                List<string> args = new List<string>();

                JObject header = JObject.Parse(((JObject)JsonConvert.DeserializeObject(content))["HEADER"].ToString());
                string command = header["command"].ToString();

                JArray jarr = (JArray)header["args"];
                foreach (var argument in jarr)
                {
                    args.Add(argument.ToString());
                }

                switch (command.ToUpper())
                {
                    case "CONNECT":
                        if (args.Count == 0)
                            break;

                        List<string> hosts = new List<string>();
                        List<string> ports = new List<string>();

                        foreach (string arg in args)
                        {
                            JObject jobj = (JObject)JsonConvert.DeserializeObject(arg);
                            hosts.Add(jobj["host"].ToString());
                            ports.Add(jobj["port"].ToString());
                        }
                        
                        if (hosts.Count > 0)
                            _targetForm.Invoke(new MethodInvoker(delegate () { _targetForm.NoDialog_Connect(hosts.ToArray(), ports.ToArray(), "UDP"); }));
                        break;
                    case "DISCONNECT":
                        if (args.Count != 0)
                            break;

                        _targetForm.Invoke(new MethodInvoker(delegate () { _targetForm.doDisconnect(MainV2.comPort); }));
                        response = "Disconnected";
                        break;

                    case "ARM":
                        if (args.Count != 0)
                            break;

                        _targetForm.Invoke(new MethodInvoker(delegate () { _targetForm.FlightData.NoDialog_ARM(); }));
                        break;


                    case "MISSION_START":
                        _targetForm.Invoke(new MethodInvoker(delegate () { _targetForm.FlightData.NoDialog_SetMode("Stabilize"); }));
                        _targetForm.Invoke(new MethodInvoker(delegate () { _targetForm.FlightData.NoDialog_ActionDo("Mission_Start"); }));
                        break;


                    case "MODE":
                        if (args.Count != 1)
                            break;

                        _targetForm.Invoke(new MethodInvoker(delegate () { _targetForm.FlightData.NoDialog_SetMode(args[0]); }));
                        break;

                    case "CHANGE_TAB":
                        if (args.Count != 1)
                            break;

                        _targetForm.Invoke(new MethodInvoker(delegate () { MainV2.View.ShowScreen(MainV2.View.screens[Convert.ToInt32(args[0])].Name); }));
                        break;

                    #region [ Swarm Commands ]
                    case "SWARM_INIT":
                        if (args.Count != 0)
                            break;

                        if (formationControl == null)
                        {
                            formationControl = new FormationControl();
                            formationControl._NoDialogMode = true;
                        }
                            
                        break;

                    case "SWARM_SET_LEADER":
                        //if (args.Count != 1 || formationControl == null)
                        //    break;

                        formationControl.NoDialog_SetLeader(MainV2.comPort.MAV);
                        break;
                    case "SWARM_GUIDE_MODE":
                        if (formationControl.SwarmInterface != null)
                            formationControl.SwarmInterface.GuidedMode();
                        break;

                    case "SWARM_ARM":
                        if (formationControl.SwarmInterface != null)
                            formationControl.SwarmInterface.Arm();
                        break;

                    case "SWARM_TAKEOFF":
                        if (formationControl.SwarmInterface != null)
                            formationControl.SwarmInterface.Takeoff(15);
                        break;
                    case "SWARM_LAND":
                        if (formationControl.SwarmInterface != null)
                            formationControl.SwarmInterface.Land();
                        break;

                    case "SWARM_START":
                    case "SWARM_STOP":
                        if (formationControl.SwarmInterface != null)
                            formationControl.ChangeSwarmThreadState();
                        break;

                    case "SWARM_SET_POSITION_TEST":
                        if (formationControl.SwarmInterface != null)
                        {
                            int _x = Convert.ToInt32(args[0]);
                            int _y = Convert.ToInt32(args[0]);
                            foreach (var port in MainV2.Comports)
                            {
                                foreach (var mav in port.MAVlist)
                                {
                                    if (mav == ((Formation)formationControl.SwarmInterface).getLeader())
                                        continue;

                                    Vector3 vector = formationControl.SwarmInterface.getOffsets(mav);
                                    vector.x = _x;
                                    vector.y = _y;
                                    vector.z = 10;
                                    _x += Convert.ToInt32(args[0]);
                                    _y += Convert.ToInt32(args[0]);
                                    formationControl.SetPosition(mav, vector);
                                }
                            }
                        }
                        break;

                    #endregion

                    case "READ_MISSION":
                        _targetForm.Invoke(new MethodInvoker(delegate () {
                            _targetForm.FlightPlanner.NoDialog_ReadWayPoints(MAVLink.MAV_MISSION_TYPE.MISSION);
                        }));
                        break;
                    case "WRITE_MISSION":
                        // Parse waypoints from recieved json object
                        if (args.Count < 1)
                            break;

                        _targetForm.Invoke(new MethodInvoker(delegate () {
                            List<Locationwp> waypoints = new List<Locationwp>();
                            waypoints.Add(_targetForm.FlightPlanner.NoDialog_ReadWayPoints(MAVLink.MAV_MISSION_TYPE.MISSION)[0]);

                            foreach (string arg in args)
                            {
                                JObject jobj = (JObject)JsonConvert.DeserializeObject(arg);
                                Locationwp wp = new Locationwp();
                                wp.id = Convert.ToUInt16(jobj["id"].ToString());
                                wp.p1 = Convert.ToSingle(jobj["p1"].ToString());
                                wp.p2 = Convert.ToSingle(jobj["p2"].ToString());
                                wp.p3 = Convert.ToSingle(jobj["p3"].ToString());
                                wp.p4 = Convert.ToSingle(jobj["p4"].ToString());
                                wp.lat = Convert.ToDouble(jobj["lat"].ToString());
                                wp.lng = Convert.ToDouble(jobj["lng"].ToString());
                                wp.alt = Convert.ToSingle(jobj["alt"].ToString());
                                wp._seq = Convert.ToUInt16(jobj["seq"].ToString());
                                wp.frame = Convert.ToByte(jobj["frame"].ToString());

                                waypoints.Add(wp);
                            }

                            bool result = _targetForm.FlightPlanner.NoDialog_WriteWayPoints(MAVLink.MAV_MISSION_TYPE.MISSION, waypoints);
                        }));
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                // TODO : Handle exception
                response = "Invaild command or arguments";
            }
            return response;
        }
    }
}
