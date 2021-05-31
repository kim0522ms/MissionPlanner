using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Term1_TCPClient
{
    public partial class UDialogConnection : Form
    {
        public List<object> result;
        public UDialogConnection()
        {
            InitializeComponent();

            dgAddressList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgAddressList.Columns[0].Width = (int)(dgAddressList.Width * 0.7);
            dgAddressList.Columns[1].Width = (int)(dgAddressList.Width * 0.3);

            dgAddressList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAddressList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (tbxAddress.Text.Equals(""))
            {
                MessageBox.Show("Please input vaild address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgAddressList.Rows.Add(tbxAddress.Text.Split(':'));
        }
        private void btnClearList_Click(object sender, EventArgs e)
        {
            dgAddressList.Rows.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (dgAddressList.Rows.Count == 0)
            {
                MessageBox.Show("Address list is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            result = new List<object>();
            for (int i = 0; i < dgAddressList.Rows.Count; i++)
            {
                JObject addr = new JObject();
                addr.Add("host", dgAddressList.Rows[i].Cells[0].Value.ToString());
                addr.Add("port", dgAddressList.Rows[i].Cells[1].Value.ToString());

                result.Add(addr);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tbxAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnAddList.PerformClick();
            }
        }
    }
}
