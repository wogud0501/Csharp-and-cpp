
namespace wav
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
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtOpen
            // 
            this.txtOpen.Location = new System.Drawing.Point(12, 30);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(230, 23);
            this.txtOpen.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(248, 29);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "열기";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "웨이브 파일(*.wav)|*.wav";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 85);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Wav 재생기";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpen;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}

