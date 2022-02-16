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

        private void lvNetState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
