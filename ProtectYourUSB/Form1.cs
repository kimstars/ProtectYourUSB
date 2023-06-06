using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtectYourUSB
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isLock = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    //MessageBox.Show(drive.Name);
                    cbListDisk.Items.Add(drive.Name);
                }
            }



        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string driveLetter = "";
            string status = lbNotiLock.Text;
            if(cbListDisk.Text != "")
            {
                driveLetter = cbListDisk.Text;
            }
           
            string drivePath = $"{driveLetter}";
            if(status == "Unlocked")
            {
                // Đặt thuộc tính chỉ đọc cho ổ đĩa
                //File.SetAttributes(drivePath, File.GetAttributes(drivePath) | FileAttributes.ReadOnly);
                runps($"get-disk -Number (Get-Partition -DriveLetter {drivePath[0]}).disknumber | Set-Disk -IsReadOnly 1");
                btnSubmit.Text = "Locked";
            }
            else
            {
                //File.SetAttributes(drivePath, File.GetAttributes(drivePath) & ~FileAttributes.ReadOnly);
                runps($"get-disk -Number (Get-Partition -DriveLetter {drivePath[0]}).disknumber | Set-Disk -IsReadOnly 0");

                btnSubmit.Text = "Unlocked";

            }

            checkstatus(drivePath);



        }
        void runps(string cmd)
        {
            Process process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = $"-Command \"{cmd}\"";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            // Bắt đầu thực thi quy trình PowerShell
            process.Start();

            // Đọc kết quả từ đầu ra và đầu ra lỗi (nếu có)
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            // Chờ quy trình kết thúc
            process.WaitForExit();

            // In kết quả và lỗi (nếu có)
            Console.WriteLine("Kết quả:");
            Console.WriteLine(error);

        }

        void checkstatus(string drivePath)
        {
            bool isReadOnly = false;
            bool shouldDelete = true;

            try
            {
                System.IO.Directory.CreateDirectory(drivePath + "test");
                shouldDelete = true;

            }
            catch (IOException ex)
            {
                //read-only
                isReadOnly = true;
                shouldDelete = false;

            }

            if (shouldDelete)
            {
                System.IO.Directory.Delete(drivePath + "test");
            }

            if (!isReadOnly)
            {
                lbNotiLock.Text = "Unlocked";
                btnSubmit.Text = "Lock";
            }
            else
            {
                lbNotiLock.Text = "Locked";
                btnSubmit.Text = "Unlock";

            }

        }
        private void cbListDisk_SelectedIndexChanged(object sender, EventArgs e)
        {

            string drivePath = cbListDisk.SelectedItem.ToString();

            checkstatus(drivePath);



            //MessageBox.Show(isReadOnly.ToString());
        }
    }
}
