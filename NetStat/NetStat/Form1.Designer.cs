
namespace NetStat
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            this.lvNetState = new System.Windows.Forms.ListView();
            this.clhLocalIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLocalPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhRemoteIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhRemotePort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLocPort = new System.Windows.Forms.Label();
            this.txtLocPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtForAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForPort = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.sfadFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lvNetState
            // 
            this.lvNetState.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhLocalIP,
            this.clhLocalPort,
            this.clhRemoteIP,
            this.clhRemotePort,
            this.clhState});
            this.lvNetState.GridLines = true;
            this.lvNetState.HideSelection = false;
            this.lvNetState.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.lvNetState.Location = new System.Drawing.Point(12, 11);
            this.lvNetState.Name = "lvNetState";
            this.lvNetState.Size = new System.Drawing.Size(485, 342);
            this.lvNetState.TabIndex = 0;
            this.lvNetState.UseCompatibleStateImageBehavior = false;
            this.lvNetState.View = System.Windows.Forms.View.Details;
            this.lvNetState.SelectedIndexChanged += new System.EventHandler(this.lvNetState_SelectedIndexChanged_1);
            // 
            // clhLocalIP
            // 
            this.clhLocalIP.Text = "로컬주소";
            this.clhLocalIP.Width = 120;
            // 
            // clhLocalPort
            // 
            this.clhLocalPort.Text = "로컬포트";
            // 
            // clhRemoteIP
            // 
            this.clhRemoteIP.Text = "외부주소";
            this.clhRemoteIP.Width = 120;
            // 
            // clhRemotePort
            // 
            this.clhRemotePort.Text = "외부포트";
            // 
            // clhState
            // 
            this.clhState.Text = "상태";
            this.clhState.Width = 90;
            // 
            // lblLocPort
            // 
            this.lblLocPort.BackColor = System.Drawing.Color.GreenYellow;
            this.lblLocPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocPort.Location = new System.Drawing.Point(12, 362);
            this.lblLocPort.Name = "lblLocPort";
            this.lblLocPort.Size = new System.Drawing.Size(60, 20);
            this.lblLocPort.TabIndex = 1;
            this.lblLocPort.Text = "로컬포트";
            this.lblLocPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLocPort
            // 
            this.txtLocPort.Location = new System.Drawing.Point(81, 361);
            this.txtLocPort.Name = "txtLocPort";
            this.txtLocPort.Size = new System.Drawing.Size(46, 21);
            this.txtLocPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(135, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "외부주소";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtForAdd
            // 
            this.txtForAdd.Location = new System.Drawing.Point(204, 361);
            this.txtForAdd.Name = "txtForAdd";
            this.txtForAdd.Size = new System.Drawing.Size(86, 21);
            this.txtForAdd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(295, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "외부포트";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtForPort
            // 
            this.txtForPort.Location = new System.Drawing.Point(361, 362);
            this.txtForPort.Name = "txtForPort";
            this.txtForPort.Size = new System.Drawing.Size(46, 21);
            this.txtForPort.TabIndex = 6;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(413, 362);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(40, 20);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "체크";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(459, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 20);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // sfadFile
            // 
            this.sfadFile.DefaultExt = "txt";
            this.sfadFile.Filter = "텍스트 파일 (*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 393);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtForPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtForAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocPort);
            this.Controls.Add(this.lblLocPort);
            this.Controls.Add(this.lvNetState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NetStat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvNetState;
        private System.Windows.Forms.ColumnHeader clhLocalIP;
        private System.Windows.Forms.ColumnHeader clhLocalPort;
        private System.Windows.Forms.ColumnHeader clhRemoteIP;
        private System.Windows.Forms.ColumnHeader clhRemotePort;
        private System.Windows.Forms.ColumnHeader clhState;
        private System.Windows.Forms.Label lblLocPort;
        private System.Windows.Forms.TextBox txtLocPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtForAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForPort;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sfadFile;
    }
}

