namespace MPRemoteCommandTestApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbTriggerMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbHostAddress = new System.Windows.Forms.Label();
            this.tbHostAddress = new System.Windows.Forms.TextBox();
            this.lbHostPort = new System.Windows.Forms.Label();
            this.tbHostPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.dgTriggeredData = new System.Windows.Forms.DataGridView();
            this.triggerTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.triggerData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbLogMessage = new System.Windows.Forms.GroupBox();
            this.dgLogMessage = new System.Windows.Forms.DataGridView();
            this.logTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTriggerBox = new System.Windows.Forms.GroupBox();
            this.cbxRawText = new System.Windows.Forms.CheckBox();
            this.gbDataView = new System.Windows.Forms.GroupBox();
            this.gbConnectionInfo = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lbCurrentHostName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ttConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbPreset = new System.Windows.Forms.GroupBox();
            this.btnPresetUploadMap2 = new System.Windows.Forms.Button();
            this.btnPresetUploadMap1 = new System.Windows.Forms.Button();
            this.btnPresetMissionStart = new System.Windows.Forms.Button();
            this.btnPresetAuto = new System.Windows.Forms.Button();
            this.btnPresetStabilize = new System.Windows.Forms.Button();
            this.btnPresetArm = new System.Windows.Forms.Button();
            this.btnPresetDisconnect = new System.Windows.Forms.Button();
            this.btnPresetConnect = new System.Windows.Forms.Button();
            this.btnSwarmInit = new System.Windows.Forms.Button();
            this.btnSwarmSetLeader = new System.Windows.Forms.Button();
            this.btnSwarmSetGuideMode = new System.Windows.Forms.Button();
            this.btnSwarmSetArm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSwarmSetPosition02 = new System.Windows.Forms.Button();
            this.btnSwarmSetPosition01 = new System.Windows.Forms.Button();
            this.btnSwarmStart = new System.Windows.Forms.Button();
            this.btnSwarmLand = new System.Windows.Forms.Button();
            this.btnSwarmTakeOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTriggeredData)).BeginInit();
            this.gbLogMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogMessage)).BeginInit();
            this.gbTriggerBox.SuspendLayout();
            this.gbDataView.SuspendLayout();
            this.gbConnectionInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbPreset.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTriggerMessage
            // 
            this.tbTriggerMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTriggerMessage.Location = new System.Drawing.Point(6, 17);
            this.tbTriggerMessage.Multiline = true;
            this.tbTriggerMessage.Name = "tbTriggerMessage";
            this.tbTriggerMessage.Size = new System.Drawing.Size(575, 43);
            this.tbTriggerMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(587, 38);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 22);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbHostAddress
            // 
            this.lbHostAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHostAddress.AutoSize = true;
            this.lbHostAddress.Location = new System.Drawing.Point(309, 32);
            this.lbHostAddress.Name = "lbHostAddress";
            this.lbHostAddress.Size = new System.Drawing.Size(52, 12);
            this.lbHostAddress.TabIndex = 3;
            this.lbHostAddress.Text = "Address";
            // 
            // tbHostAddress
            // 
            this.tbHostAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHostAddress.Location = new System.Drawing.Point(379, 39);
            this.tbHostAddress.Name = "tbHostAddress";
            this.tbHostAddress.Size = new System.Drawing.Size(102, 21);
            this.tbHostAddress.TabIndex = 4;
            this.tbHostAddress.Text = "127.0.0.1";
            this.tbHostAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbHostPort
            // 
            this.lbHostPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHostPort.AutoSize = true;
            this.lbHostPort.Location = new System.Drawing.Point(475, 32);
            this.lbHostPort.Name = "lbHostPort";
            this.lbHostPort.Size = new System.Drawing.Size(27, 12);
            this.lbHostPort.TabIndex = 5;
            this.lbHostPort.Text = "Port";
            // 
            // tbHostPort
            // 
            this.tbHostPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHostPort.Location = new System.Drawing.Point(519, 39);
            this.tbHostPort.Name = "tbHostPort";
            this.tbHostPort.Size = new System.Drawing.Size(57, 21);
            this.tbHostPort.TabIndex = 6;
            this.tbHostPort.Text = "11000";
            this.tbHostPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(587, 14);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 21);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // dgTriggeredData
            // 
            this.dgTriggeredData.AllowUserToAddRows = false;
            this.dgTriggeredData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTriggeredData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTriggeredData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTriggeredData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTriggeredData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.triggerTimeStamp,
            this.triggerData});
            this.dgTriggeredData.Location = new System.Drawing.Point(9, 20);
            this.dgTriggeredData.Name = "dgTriggeredData";
            this.dgTriggeredData.RowHeadersVisible = false;
            this.dgTriggeredData.RowTemplate.Height = 23;
            this.dgTriggeredData.Size = new System.Drawing.Size(672, 140);
            this.dgTriggeredData.TabIndex = 8;
            // 
            // triggerTimeStamp
            // 
            this.triggerTimeStamp.HeaderText = "Time Stamp";
            this.triggerTimeStamp.Name = "triggerTimeStamp";
            // 
            // triggerData
            // 
            this.triggerData.HeaderText = "Data";
            this.triggerData.Name = "triggerData";
            // 
            // gbLogMessage
            // 
            this.gbLogMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLogMessage.Controls.Add(this.dgLogMessage);
            this.gbLogMessage.Location = new System.Drawing.Point(12, 436);
            this.gbLogMessage.Name = "gbLogMessage";
            this.gbLogMessage.Size = new System.Drawing.Size(687, 143);
            this.gbLogMessage.TabIndex = 9;
            this.gbLogMessage.TabStop = false;
            this.gbLogMessage.Text = "System Log";
            // 
            // dgLogMessage
            // 
            this.dgLogMessage.AllowUserToAddRows = false;
            this.dgLogMessage.AllowUserToResizeRows = false;
            this.dgLogMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLogMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLogMessage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgLogMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logTimeStamp,
            this.logTarget,
            this.logMessage});
            this.dgLogMessage.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgLogMessage.Location = new System.Drawing.Point(6, 14);
            this.dgLogMessage.Name = "dgLogMessage";
            this.dgLogMessage.RowHeadersVisible = false;
            this.dgLogMessage.RowTemplate.Height = 16;
            this.dgLogMessage.Size = new System.Drawing.Size(675, 123);
            this.dgLogMessage.TabIndex = 1;
            // 
            // logTimeStamp
            // 
            this.logTimeStamp.HeaderText = "Time Stamp";
            this.logTimeStamp.Name = "logTimeStamp";
            // 
            // logTarget
            // 
            this.logTarget.HeaderText = "Target";
            this.logTarget.Name = "logTarget";
            // 
            // logMessage
            // 
            this.logMessage.HeaderText = "Message";
            this.logMessage.Name = "logMessage";
            // 
            // gbTriggerBox
            // 
            this.gbTriggerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTriggerBox.Controls.Add(this.cbxRawText);
            this.gbTriggerBox.Controls.Add(this.btnSend);
            this.gbTriggerBox.Controls.Add(this.tbTriggerMessage);
            this.gbTriggerBox.Location = new System.Drawing.Point(12, 585);
            this.gbTriggerBox.Name = "gbTriggerBox";
            this.gbTriggerBox.Size = new System.Drawing.Size(687, 70);
            this.gbTriggerBox.TabIndex = 10;
            this.gbTriggerBox.TabStop = false;
            this.gbTriggerBox.Text = "Send Trigger";
            // 
            // cbxRawText
            // 
            this.cbxRawText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRawText.AutoSize = true;
            this.cbxRawText.Checked = true;
            this.cbxRawText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRawText.Location = new System.Drawing.Point(597, 19);
            this.cbxRawText.Name = "cbxRawText";
            this.cbxRawText.Size = new System.Drawing.Size(78, 16);
            this.cbxRawText.TabIndex = 3;
            this.cbxRawText.Text = "Raw Text";
            this.cbxRawText.UseVisualStyleBackColor = true;
            // 
            // gbDataView
            // 
            this.gbDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDataView.Controls.Add(this.dgTriggeredData);
            this.gbDataView.Location = new System.Drawing.Point(12, 264);
            this.gbDataView.Name = "gbDataView";
            this.gbDataView.Size = new System.Drawing.Size(687, 166);
            this.gbDataView.TabIndex = 11;
            this.gbDataView.TabStop = false;
            this.gbDataView.Text = "Recieved Data";
            // 
            // gbConnectionInfo
            // 
            this.gbConnectionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConnectionInfo.Controls.Add(this.btnDisconnect);
            this.gbConnectionInfo.Controls.Add(this.btnConnect);
            this.gbConnectionInfo.Controls.Add(this.lbCurrentHostName);
            this.gbConnectionInfo.Controls.Add(this.label1);
            this.gbConnectionInfo.Controls.Add(this.lbHostAddress);
            this.gbConnectionInfo.Controls.Add(this.lbHostPort);
            this.gbConnectionInfo.Location = new System.Drawing.Point(12, 13);
            this.gbConnectionInfo.Name = "gbConnectionInfo";
            this.gbConnectionInfo.Size = new System.Drawing.Size(681, 68);
            this.gbConnectionInfo.TabIndex = 12;
            this.gbConnectionInfo.TabStop = false;
            this.gbConnectionInfo.Text = "MIssion Planner Connection Info";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.Location = new System.Drawing.Point(587, 41);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(88, 21);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lbCurrentHostName
            // 
            this.lbCurrentHostName.AutoSize = true;
            this.lbCurrentHostName.Location = new System.Drawing.Point(107, 32);
            this.lbCurrentHostName.Name = "lbCurrentHostName";
            this.lbCurrentHostName.Size = new System.Drawing.Size(35, 12);
            this.lbCurrentHostName.TabIndex = 1;
            this.lbCurrentHostName.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Host :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttConnectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(711, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ttConnectionStatus
            // 
            this.ttConnectionStatus.Name = "ttConnectionStatus";
            this.ttConnectionStatus.Size = new System.Drawing.Size(80, 17);
            this.ttConnectionStatus.Text = "Disconnected";
            // 
            // gbPreset
            // 
            this.gbPreset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPreset.Controls.Add(this.btnPresetUploadMap2);
            this.gbPreset.Controls.Add(this.btnPresetUploadMap1);
            this.gbPreset.Controls.Add(this.btnPresetMissionStart);
            this.gbPreset.Controls.Add(this.btnPresetAuto);
            this.gbPreset.Controls.Add(this.btnPresetStabilize);
            this.gbPreset.Controls.Add(this.btnPresetArm);
            this.gbPreset.Controls.Add(this.btnPresetDisconnect);
            this.gbPreset.Controls.Add(this.btnPresetConnect);
            this.gbPreset.Location = new System.Drawing.Point(12, 87);
            this.gbPreset.Name = "gbPreset";
            this.gbPreset.Size = new System.Drawing.Size(687, 84);
            this.gbPreset.TabIndex = 12;
            this.gbPreset.TabStop = false;
            this.gbPreset.Text = "Single Commands";
            // 
            // btnPresetUploadMap2
            // 
            this.btnPresetUploadMap2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresetUploadMap2.Location = new System.Drawing.Point(582, 49);
            this.btnPresetUploadMap2.Name = "btnPresetUploadMap2";
            this.btnPresetUploadMap2.Size = new System.Drawing.Size(93, 23);
            this.btnPresetUploadMap2.TabIndex = 7;
            this.btnPresetUploadMap2.Text = "Upload Map2";
            this.btnPresetUploadMap2.UseVisualStyleBackColor = true;
            this.btnPresetUploadMap2.Click += new System.EventHandler(this.btnPresetUploadMap2_Click);
            // 
            // btnPresetUploadMap1
            // 
            this.btnPresetUploadMap1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresetUploadMap1.Location = new System.Drawing.Point(582, 20);
            this.btnPresetUploadMap1.Name = "btnPresetUploadMap1";
            this.btnPresetUploadMap1.Size = new System.Drawing.Size(93, 23);
            this.btnPresetUploadMap1.TabIndex = 6;
            this.btnPresetUploadMap1.Text = "Upload Map1";
            this.btnPresetUploadMap1.UseVisualStyleBackColor = true;
            this.btnPresetUploadMap1.Click += new System.EventHandler(this.btnPresetUploadMap1_Click);
            // 
            // btnPresetMissionStart
            // 
            this.btnPresetMissionStart.Location = new System.Drawing.Point(108, 49);
            this.btnPresetMissionStart.Name = "btnPresetMissionStart";
            this.btnPresetMissionStart.Size = new System.Drawing.Size(93, 23);
            this.btnPresetMissionStart.TabIndex = 5;
            this.btnPresetMissionStart.Text = "Mission Start";
            this.btnPresetMissionStart.UseVisualStyleBackColor = true;
            this.btnPresetMissionStart.Click += new System.EventHandler(this.btnPresetMissionStart_Click);
            // 
            // btnPresetAuto
            // 
            this.btnPresetAuto.Location = new System.Drawing.Point(207, 49);
            this.btnPresetAuto.Name = "btnPresetAuto";
            this.btnPresetAuto.Size = new System.Drawing.Size(93, 23);
            this.btnPresetAuto.TabIndex = 4;
            this.btnPresetAuto.Text = "Auto";
            this.btnPresetAuto.UseVisualStyleBackColor = true;
            this.btnPresetAuto.Click += new System.EventHandler(this.btnPresetAuto_Click);
            // 
            // btnPresetStabilize
            // 
            this.btnPresetStabilize.Location = new System.Drawing.Point(207, 20);
            this.btnPresetStabilize.Name = "btnPresetStabilize";
            this.btnPresetStabilize.Size = new System.Drawing.Size(93, 23);
            this.btnPresetStabilize.TabIndex = 3;
            this.btnPresetStabilize.Text = "Staibilize";
            this.btnPresetStabilize.UseVisualStyleBackColor = true;
            this.btnPresetStabilize.Click += new System.EventHandler(this.btnPresetStabilize_Click);
            // 
            // btnPresetArm
            // 
            this.btnPresetArm.Location = new System.Drawing.Point(108, 20);
            this.btnPresetArm.Name = "btnPresetArm";
            this.btnPresetArm.Size = new System.Drawing.Size(93, 23);
            this.btnPresetArm.TabIndex = 2;
            this.btnPresetArm.Text = "Arm / Disarm";
            this.btnPresetArm.UseVisualStyleBackColor = true;
            this.btnPresetArm.Click += new System.EventHandler(this.btnPresetArm_Click);
            // 
            // btnPresetDisconnect
            // 
            this.btnPresetDisconnect.Location = new System.Drawing.Point(9, 49);
            this.btnPresetDisconnect.Name = "btnPresetDisconnect";
            this.btnPresetDisconnect.Size = new System.Drawing.Size(93, 23);
            this.btnPresetDisconnect.TabIndex = 1;
            this.btnPresetDisconnect.Text = "Disconnect";
            this.btnPresetDisconnect.UseVisualStyleBackColor = true;
            this.btnPresetDisconnect.Click += new System.EventHandler(this.btnPresetDisconnect_Click);
            // 
            // btnPresetConnect
            // 
            this.btnPresetConnect.Location = new System.Drawing.Point(9, 20);
            this.btnPresetConnect.Name = "btnPresetConnect";
            this.btnPresetConnect.Size = new System.Drawing.Size(93, 23);
            this.btnPresetConnect.TabIndex = 0;
            this.btnPresetConnect.Text = "Connect";
            this.btnPresetConnect.UseVisualStyleBackColor = true;
            this.btnPresetConnect.Click += new System.EventHandler(this.btnPresetConnect_Click);
            // 
            // btnSwarmInit
            // 
            this.btnSwarmInit.Location = new System.Drawing.Point(9, 20);
            this.btnSwarmInit.Name = "btnSwarmInit";
            this.btnSwarmInit.Size = new System.Drawing.Size(93, 23);
            this.btnSwarmInit.TabIndex = 9;
            this.btnSwarmInit.Text = "Initialize";
            this.btnSwarmInit.UseVisualStyleBackColor = true;
            this.btnSwarmInit.Click += new System.EventHandler(this.btnPresetInitSwarm_Click);
            // 
            // btnSwarmSetLeader
            // 
            this.btnSwarmSetLeader.Location = new System.Drawing.Point(9, 49);
            this.btnSwarmSetLeader.Name = "btnSwarmSetLeader";
            this.btnSwarmSetLeader.Size = new System.Drawing.Size(93, 23);
            this.btnSwarmSetLeader.TabIndex = 10;
            this.btnSwarmSetLeader.Text = "Set Leader";
            this.btnSwarmSetLeader.UseVisualStyleBackColor = true;
            this.btnSwarmSetLeader.Click += new System.EventHandler(this.btnPresetSetLeader_Click);
            // 
            // btnSwarmSetGuideMode
            // 
            this.btnSwarmSetGuideMode.Location = new System.Drawing.Point(108, 20);
            this.btnSwarmSetGuideMode.Name = "btnSwarmSetGuideMode";
            this.btnSwarmSetGuideMode.Size = new System.Drawing.Size(112, 23);
            this.btnSwarmSetGuideMode.TabIndex = 11;
            this.btnSwarmSetGuideMode.Text = "Set Slave Guide";
            this.btnSwarmSetGuideMode.UseVisualStyleBackColor = true;
            this.btnSwarmSetGuideMode.Click += new System.EventHandler(this.btnPresetSetSwarmGuideMode_Click);
            // 
            // btnSwarmSetArm
            // 
            this.btnSwarmSetArm.Location = new System.Drawing.Point(108, 49);
            this.btnSwarmSetArm.Name = "btnSwarmSetArm";
            this.btnSwarmSetArm.Size = new System.Drawing.Size(112, 23);
            this.btnSwarmSetArm.TabIndex = 12;
            this.btnSwarmSetArm.Text = "Set Slave Arm";
            this.btnSwarmSetArm.UseVisualStyleBackColor = true;
            this.btnSwarmSetArm.Click += new System.EventHandler(this.btnPresetSetSwarmArm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSwarmSetPosition02);
            this.groupBox1.Controls.Add(this.btnSwarmSetPosition01);
            this.groupBox1.Controls.Add(this.btnSwarmStart);
            this.groupBox1.Controls.Add(this.btnSwarmLand);
            this.groupBox1.Controls.Add(this.btnSwarmTakeOff);
            this.groupBox1.Controls.Add(this.btnSwarmSetArm);
            this.groupBox1.Controls.Add(this.btnSwarmSetGuideMode);
            this.groupBox1.Controls.Add(this.btnSwarmSetLeader);
            this.groupBox1.Controls.Add(this.btnSwarmInit);
            this.groupBox1.Location = new System.Drawing.Point(12, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 84);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Swarm Commands";
            // 
            // btnSwarmSetPosition02
            // 
            this.btnSwarmSetPosition02.Location = new System.Drawing.Point(563, 49);
            this.btnSwarmSetPosition02.Name = "btnSwarmSetPosition02";
            this.btnSwarmSetPosition02.Size = new System.Drawing.Size(112, 23);
            this.btnSwarmSetPosition02.TabIndex = 17;
            this.btnSwarmSetPosition02.Text = "Set Formation 02";
            this.btnSwarmSetPosition02.UseVisualStyleBackColor = true;
            this.btnSwarmSetPosition02.Click += new System.EventHandler(this.btnSwarmSetPosition02_Click);
            // 
            // btnSwarmSetPosition01
            // 
            this.btnSwarmSetPosition01.Location = new System.Drawing.Point(563, 20);
            this.btnSwarmSetPosition01.Name = "btnSwarmSetPosition01";
            this.btnSwarmSetPosition01.Size = new System.Drawing.Size(112, 23);
            this.btnSwarmSetPosition01.TabIndex = 16;
            this.btnSwarmSetPosition01.Text = "Set Formation 01";
            this.btnSwarmSetPosition01.UseVisualStyleBackColor = true;
            this.btnSwarmSetPosition01.Click += new System.EventHandler(this.btnSwarmSetPosition01_Click);
            // 
            // btnSwarmStart
            // 
            this.btnSwarmStart.Location = new System.Drawing.Point(344, 20);
            this.btnSwarmStart.Name = "btnSwarmStart";
            this.btnSwarmStart.Size = new System.Drawing.Size(112, 23);
            this.btnSwarmStart.TabIndex = 15;
            this.btnSwarmStart.Text = "Start";
            this.btnSwarmStart.UseVisualStyleBackColor = true;
            this.btnSwarmStart.Click += new System.EventHandler(this.btnSwarmStart_Click);
            // 
            // btnSwarmLand
            // 
            this.btnSwarmLand.Location = new System.Drawing.Point(226, 49);
            this.btnSwarmLand.Name = "btnSwarmLand";
            this.btnSwarmLand.Size = new System.Drawing.Size(112, 23);
            this.btnSwarmLand.TabIndex = 14;
            this.btnSwarmLand.Text = "Land";
            this.btnSwarmLand.UseVisualStyleBackColor = true;
            this.btnSwarmLand.Click += new System.EventHandler(this.btnSwarmLand_Click);
            // 
            // btnSwarmTakeOff
            // 
            this.btnSwarmTakeOff.Location = new System.Drawing.Point(226, 20);
            this.btnSwarmTakeOff.Name = "btnSwarmTakeOff";
            this.btnSwarmTakeOff.Size = new System.Drawing.Size(112, 23);
            this.btnSwarmTakeOff.TabIndex = 13;
            this.btnSwarmTakeOff.Text = "Takeoff";
            this.btnSwarmTakeOff.UseVisualStyleBackColor = true;
            this.btnSwarmTakeOff.Click += new System.EventHandler(this.btnSwarmTakeOff_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPreset);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbLogMessage);
            this.Controls.Add(this.tbHostPort);
            this.Controls.Add(this.tbHostAddress);
            this.Controls.Add(this.gbTriggerBox);
            this.Controls.Add(this.gbDataView);
            this.Controls.Add(this.gbConnectionInfo);
            this.Name = "MainForm";
            this.Text = "Mission Planner Remote Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgTriggeredData)).EndInit();
            this.gbLogMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLogMessage)).EndInit();
            this.gbTriggerBox.ResumeLayout(false);
            this.gbTriggerBox.PerformLayout();
            this.gbDataView.ResumeLayout(false);
            this.gbConnectionInfo.ResumeLayout(false);
            this.gbConnectionInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbPreset.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTriggerMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbHostAddress;
        private System.Windows.Forms.TextBox tbHostAddress;
        private System.Windows.Forms.Label lbHostPort;
        private System.Windows.Forms.TextBox tbHostPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridView dgTriggeredData;
        private System.Windows.Forms.GroupBox gbLogMessage;
        private System.Windows.Forms.GroupBox gbTriggerBox;
        private System.Windows.Forms.DataGridView dgLogMessage;
        private System.Windows.Forms.GroupBox gbDataView;
        private System.Windows.Forms.GroupBox gbConnectionInfo;
        private System.Windows.Forms.Label lbCurrentHostName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.DataGridViewTextBoxColumn triggerTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn triggerData;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn logMessage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ttConnectionStatus;
        private System.Windows.Forms.CheckBox cbxRawText;
        private System.Windows.Forms.GroupBox gbPreset;
        private System.Windows.Forms.Button btnPresetUploadMap2;
        private System.Windows.Forms.Button btnPresetUploadMap1;
        private System.Windows.Forms.Button btnPresetMissionStart;
        private System.Windows.Forms.Button btnPresetAuto;
        private System.Windows.Forms.Button btnPresetStabilize;
        private System.Windows.Forms.Button btnPresetArm;
        private System.Windows.Forms.Button btnPresetDisconnect;
        private System.Windows.Forms.Button btnPresetConnect;
        private System.Windows.Forms.Button btnSwarmInit;
        private System.Windows.Forms.Button btnSwarmSetLeader;
        private System.Windows.Forms.Button btnSwarmSetGuideMode;
        private System.Windows.Forms.Button btnSwarmSetArm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSwarmLand;
        private System.Windows.Forms.Button btnSwarmTakeOff;
        private System.Windows.Forms.Button btnSwarmStart;
        private System.Windows.Forms.Button btnSwarmSetPosition01;
        private System.Windows.Forms.Button btnSwarmSetPosition02;
    }
}

