using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace DnsLookUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string HostName = null;
            if (this.txtHost.Text.Contains("://") == true)
            {
                HostName = this.txtHost.Text.Replace("https://", "");
            }
            else { HostName = this.txtHost.Text; }
            try
            {
                IPHostEntry ipe = Dns.GetHostEntry(HostName);
                IPAddress[] addrs = ipe.AddressList;
                if (listAddr.Items.Count > 0)
                    listAddr.Items.Clear();
                foreach (IPAddress addr in addrs)
                {
                    listAddr.Items.Add(addr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
