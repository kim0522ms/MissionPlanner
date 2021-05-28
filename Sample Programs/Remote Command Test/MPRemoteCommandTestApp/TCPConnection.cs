using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MPRemoteCommandTestApp
{
    public class TCPConnection
    {
        #region [ Member Variables ]
        private string _host_address;
        private int _host_port;
        private Socket _client;
        #endregion

        ~TCPConnection()
        {
            if (IsConnected())
                Disconnect();
        }
        
        public bool IsConnected()
        {
            return (_client != null && _client.Connected == true) ? true : false;
        }
        public void Disconnect()
        {
            // TODO : Implement Disconnect() function
            try
            {
                if (_client != null)
                {
                    // Release the socket.  
                    _client.Shutdown(SocketShutdown.Both);
                    _client.Close();
                }
                else if (IsConnected() == false)
                    MainForm.Log("Not connected!");
            } catch (Exception ex)
            {
                MainForm.Log("Error occurred while disconnect current session.", "Disconnect()");
            }
            finally
            {
                MainForm.UpdateCurrentHostName();
            }
        }
        public void Connect(string host_address, int host_port = 7001)
        {
            if (IsConnected())
                Disconnect();
            
            MainForm.Log(string.Format("Try to connect with {0}:{1} ....", host_address, host_port), "Connect()");
                        
            IPAddress ipAddress = IPAddress.Parse(host_address);
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, host_port);

            // Create a TCP/IP socket.  
            _client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Connect to the remote endpoint.  
            _client.BeginConnect(remoteEP, new AsyncCallback(ConnectCallback), _client);
            connectDone.WaitOne();

            MainForm.Log(string.Format("Connected to {0}", _client.RemoteEndPoint.ToString()));

            this._host_address = host_address;
            this._host_port = host_port;

            MainForm.UpdateCurrentHostName(this._host_address, this._host_port);
        }

        public void Send(string message, bool isRawMessage = false)
        {
            if (isRawMessage == false)
            {
                var json = new JObject();
                json.Add("HEADER", message);
                message = JsonConvert.SerializeObject(json);
            }

            message = message + "<EOF>";
            // Convert the string data to byte data using ASCII encoding.  
            byte[] byteData = Encoding.ASCII.GetBytes(message);

            // Begin sending the data to the remote device.  
            _client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), _client);
        }

        public class StateObject
        {
            // Client socket.  
            public Socket workSocket = null;
            // Size of receive buffer.  
            public const int BufferSize = 256;
            // Receive buffer.  
            public byte[] buffer = new byte[BufferSize];
            // Received data string.  
            public StringBuilder sb = new StringBuilder();
        }
        
        // ManualResetEvent instances signal completion.  
        private static ManualResetEvent connectDone =
            new ManualResetEvent(false);
        private static ManualResetEvent receiveDone =
            new ManualResetEvent(false);

        // The response from the remote device.  
        private static String response = String.Empty;
        
        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.  
                client.EndConnect(ar);
                
                // Signal that the connection has been made.  
                connectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Receive(Socket client)
        {
            try
            {
                // Create the state object.  
                StateObject state = new StateObject();
                state.workSocket = client;

                // Begin receiving the data from the remote device.  
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket
                // from the asynchronous state object.  
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                // Read data from the remote device.  
                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.  
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    // Get the rest of the data.  
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    // All the data has arrived; put it in response.  
                    if (state.sb.Length > 1)
                    {
                        response = state.sb.ToString();
                    }
                    // Signal that all bytes have been received.  
                    receiveDone.Set();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                int bytesSent = client.EndSend(ar);
            }
            catch (Exception e)
            {
            }
        }

    }
}
