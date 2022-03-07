
namespace DnsLookUp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.listAddr = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(29, 51);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(61, 12);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "도 메 인 : ";
            this.lblUrl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUrl.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(107, 48);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(329, 21);
            this.txtHost.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(489, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 21);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(29, 112);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(67, 12);
            this.lblAdd.TabIndex = 3;
            this.lblAdd.Text = "IP Address";
            // 
            // listAddr
            // 
            this.listAddr.FormattingEnabled = true;
            this.listAddr.ItemHeight = 12;
            this.listAddr.Location = new System.Drawing.Point(31, 127);
            this.listAddr.Name = "listAddr";
            this.listAddr.Size = new System.Drawing.Size(529, 100);
            this.listAddr.TabIndex = 4;
            this.listAddr.SelectedIndexChanged += new System.EventHandler(this.listAddr_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 281);
            this.Controls.Add(this.listAddr);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.lblUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DNS LookUp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.ListBox listAddr;
    }
}

