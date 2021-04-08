
namespace study1
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
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.bthShow = new System.Windows.Forms.Button();
            this.btnMag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImg
            // 
            this.pbImg.Image = global::study1.Properties.Resources.자캐;
            this.pbImg.Location = new System.Drawing.Point(12, 12);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(270, 195);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            this.pbImg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bthShow
            // 
            this.bthShow.Location = new System.Drawing.Point(12, 213);
            this.bthShow.Name = "bthShow";
            this.bthShow.Size = new System.Drawing.Size(97, 23);
            this.bthShow.TabIndex = 1;
            this.bthShow.Text = "슬라이드 열기";
            this.bthShow.UseVisualStyleBackColor = true;
            this.bthShow.Click += new System.EventHandler(this.bthShow_Click);
            // 
            // btnMag
            // 
            this.btnMag.Location = new System.Drawing.Point(187, 213);
            this.btnMag.Name = "btnMag";
            this.btnMag.Size = new System.Drawing.Size(95, 23);
            this.btnMag.TabIndex = 2;
            this.btnMag.Text = "폼 붙이기 열기";
            this.btnMag.UseVisualStyleBackColor = true;
            this.btnMag.Click += new System.EventHandler(this.btnMag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.Controls.Add(this.btnMag);
            this.Controls.Add(this.bthShow);
            this.Controls.Add(this.pbImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button bthShow;
        private System.Windows.Forms.Button btnMag;
    }
}

