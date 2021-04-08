
namespace header
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
            this.lvCall = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chPhone = new System.Windows.Forms.ColumnHeader();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCall
            // 
            this.lvCall.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPhone});
            this.lvCall.FullRowSelect = true;
            this.lvCall.GridLines = true;
            this.lvCall.HideSelection = false;
            this.lvCall.Location = new System.Drawing.Point(12, 12);
            this.lvCall.Name = "lvCall";
            this.lvCall.Size = new System.Drawing.Size(512, 320);
            this.lvCall.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvCall.TabIndex = 0;
            this.lvCall.UseCompatibleStateImageBehavior = false;
            this.lvCall.View = System.Windows.Forms.View.Details;
            this.lvCall.SelectedIndexChanged += new System.EventHandler(this.lvCall_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 100;
            // 
            // chPhone
            // 
            this.chPhone.Text = "전화번호";
            this.chPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPhone.Width = 100;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 385);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 425);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 15);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "전화번호";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 382);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 23);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(73, 422);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(190, 23);
            this.txtPhone.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(386, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "입력";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 491);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lvCall);
            this.Name = "Form1";
            this.Text = "헤더 정렬";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCall;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
    }
}

