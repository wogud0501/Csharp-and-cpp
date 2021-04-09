using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace oops
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20; // 스크린의 가로 위치
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height; // 스크린의 세로 위치

            DesktopLocation = new Point(x, y); // 폼의 위치 설정
            InitializeComponent();
        }
        private static System.Timers.Timer TimerEvent; // 타이머 객체 생성

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close(); // 폼 종료
        }

        private void picClose_MouseDown(object sender, MouseEventArgs e)
        {
            //마우스 누름 이미지 설정
            this.picClose.Image = Image.FromFile(@"..\..\img\Close_Down.jpg");
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            // 마우스 떠남 이미지 설정
            this.picClose.Image = Image.FromFile(@"..\..\img\Close_Normal.jpg");
        }

        private void picClose_MouseMove(object sender, MouseEventArgs e)
        {
            // 마우스 오버 이미지 설정
            this.picClose.Image = Image.FromFile(@"..\..\img\Close_Over.jpg");
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            var fullScreen =
                System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            this.Location = new System.Drawing.Point((int)fullScreen.Width -200,
                (int)fullScreen.Height -60);
            TimerEvent = new System.Timers.Timer(2);
            TimerEvent.Elapsed += new System.Timers.ElapsedEventHandler(OnPopUp);
            TimerEvent.Start();
        }
        private void OnPopUp(object sender, ElapsedEventArgs e)
        {
            if (Height < 120)
            {
                Height++;
                Top--;

            }
            else
            {
                TimerEvent.Stop();
                TimerEvent.Elapsed -= new System.Timers.ElapsedEventHandler(OnPopUp);
                TimerEvent.Elapsed += new System.Timers.ElapsedEventHandler(OnPopOut);
                TimerEvent.Interval = 3000;
                TimerEvent.Start();
            }
        }
        private void OnPopOut(object sender, ElapsedEventArgs e)
        {
            while (Height > 2)
            {
                Height--;
                Top++;
            }
            this.Close();
        }
    }
}
