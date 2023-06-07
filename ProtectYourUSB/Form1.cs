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
            cbListDisk2.Items.Clear();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    cbListDisk.Items.Add(drive.Name);
                    cbListDisk1.Items.Add(drive.Name);
                    cbListDisk2.Items.Add(drive.Name);
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            bool flag;
            using (WindowsIdentity current = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
                flag = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            if (flag)
            {
                LoadDisk();

            }
            else
            {
                MessageBox.Show("Yêu cầu chạy với quyền Administrator !!!");
                return;
            }




        }

        void SetPermission_Store(string drive)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(drive);
            DirectorySecurity accessControl2 = directoryInfo.GetAccessControl();
            accessControl2.SetAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.Read, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));

            accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadData, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadExtendedAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.WriteData, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.AppendData, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.WriteAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.WriteExtendedAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.DeleteSubdirectoriesAndFiles, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            accessControl2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadPermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            directoryInfo.SetAccessControl(accessControl2);
            lbatNoti.Text = "Cài đặt quyền Store cho thư mục " + txtfnData.Text + "thành công";


        }


        void SetPermission_ReadOnly(string drive)
        {
            

                DirectoryInfo directoryInfo = new DirectoryInfo(drive);
                DirectorySecurity accessControl4 = directoryInfo.GetAccessControl();
                string userName = Environment.UserName;
                accessControl4.AddAccessRule(new FileSystemAccessRule(userName, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                accessControl4.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadData, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                accessControl4.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                accessControl4.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadExtendedAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                accessControl4.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadPermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                directoryInfo.SetAccessControl(accessControl4);

                lbatNoti.Text = "Cài đặt quyền ReadOnly cho thư mục " + txtfnReadOnly.Text + "thành công";

            
        }




        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string driveLetter = "";
            string status = lbNotiLock.Text;
            if (cbListDisk.Text != "")
            {
                driveLetter = cbListDisk.Text;
            }


            string drivePath = driveLetter.Trim().Substring(0, 2);

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
                SetPermission_Store(drivePath);

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

            DriveInfo driveInfo = new DriveInfo(drivePath);
            if (driveInfo.IsReady)
            {


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

                if (fullcontrol || modify || readX || write)
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
                else if (write && read)
                {
                    lbnotiPer.Text = "Write||Read";
                }
                else if (read)
                {
                    lbnotiPer.Text = "ReadOnly";

                }

                //string userName = Environment.UserName;
                //MessageBox.Show(userName);

            }
            else
            {
                MessageBox.Show("Không tìm thấy USB!!");
            }

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

            //tim virus shortcut

            string pathDisk = cbListDisk1.Text.Trim();
            Recur_find_Folder(pathDisk);

            GetListEXE();

            MessageBox.Show("Hiện file ẩn thành công!!");

            MessageBox.Show("Done");

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDisk();

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }


        public bool FormatDrive(string drive, string driveLabel, string fileSystem, bool quickFormat, bool enableCompression)
        {
            bool result = false;
            try
            {

                Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = "format.com",
                    CreateNoWindow = true,
                    WorkingDirectory = Environment.SystemDirectory,
                    Arguments = string.Concat(new string[]
                    {
                        "/FS:",
                        fileSystem,
                        " /Y /V:",
                        driveLabel,
                        quickFormat ? " /Q" : "",
                        (fileSystem == "NTFS" && enableCompression) ? " /C" : "",
                        " ",
                        drive
                    }),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true
                });
                process.WaitForExit();
                result = true;

            }
            catch (Exception)
            {
                result = false;

            }
            return result;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/msec.club");
        }

        private void chkFormat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFormat.Checked)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;

            }
        }

        private void chkLuutru_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLuutru.Checked)
            {
                txtfnData.Enabled = true;
            }
            else
            {
                txtfnData.Enabled = false;
            }
        }

        private void chkChiDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChiDoc.Checked)
            {
                txtfnReadOnly.Enabled = true;
            }
            else
            {
                txtfnReadOnly.Enabled = false;
            }
        }

        bool CreatingFolders(string drive)
        {
            string pathDisk = drive + "\\";
            bool res = false;
            lbatNoti.Text = "Đang tạo thư mục...";

            if (chkLuutru.Checked)
            {
                string namefn = pathDisk + txtfnData.Text.Trim();
                if (namefn != pathDisk)
                {
                    Directory.CreateDirectory(namefn);
                    res = true;
                }
            }

            if (chkChiDoc.Checked)
            {
                string namefn = pathDisk + txtfnReadOnly.Text.Trim();
                if (namefn != pathDisk)
                {
                    Directory.CreateDirectory(namefn);
                    res = true;

                }
            }
            lbatNoti.Text = "";
            return res;
        }


        private void btnMakeUSB_Click(object sender, EventArgs e)
        {
            if (cbListDisk2.Text == "")
            {
                MessageBox.Show("Hay chon o dia!!");
                return;
            }
            string pathDisk = cbListDisk2.Text.Trim().Substring(0, 2); // f:
            DirectoryInfo directoryInfo = new DirectoryInfo(pathDisk + "\\");
            DirectorySecurity accessControl = directoryInfo.GetAccessControl();
            accessControl.SetAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.Read, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            directoryInfo.SetAccessControl(accessControl);

            if (chkFormat.Checked) // format -> tao 3 thu muc
            {
                if (MessageBox.Show("Format USB sẽ mất tất cả dữ liệu hiện tại", "Format!! Bạn có chắc không?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnMakeUSB.Enabled = false;
                    lbatNoti.Text = "Đang thực hiện format, đợi một chút...";
                    lbatNoti.ForeColor = System.Drawing.Color.Blue;
                    if (FormatDrive(pathDisk, txtUSBname.Text.Trim(), "NTFS", true, false))
                    {
                        if (CreatingFolders(pathDisk))
                        {

                            

                            if (chkLuutru.Checked) SetPermission_Store(pathDisk + "\\" + txtfnData.Text.Trim());
                            if (chkChiDoc.Checked) SetPermission_ReadOnly(pathDisk + "\\"+txtfnReadOnly.Text.Trim());

                        }
                    }

                }
            }
            else // ko format-> tao 1 thu muc Data -> copy all vao Data
            {
                string dataFolderPath = $"{pathDisk}//Data";
                lbatNoti.Text = "Tạo thư mục Data...";

                if (!Directory.Exists(dataFolderPath))
                {
                    Directory.CreateDirectory(dataFolderPath);
                }
                lbatNoti.Text = "Đang thực hiện format, đợi một chút...";
                lbatNoti.Text = $"Bắt đầu di chuyển tệp...";
                CopyFilesAndFolders(pathDisk, dataFolderPath);
                SetPermission_ReadOnly(dataFolderPath);



            }


            lbatNoti.Text = "Hoàn tất";
            Process.Start(pathDisk);
            btnMakeUSB.Enabled = true;


        }


        void CopyFilesAndFolders(string sourcePath, string destinationPath)
        {
            // Sao chép tất cả các tệp
            try
            {
                string[] test = Directory.GetDirectories(sourcePath);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return;
            }

            foreach (string filePath in Directory.GetFiles(sourcePath))
            {
                string fileName = Path.GetFileName(filePath);
                string destinationFilePath = Path.Combine(destinationPath, fileName);
                File.Move(filePath, destinationFilePath);

                lbatNoti.Text = $"Đang chuyển {fileName} vào thư mục {destinationPath}";

            }

            // Sao chép tất cả các thư mục và nội dung bên trong
            foreach (string folderPath in Directory.GetDirectories(sourcePath))
            {
                string folderName = Path.GetFileName(folderPath);
                if (folderName != "Data")
                {
                    lbatNoti.Text = $"Đang chuyển thư mục {folderName} vào thư mục {destinationPath}";
                    string destinationFolderPath = Path.Combine(destinationPath, folderName);
                    //Directory.CreateDirectory(destinationFolderPath);
                    try
                    {
                        Directory.Move(folderPath, destinationFolderPath);

                    }
                    catch
                    {
                        continue;
                    }
                    CopyFilesAndFolders(folderPath, destinationFolderPath);

                }

            }

            lbatNoti.Text = $"Hoàn tất di chuyển...";

        }

        private void lkLuuTru_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Lưu trữ: Mọi người đều có thể thêm sửa xóa vào trong thư mục này của bạn, tên thư mục mặc định là Data");
        }

        private void lkChiDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chỉ đọc: Chỉ bạn có quyền thêm sửa xóa tại thư mục này, Người dùng khác chỉ có thế đọc, tên mặc định là ReadOnly");
        }

        private void lbusbATnoti_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thư mục Data sẽ được cài đặt chỉ đọc, chỉ bạn có thể thêm sửa xóa file, folder. ");
        }
        List<string> ListFolder = new List<string>();
        void Recur_find_Folder(string path)
        {
            try
            {
                string[] test = Directory.GetDirectories(path);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);

                return;
            }

            foreach (string folderPath in Directory.GetDirectories(path))
            {
                string folderName = Path.GetFileName(folderPath);
                ListFolder.Add(folderPath);
                string nextfolder = Path.Combine(path, folderName);
                Recur_find_Folder(nextfolder);
            }
        }


        void GetListEXE()
        {
            foreach (string namefd in ListFolder)
            {
                string parentPath = Directory.GetParent(namefd).FullName;
                string[] exefile = Directory.GetFiles(parentPath, Path.GetFileName(namefd) + "*.exe");

                if (exefile.Length > 0)
                {
                    foreach (string item in exefile)
                    {
                        string pathExe = Path.Combine(parentPath, item);
                        try
                        {

                            File.Delete(pathExe);
                            MessageBox.Show("Đã xóa " + pathExe);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Lỗi xóa tệp tin: " + ex.Message);
                        }


                    }

                }

            }
        }


    }
}
