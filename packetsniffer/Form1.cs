using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;


namespace mook_PacketSniffer
{
    public enum Protocol
    {
        TCP = 6,
        UDP = 17,
        Unknown = -1
    };

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Socket mainSocket;
        private byte[] byteData = new byte[4096];
        private bool bContinueCapturing = false;

        private int PacketNum = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tscbNum.Text = "100";
            
            string strIP = null;

            IPHostEntry HosyEntry = Dns.GetHostEntry((Dns.GetHostName()));
            if (HosyEntry.AddressList.Length > 0)
            {
                foreach (IPAddress ip in HosyEntry.AddressList)
                {
                    strIP = ip.ToString();
                    this.tscbIp.Items.Add(strIP);
                }
            }       
        }

        private void tsbtnStar_Click(object sender, EventArgs e)
        {
            if (this.tscbIp.Text == "")
            {
                MessageBox.Show("캡쳐할 네트워크 인터페이스를 선택하세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (!bContinueCapturing)
                {
                    this.tsbtnStar.Enabled = false;
                    this.tsbtnStop.Enabled = true;

                    bContinueCapturing = true;

                    mainSocket = new Socket(AddressFamily.InterNetwork,
                        SocketType.Raw, ProtocolType.IP);

                    mainSocket.Bind(new IPEndPoint(IPAddress.Parse(this.tscbIp.Text), 0));

                    mainSocket.SetSocketOption(SocketOptionLevel.IP,
                                               SocketOptionName.HeaderIncluded,
                                               true);

                    byte[] byTrue = new byte[4] { 1, 0, 0, 0 };
                    byte[] byOut = new byte[4] { 1, 0, 0, 0 };

                    mainSocket.IOControl(IOControlCode.ReceiveAll,
                                         byTrue,
                                         byOut);

                    mainSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                        new AsyncCallback(OnReceive), null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                int nReceived = mainSocket.EndReceive(ar);
                ParseData(byteData, nReceived);

                if (bContinueCapturing)
                {
                    byteData = new byte[4096];
                    mainSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                        new AsyncCallback(OnReceive), null);
                }
            }
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ParseData(byte[] byteData, int nReceived)
        {
            if (PacketNum == Convert.ToInt32(this.tscbNum.Text))
            {
                PacketNum = 1;
                this.lvReceivedPackets.Items.Clear();
            }
            IPHeader ipHeader = new IPHeader(byteData, nReceived);

            string[] lvStrArr = new string[] { PacketNum.ToString(), DateTime.Now.ToString(), 
                ipHeader.SourceAddress.ToString(), ipHeader.DestinationAddress.ToString(),
                ipHeader.ProtocolType.ToString(), ipHeader.TotalLength};

            string[] IpStrArr = MakeIP(ipHeader, ipHeader.ProtocolType.ToString());

            string[] MergeIPArr = new string[lvStrArr.Length + IpStrArr.Length];
            Array.Copy(lvStrArr, 0, MergeIPArr, 0, lvStrArr.Length);
            Array.Copy(IpStrArr, 0, MergeIPArr, lvStrArr.Length, IpStrArr.Length);

            string[] MergeTCP = null;
            string[] MergeUDP = null;
            string[] MergeAll = null;

            switch (ipHeader.ProtocolType)
            {
                case Protocol.TCP:
                    TCPHeader tcpHeader = new TCPHeader(ipHeader.Data,
                                                        ipHeader.MessageLength);
                    MergeTCP = MakeTCP(tcpHeader);
                    MergeAll = new string[MergeIPArr.Length + MergeTCP.Length];
                    Array.Copy(MergeIPArr, 0, MergeAll, 0, MergeIPArr.Length);
                    Array.Copy(MergeTCP, 0, MergeAll, MergeIPArr.Length, MergeTCP.Length);
                    break;
                case Protocol.UDP:
                    UDPHeader udpHeader = new UDPHeader(ipHeader.Data, 
                                                       (int)ipHeader.MessageLength);
                    MergeUDP = MakeUDP(udpHeader);
                    MergeAll = new string[MergeIPArr.Length + MergeUDP.Length];
                    Array.Copy(MergeIPArr, 0, MergeAll, 0, MergeIPArr.Length);
                    Array.Copy(MergeUDP, 0, MergeAll, MergeIPArr.Length, MergeUDP.Length);
                    break;
                case Protocol.Unknown:
                    MergeAll = MergeIPArr;
                    break;
            }
            var lvt = new ListViewItem(MergeAll);
            this.lvReceivedPackets.Items.Add(lvt);
            PacketNum++;
        }

        private string[] MakeIP(IPHeader ipHeader, string ProType)
        {
            string[] IpNode = new string[] { "IP", "Ver: " + ipHeader.Version, 
                "Header Length: " + ipHeader.HeaderLength,
                "Differntiated Services: " + ipHeader.DifferentiatedServices, 
                "Total Length: " + ipHeader.TotalLength,
                "Identification: " + ipHeader.Identification, 
                "Flags: " + ipHeader.Flags, 
                "Fragmentation Offset: " + ipHeader.FragmentationOffset,
                "Time to live: " + ipHeader.TTL, "Protocol: " + ProType,
                "Checksum: " + ipHeader.Checksum, 
                "Source: " + ipHeader.SourceAddress.ToString(),
                "Destination: " + ipHeader.DestinationAddress.ToString()};
            return IpNode;
        }

        private string[] MakeTCP(TCPHeader tcpHeader)
        {
            string ack = null; 
            if (tcpHeader.AcknowledgementNumber != "") 
                ack = "Acknowledgement Number: " + tcpHeader.AcknowledgementNumber;
            else 
                ack =  "Acknowledgement Number: ";

            string[] TCPNode = new string[] {"TCP", "Source Port: " + tcpHeader.SourcePort,
                "Destination Port: " + tcpHeader.DestinationPort,
                "Sequence Number: " + tcpHeader.SequenceNumber,
                ack, "Header Length: " + tcpHeader.HeaderLength,
                "Flags: " + tcpHeader.Flags,
                "Window Size: " + tcpHeader.WindowSize,
                "Checksum: " + tcpHeader.Checksum};
            return TCPNode;
        }

        private string[] MakeUDP(UDPHeader udpHeader)
        {
            string[] UDPNode = new string[] {"UDP", "Source Port: " + udpHeader.SourcePort,
                "Destination Port: " + udpHeader.DestinationPort,
                "Length: " + udpHeader.Length,
                "Checksum: " + udpHeader.Checksum};
            return UDPNode;
        }

        private void tsbtnStop_Click(object sender, EventArgs e)
        {
            this.tsbtnStar.Enabled = true;
            this.tsbtnStop.Enabled = false;
            bContinueCapturing = false;
            mainSocket.Close();
        }

        private void lvReceivedPackets_Click(object sender, EventArgs e)
        {
            this.tvPacketDetail.Nodes.Clear();
            tvPacketDetail.Nodes.Add(this.lvReceivedPackets.SelectedItems[0].SubItems[6].Text);
            for (int n = 7 ; n < 19 ;n++ )
            {
                 tvPacketDetail.Nodes[0].Nodes.Add(this.lvReceivedPackets.SelectedItems[0].SubItems[n].Text);
            }
            if(this.lvReceivedPackets.SelectedItems[0].SubItems[4].Text == "TCP")
            {
                tvPacketDetail.Nodes.Add(this.lvReceivedPackets.SelectedItems[0].SubItems[19].Text);
                for (int n = 20; n < 28; n++)
                {
                    tvPacketDetail.Nodes[1].Nodes.Add(this.lvReceivedPackets.SelectedItems[0].SubItems[n].Text);
                }
            }
            else if(this.lvReceivedPackets.SelectedItems[0].SubItems[4].Text == "UDP")
            {
                tvPacketDetail.Nodes.Add(this.lvReceivedPackets.SelectedItems[0].SubItems[19].Text);
                for (int n = 20; n < 24; n++)
                {
                    tvPacketDetail.Nodes[1].Nodes.Add(this.lvReceivedPackets.SelectedItems[0].SubItems[n].Text);
                }
            }
            this.tvPacketDetail.ExpandAll();
        }

        private void lvReceivedPackets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
