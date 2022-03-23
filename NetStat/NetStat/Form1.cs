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
using System.Net.NetworkInformation;
using System.Threading;
using System.IO;

namespace NetStat
{
    public partial class Form1 : Form
    {
        IPGlobalProperties ipProperites =
            IPGlobalProperties.GetIPGlobalProperties();
        Thread NetThread = null;
        string LocPort, RemoAdd, RemoPort;
        bool CheckBool = true;
        // 델리게이트 선언
        private delegate void OnConnViewDelegate(bool flags, string[] AddInfo);
        // 델리게이트 개체 생성
        private OnConnViewDelegate OnView = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void LvNetState_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnView = new OnConnViewDelegate(OnNewView);
            NetThread = new Thread(NetView);
            NetThread.Start();
        }
        private void NetView()
        {
            while (true)
            {
                this.CheckBool = true;
                NCheck();
                OnView.Invoke(true, null);
                TcpConnectionInformation[] tcpConnections =
                ipProperites.GetActiveTcpConnections();
                int i = 0;
                foreach (TcpConnectionInformation NetInfo in tcpConnections)
                {
                    string[] AddInfo = new string[6] {NetInfo.LocalEndPoint.Address.ToString(),
                    NetInfo.LocalEndPoint.Port.ToString(),
                    NetInfo.RemoteEndPoint.Address.ToString(),
                    NetInfo.RemoteEndPoint.Port.ToString(),
                    NetInfo.State.ToString(), i.ToString()};
                    OnView.Invoke(false, AddInfo);
                    i++;
                }
                this.CheckBool = false;
                NCheck();
                Thread.Sleep(30000);
            }
        }
        private void OnNewView(bool flags, string[] AddInfo)
        {
            if (flags == true)
                this.lvNetState.Items.Clear();
            else
            {
                int i = Convert.ToInt32(AddInfo[5]);
                this.lvNetState.Items.Add(AddInfo[0]);
                this.lvNetState.Items[i].SubItems.Add(AddInfo[1]);
                this.lvNetState.Items[i].SubItems.Add(AddInfo[2]);
                this.lvNetState.Items[i].SubItems.Add(AddInfo[3]);
                this.lvNetState.Items[i].SubItems.Add(AddInfo[4]);
                if (AddInfo[1] == LocPort)
                    this.lvNetState.Items[i].SubItems[0].BackColor = Color.GreenYellow;
                if (AddInfo[2] == RemoAdd)
                    this.lvNetState.Items[i].SubItems[0].BackColor = Color.LightPink;
                if (AddInfo[3] == RemoPort)
                    this.lvNetState.Items[i].SubItems[0].BackColor = Color.Aqua;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NetThread != null)
                NetThread.Abort();
            Application.ExitThread();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.LocPort = this.txtLocPort.Text;
            this.RemoAdd = this.txtForAdd.Text;
            this.RemoPort = this.txtForPort.Text;
            NCheck();
        }

        private void lvNetState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvNetState_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {

        }

        private void NCheck()
        {
            if (CheckBool)
            {
                this.txtLocPort.Enabled = false;
                this.txtForPort.Enabled = false;
                this.txtForAdd.Enabled = false;
                this.btnCheck.Enabled = false;
                this.btnSave.Enabled = false;
            }
            else
            {
                this.txtLocPort.Enabled = true;
                this.txtForPort.Enabled = true;
                this.txtForAdd.Enabled = true;
                this.btnCheck.Enabled = true;
                this.btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.sfadFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(this.sfadFile.FileName);
                sw.WriteLine("파일생성 : " + DateTime.Now);
                sw.WriteLine();
                sw.WriteLine("로컬주소	로컬포트	외부주소	외부포트	상태");
                for (int i = 0; i < this.lvNetState.Items.Count - 1; i++)
                {
                    sw.WriteLine(this.lvNetState.Items[i].SubItems[0].Text + "	" +
                        this.lvNetState.Items[i].SubItems[1].Text + "	" +
                        this.lvNetState.Items[i].SubItems[2].Text + "	" +
                        this.lvNetState.Items[i].SubItems[3].Text + "	" +
                        this.lvNetState.Items[i].SubItems[4].Text);
                }
                sw.WriteLine();
                sw.WriteLine("파일생성 종료 : " + DateTime.Now);
                sw.Close();
            }
        }

    }
}
