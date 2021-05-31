
namespace Term1_TCPClient
{
    partial class UDialogConnection
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
            this.dgAddressList = new System.Windows.Forms.DataGridView();
            this.rHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.btnAddList = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddressList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAddressList
            // 
            this.dgAddressList.AllowUserToAddRows = false;
            this.dgAddressList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAddressList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAddressList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddressList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rHost,
            this.rPort});
            this.dgAddressList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgAddressList.Location = new System.Drawing.Point(12, 12);
            this.dgAddressList.Name = "dgAddressList";
            this.dgAddressList.RowHeadersVisible = false;
            this.dgAddressList.RowTemplate.Height = 23;
            this.dgAddressList.Size = new System.Drawing.Size(299, 137);
            this.dgAddressList.TabIndex = 9;
            // 
            // rHost
            // 
            this.rHost.HeaderText = "Host";
            this.rHost.Name = "rHost";
            // 
            // rPort
            // 
            this.rPort.HeaderText = "Port";
            this.rPort.Name = "rPort";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(182, 180);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 21);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP Address :";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(93, 153);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(218, 21);
            this.tbxAddress.TabIndex = 13;
            this.tbxAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxAddress_KeyUp);
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(14, 180);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(75, 21);
            this.btnAddList.TabIndex = 15;
            this.btnAddList.Text = "Add";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(98, 180);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 21);
            this.btnClearList.TabIndex = 17;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // UDialogConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 207);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.dgAddressList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UDialogConnection";
            this.Text = "Connection List";
            ((System.ComponentModel.ISupportInitialize)(this.dgAddressList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAddressList;
        private System.Windows.Forms.DataGridViewTextBoxColumn rHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn rPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Button btnClearList;
    }
}