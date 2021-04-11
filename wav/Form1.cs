using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using wav;

namespace wav
{
    public partial class Form1 : Form
    {
        private Thread SoundPlayThread;   // 사운드 실행 스레드 개체 생성
        private string FilePath = "";     // 파일 경로 저장
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtOpen.Text = this.ofdFile.FileName;
                this.FilePath = this.ofdFile.FileName;
                SoundPlayThread = new Thread(SoundPlayGo);
                SoundPlayThread.Start();
            }
        }
        private void SoundPlayGo()
        {
            PlaySoundGo.PlaySoundStart(FilePath, new System.IntPtr(),
                PlaySoundGo.PlaySoundFlags.SND_SYNC);
#pragma warning disable SYSLIB0006 // 형식 또는 멤버는 사용되지 않습니다.
            SoundPlayThread.Abort();
#pragma warning restore SYSLIB0006 // 형식 또는 멤버는 사용되지 않습니다.
        }
    }
}
