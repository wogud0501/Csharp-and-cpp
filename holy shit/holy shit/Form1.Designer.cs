
namespace holy_shit
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cbbSelect = new System.Windows.Forms.ComboBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-5, -62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(12, 19);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(31, 15);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "선택";
            this.lblSelect.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbbSelect
            // 
            this.cbbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbSelect.FormattingEnabled = true;
            this.cbbSelect.Items.AddRange(new object[] {
            "2단",
            "3단",
            "4단",
            "5단",
            "6단",
            "7단",
            "8단",
            "9단"});
            this.cbbSelect.Location = new System.Drawing.Point(85, 16);
            this.cbbSelect.Name = "cbbSelect";
            this.cbbSelect.Size = new System.Drawing.Size(307, 23);
            this.cbbSelect.TabIndex = 2;
            this.cbbSelect.SelectedIndexChanged += new System.EventHandler(this.cbbSelect_SelectedIndexChanged);
            // 
            // lbResult
            // 
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 15;
            this.lbResult.Location = new System.Drawing.Point(12, 57);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(396, 362);
            this.lbResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.cbbSelect);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "구구단";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cbbSelect;
        private System.Windows.Forms.ListBox lbResult;
    }
}

