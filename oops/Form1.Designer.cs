
namespace oops
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
            this.btnModal = new System.Windows.Forms.Button();
            this.btnModeless = new System.Windows.Forms.Button();
            this.btnMsr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(158, 162);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(75, 32);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "모달 폼";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnModeless
            // 
            this.btnModeless.Location = new System.Drawing.Point(272, 162);
            this.btnModeless.Name = "btnModeless";
            this.btnModeless.Size = new System.Drawing.Size(101, 32);
            this.btnModeless.TabIndex = 1;
            this.btnModeless.Text = "모달리스 폼";
            this.btnModeless.UseVisualStyleBackColor = true;
            this.btnModeless.Click += new System.EventHandler(this.btnModeless_Click);
            // 
            // btnMsr
            // 
            this.btnMsr.Location = new System.Drawing.Point(213, 200);
            this.btnMsr.Name = "btnMsr";
            this.btnMsr.Size = new System.Drawing.Size(114, 33);
            this.btnMsr.TabIndex = 2;
            this.btnMsr.Text = "메신저 알림 폼";
            this.btnMsr.UseVisualStyleBackColor = true;
            this.btnMsr.Click += new System.EventHandler(this.btnMsr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 428);
            this.Controls.Add(this.btnMsr);
            this.Controls.Add(this.btnModeless);
            this.Controls.Add(this.btnModal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "부모";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnModeless;
        private System.Windows.Forms.Button btnMsr;
    }
}

