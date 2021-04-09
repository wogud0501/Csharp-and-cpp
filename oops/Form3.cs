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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Timer.Enabled = true; // 타이머 컨트롤 활성화
            this.Opacity = Convert.ToSingle(100 / 100); // 폼 투명도값 100% 설정
        }


        public string SetText
        {
            set { this.Text = value; } // 다른 클래스에서 접근
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.Size.Width > 300 && this.Size.Height > 300)
            {
                this.Timer.Enabled = false;
            }
            else
            {
                this.Size += new Size(10, 10); // 폼 사이즈 변경
            }
        }
    }
}
