
namespace ProtectYourUSB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbListDisk = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lbnotiPer = new System.Windows.Forms.Label();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lbNotiLock = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cbListDisk2 = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFormat = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtUSBname = new System.Windows.Forms.TextBox();
            this.lbusbATnoti = new System.Windows.Forms.Label();
            this.lbatNoti = new System.Windows.Forms.Label();
            this.btnMakeUSB = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lkChiDoc = new System.Windows.Forms.LinkLabel();
            this.lkLuuTru = new System.Windows.Forms.LinkLabel();
            this.txtfnReadOnly = new System.Windows.Forms.TextBox();
            this.txtfnData = new System.Windows.Forms.TextBox();
            this.chkChiDoc = new MetroFramework.Controls.MetroCheckBox();
            this.chkLuutru = new MetroFramework.Controls.MetroCheckBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnShow = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbListDisk1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(59, 111);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Select USB";
            // 
            // cbListDisk
            // 
            this.cbListDisk.FormattingEnabled = true;
            this.cbListDisk.ItemHeight = 24;
            this.cbListDisk.Location = new System.Drawing.Point(162, 111);
            this.cbListDisk.Name = "cbListDisk";
            this.cbListDisk.Size = new System.Drawing.Size(121, 30);
            this.cbListDisk.TabIndex = 1;
            this.cbListDisk.SelectedIndexChanged += new System.EventHandler(this.cbListDisk_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Location = new System.Drawing.Point(89, 164);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Status";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(561, 415);
            this.metroTabControl1.TabIndex = 6;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.lbnotiPer);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.lbNotiLock);
            this.metroTabPage1.Controls.Add(this.btnSubmit);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.cbListDisk);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(553, 372);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Protect USB";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(23, 35);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(428, 25);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Khóa tạm thời USB của bạn khỏi Virus shortcut";
            // 
            // lbnotiPer
            // 
            this.lbnotiPer.AutoSize = true;
            this.lbnotiPer.BackColor = System.Drawing.Color.Transparent;
            this.lbnotiPer.ForeColor = System.Drawing.Color.Red;
            this.lbnotiPer.Location = new System.Drawing.Point(159, 207);
            this.lbnotiPer.Name = "lbnotiPer";
            this.lbnotiPer.Size = new System.Drawing.Size(13, 17);
            this.lbnotiPer.TabIndex = 9;
            this.lbnotiPer.Text = "*";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Location = new System.Drawing.Point(59, 204);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 20);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Permission";
            // 
            // lbNotiLock
            // 
            this.lbNotiLock.AutoSize = true;
            this.lbNotiLock.BackColor = System.Drawing.Color.Transparent;
            this.lbNotiLock.ForeColor = System.Drawing.Color.Red;
            this.lbNotiLock.Location = new System.Drawing.Point(159, 167);
            this.lbNotiLock.Name = "lbNotiLock";
            this.lbNotiLock.Size = new System.Drawing.Size(13, 17);
            this.lbNotiLock.TabIndex = 7;
            this.lbNotiLock.Text = "*";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(333, 110);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 114);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Lock";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.White;
            this.metroTabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTabPage3.Controls.Add(this.pictureBox1);
            this.metroTabPage3.Controls.Add(this.metroLabel9);
            this.metroTabPage3.Controls.Add(this.metroLabel8);
            this.metroTabPage3.Controls.Add(this.cbListDisk2);
            this.metroTabPage3.Controls.Add(this.groupBox2);
            this.metroTabPage3.Controls.Add(this.lbatNoti);
            this.metroTabPage3.Controls.Add(this.btnMakeUSB);
            this.metroTabPage3.Controls.Add(this.groupBox1);
            this.metroTabPage3.CustomBackground = true;
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(553, 372);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Tạo USB-AT";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ProtectYourUSB.Properties.Resources.usb1;
            this.pictureBox1.Location = new System.Drawing.Point(-311, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(148, 26);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(259, 25);
            this.metroLabel9.TabIndex = 15;
            this.metroLabel9.Text = "Tạo USB an toàn chuẩn CTK";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.Location = new System.Drawing.Point(71, 73);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(75, 20);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Select USB";
            // 
            // cbListDisk2
            // 
            this.cbListDisk2.FormattingEnabled = true;
            this.cbListDisk2.ItemHeight = 24;
            this.cbListDisk2.Location = new System.Drawing.Point(170, 73);
            this.cbListDisk2.Name = "cbListDisk2";
            this.cbListDisk2.Size = new System.Drawing.Size(199, 30);
            this.cbListDisk2.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkFormat);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.txtUSBname);
            this.groupBox2.Controls.Add(this.lbusbATnoti);
            this.groupBox2.Location = new System.Drawing.Point(19, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 89);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiết lập chung";
            // 
            // chkFormat
            // 
            this.chkFormat.AutoSize = true;
            this.chkFormat.Location = new System.Drawing.Point(35, 26);
            this.chkFormat.Name = "chkFormat";
            this.chkFormat.Size = new System.Drawing.Size(92, 17);
            this.chkFormat.TabIndex = 10;
            this.chkFormat.Text = "Format USB";
            this.chkFormat.UseVisualStyleBackColor = true;
            this.chkFormat.CheckedChanged += new System.EventHandler(this.chkFormat_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(267, 23);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 20);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Đặt tên USB";
            // 
            // txtUSBname
            // 
            this.txtUSBname.Location = new System.Drawing.Point(378, 21);
            this.txtUSBname.Name = "txtUSBname";
            this.txtUSBname.Size = new System.Drawing.Size(93, 22);
            this.txtUSBname.TabIndex = 6;
            this.txtUSBname.Text = "usb_at_msec";
            // 
            // lbusbATnoti
            // 
            this.lbusbATnoti.AutoSize = true;
            this.lbusbATnoti.BackColor = System.Drawing.Color.Transparent;
            this.lbusbATnoti.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusbATnoti.ForeColor = System.Drawing.Color.Red;
            this.lbusbATnoti.Location = new System.Drawing.Point(27, 55);
            this.lbusbATnoti.Name = "lbusbATnoti";
            this.lbusbATnoti.Size = new System.Drawing.Size(468, 19);
            this.lbusbATnoti.TabIndex = 3;
            this.lbusbATnoti.Text = "*không chon Format, các file và folder sẽ được chuyển vào thư mục /Data";
            this.lbusbATnoti.Click += new System.EventHandler(this.lbusbATnoti_Click);
            // 
            // lbatNoti
            // 
            this.lbatNoti.AutoSize = true;
            this.lbatNoti.BackColor = System.Drawing.Color.Transparent;
            this.lbatNoti.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbatNoti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbatNoti.Location = new System.Drawing.Point(33, 341);
            this.lbatNoti.Name = "lbatNoti";
            this.lbatNoti.Size = new System.Drawing.Size(15, 19);
            this.lbatNoti.TabIndex = 11;
            this.lbatNoti.Text = "*";
            // 
            // btnMakeUSB
            // 
            this.btnMakeUSB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakeUSB.Location = new System.Drawing.Point(170, 297);
            this.btnMakeUSB.Name = "btnMakeUSB";
            this.btnMakeUSB.Size = new System.Drawing.Size(199, 34);
            this.btnMakeUSB.TabIndex = 9;
            this.btnMakeUSB.Text = "Tạo USB-AT";
            this.btnMakeUSB.Click += new System.EventHandler(this.btnMakeUSB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lkChiDoc);
            this.groupBox1.Controls.Add(this.lkLuuTru);
            this.groupBox1.Controls.Add(this.txtfnReadOnly);
            this.groupBox1.Controls.Add(this.txtfnData);
            this.groupBox1.Controls.Add(this.chkChiDoc);
            this.groupBox1.Controls.Add(this.chkLuutru);
            this.groupBox1.Location = new System.Drawing.Point(19, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân quyền thư mục";
            this.groupBox1.Visible = false;
            // 
            // lkChiDoc
            // 
            this.lkChiDoc.AutoSize = true;
            this.lkChiDoc.Location = new System.Drawing.Point(264, 25);
            this.lkChiDoc.Name = "lkChiDoc";
            this.lkChiDoc.Size = new System.Drawing.Size(16, 17);
            this.lkChiDoc.TabIndex = 13;
            this.lkChiDoc.TabStop = true;
            this.lkChiDoc.Text = "?";
            this.lkChiDoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkChiDoc_LinkClicked);
            // 
            // lkLuuTru
            // 
            this.lkLuuTru.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lkLuuTru.AutoSize = true;
            this.lkLuuTru.Location = new System.Drawing.Point(13, 26);
            this.lkLuuTru.Name = "lkLuuTru";
            this.lkLuuTru.Size = new System.Drawing.Size(16, 17);
            this.lkLuuTru.TabIndex = 12;
            this.lkLuuTru.TabStop = true;
            this.lkLuuTru.Text = "?";
            this.lkLuuTru.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLuuTru_LinkClicked);
            // 
            // txtfnReadOnly
            // 
            this.txtfnReadOnly.Enabled = false;
            this.txtfnReadOnly.Location = new System.Drawing.Point(378, 21);
            this.txtfnReadOnly.Name = "txtfnReadOnly";
            this.txtfnReadOnly.Size = new System.Drawing.Size(93, 22);
            this.txtfnReadOnly.TabIndex = 11;
            this.txtfnReadOnly.Text = "ReadOnly";
            // 
            // txtfnData
            // 
            this.txtfnData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtfnData.Enabled = false;
            this.txtfnData.Location = new System.Drawing.Point(129, 20);
            this.txtfnData.Name = "txtfnData";
            this.txtfnData.Size = new System.Drawing.Size(93, 22);
            this.txtfnData.TabIndex = 10;
            this.txtfnData.Text = "Data";
            // 
            // chkChiDoc
            // 
            this.chkChiDoc.AutoSize = true;
            this.chkChiDoc.Location = new System.Drawing.Point(282, 25);
            this.chkChiDoc.Name = "chkChiDoc";
            this.chkChiDoc.Size = new System.Drawing.Size(68, 17);
            this.chkChiDoc.TabIndex = 9;
            this.chkChiDoc.Text = "Chỉ đọc";
            this.chkChiDoc.UseVisualStyleBackColor = true;
            this.chkChiDoc.CheckedChanged += new System.EventHandler(this.chkChiDoc_CheckedChanged);
            // 
            // chkLuutru
            // 
            this.chkLuutru.AutoSize = true;
            this.chkLuutru.Location = new System.Drawing.Point(35, 25);
            this.chkLuutru.Name = "chkLuutru";
            this.chkLuutru.Size = new System.Drawing.Size(66, 17);
            this.chkLuutru.TabIndex = 8;
            this.chkLuutru.Text = "Lưu trữ";
            this.chkLuutru.UseVisualStyleBackColor = true;
            this.chkLuutru.CheckedChanged += new System.EventHandler(this.chkLuutru_CheckedChanged);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.btnShow);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.cbListDisk1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(553, 372);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Hiện file ẩn";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(97, 79);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(328, 25);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Hiện thị file bị ẩn bởi Virus shortcut";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(327, 163);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(127, 30);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Location = new System.Drawing.Point(61, 163);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 20);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Select USB";
            // 
            // cbListDisk1
            // 
            this.cbListDisk1.FormattingEnabled = true;
            this.cbListDisk1.ItemHeight = 24;
            this.cbListDisk1.Location = new System.Drawing.Point(172, 163);
            this.cbListDisk1.Name = "cbListDisk1";
            this.cbListDisk1.Size = new System.Drawing.Size(127, 30);
            this.cbListDisk1.TabIndex = 3;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.label3);
            this.metroTabPage4.Controls.Add(this.label2);
            this.metroTabPage4.Controls.Add(this.label1);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(553, 372);
            this.metroTabPage4.TabIndex = 4;
            this.metroTabPage4.Text = "Thông tin";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(542, 43);
            this.label3.TabIndex = 7;
            this.label3.Text = "Github: kimstars";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author: Chu Tuan Kiet";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Công cụ tạm khóa USB của bạn tránh Virus shortcut ẩn, thay đổi dữ liệu trong USB " +
    "của bạn khi cắm USB ở các máy tính chùa như quán photo, tiệm net";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(287, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 37);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(601, 495);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(601, 495);
            this.MinimumSize = new System.Drawing.Size(601, 495);
            this.Name = "Form1";
            this.Text = "ProtectYourUSB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbListDisk;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnShow;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbListDisk1;
        private System.Windows.Forms.Label lbNotiLock;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.Label lbnotiPer;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbusbATnoti;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox txtUSBname;
        private MetroFramework.Controls.MetroCheckBox chkChiDoc;
        private MetroFramework.Controls.MetroCheckBox chkLuutru;
        private MetroFramework.Controls.MetroCheckBox chkFormat;
        private MetroFramework.Controls.MetroButton btnMakeUSB;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Label lbatNoti;
        private System.Windows.Forms.TextBox txtfnReadOnly;
        private System.Windows.Forms.TextBox txtfnData;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cbListDisk2;
        private System.Windows.Forms.LinkLabel lkChiDoc;
        private System.Windows.Forms.LinkLabel lkLuuTru;
    }
}

