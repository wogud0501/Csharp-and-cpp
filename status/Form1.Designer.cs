
namespace status
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plBar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // plBar
            // 
            this.plBar.BackColor = System.Drawing.Color.White;
            this.plBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plBar.Location = new System.Drawing.Point(12, 12);
            this.plBar.Name = "plBar";
            this.plBar.Size = new System.Drawing.Size(420, 34);
            this.plBar.TabIndex = 0;
            this.plBar.Paint += new System.Windows.Forms.PaintEventHandler(this.plBar_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 79);
            this.Controls.Add(this.plBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "메모리 체크";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plBar;
    }
}

