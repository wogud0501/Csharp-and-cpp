
namespace test
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
            this.btnDynamic = new System.Windows.Forms.Button();
            this.btnForm = new System.Windows.Forms.Button();
            this.btnFormShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDynamic
            // 
            this.btnDynamic.Location = new System.Drawing.Point(12, 76);
            this.btnDynamic.Name = "btnDynamic";
            this.btnDynamic.Size = new System.Drawing.Size(75, 23);
            this.btnDynamic.TabIndex = 0;
            this.btnDynamic.Text = "버튼생성";
            this.btnDynamic.UseVisualStyleBackColor = true;
            this.btnDynamic.Click += new System.EventHandler(this.btnDynamic_Click);
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(105, 76);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(75, 23);
            this.btnForm.TabIndex = 1;
            this.btnForm.Text = "-";
            this.btnForm.UseVisualStyleBackColor = true;
            // 
            // btnFormShow
            // 
            this.btnFormShow.Location = new System.Drawing.Point(197, 76);
            this.btnFormShow.Name = "btnFormShow";
            this.btnFormShow.Size = new System.Drawing.Size(75, 23);
            this.btnFormShow.TabIndex = 2;
            this.btnFormShow.Text = "폼 보이기";
            this.btnFormShow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.btnFormShow);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.btnDynamic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "폼 제어";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDynamic;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Button btnFormShow;
    }
}

