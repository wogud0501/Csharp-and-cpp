namespace mook_PacketSniffer
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnStar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblIp = new System.Windows.Forms.ToolStripLabel();
            this.tscbIp = new System.Windows.Forms.ToolStripComboBox();
            this.tslblNum = new System.Windows.Forms.ToolStripLabel();
            this.tscbNum = new System.Windows.Forms.ToolStripComboBox();
            this.lvReceivedPackets = new System.Windows.Forms.ListView();
            this.chNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProtocol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvPacketDetail = new System.Windows.Forms.TreeView();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnStar,
            this.tsbtnStop,
            this.toolStripSeparator1,
            this.tslblIp,
            this.tscbIp,
            this.tslblNum,
            this.tscbNum});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.MinimumSize = new System.Drawing.Size(0, 28);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(931, 28);
            this.tsMenu.TabIndex = 2;
            this.tsMenu.Text = "tsManu";
            // 
            // tsbtnStar
            // 
            this.tsbtnStar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStar.Image")));
            this.tsbtnStar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStar.Name = "tsbtnStar";
            this.tsbtnStar.Size = new System.Drawing.Size(23, 25);
            this.tsbtnStar.Text = "Start";
            this.tsbtnStar.Click += new System.EventHandler(this.tsbtnStar_Click);
            // 
            // tsbtnStop
            // 
            this.tsbtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStop.Enabled = false;
            this.tsbtnStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStop.Image")));
            this.tsbtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStop.Name = "tsbtnStop";
            this.tsbtnStop.Size = new System.Drawing.Size(23, 25);
            this.tsbtnStop.Text = "Stop";
            this.tsbtnStop.Click += new System.EventHandler(this.tsbtnStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // tslblIp
            // 
            this.tslblIp.Name = "tslblIp";
            this.tslblIp.Size = new System.Drawing.Size(83, 25);
            this.tslblIp.Text = "Select IP Addr";
            // 
            // tscbIp
            // 
            this.tscbIp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbIp.Name = "tscbIp";
            this.tscbIp.Size = new System.Drawing.Size(250, 28);
            // 
            // tslblNum
            // 
            this.tslblNum.Name = "tslblNum";
            this.tslblNum.Size = new System.Drawing.Size(73, 25);
            this.tslblNum.Text = "Packet Num";
            // 
            // tscbNum
            // 
            this.tscbNum.Items.AddRange(new object[] {
            "100",
            "300",
            "400",
            "500",
            "1000"});
            this.tscbNum.Name = "tscbNum";
            this.tscbNum.Size = new System.Drawing.Size(80, 28);
            // 
            // lvReceivedPackets
            // 
            this.lvReceivedPackets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNo,
            this.chTime,
            this.chSource,
            this.chDest,
            this.chProtocol,
            this.chPack});
            this.lvReceivedPackets.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvReceivedPackets.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvReceivedPackets.FullRowSelect = true;
            this.lvReceivedPackets.GridLines = true;
            this.lvReceivedPackets.HideSelection = false;
            this.lvReceivedPackets.Location = new System.Drawing.Point(0, 28);
            this.lvReceivedPackets.Name = "lvReceivedPackets";
            this.lvReceivedPackets.Size = new System.Drawing.Size(931, 187);
            this.lvReceivedPackets.TabIndex = 3;
            this.lvReceivedPackets.UseCompatibleStateImageBehavior = false;
            this.lvReceivedPackets.View = System.Windows.Forms.View.Details;
            this.lvReceivedPackets.SelectedIndexChanged += new System.EventHandler(this.lvReceivedPackets_SelectedIndexChanged);
            this.lvReceivedPackets.Click += new System.EventHandler(this.lvReceivedPackets_Click);
            // 
            // chNo
            // 
            this.chNo.Text = "No.";
            this.chNo.Width = 70;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.Width = 180;
            // 
            // chSource
            // 
            this.chSource.Text = "Source";
            this.chSource.Width = 150;
            // 
            // chDest
            // 
            this.chDest.Text = "Destination";
            this.chDest.Width = 150;
            // 
            // chProtocol
            // 
            this.chProtocol.Text = "Protocol";
            this.chProtocol.Width = 100;
            // 
            // chPack
            // 
            this.chPack.Text = "Package Size";
            this.chPack.Width = 100;
            // 
            // tvPacketDetail
            // 
            this.tvPacketDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvPacketDetail.Location = new System.Drawing.Point(0, 215);
            this.tvPacketDetail.Name = "tvPacketDetail";
            this.tvPacketDetail.Size = new System.Drawing.Size(931, 219);
            this.tvPacketDetail.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 434);
            this.Controls.Add(this.tvPacketDetail);
            this.Controls.Add(this.lvReceivedPackets);
            this.Controls.Add(this.tsMenu);
            this.Name = "Form1";
            this.Text = "PacketSniffer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbtnStar;
        private System.Windows.Forms.ToolStripButton tsbtnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslblIp;
        private System.Windows.Forms.ToolStripComboBox tscbIp;
        private System.Windows.Forms.ListView lvReceivedPackets;
        private System.Windows.Forms.ColumnHeader chNo;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chSource;
        private System.Windows.Forms.ColumnHeader chDest;
        private System.Windows.Forms.ColumnHeader chProtocol;
        private System.Windows.Forms.ColumnHeader chPack;
        private System.Windows.Forms.ToolStripLabel tslblNum;
        private System.Windows.Forms.ToolStripComboBox tscbNum;
        private System.Windows.Forms.TreeView tvPacketDetail;
    }
}

