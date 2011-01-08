namespace GUI
{
    partial class QuanLyGUI
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.tpgThachDau = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.cmbNguoiQuanLy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lsvThachDau = new System.Windows.Forms.ListView();
            this.STT5 = new System.Windows.Forms.ColumnHeader();
            this.ThoiGian = new System.Windows.Forms.ColumnHeader();
            this.DiaDiem = new System.Windows.Forms.ColumnHeader();
            this.NguoiQuanLy = new System.Windows.Forms.ColumnHeader();
            this.btnXoaThachDau = new System.Windows.Forms.Button();
            this.btnSuaThachDau = new System.Windows.Forms.Button();
            this.btnThemThachDau = new System.Windows.Forms.Button();
            this.chkChonTatCaThachDau = new System.Windows.Forms.CheckBox();
            this.tpgThangDiem = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvDanhSachDiem = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenDiem = new System.Windows.Forms.ColumnHeader();
            this.CongThucTinh = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCongThucTinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaDiem = new System.Windows.Forms.Button();
            this.btnSuaDiem = new System.Windows.Forms.Button();
            this.btnThemDiem = new System.Windows.Forms.Button();
            this.chkChonTatCaDiem = new System.Windows.Forms.CheckBox();
            this.tpgCapBac = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lsvDanhSachCapBac = new System.Windows.Forms.ListView();
            this.STT4 = new System.Windows.Forms.ColumnHeader();
            this.ChiSoCapBac = new System.Windows.Forms.ColumnHeader();
            this.TenCapBac = new System.Windows.Forms.ColumnHeader();
            this.NguongVuotTroi = new System.Windows.Forms.ColumnHeader();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtNguongVuotTroi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenCapBac = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChiSoCapBac = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnXoaCapBac = new System.Windows.Forms.Button();
            this.btnSuaCapBac = new System.Windows.Forms.Button();
            this.btnThemCapBac = new System.Windows.Forms.Button();
            this.chkChonTatCaCapBac = new System.Windows.Forms.CheckBox();
            this.tpgHoiVien = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsvDanhSachHoiVien = new System.Windows.Forms.ListView();
            this.STT2 = new System.Windows.Forms.ColumnHeader();
            this.MSSV = new System.Windows.Forms.ColumnHeader();
            this.TenHoiVien = new System.Windows.Forms.ColumnHeader();
            this.CapBac = new System.Windows.Forms.ColumnHeader();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbCapBac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenHoiVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoaHoiVien = new System.Windows.Forms.Button();
            this.btnSuaHoiVien = new System.Windows.Forms.Button();
            this.btnThemHoiVien = new System.Windows.Forms.Button();
            this.chkChonTatCaHoiVien = new System.Windows.Forms.CheckBox();
            this.Tab1 = new System.Windows.Forms.TabControl();
            this.tpgThachDau.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tpgThangDiem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpgCapBac.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tpgHoiVien.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(562, 448);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(96, 29);
            this.btn_Thoat.TabIndex = 40;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // tpgThachDau
            // 
            this.tpgThachDau.Controls.Add(this.groupBox6);
            this.tpgThachDau.Controls.Add(this.groupBox5);
            this.tpgThachDau.Controls.Add(this.btnXoaThachDau);
            this.tpgThachDau.Controls.Add(this.btnSuaThachDau);
            this.tpgThachDau.Controls.Add(this.btnThemThachDau);
            this.tpgThachDau.Controls.Add(this.chkChonTatCaThachDau);
            this.tpgThachDau.Location = new System.Drawing.Point(4, 25);
            this.tpgThachDau.Name = "tpgThachDau";
            this.tpgThachDau.Padding = new System.Windows.Forms.Padding(3);
            this.tpgThachDau.Size = new System.Drawing.Size(664, 417);
            this.tpgThachDau.TabIndex = 5;
            this.tpgThachDau.Text = "Thách Đấu";
            this.tpgThachDau.UseVisualStyleBackColor = true;
            this.tpgThachDau.Enter += new System.EventHandler(this.tpgThachDau_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtDiaDiem);
            this.groupBox6.Controls.Add(this.dtpThoiGian);
            this.groupBox6.Controls.Add(this.cmbNguoiQuanLy);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(495, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(159, 346);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chi Tiết Thách Đấu";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(10, 144);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(140, 22);
            this.txtDiaDiem.TabIndex = 12;
            this.txtDiaDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaDiem_KeyPress);
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(10, 69);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(140, 22);
            this.dtpThoiGian.TabIndex = 11;
            this.dtpThoiGian.Value = new System.DateTime(2010, 10, 5, 0, 0, 0, 0);
            // 
            // cmbNguoiQuanLy
            // 
            this.cmbNguoiQuanLy.FormattingEnabled = true;
            this.cmbNguoiQuanLy.Location = new System.Drawing.Point(10, 214);
            this.cmbNguoiQuanLy.Name = "cmbNguoiQuanLy";
            this.cmbNguoiQuanLy.Size = new System.Drawing.Size(140, 24);
            this.cmbNguoiQuanLy.TabIndex = 13;
            this.cmbNguoiQuanLy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNguoiQuanLy_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Người quản lý";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa điểm thách đấu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày thách đấu";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lsvThachDau);
            this.groupBox5.Location = new System.Drawing.Point(9, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(479, 350);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách Thách Đấu";
            // 
            // lsvThachDau
            // 
            this.lsvThachDau.CheckBoxes = true;
            this.lsvThachDau.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT5,
            this.ThoiGian,
            this.DiaDiem,
            this.NguoiQuanLy});
            this.lsvThachDau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvThachDau.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvThachDau.FullRowSelect = true;
            this.lsvThachDau.GridLines = true;
            this.lsvThachDau.Location = new System.Drawing.Point(3, 18);
            this.lsvThachDau.Name = "lsvThachDau";
            this.lsvThachDau.Size = new System.Drawing.Size(473, 329);
            this.lsvThachDau.TabIndex = 9;
            this.lsvThachDau.UseCompatibleStateImageBehavior = false;
            this.lsvThachDau.View = System.Windows.Forms.View.Details;
            this.lsvThachDau.SelectedIndexChanged += new System.EventHandler(this.lsvThachDau_SelectedIndexChanged);
            // 
            // STT5
            // 
            this.STT5.Text = "STT";
            // 
            // ThoiGian
            // 
            this.ThoiGian.Text = "Ngày Thách Đấu";
            this.ThoiGian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThoiGian.Width = 140;
            // 
            // DiaDiem
            // 
            this.DiaDiem.Text = "Địa Điểm";
            this.DiaDiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiaDiem.Width = 100;
            // 
            // NguoiQuanLy
            // 
            this.NguoiQuanLy.Text = "Người Quản Lý";
            this.NguoiQuanLy.Width = 160;
            // 
            // btnXoaThachDau
            // 
            this.btnXoaThachDau.Location = new System.Drawing.Point(456, 370);
            this.btnXoaThachDau.Name = "btnXoaThachDau";
            this.btnXoaThachDau.Size = new System.Drawing.Size(96, 29);
            this.btnXoaThachDau.TabIndex = 23;
            this.btnXoaThachDau.Text = "Xóa";
            this.btnXoaThachDau.UseVisualStyleBackColor = true;
            this.btnXoaThachDau.Click += new System.EventHandler(this.btnXoaThachDau_Click);
            // 
            // btnSuaThachDau
            // 
            this.btnSuaThachDau.Location = new System.Drawing.Point(559, 370);
            this.btnSuaThachDau.Name = "btnSuaThachDau";
            this.btnSuaThachDau.Size = new System.Drawing.Size(96, 29);
            this.btnSuaThachDau.TabIndex = 24;
            this.btnSuaThachDau.Text = "Sửa";
            this.btnSuaThachDau.UseVisualStyleBackColor = true;
            this.btnSuaThachDau.Click += new System.EventHandler(this.btnSuaThachDau_Click);
            // 
            // btnThemThachDau
            // 
            this.btnThemThachDau.Location = new System.Drawing.Point(353, 370);
            this.btnThemThachDau.Name = "btnThemThachDau";
            this.btnThemThachDau.Size = new System.Drawing.Size(96, 29);
            this.btnThemThachDau.TabIndex = 22;
            this.btnThemThachDau.Text = "Thêm";
            this.btnThemThachDau.UseVisualStyleBackColor = true;
            this.btnThemThachDau.Click += new System.EventHandler(this.btnThemThachDau_Click);
            // 
            // chkChonTatCaThachDau
            // 
            this.chkChonTatCaThachDau.AutoSize = true;
            this.chkChonTatCaThachDau.Location = new System.Drawing.Point(17, 379);
            this.chkChonTatCaThachDau.Name = "chkChonTatCaThachDau";
            this.chkChonTatCaThachDau.Size = new System.Drawing.Size(94, 20);
            this.chkChonTatCaThachDau.TabIndex = 21;
            this.chkChonTatCaThachDau.Text = "Chọn tất cả";
            this.chkChonTatCaThachDau.UseVisualStyleBackColor = true;
            this.chkChonTatCaThachDau.CheckedChanged += new System.EventHandler(this.chkChonTatCaThachDau_CheckedChanged);
            // 
            // tpgThangDiem
            // 
            this.tpgThangDiem.Controls.Add(this.groupBox1);
            this.tpgThangDiem.Controls.Add(this.groupBox2);
            this.tpgThangDiem.Controls.Add(this.btnXoaDiem);
            this.tpgThangDiem.Controls.Add(this.btnSuaDiem);
            this.tpgThangDiem.Controls.Add(this.btnThemDiem);
            this.tpgThangDiem.Controls.Add(this.chkChonTatCaDiem);
            this.tpgThangDiem.Location = new System.Drawing.Point(4, 25);
            this.tpgThangDiem.Name = "tpgThangDiem";
            this.tpgThangDiem.Padding = new System.Windows.Forms.Padding(3);
            this.tpgThangDiem.Size = new System.Drawing.Size(664, 417);
            this.tpgThangDiem.TabIndex = 4;
            this.tpgThangDiem.Text = "Thang Điểm";
            this.tpgThangDiem.UseVisualStyleBackColor = true;
            this.tpgThangDiem.Enter += new System.EventHandler(this.tpgThangDiem_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvDanhSachDiem);
            this.groupBox1.Location = new System.Drawing.Point(7, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 350);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Thang Điểm";
            // 
            // lsvDanhSachDiem
            // 
            this.lsvDanhSachDiem.CheckBoxes = true;
            this.lsvDanhSachDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenDiem,
            this.CongThucTinh});
            this.lsvDanhSachDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhSachDiem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDanhSachDiem.FullRowSelect = true;
            this.lsvDanhSachDiem.GridLines = true;
            this.lsvDanhSachDiem.Location = new System.Drawing.Point(3, 18);
            this.lsvDanhSachDiem.Name = "lsvDanhSachDiem";
            this.lsvDanhSachDiem.Size = new System.Drawing.Size(475, 329);
            this.lsvDanhSachDiem.TabIndex = 9;
            this.lsvDanhSachDiem.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachDiem.View = System.Windows.Forms.View.Details;
            this.lsvDanhSachDiem.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSachDiem_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // TenDiem
            // 
            this.TenDiem.Text = "Tên Điểm";
            this.TenDiem.Width = 150;
            // 
            // CongThucTinh
            // 
            this.CongThucTinh.Text = "Công Thức Tính";
            this.CongThucTinh.Width = 255;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCongThucTinh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTenDiem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(495, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 346);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Thang Điểm";
            // 
            // txtCongThucTinh
            // 
            this.txtCongThucTinh.Location = new System.Drawing.Point(7, 135);
            this.txtCongThucTinh.Multiline = true;
            this.txtCongThucTinh.Name = "txtCongThucTinh";
            this.txtCongThucTinh.Size = new System.Drawing.Size(144, 202);
            this.txtCongThucTinh.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Công thức tính";
            // 
            // txtTenDiem
            // 
            this.txtTenDiem.Location = new System.Drawing.Point(7, 73);
            this.txtTenDiem.Name = "txtTenDiem";
            this.txtTenDiem.Size = new System.Drawing.Size(144, 22);
            this.txtTenDiem.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên điểm";
            // 
            // btnXoaDiem
            // 
            this.btnXoaDiem.Location = new System.Drawing.Point(455, 370);
            this.btnXoaDiem.Name = "btnXoaDiem";
            this.btnXoaDiem.Size = new System.Drawing.Size(96, 29);
            this.btnXoaDiem.TabIndex = 22;
            this.btnXoaDiem.Text = "Xóa";
            this.btnXoaDiem.UseVisualStyleBackColor = true;
            this.btnXoaDiem.Click += new System.EventHandler(this.btnXoaDiem_Click);
            // 
            // btnSuaDiem
            // 
            this.btnSuaDiem.Location = new System.Drawing.Point(558, 370);
            this.btnSuaDiem.Name = "btnSuaDiem";
            this.btnSuaDiem.Size = new System.Drawing.Size(96, 29);
            this.btnSuaDiem.TabIndex = 23;
            this.btnSuaDiem.Text = "Sửa";
            this.btnSuaDiem.UseVisualStyleBackColor = true;
            this.btnSuaDiem.Click += new System.EventHandler(this.btnSuaDiem_Click);
            // 
            // btnThemDiem
            // 
            this.btnThemDiem.Location = new System.Drawing.Point(352, 370);
            this.btnThemDiem.Name = "btnThemDiem";
            this.btnThemDiem.Size = new System.Drawing.Size(96, 29);
            this.btnThemDiem.TabIndex = 21;
            this.btnThemDiem.Text = "Thêm";
            this.btnThemDiem.UseVisualStyleBackColor = true;
            this.btnThemDiem.Click += new System.EventHandler(this.btnThemDiem_Click);
            // 
            // chkChonTatCaDiem
            // 
            this.chkChonTatCaDiem.AutoSize = true;
            this.chkChonTatCaDiem.Location = new System.Drawing.Point(15, 379);
            this.chkChonTatCaDiem.Name = "chkChonTatCaDiem";
            this.chkChonTatCaDiem.Size = new System.Drawing.Size(94, 20);
            this.chkChonTatCaDiem.TabIndex = 24;
            this.chkChonTatCaDiem.Text = "Chọn tất cả";
            this.chkChonTatCaDiem.UseVisualStyleBackColor = true;
            this.chkChonTatCaDiem.CheckedChanged += new System.EventHandler(this.chkChonTatCaDiem_CheckedChanged);
            // 
            // tpgCapBac
            // 
            this.tpgCapBac.Controls.Add(this.groupBox7);
            this.tpgCapBac.Controls.Add(this.groupBox8);
            this.tpgCapBac.Controls.Add(this.btnXoaCapBac);
            this.tpgCapBac.Controls.Add(this.btnSuaCapBac);
            this.tpgCapBac.Controls.Add(this.btnThemCapBac);
            this.tpgCapBac.Controls.Add(this.chkChonTatCaCapBac);
            this.tpgCapBac.Location = new System.Drawing.Point(4, 25);
            this.tpgCapBac.Name = "tpgCapBac";
            this.tpgCapBac.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCapBac.Size = new System.Drawing.Size(664, 417);
            this.tpgCapBac.TabIndex = 3;
            this.tpgCapBac.Text = "Cấp Bậc";
            this.tpgCapBac.UseVisualStyleBackColor = true;
            this.tpgCapBac.Enter += new System.EventHandler(this.tpgCapBac_Enter);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lsvDanhSachCapBac);
            this.groupBox7.Location = new System.Drawing.Point(8, 14);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(479, 350);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Danh Sách Cấp Bậc";
            // 
            // lsvDanhSachCapBac
            // 
            this.lsvDanhSachCapBac.CheckBoxes = true;
            this.lsvDanhSachCapBac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT4,
            this.ChiSoCapBac,
            this.TenCapBac,
            this.NguongVuotTroi});
            this.lsvDanhSachCapBac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhSachCapBac.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDanhSachCapBac.FullRowSelect = true;
            this.lsvDanhSachCapBac.GridLines = true;
            this.lsvDanhSachCapBac.Location = new System.Drawing.Point(3, 18);
            this.lsvDanhSachCapBac.Name = "lsvDanhSachCapBac";
            this.lsvDanhSachCapBac.Size = new System.Drawing.Size(473, 329);
            this.lsvDanhSachCapBac.TabIndex = 9;
            this.lsvDanhSachCapBac.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachCapBac.View = System.Windows.Forms.View.Details;
            this.lsvDanhSachCapBac.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSachCapBac_SelectedIndexChanged);
            // 
            // STT4
            // 
            this.STT4.Text = "STT";
            // 
            // ChiSoCapBac
            // 
            this.ChiSoCapBac.Text = "Chỉ Số";
            this.ChiSoCapBac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChiSoCapBac.Width = 80;
            // 
            // TenCapBac
            // 
            this.TenCapBac.Text = "Tên Cấp Bậc";
            this.TenCapBac.Width = 180;
            // 
            // NguongVuotTroi
            // 
            this.NguongVuotTroi.Text = "Ngưỡng Vượt Trội";
            this.NguongVuotTroi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NguongVuotTroi.Width = 140;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtNguongVuotTroi);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.txtTenCapBac);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.txtChiSoCapBac);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Location = new System.Drawing.Point(495, 17);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(159, 346);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Chi Tiết Cấp Bậc";
            // 
            // txtNguongVuotTroi
            // 
            this.txtNguongVuotTroi.Location = new System.Drawing.Point(7, 208);
            this.txtNguongVuotTroi.Name = "txtNguongVuotTroi";
            this.txtNguongVuotTroi.Size = new System.Drawing.Size(144, 22);
            this.txtNguongVuotTroi.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngưỡng vượt trội";
            // 
            // txtTenCapBac
            // 
            this.txtTenCapBac.Location = new System.Drawing.Point(7, 134);
            this.txtTenCapBac.Name = "txtTenCapBac";
            this.txtTenCapBac.Size = new System.Drawing.Size(144, 22);
            this.txtTenCapBac.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên cấp bậc";
            // 
            // txtChiSoCapBac
            // 
            this.txtChiSoCapBac.Location = new System.Drawing.Point(7, 69);
            this.txtChiSoCapBac.Name = "txtChiSoCapBac";
            this.txtChiSoCapBac.Size = new System.Drawing.Size(144, 22);
            this.txtChiSoCapBac.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Chỉ số cấp bậc";
            // 
            // btnXoaCapBac
            // 
            this.btnXoaCapBac.Location = new System.Drawing.Point(455, 374);
            this.btnXoaCapBac.Name = "btnXoaCapBac";
            this.btnXoaCapBac.Size = new System.Drawing.Size(96, 29);
            this.btnXoaCapBac.TabIndex = 22;
            this.btnXoaCapBac.Text = "Xóa";
            this.btnXoaCapBac.UseVisualStyleBackColor = true;
            this.btnXoaCapBac.Click += new System.EventHandler(this.btnXoaCapBac_Click);
            // 
            // btnSuaCapBac
            // 
            this.btnSuaCapBac.Location = new System.Drawing.Point(558, 374);
            this.btnSuaCapBac.Name = "btnSuaCapBac";
            this.btnSuaCapBac.Size = new System.Drawing.Size(96, 29);
            this.btnSuaCapBac.TabIndex = 23;
            this.btnSuaCapBac.Text = "Sửa";
            this.btnSuaCapBac.UseVisualStyleBackColor = true;
            this.btnSuaCapBac.Click += new System.EventHandler(this.btnSuaCapBac_Click);
            // 
            // btnThemCapBac
            // 
            this.btnThemCapBac.Location = new System.Drawing.Point(352, 374);
            this.btnThemCapBac.Name = "btnThemCapBac";
            this.btnThemCapBac.Size = new System.Drawing.Size(96, 29);
            this.btnThemCapBac.TabIndex = 21;
            this.btnThemCapBac.Text = "Thêm";
            this.btnThemCapBac.UseVisualStyleBackColor = true;
            this.btnThemCapBac.Click += new System.EventHandler(this.btnThemCapBac_Click);
            // 
            // chkChonTatCaCapBac
            // 
            this.chkChonTatCaCapBac.AutoSize = true;
            this.chkChonTatCaCapBac.Location = new System.Drawing.Point(16, 379);
            this.chkChonTatCaCapBac.Name = "chkChonTatCaCapBac";
            this.chkChonTatCaCapBac.Size = new System.Drawing.Size(94, 20);
            this.chkChonTatCaCapBac.TabIndex = 24;
            this.chkChonTatCaCapBac.Text = "Chọn tất cả";
            this.chkChonTatCaCapBac.UseVisualStyleBackColor = true;
            this.chkChonTatCaCapBac.CheckedChanged += new System.EventHandler(this.chkChonTatCaCapBac_CheckedChanged);
            // 
            // tpgHoiVien
            // 
            this.tpgHoiVien.Controls.Add(this.groupBox3);
            this.tpgHoiVien.Controls.Add(this.groupBox4);
            this.tpgHoiVien.Controls.Add(this.btnXoaHoiVien);
            this.tpgHoiVien.Controls.Add(this.btnSuaHoiVien);
            this.tpgHoiVien.Controls.Add(this.btnThemHoiVien);
            this.tpgHoiVien.Controls.Add(this.chkChonTatCaHoiVien);
            this.tpgHoiVien.Location = new System.Drawing.Point(4, 25);
            this.tpgHoiVien.Name = "tpgHoiVien";
            this.tpgHoiVien.Padding = new System.Windows.Forms.Padding(3);
            this.tpgHoiVien.Size = new System.Drawing.Size(664, 417);
            this.tpgHoiVien.TabIndex = 1;
            this.tpgHoiVien.Text = "Hội Viên";
            this.tpgHoiVien.UseVisualStyleBackColor = true;
            this.tpgHoiVien.Enter += new System.EventHandler(this.tpgHoiVien_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsvDanhSachHoiVien);
            this.groupBox3.Location = new System.Drawing.Point(8, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 350);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Hội Viên";
            // 
            // lsvDanhSachHoiVien
            // 
            this.lsvDanhSachHoiVien.CheckBoxes = true;
            this.lsvDanhSachHoiVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT2,
            this.MSSV,
            this.TenHoiVien,
            this.CapBac});
            this.lsvDanhSachHoiVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhSachHoiVien.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDanhSachHoiVien.FullRowSelect = true;
            this.lsvDanhSachHoiVien.GridLines = true;
            this.lsvDanhSachHoiVien.Location = new System.Drawing.Point(3, 18);
            this.lsvDanhSachHoiVien.Name = "lsvDanhSachHoiVien";
            this.lsvDanhSachHoiVien.Size = new System.Drawing.Size(473, 329);
            this.lsvDanhSachHoiVien.TabIndex = 9;
            this.lsvDanhSachHoiVien.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachHoiVien.View = System.Windows.Forms.View.Details;
            this.lsvDanhSachHoiVien.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSachHoiVien_SelectedIndexChanged);
            // 
            // STT2
            // 
            this.STT2.Text = "STT";
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            this.MSSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MSSV.Width = 80;
            // 
            // TenHoiVien
            // 
            this.TenHoiVien.Text = "Tên Hội Viên";
            this.TenHoiVien.Width = 200;
            // 
            // CapBac
            // 
            this.CapBac.Text = "Cấp Bậc";
            this.CapBac.Width = 120;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbCapBac);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtTenHoiVien);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtMSSV);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(495, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(159, 346);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi Tiết Hội Viên";
            // 
            // cmbCapBac
            // 
            this.cmbCapBac.FormattingEnabled = true;
            this.cmbCapBac.Location = new System.Drawing.Point(7, 203);
            this.cmbCapBac.Name = "cmbCapBac";
            this.cmbCapBac.Size = new System.Drawing.Size(144, 24);
            this.cmbCapBac.TabIndex = 13;
            this.cmbCapBac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCapBac_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cấp bậc";
            // 
            // txtTenHoiVien
            // 
            this.txtTenHoiVien.Location = new System.Drawing.Point(7, 134);
            this.txtTenHoiVien.Name = "txtTenHoiVien";
            this.txtTenHoiVien.Size = new System.Drawing.Size(144, 22);
            this.txtTenHoiVien.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên hội viên";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(7, 69);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(144, 22);
            this.txtMSSV.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "MSSV";
            // 
            // btnXoaHoiVien
            // 
            this.btnXoaHoiVien.Location = new System.Drawing.Point(455, 370);
            this.btnXoaHoiVien.Name = "btnXoaHoiVien";
            this.btnXoaHoiVien.Size = new System.Drawing.Size(96, 29);
            this.btnXoaHoiVien.TabIndex = 22;
            this.btnXoaHoiVien.Text = "Xóa";
            this.btnXoaHoiVien.UseVisualStyleBackColor = true;
            this.btnXoaHoiVien.Click += new System.EventHandler(this.btnXoaHoiVien_Click);
            // 
            // btnSuaHoiVien
            // 
            this.btnSuaHoiVien.Location = new System.Drawing.Point(558, 370);
            this.btnSuaHoiVien.Name = "btnSuaHoiVien";
            this.btnSuaHoiVien.Size = new System.Drawing.Size(96, 29);
            this.btnSuaHoiVien.TabIndex = 23;
            this.btnSuaHoiVien.Text = "Sửa";
            this.btnSuaHoiVien.UseVisualStyleBackColor = true;
            this.btnSuaHoiVien.Click += new System.EventHandler(this.btnSuaHoiVien_Click);
            // 
            // btnThemHoiVien
            // 
            this.btnThemHoiVien.Location = new System.Drawing.Point(352, 370);
            this.btnThemHoiVien.Name = "btnThemHoiVien";
            this.btnThemHoiVien.Size = new System.Drawing.Size(96, 29);
            this.btnThemHoiVien.TabIndex = 21;
            this.btnThemHoiVien.Text = "Thêm";
            this.btnThemHoiVien.UseVisualStyleBackColor = true;
            this.btnThemHoiVien.Click += new System.EventHandler(this.btnThemHoiVien_Click);
            // 
            // chkChonTatCaHoiVien
            // 
            this.chkChonTatCaHoiVien.AutoSize = true;
            this.chkChonTatCaHoiVien.Location = new System.Drawing.Point(16, 379);
            this.chkChonTatCaHoiVien.Name = "chkChonTatCaHoiVien";
            this.chkChonTatCaHoiVien.Size = new System.Drawing.Size(94, 20);
            this.chkChonTatCaHoiVien.TabIndex = 24;
            this.chkChonTatCaHoiVien.Text = "Chọn tất cả";
            this.chkChonTatCaHoiVien.UseVisualStyleBackColor = true;
            this.chkChonTatCaHoiVien.CheckedChanged += new System.EventHandler(this.chkChonTatCaHoiVien_CheckedChanged);
            // 
            // Tab1
            // 
            this.Tab1.Controls.Add(this.tpgHoiVien);
            this.Tab1.Controls.Add(this.tpgCapBac);
            this.Tab1.Controls.Add(this.tpgThangDiem);
            this.Tab1.Controls.Add(this.tpgThachDau);
            this.Tab1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tab1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1.Location = new System.Drawing.Point(0, 0);
            this.Tab1.Name = "Tab1";
            this.Tab1.SelectedIndex = 0;
            this.Tab1.Size = new System.Drawing.Size(672, 446);
            this.Tab1.TabIndex = 0;
            // 
            // QuanLyGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 485);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.Tab1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuanLyGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QuanLyGUI";           
            this.Activated += new System.EventHandler(this.QuanLyGUI_Activated);
            this.tpgThachDau.ResumeLayout(false);
            this.tpgThachDau.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tpgThangDiem.ResumeLayout(false);
            this.tpgThangDiem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpgCapBac.ResumeLayout(false);
            this.tpgCapBac.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tpgHoiVien.ResumeLayout(false);
            this.tpgHoiVien.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Tab1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TabPage tpgThachDau;
        private System.Windows.Forms.TabPage tpgThangDiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvDanhSachDiem;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenDiem;
        private System.Windows.Forms.ColumnHeader CongThucTinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCongThucTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoaDiem;
        private System.Windows.Forms.Button btnSuaDiem;
        private System.Windows.Forms.Button btnThemDiem;
        private System.Windows.Forms.CheckBox chkChonTatCaDiem;
        private System.Windows.Forms.TabPage tpgCapBac;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListView lsvDanhSachCapBac;
        private System.Windows.Forms.ColumnHeader STT4;
        private System.Windows.Forms.ColumnHeader ChiSoCapBac;
        private System.Windows.Forms.ColumnHeader TenCapBac;
        private System.Windows.Forms.ColumnHeader NguongVuotTroi;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtNguongVuotTroi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenCapBac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtChiSoCapBac;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnXoaCapBac;
        private System.Windows.Forms.Button btnSuaCapBac;
        private System.Windows.Forms.Button btnThemCapBac;
        private System.Windows.Forms.CheckBox chkChonTatCaCapBac;
        private System.Windows.Forms.TabPage tpgHoiVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lsvDanhSachHoiVien;
        private System.Windows.Forms.ColumnHeader STT2;
        public System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader TenHoiVien;
        private System.Windows.Forms.ColumnHeader CapBac;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbCapBac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenHoiVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoaHoiVien;
        private System.Windows.Forms.Button btnSuaHoiVien;
        private System.Windows.Forms.Button btnThemHoiVien;
        private System.Windows.Forms.CheckBox chkChonTatCaHoiVien;
        private System.Windows.Forms.TabControl Tab1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lsvThachDau;
        private System.Windows.Forms.ColumnHeader STT5;
        public System.Windows.Forms.ColumnHeader ThoiGian;
        private System.Windows.Forms.ColumnHeader DiaDiem;
        private System.Windows.Forms.ColumnHeader NguoiQuanLy;
        private System.Windows.Forms.Button btnXoaThachDau;
        private System.Windows.Forms.Button btnSuaThachDau;
        private System.Windows.Forms.Button btnThemThachDau;
        private System.Windows.Forms.CheckBox chkChonTatCaThachDau;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbNguoiQuanLy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.TextBox txtDiaDiem;
    }
}