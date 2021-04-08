using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace header
{
    public partial class Form1 : Form
    {
        private bool Isort = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lvCall_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void IvCall_ColummClick(object sender, ColumnClickEventArgs e)
        {
            if (Isort == true)
            {
                this.lvCall.ListViewItemSorter =
                    new ListViewItemComparer(e.Column, Isort);
                Isort = false;
            }    
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ControlCheck() == true)
            {
                var strArray = new String[] { this.txtName.Text,
                                              this.txtPhone.Text };

                var lvt = new ListViewItem(strArray);
                this.lvCall.Items.Add(lvt);
                this.txtName.Clear();
                this.txtPhone.Clear();

            }
            else
            {
                return;
            }
        }

       private bool ControlCheck()
        {
            if (this.txtName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요!!", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            else if (this.txtPhone.Text == "")
            {
                MessageBox.Show("전화번호를 입력하세요!", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPhone.Focus();
                return false;
            }
            else
            {
                return false;
            }
        }
        }

    class ListViewItemComparer : IComparer
    {
        private int col;
        private bool z;
        public ListViewItemComparer(int column, bool v)
        {
            col = column;
            z = v;
        }
        public int Compare(object x, object y)
        {
            object a, b;
            if(z == true)
            {
                a = x;
                b = y;
            }
            else
            {
                a = y;
                b = x;
            }
            return String.Compare(((ListViewItem)a).SubItems[col].Text,
                ((ListViewItem)b).SubItems[col].Text);
        }
    }
}
