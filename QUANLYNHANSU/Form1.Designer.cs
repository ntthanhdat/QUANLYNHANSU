
namespace QUANLYNHANSU
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgNV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbChucVuNV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rbNU = new System.Windows.Forms.RadioButton();
            this.rbNAM = new System.Windows.Forms.RadioButton();
            this.dtDate_o_NV = new System.Windows.Forms.DateTimePicker();
            this.btDeleteNV = new System.Windows.Forms.Button();
            this.btEditNV = new System.Windows.Forms.Button();
            this.btAddNV = new System.Windows.Forms.Button();
            this.tbQQNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNameNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgNC = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nctbHeSoLuong = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nctbTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.sdtgNV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sbGT = new System.Windows.Forms.ComboBox();
            this.sbTuoi = new System.Windows.Forms.TextBox();
            this.sbCV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.sbQQ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sbTen = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbncGioLaoDong = new System.Windows.Forms.NumericUpDown();
            this.nctbThuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nctbHeSoPC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbLuongTong = new System.Windows.Forms.Label();
            this.nctbMaNV = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNC)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdtgNV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbncGioLaoDong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.ReLoad);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dtgNV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtgNV
            // 
            this.dtgNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgNV.Location = new System.Drawing.Point(3, 212);
            this.dtgNV.Name = "dtgNV";
            this.dtgNV.Size = new System.Drawing.Size(780, 203);
            this.dtgNV.TabIndex = 0;
            this.dtgNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNV_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbChucVuNV);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.rbNU);
            this.panel1.Controls.Add(this.rbNAM);
            this.panel1.Controls.Add(this.dtDate_o_NV);
            this.panel1.Controls.Add(this.btDeleteNV);
            this.panel1.Controls.Add(this.btEditNV);
            this.panel1.Controls.Add(this.btAddNV);
            this.panel1.Controls.Add(this.tbQQNV);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbNameNV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 203);
            this.panel1.TabIndex = 1;
            // 
            // tbChucVuNV
            // 
            this.tbChucVuNV.Location = new System.Drawing.Point(113, 149);
            this.tbChucVuNV.Name = "tbChucVuNV";
            this.tbChucVuNV.Size = new System.Drawing.Size(148, 20);
            this.tbChucVuNV.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(62, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Chức vụ";
            // 
            // rbNU
            // 
            this.rbNU.AutoSize = true;
            this.rbNU.Location = new System.Drawing.Point(201, 87);
            this.rbNU.Name = "rbNU";
            this.rbNU.Size = new System.Drawing.Size(39, 17);
            this.rbNU.TabIndex = 4;
            this.rbNU.TabStop = true;
            this.rbNU.Text = "Nữ";
            this.rbNU.UseVisualStyleBackColor = true;
            // 
            // rbNAM
            // 
            this.rbNAM.AutoSize = true;
            this.rbNAM.Location = new System.Drawing.Point(112, 88);
            this.rbNAM.Name = "rbNAM";
            this.rbNAM.Size = new System.Drawing.Size(47, 17);
            this.rbNAM.TabIndex = 4;
            this.rbNAM.TabStop = true;
            this.rbNAM.Text = "Nam";
            this.rbNAM.UseVisualStyleBackColor = true;
            // 
            // dtDate_o_NV
            // 
            this.dtDate_o_NV.CustomFormat = "dd/MM/yyyy";
            this.dtDate_o_NV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate_o_NV.Location = new System.Drawing.Point(114, 51);
            this.dtDate_o_NV.Name = "dtDate_o_NV";
            this.dtDate_o_NV.Size = new System.Drawing.Size(148, 20);
            this.dtDate_o_NV.TabIndex = 3;
            // 
            // btDeleteNV
            // 
            this.btDeleteNV.Location = new System.Drawing.Point(606, 152);
            this.btDeleteNV.Name = "btDeleteNV";
            this.btDeleteNV.Size = new System.Drawing.Size(75, 33);
            this.btDeleteNV.TabIndex = 2;
            this.btDeleteNV.Text = "Xóa";
            this.btDeleteNV.UseVisualStyleBackColor = true;
            this.btDeleteNV.Click += new System.EventHandler(this.btDeleteNV_Click);
            // 
            // btEditNV
            // 
            this.btEditNV.Location = new System.Drawing.Point(606, 112);
            this.btEditNV.Name = "btEditNV";
            this.btEditNV.Size = new System.Drawing.Size(75, 33);
            this.btEditNV.TabIndex = 2;
            this.btEditNV.Text = "Sửa";
            this.btEditNV.UseVisualStyleBackColor = true;
            this.btEditNV.Click += new System.EventHandler(this.btEditNV_Click);
            // 
            // btAddNV
            // 
            this.btAddNV.Location = new System.Drawing.Point(606, 73);
            this.btAddNV.Name = "btAddNV";
            this.btAddNV.Size = new System.Drawing.Size(75, 33);
            this.btAddNV.TabIndex = 2;
            this.btAddNV.Text = "Thêm";
            this.btAddNV.UseVisualStyleBackColor = true;
            this.btAddNV.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbQQNV
            // 
            this.tbQQNV.Location = new System.Drawing.Point(113, 119);
            this.tbQQNV.Name = "tbQQNV";
            this.tbQQNV.Size = new System.Drawing.Size(148, 20);
            this.tbQQNV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quê Quán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới Tính";
            // 
            // tbNameNV
            // 
            this.tbNameNV.Location = new System.Drawing.Point(113, 17);
            this.tbNameNV.Name = "tbNameNV";
            this.tbNameNV.Size = new System.Drawing.Size(148, 20);
            this.tbNameNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cập nhật ngày công";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dtgNC, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dtgNC
            // 
            this.dtgNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgNC.Location = new System.Drawing.Point(3, 212);
            this.dtgNC.Name = "dtgNC";
            this.dtgNC.Size = new System.Drawing.Size(780, 203);
            this.dtgNC.TabIndex = 0;
            this.dtgNC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNC_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nctbMaNV);
            this.panel2.Controls.Add(this.lbLuongTong);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.nctbHeSoPC);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.nctbThuong);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbncGioLaoDong);
            this.panel2.Controls.Add(this.nctbHeSoLuong);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.nctbTen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 203);
            this.panel2.TabIndex = 1;
            // 
            // nctbHeSoLuong
            // 
            this.nctbHeSoLuong.Location = new System.Drawing.Point(345, 68);
            this.nctbHeSoLuong.Name = "nctbHeSoLuong";
            this.nctbHeSoLuong.Size = new System.Drawing.Size(123, 20);
            this.nctbHeSoLuong.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(269, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Hệ Số Lương";
            // 
            // nctbTen
            // 
            this.nctbTen.Location = new System.Drawing.Point(320, 25);
            this.nctbTen.Name = "nctbTen";
            this.nctbTen.Size = new System.Drawing.Size(148, 20);
            this.nctbTen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Họ Tên";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(566, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Sửa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Edit_NgayCong_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giờ Lao Động";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã NV";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tìm Kiếm";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.sdtgNV, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // sdtgNV
            // 
            this.sdtgNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sdtgNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdtgNV.Location = new System.Drawing.Point(3, 212);
            this.sdtgNV.Name = "sdtgNV";
            this.sdtgNV.Size = new System.Drawing.Size(780, 203);
            this.sdtgNV.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sbGT);
            this.panel3.Controls.Add(this.sbTuoi);
            this.panel3.Controls.Add(this.sbCV);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.sbQQ);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.sbTen);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 203);
            this.panel3.TabIndex = 1;
            // 
            // sbGT
            // 
            this.sbGT.FormattingEnabled = true;
            this.sbGT.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ"});
            this.sbGT.Location = new System.Drawing.Point(117, 106);
            this.sbGT.Name = "sbGT";
            this.sbGT.Size = new System.Drawing.Size(121, 21);
            this.sbGT.TabIndex = 18;
            // 
            // sbTuoi
            // 
            this.sbTuoi.Location = new System.Drawing.Point(117, 68);
            this.sbTuoi.Name = "sbTuoi";
            this.sbTuoi.Size = new System.Drawing.Size(148, 20);
            this.sbTuoi.TabIndex = 17;
            // 
            // sbCV
            // 
            this.sbCV.Location = new System.Drawing.Point(117, 168);
            this.sbCV.Name = "sbCV";
            this.sbCV.Size = new System.Drawing.Size(148, 20);
            this.sbCV.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Chức vụ";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(522, 55);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 33);
            this.button7.TabIndex = 14;
            this.button7.Text = "Tìm kiếm";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // sbQQ
            // 
            this.sbQQ.Location = new System.Drawing.Point(117, 140);
            this.sbQQ.Name = "sbQQ";
            this.sbQQ.Size = new System.Drawing.Size(148, 20);
            this.sbQQ.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tuổi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Quê Quán";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Giới Tính";
            // 
            // sbTen
            // 
            this.sbTen.Location = new System.Drawing.Point(117, 35);
            this.sbTen.Name = "sbTen";
            this.sbTen.Size = new System.Drawing.Size(148, 20);
            this.sbTen.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Họ Tên";
            // 
            // tbncGioLaoDong
            // 
            this.tbncGioLaoDong.Location = new System.Drawing.Point(117, 70);
            this.tbncGioLaoDong.Name = "tbncGioLaoDong";
            this.tbncGioLaoDong.Size = new System.Drawing.Size(120, 20);
            this.tbncGioLaoDong.TabIndex = 10;
            // 
            // nctbThuong
            // 
            this.nctbThuong.Location = new System.Drawing.Point(345, 107);
            this.nctbThuong.Name = "nctbThuong";
            this.nctbThuong.Size = new System.Drawing.Size(123, 20);
            this.nctbThuong.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Thưởng";
            // 
            // nctbHeSoPC
            // 
            this.nctbHeSoPC.Location = new System.Drawing.Point(118, 109);
            this.nctbHeSoPC.Name = "nctbHeSoPC";
            this.nctbHeSoPC.Size = new System.Drawing.Size(123, 20);
            this.nctbHeSoPC.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Hệ Số PC";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(42, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 29);
            this.label17.TabIndex = 15;
            this.label17.Text = "Lương:";
            // 
            // lbLuongTong
            // 
            this.lbLuongTong.AutoSize = true;
            this.lbLuongTong.Font = new System.Drawing.Font("Yu Gothic Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuongTong.Location = new System.Drawing.Point(164, 167);
            this.lbLuongTong.Name = "lbLuongTong";
            this.lbLuongTong.Size = new System.Drawing.Size(15, 17);
            this.lbLuongTong.TabIndex = 16;
            this.lbLuongTong.Text = "đ";
            // 
            // nctbMaNV
            // 
            this.nctbMaNV.Enabled = false;
            this.nctbMaNV.Location = new System.Drawing.Point(118, 25);
            this.nctbMaNV.Name = "nctbMaNV";
            this.nctbMaNV.Size = new System.Drawing.Size(123, 20);
            this.nctbMaNV.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sdtgNV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbncGioLaoDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNU;
        private System.Windows.Forms.RadioButton rbNAM;
        private System.Windows.Forms.DateTimePicker dtDate_o_NV;
        private System.Windows.Forms.Button btDeleteNV;
        private System.Windows.Forms.Button btEditNV;
        private System.Windows.Forms.Button btAddNV;
        private System.Windows.Forms.TextBox tbQQNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNameNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dtgNC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView sdtgNV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox sbQQ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox sbTen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbChucVuNV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox sbTuoi;
        private System.Windows.Forms.TextBox sbCV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox sbGT;
        private System.Windows.Forms.TextBox nctbHeSoLuong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nctbTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nctbHeSoPC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nctbThuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown tbncGioLaoDong;
        private System.Windows.Forms.Label lbLuongTong;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox nctbMaNV;
    }
}

