namespace WindowsForm
{
    partial class InformationForm
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
            this.ok_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DonVi = new System.Windows.Forms.ComboBox();
            this.LiDo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TGianRa = new System.Windows.Forms.TextBox();
            this.TGianVao = new System.Windows.Forms.TextBox();
            this.LiDo_Khac = new System.Windows.Forms.RichTextBox();
            this.ChucVu = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Tongiao = new System.Windows.Forms.TextBox();
            this.QueQuan = new System.Windows.Forms.TextBox();
            this.DiaChi = new System.Windows.Forms.TextBox();
            this.QTich = new System.Windows.Forms.TextBox();
            this.GTinh = new System.Windows.Forms.TextBox();
            this.NgSinh = new System.Windows.Forms.TextBox();
            this.HoTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CCCD = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CMND = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.HetHan = new System.Windows.Forms.TextBox();
            this.NgayCap = new System.Windows.Forms.TextBox();
            this.TenVC = new System.Windows.Forms.TextBox();
            this.TenMe = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TenCha = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(493, 622);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.OK_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(47, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Đơn vị             : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(49, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Lí do               : ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // DonVi
            // 
            this.DonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DonVi.FormattingEnabled = true;
            this.DonVi.Location = new System.Drawing.Point(209, 251);
            this.DonVi.Name = "DonVi";
            this.DonVi.Size = new System.Drawing.Size(298, 24);
            this.DonVi.TabIndex = 21;
            this.DonVi.SelectedIndexChanged += new System.EventHandler(this.DonVi_SelectedIndexChanged);
            // 
            // LiDo
            // 
            this.LiDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LiDo.FormattingEnabled = true;
            this.LiDo.Location = new System.Drawing.Point(211, 299);
            this.LiDo.Name = "LiDo";
            this.LiDo.Size = new System.Drawing.Size(298, 24);
            this.LiDo.TabIndex = 22;
            this.LiDo.SelectedIndexChanged += new System.EventHandler(this.LiDo_SelectedIndexChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(49, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "Thời gian vào : ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(49, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "Thời gian ra   : ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // TGianRa
            // 
            this.TGianRa.Location = new System.Drawing.Point(211, 52);
            this.TGianRa.Name = "TGianRa";
            this.TGianRa.Size = new System.Drawing.Size(298, 22);
            this.TGianRa.TabIndex = 25;
            this.TGianRa.TextChanged += new System.EventHandler(this.TGianRa_TextChanged);
            // 
            // TGianVao
            // 
            this.TGianVao.Location = new System.Drawing.Point(211, 107);
            this.TGianVao.Name = "TGianVao";
            this.TGianVao.Size = new System.Drawing.Size(298, 22);
            this.TGianVao.TabIndex = 26;
            this.TGianVao.TextChanged += new System.EventHandler(this.TGianVao_TextChanged);
            // 
            // LiDo_Khac
            // 
            this.LiDo_Khac.Location = new System.Drawing.Point(209, 349);
            this.LiDo_Khac.Name = "LiDo_Khac";
            this.LiDo_Khac.Size = new System.Drawing.Size(298, 96);
            this.LiDo_Khac.TabIndex = 27;
            this.LiDo_Khac.Text = "";
            this.LiDo_Khac.TextChanged += new System.EventHandler(this.LiDo_Khac_TextChanged);
            // 
            // ChucVu
            // 
            this.ChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChucVu.FormattingEnabled = true;
            this.ChucVu.Location = new System.Drawing.Point(211, 162);
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Size = new System.Drawing.Size(298, 24);
            this.ChucVu.TabIndex = 29;
            this.ChucVu.SelectedIndexChanged += new System.EventHandler(this.ChucVu_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(49, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "Bạn là             : ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(47, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(215, 19);
            this.label14.TabIndex = 30;
            this.label14.Text = "* Chỉ áp dụng với quân nhân";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(593, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(487, 576);
            this.tabControl1.TabIndex = 31;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox6);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.Tongiao);
            this.tabPage1.Controls.Add(this.QueQuan);
            this.tabPage1.Controls.Add(this.DiaChi);
            this.tabPage1.Controls.Add(this.QTich);
            this.tabPage1.Controls.Add(this.GTinh);
            this.tabPage1.Controls.Add(this.NgSinh);
            this.tabPage1.Controls.Add(this.HoTen);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CCCD);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(479, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Front";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Tongiao
            // 
            this.Tongiao.Location = new System.Drawing.Point(152, 434);
            this.Tongiao.Name = "Tongiao";
            this.Tongiao.Size = new System.Drawing.Size(300, 22);
            this.Tongiao.TabIndex = 49;
            this.Tongiao.TextChanged += new System.EventHandler(this.Tongiao_TextChanged);
            // 
            // QueQuan
            // 
            this.QueQuan.Location = new System.Drawing.Point(152, 477);
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Size = new System.Drawing.Size(300, 22);
            this.QueQuan.TabIndex = 48;
            this.QueQuan.TextChanged += new System.EventHandler(this.QueQuan_TextChanged);
            // 
            // DiaChi
            // 
            this.DiaChi.Location = new System.Drawing.Point(152, 522);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(300, 22);
            this.DiaChi.TabIndex = 47;
            this.DiaChi.TextChanged += new System.EventHandler(this.DiaChi_TextChanged);
            // 
            // QTich
            // 
            this.QTich.Location = new System.Drawing.Point(152, 387);
            this.QTich.Name = "QTich";
            this.QTich.Size = new System.Drawing.Size(300, 22);
            this.QTich.TabIndex = 46;
            this.QTich.TextChanged += new System.EventHandler(this.QTich_TextChanged_1);
            // 
            // GTinh
            // 
            this.GTinh.Location = new System.Drawing.Point(152, 345);
            this.GTinh.Name = "GTinh";
            this.GTinh.Size = new System.Drawing.Size(300, 22);
            this.GTinh.TabIndex = 45;
            this.GTinh.TextChanged += new System.EventHandler(this.GTinh_TextChanged);
            // 
            // NgSinh
            // 
            this.NgSinh.Location = new System.Drawing.Point(152, 300);
            this.NgSinh.Name = "NgSinh";
            this.NgSinh.Size = new System.Drawing.Size(300, 22);
            this.NgSinh.TabIndex = 44;
            this.NgSinh.TextChanged += new System.EventHandler(this.NgSinh_TextChanged);
            // 
            // HoTen
            // 
            this.HoTen.Location = new System.Drawing.Point(152, 255);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(300, 22);
            this.HoTen.TabIndex = 43;
            this.HoTen.TextChanged += new System.EventHandler(this.HoTen_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(12, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 42;
            this.label8.Text = "Tôn giáo     : ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(12, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Quê quán  : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(16, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Địa chỉ      :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(12, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Quốc tịch : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(12, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "Giới tính  : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ngày sinh : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Họ tên      : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Số CCCD : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CCCD
            // 
            this.CCCD.Location = new System.Drawing.Point(152, 207);
            this.CCCD.Name = "CCCD";
            this.CCCD.Size = new System.Drawing.Size(300, 22);
            this.CCCD.TabIndex = 34;
            this.CCCD.TextChanged += new System.EventHandler(this.CCCD_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CMND);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.HetHan);
            this.tabPage2.Controls.Add(this.NgayCap);
            this.tabPage2.Controls.Add(this.TenVC);
            this.tabPage2.Controls.Add(this.TenMe);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.TenCha);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(479, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Back";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // CMND
            // 
            this.CMND.Location = new System.Drawing.Point(146, 436);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(300, 22);
            this.CMND.TabIndex = 66;
            this.CMND.TextChanged += new System.EventHandler(this.CMND_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label20.Location = new System.Drawing.Point(6, 431);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 23);
            this.label20.TabIndex = 65;
            this.label20.Text = "CMND cũ :";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // HetHan
            // 
            this.HetHan.Location = new System.Drawing.Point(144, 391);
            this.HetHan.Name = "HetHan";
            this.HetHan.Size = new System.Drawing.Size(300, 22);
            this.HetHan.TabIndex = 62;
            this.HetHan.TextChanged += new System.EventHandler(this.HetHan_TextChanged);
            // 
            // NgayCap
            // 
            this.NgayCap.Location = new System.Drawing.Point(144, 349);
            this.NgayCap.Name = "NgayCap";
            this.NgayCap.Size = new System.Drawing.Size(300, 22);
            this.NgayCap.TabIndex = 61;
            this.NgayCap.TextChanged += new System.EventHandler(this.NgayCap_TextChanged);
            // 
            // TenVC
            // 
            this.TenVC.Location = new System.Drawing.Point(144, 304);
            this.TenVC.Name = "TenVC";
            this.TenVC.Size = new System.Drawing.Size(300, 22);
            this.TenVC.TabIndex = 60;
            this.TenVC.TextChanged += new System.EventHandler(this.TenVC_TextChanged);
            // 
            // TenMe
            // 
            this.TenMe.Location = new System.Drawing.Point(144, 259);
            this.TenMe.Name = "TenMe";
            this.TenMe.Size = new System.Drawing.Size(300, 22);
            this.TenMe.TabIndex = 59;
            this.TenMe.TextChanged += new System.EventHandler(this.TenMe_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(4, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 23);
            this.label15.TabIndex = 58;
            this.label15.Text = "Ngày hết hạn :";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(4, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 23);
            this.label16.TabIndex = 57;
            this.label16.Text = "Ngày cấp  : ";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(4, 296);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 23);
            this.label17.TabIndex = 56;
            this.label17.Text = "Tên vợ/chồng: ";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(4, 251);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 23);
            this.label18.TabIndex = 55;
            this.label18.Text = "Tên mẹ     : ";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.Location = new System.Drawing.Point(4, 206);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 23);
            this.label19.TabIndex = 54;
            this.label19.Text = "Tên cha : ";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // TenCha
            // 
            this.TenCha.Location = new System.Drawing.Point(144, 211);
            this.TenCha.Name = "TenCha";
            this.TenCha.Size = new System.Drawing.Size(300, 22);
            this.TenCha.TabIndex = 53;
            this.TenCha.TextChanged += new System.EventHandler(this.TenCha_TextChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(353, 3);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(131, 160);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 52;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(174, 3);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(131, 160);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 51;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(-5, 3);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(131, 160);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(345, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(166, 7);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 160);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 576);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1092, 660);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ChucVu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LiDo_Khac);
            this.Controls.Add(this.TGianVao);
            this.Controls.Add(this.TGianRa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LiDo);
            this.Controls.Add(this.DonVi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ok_btn);
            this.Name = "InformationForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox DonVi;
        private System.Windows.Forms.ComboBox LiDo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TGianRa;
        private System.Windows.Forms.TextBox TGianVao;
        private System.Windows.Forms.RichTextBox LiDo_Khac;
        private System.Windows.Forms.ComboBox ChucVu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox Tongiao;
        private System.Windows.Forms.TextBox QueQuan;
        private System.Windows.Forms.TextBox DiaChi;
        private System.Windows.Forms.TextBox QTich;
        private System.Windows.Forms.TextBox GTinh;
        private System.Windows.Forms.TextBox NgSinh;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CCCD;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox CMND;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox HetHan;
        private System.Windows.Forms.TextBox TenVC;
        private System.Windows.Forms.TextBox TenMe;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TenCha;
        private System.Windows.Forms.TextBox NgayCap;
    }
}