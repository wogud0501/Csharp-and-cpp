using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void PicClose_Click(object sender, EventArgs e)
    }
   
}
