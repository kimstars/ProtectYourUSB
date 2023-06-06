using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
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
        void LoadDisk()
        {
            cbListDisk.Items.Clear();
            cbListDisk1.Items.Clear();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    //MessageBox.Show(drive.Name);
                    cbListDisk.Items.Add(drive.Name);
                    cbListDisk1.Items.Add(drive.Name);
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDisk();



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

            DirectoryInfo directoryInfo = new DirectoryInfo(drivePath);
            DirectorySecurity accessControl = directoryInfo.GetAccessControl();



            if (status == "Unlocked")
            {
                accessControl.SetAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.Read, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                directoryInfo.SetAccessControl(accessControl);

                btnSubmit.Text = "Locked";
            }
            else
            {
                DirectoryInfo directoryInfo2 = new DirectoryInfo(drivePath);
                DirectorySecurity accessControl2 = directoryInfo.GetAccessControl();
                accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadData, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadExtendedAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.WriteData, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.AppendData, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.WriteAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.WriteExtendedAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.DeleteSubdirectoriesAndFiles, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadPermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                directoryInfo2.SetAccessControl(accessControl2);

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

        }

        void checkstatus(string drivePath)
        {
            bool fullcontrol, modify, readX, listfolder, read, write;
            fullcontrol = modify = readX = listfolder = read = write = false;
            string status = "";

            DriveInfo driveInfo = new DriveInfo(drivePath);
            AuthorizationRuleCollection accessRules = driveInfo.RootDirectory.GetAccessControl().GetAccessRules(true, true, typeof(SecurityIdentifier));

            foreach (FileSystemAccessRule rule in accessRules)
            {
                if (rule.IdentityReference.Value.ToString() == "S-1-1-0")
                {
                    if (rule.AccessControlType == AccessControlType.Allow)
                    {
                        if ((rule.FileSystemRights & FileSystemRights.FullControl) == FileSystemRights.FullControl)
                        {
                            fullcontrol = true;
                            break;
                        }

                        if ((rule.FileSystemRights & FileSystemRights.Modify) == FileSystemRights.Modify)
                        {
                            modify = true;
                        }

                        if ((rule.FileSystemRights & FileSystemRights.ReadAndExecute) == FileSystemRights.ReadAndExecute)
                        {
                            readX = true;
                        }

                        
                        if ((rule.FileSystemRights & FileSystemRights.Read) == FileSystemRights.Read)
                        {
                            read = true;
                        }

                        if ((rule.FileSystemRights & FileSystemRights.Write) == FileSystemRights.Write)
                        {
                            write = true;
                        }
                    }
                }
            }

            if (fullcontrol || modify||readX|| write)
            {
                lbNotiLock.Text = "Unlocked";
                btnSubmit.Text = "Lock";
            }
            else
            {
                lbNotiLock.Text = "Locked";
                btnSubmit.Text = "Unlock";
            }

            if (fullcontrol)
            {
                lbnotiPer.Text = "FullControl";
            }
            else if (write&&read)
            {
                lbnotiPer.Text = "Write||Read";
            }else if (read)
            {
                lbnotiPer.Text = "ReadOnly";

            }

            //string userName = Environment.UserName;
            //MessageBox.Show(userName);


        }
        private void cbListDisk_SelectedIndexChanged(object sender, EventArgs e)
        {

            string drivePath = cbListDisk.SelectedItem.ToString();

            checkstatus(drivePath);

 
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string driveLetter = "";
            if (cbListDisk1.Text != "")
            {
                driveLetter = cbListDisk1.Text;
            }

            string drivePath = $"{driveLetter}";
            runps($"attrib -s -h -r /s /d {drivePath}*. ");
            MessageBox.Show("Done");

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDisk();

        }
    }
}
