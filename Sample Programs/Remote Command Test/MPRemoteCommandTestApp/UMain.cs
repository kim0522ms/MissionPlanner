using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MPRemoteCommandTestApp.DTO;
using Term1_TCPClient;

namespace MPRemoteCommandTestApp
{
    public partial class MainForm : Form
    {
        private static DataGridView         _dgLogMessage;
        private static DataGridView         _dgTriggeredData;
        private static Label                _lbCurrentHostName;
        private static ToolStripStatusLabel _ttConnectionStatus;

        private TCPConnection _tcp;

        #region [ Form Events ]
        public MainForm()
        {
            InitializeComponent();
            _dgLogMessage       = dgLogMessage;
            _dgTriggeredData    = dgTriggeredData;
            _lbCurrentHostName  = lbCurrentHostName;
            _ttConnectionStatus = ttConnectionStatus;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_tcp != null)
                _tcp.Disconnect();
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            #region [ Edit DataGridView attributes ]
            // dgLogMessage
            dgLogMessage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgLogMessage.Columns[0].Width = (int)(dgLogMessage.Width * 0.25);
            dgLogMessage.Columns[1].Width = (int)(dgLogMessage.Width * 0.15);
            dgLogMessage.Columns[2].Width = (int)(dgLogMessage.Width * 0.6);

            dgLogMessage.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgLogMessage.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgLogMessage.Font = new Font("굴림", 8, FontStyle.Regular);

            // dgTriggeredData
            dgTriggeredData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgTriggeredData.Columns[0].Width = (int)(dgLogMessage.Width * 0.25);
            dgTriggeredData.Columns[1].Width = (int)(dgLogMessage.Width * 0.75);

            dgTriggeredData.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgTriggeredData.Font = new Font("굴림", 8, FontStyle.Regular);

            #endregion
        }
        #endregion
        #region [ Button Events ]
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Check server information is inputted or not
            if (tbHostAddress.Text.Equals(""))
            {
                MessageBox.Show("Please input server address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (tbHostPort.Text.Equals("") || tbHostPort.Text == null)
            {
                MessageBox.Show("Please input server port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidateIPAddress(tbHostAddress.Text) == false)
            {
                MessageBox.Show("Please input proper address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_tcp != null && _tcp.IsConnected())
                _tcp.Disconnect();

            ttConnectionStatus.Text = "Connecting...";
            // Establish Connection
            _tcp = new TCPConnection();

            _tcp.Connect(tbHostAddress.Text, Convert.ToInt32(tbHostPort.Text));
        }  
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (_tcp != null && _tcp.IsConnected())
                _tcp.Disconnect();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbTriggerMessage.Text.Equals(""))
            {
                MessageBox.Show("Please input trigger text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _tcp.Send(tbTriggerMessage.Text, cbxRawText.Checked);
        }
        #endregion
        #region [ DataGridView Handler ]
        public static void Log(string message, string target = null, DataGridView dgLogMessage = null)
        {
            if (dgLogMessage == null)
                dgLogMessage = MainForm._dgLogMessage;

            dgLogMessage.Invoke(new MethodInvoker(delegate ()
            {
                dgLogMessage.Rows.Add(DateTime.Now.ToString(), target != null ? target : "System", message);
                dgLogMessage.CurrentCell = dgLogMessage.Rows[dgLogMessage.Rows.Count - 1].Cells[0];
            }));
        }
        public static void AddData(string message, DataGridView dgTriggerdData = null)
        {
            if (dgTriggerdData == null)
                dgTriggerdData = MainForm._dgTriggeredData;

            dgTriggerdData.Invoke(new MethodInvoker(delegate ()
            {
                dgTriggerdData.Rows.Add(DateTime.Now.ToString(), message);
                dgTriggerdData.CurrentCell = dgTriggerdData.Rows[dgTriggerdData.Rows.Count - 1].Cells[0];
            }));
        }
        #endregion

        public static void UpdateCurrentHostName(string ipAddress = null, int port = 0, Label lbCurrentHostName = null)
        {
            string hostInfo = "None (Disconnected)";
            if (ipAddress != null && port != 0)
            {
                hostInfo = string.Format("{0}:{1}", ipAddress, port);
                UpdateConnectionStateToolTip(true);
            }
            else
                UpdateConnectionStateToolTip(false);
                
            
            if (lbCurrentHostName == null)
                lbCurrentHostName = _lbCurrentHostName;
            
            lbCurrentHostName.Invoke(new MethodInvoker(delegate ()
            {
                lbCurrentHostName.Text = hostInfo;
            }));
        }

        public static void UpdateConnectionStateToolTip(bool state)
        {
            _ttConnectionStatus.Text = state ? "Connected" : "Disconnected";
        }

        private bool ValidateIPAddress(string ip)
        {
            Regex regex = new Regex(@"^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$");

            if (regex.IsMatch(ip))
                return true;
            return false;
        }

        #region [ Preset Buttons ]
        private string MakeMPCommandJson(string command, object[] args)
        {
            JObject jobjCommand = new JObject();
            jobjCommand.Add("command", command);
            jobjCommand.Add("args", new JArray(args));

            return jobjCommand.ToString();
        }

        private void btnPresetConnect_Click(object sender, EventArgs e)
        {
            object[] args = new object[] { };

            UDialogConnection dialog = new UDialogConnection();
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _tcp.Send(MakeMPCommandJson("CONNECT", dialog.result.ToArray()));
            }
        }

        private void btnPresetDisconnect_Click(object sender, EventArgs e)
        {
            string[] args = { };
            _tcp.Send(MakeMPCommandJson("DISCONNECT", args));
        }

        private void btnPresetArm_Click(object sender, EventArgs e)
        {
            string[] args = { };
            _tcp.Send(MakeMPCommandJson("ARM", args));
        }

        private void btnPresetMissionStart_Click(object sender, EventArgs e)
        {
            string[] args = { };
            _tcp.Send(MakeMPCommandJson("MISSION_START", args));
        }

        private void btnPresetStabilize_Click(object sender, EventArgs e)
        {
            string[] args = { "Stabilize" };
            _tcp.Send(MakeMPCommandJson("MODE", args));
        }

        private void btnPresetAuto_Click(object sender, EventArgs e)
        {
            string[] args = { "Auto" };
            _tcp.Send(MakeMPCommandJson("MODE", args));
        }

        private void btnPresetUploadMap1_Click(object sender, EventArgs e)
        {
            object[] args =
            {
                Waypoint.ToJObject("22", "0", "0", "0", "0", "0", "0", "100", "1", "3"),
                Waypoint.ToJObject("16", "0", "0", "0", "0", "-35.3636547", "149.1625679", "100", "2", "3"),
                Waypoint.ToJObject("16", "0", "0", "0", "0", "-35.3616511", "149.1632652", "100", "3", "3"),
                Waypoint.ToJObject("20", "0", "0", "0", "0", "0", "0", "0", "4", "3")
            };

            _tcp.Send(MakeMPCommandJson("WRITE_MISSION", args));
        }

        private void btnPresetUploadMap2_Click(object sender, EventArgs e)
        {
            object[] args =
            {
                Waypoint.ToJObject("22", "0", "0", "0", "0", "0", "0", "10", "1", "3"),
                Waypoint.ToJObject("16", "0", "0", "0", "0", "-35.3634797", "149.1633725", "10", "2", "3"),
                Waypoint.ToJObject("16", "0", "0", "0", "0", "-35.3628585", "149.1632867", "10", "3", "3"),
                Waypoint.ToJObject("16", "0", "0", "0", "0", "-35.3625698", "149.1666555", "10", "4", "3"),
                Waypoint.ToJObject("16", "0", "0", "0", "0", "-35.3637072", "149.1668057", "10", "5", "3"),
                Waypoint.ToJObject("16", "0", "0", "0", "0", "-35.3640397", "149.1629648", "10", "6", "3"),
                Waypoint.ToJObject("16", "0", "0", "0", "0", "-35.3625698", "149.1627073", "10", "7", "3"),
                Waypoint.ToJObject("16", "0", "0", "0", "0", "-35.3621061", "149.1671491", "10", "8", "3"),
                Waypoint.ToJObject("16", "0", "0", "0", "0", "-35.3640484", "149.1674066", "10", "9", "3"),
                Waypoint.ToJObject("16", "0", "0", "0", "0", "-35.3642847", "149.1652822", "10", "10", "3"),
                Waypoint.ToJObject("20", "0", "0", "0", "0", "0", "0", "0", "11", "3")

            };

            _tcp.Send(MakeMPCommandJson("WRITE_MISSION", args));
        }
       

        #endregion

        private void btnPresetInitSwarm_Click(object sender, EventArgs e)
        {
            string[] args = { };
            _tcp.Send(MakeMPCommandJson("SWARM_INIT", args));
        }

        private void btnPresetSetLeader_Click(object sender, EventArgs e)
        {
            string[] args = { };
            _tcp.Send(MakeMPCommandJson("SWARM_SET_LEADER", args));
        }

        private void btnPresetSetSwarmGuideMode_Click(object sender, EventArgs e)
        {
            string[] args = { };
            _tcp.Send(MakeMPCommandJson("SWARM_GUIDE_MODE", args));
        }

        private void btnPresetSetSwarmArm_Click(object sender, EventArgs e)
        {
            string[] args = { };
            _tcp.Send(MakeMPCommandJson("SWARM_ARM", args));
        }

        private void btnSwarmTakeOff_Click(object sender, EventArgs e)
        {
            string[] args = { };
            _tcp.Send(MakeMPCommandJson("SWARM_TAKEOFF", args));
        }

        private void btnSwarmLand_Click(object sender, EventArgs e)
        {
            string[] args = { };
            _tcp.Send(MakeMPCommandJson("SWARM_LAND", args));
        }

        private void btnSwarmStart_Click(object sender, EventArgs e)
        {
            string[] args = { };
            _tcp.Send(MakeMPCommandJson("SWARM_START", args));
        }

        private void btnSwarmSetPosition01_Click(object sender, EventArgs e)
        {
            string[] args = {"30"};
            _tcp.Send(MakeMPCommandJson("SWARM_SET_POSITION_TEST", args));
        }

        private void btnSwarmSetPosition02_Click(object sender, EventArgs e)
        {
            string[] args = { "15" };
            _tcp.Send(MakeMPCommandJson("SWARM_SET_POSITION_TEST", args));
        }
    }
}
