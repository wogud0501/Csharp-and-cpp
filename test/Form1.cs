using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDynamic_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                DynamicButton(i * 50, 10, i + 1);
            }
        }
        private void DynamicButton(int x, int y, int k)
        {
            Button btnPer = new Button();
            string btntxt = "버튼" + k.ToString();
            if (k == 3)
                btntxt = "흔들";
            btnPer.Width = 50;
            btnPer.Height = 20;
            btnPer.Location = new System.Drawing.Point(x + 15, y);
            btnPer.Text = btntxt;
            btnPer.Name = "btn" + k.ToString();
            btnPer.Click += new EventHandler(btn_Click);
            Controls.Add(btnPer);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            string btnText = sender.ToString().Split(':')[1].ToString().Trim();
            if (btnText == "흔들")
            {
                
            }
            else
                MessageBox.Show(btnText, "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnFormShow_Click(object sender, EventArgs e)
        {
            for (int i = 10; 0 >= 0; i--)
            {
                this.Opacity = 0.1 * i;
                System.Threading.Thread.Sleep(100);
            }
        }
    }
    }
