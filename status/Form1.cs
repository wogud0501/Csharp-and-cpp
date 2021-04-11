using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace status
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkThread = new Thread(getCPU_Info);
            checkThread.Start();   // checkThread 스레드 프로세스 시작
        }
        private PerformanceCounter oCPU =
            new PerformanceCounter("Processor", "% Processor Time", "_Total");
        // 시스템 성능 카운터
        private bool bExit = false;               // 실시간 체크를 위한 while 조건
        private int iCPU = 0;                     // cpu 초기 사용률
        private Font F = new Font("굴림", 9);     // 폰트 모양
        private Thread checkThread;               // 스레드 개체 생성


        private void getCPU_Info()
        {
            while (!bExit)
            {
                iCPU = (int)oCPU.NextValue();
                this.Text = "CPU 사용: " + iCPU.ToString() + "%";
                iCPU = iCPU * 3;
                plBar.Invalidate();
                Thread.Sleep(1000);
            }
        }

        private void plBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            if (iCPU <= 60)
                G.FillRectangle(Brushes.BlanchedAlmond, 0, 0, iCPU, plBar.Height);
            else if (iCPU <= 120)
                G.FillRectangle(Brushes.Wheat, 0, 0, iCPU, plBar.Height);
            else if (iCPU <= 180)
                G.FillRectangle(Brushes.NavajoWhite, 0, 0, iCPU, plBar.Height);
            else if (iCPU <= 240)
                G.FillRectangle(Brushes.Orange, 0, 0, iCPU, plBar.Height);
            else
                G.FillRectangle(Brushes.DarkOrange, 0, 0, iCPU, plBar.Height);
            iCPU = iCPU / 3;
            G.DrawString(iCPU.ToString() + "%", F, Brushes.DarkRed,
                plBar.Width / 2 - 17, plBar.Height / 4);
        }
    }
}
