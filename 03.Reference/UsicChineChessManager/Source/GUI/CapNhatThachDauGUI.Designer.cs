namespace GUI
{
    partial class CapNhatThachDauGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvDanhSachChiTietThachDau = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.MaHoiVien1 = new System.Windows.Forms.ColumnHeader();
            this.HoTenHoiVien1 = new System.Windows.Forms.ColumnHeader();
            this.MaHoiVien2 = new System.Windows.Forms.ColumnHeader();
            this.HoTenHoiVien2 = new System.Windows.Forms.ColumnHeader();
            this.KetQua = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbKetQua = new System.Windows.Forms.ComboBox();
            this.btnXoaChiTietThachDau = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbMaHoiVien2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenHoiVien2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbMaHoiVien1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHoiVien1 = new System.Windows.Forms.TextBox();
            this.btnSuaChiTietThachDau = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemChiTietThachDau = new System.Windows.Forms.Button();
            this.chkChonTatCa = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbNguoiQuanLy = new System.Windows.Forms.ComboBox();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.btnSuaThachDau = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThemThachDau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvDanhSachChiTietThachDau);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(252, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 554);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Thách Đấu";
            // 
            // lsvDanhSachChiTietThachDau
            // 
            this.lsvDanhSachChiTietThachDau.CheckBoxes = true;
            this.lsvDanhSachChiTietThachDau.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MaHoiVien1,
            this.HoTenHoiVien1,
            this.MaHoiVien2,
            this.HoTenHoiVien2,
            this.KetQua});
            this.lsvDanhSachChiTietThachDau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhSachChiTietThachDau.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDanhSachChiTietThachDau.FullRowSelect = true;
            this.lsvDanhSachChiTietThachDau.GridLines = true;
            this.lsvDanhSachChiTietThachDau.Location = new System.Drawing.Point(3, 20);
            this.lsvDanhSachChiTietThachDau.Name = "lsvDanhSachChiTietThachDau";
            this.lsvDanhSachChiTietThachDau.Size = new System.Drawing.Size(721, 531);
            this.lsvDanhSachChiTietThachDau.TabIndex = 19;
            this.lsvDanhSachChiTietThachDau.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachChiTietThachDau.View = System.Windows.Forms.View.Details;
            this.lsvDanhSachChiTietThachDau.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSachChiTietThachDau_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // MaHoiVien1
            // 
            this.MaHoiVien1.Text = "MSSV1";
            this.MaHoiVien1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaHoiVien1.Width = 90;
            // 
            // HoTenHoiVien1
            // 
            this.HoTenHoiVien1.Text = "Họ Tên Hội Viên 1";
            this.HoTenHoiVien1.Width = 200;
            // 
            // MaHoiVien2
            // 
            this.MaHoiVien2.Text = "MSSV2";
            this.MaHoiVien2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaHoiVien2.Width = 90;
            // 
            // HoTenHoiVien2
            // 
            this.HoTenHoiVien2.Text = "Họ Tên Hội Viên 2";
            this.HoTenHoiVien2.Width = 200;
            // 
            // KetQua
            // 
            this.KetQua.Text = "Kết Quả";
            this.KetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KetQua.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbKetQua);
            this.groupBox2.Controls.Add(this.btnXoaChiTietThachDau);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnSuaChiTietThachDau);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnThemChiTietThachDau);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 357);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Thách Đấu";
            // 
            // cmbKetQua
            // 
            this.cmbKetQua.FormattingEnabled = true;
            this.cmbKetQua.Items.AddRange(new object[] {
            "1 - 0",
            "0 - 1",
            "0 - 0"});
            this.cmbKetQua.Location = new System.Drawing.Point(92, 265);
            this.cmbKetQua.Name = "cmbKetQua";
            this.cmbKetQua.Size = new System.Drawing.Size(125, 24);
            this.cmbKetQua.TabIndex = 26;
            // 
            // btnXoaChiTietThachDau
            // 
            this.btnXoaChiTietThachDau.Location = new System.Drawing.Point(82, 312);
            this.btnXoaChiTietThachDau.Name = "btnXoaChiTietThachDau";
            this.btnXoaChiTietThachDau.Size = new System.Drawing.Size(70, 25);
            this.btnXoaChiTietThachDau.TabIndex = 28;
            this.btnXoaChiTietThachDau.Text = "Xóa";
            this.btnXoaChiTietThachDau.UseVisualStyleBackColor = true;
            this.btnXoaChiTietThachDau.Click += new System.EventHandler(this.btnXoaChiTietThachDau_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbMaHoiVien2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtTenHoiVien2);
            this.groupBox4.Location = new System.Drawing.Point(9, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 100);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hội Viên 2";
            // 
            // cmbMaHoiVien2
            // 
            this.cmbMaHoiVien2.FormattingEnabled = true;
            this.cmbMaHoiVien2.Location = new System.Drawing.Point(80, 32);
            this.cmbMaHoiVien2.Name = "cmbMaHoiVien2";
            this.cmbMaHoiVien2.Size = new System.Drawing.Size(125, 24);
            this.cmbMaHoiVien2.TabIndex = 23;
            this.cmbMaHoiVien2.SelectedIndexChanged += new System.EventHandler(this.cmbMaHoiVien2_SelectedIndexChanged);
            this.cmbMaHoiVien2.TextUpdate += new System.EventHandler(this.cmbMaHoiVien2_TextUpdate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "MSSV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Họ tên";
            // 
            // txtTenHoiVien2
            // 
            this.txtTenHoiVien2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHoiVien2.Location = new System.Drawing.Point(80, 65);
            this.txtTenHoiVien2.Name = "txtTenHoiVien2";
            this.txtTenHoiVien2.Size = new System.Drawing.Size(125, 22);
            this.txtTenHoiVien2.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbMaHoiVien1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTenHoiVien1);
            this.groupBox3.Location = new System.Drawing.Point(9, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 90);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hội Viên 1";
            // 
            // cmbMaHoiVien1
            // 
            this.cmbMaHoiVien1.FormattingEnabled = true;
            this.cmbMaHoiVien1.Location = new System.Drawing.Point(80, 26);
            this.cmbMaHoiVien1.Name = "cmbMaHoiVien1";
            this.cmbMaHoiVien1.Size = new System.Drawing.Size(125, 24);
            this.cmbMaHoiVien1.TabIndex = 22;
            this.cmbMaHoiVien1.SelectedIndexChanged += new System.EventHandler(this.cmbMaHoiVien1_SelectedIndexChanged);
            this.cmbMaHoiVien1.TextUpdate += new System.EventHandler(this.cmbMaHoiVien1_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // txtTenHoiVien1
            // 
            this.txtTenHoiVien1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHoiVien1.Location = new System.Drawing.Point(80, 58);
            this.txtTenHoiVien1.Name = "txtTenHoiVien1";
            this.txtTenHoiVien1.Size = new System.Drawing.Size(125, 22);
            this.txtTenHoiVien1.TabIndex = 23;
            // 
            // btnSuaChiTietThachDau
            // 
            this.btnSuaChiTietThachDau.Location = new System.Drawing.Point(158, 312);
            this.btnSuaChiTietThachDau.Name = "btnSuaChiTietThachDau";
            this.btnSuaChiTietThachDau.Size = new System.Drawing.Size(70, 25);
            this.btnSuaChiTietThachDau.TabIndex = 29;
            this.btnSuaChiTietThachDau.Text = "Sửa";
            this.btnSuaChiTietThachDau.UseVisualStyleBackColor = true;
            this.btnSuaChiTietThachDau.Click += new System.EventHandler(this.btnSuaChiTietThachDau_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả";
            // 
            // btnThemChiTietThachDau
            // 
            this.btnThemChiTietThachDau.Location = new System.Drawing.Point(6, 312);
            this.btnThemChiTietThachDau.Name = "btnThemChiTietThachDau";
            this.btnThemChiTietThachDau.Size = new System.Drawing.Size(70, 25);
            this.btnThemChiTietThachDau.TabIndex = 27;
            this.btnThemChiTietThachDau.Text = "Thêm";
            this.btnThemChiTietThachDau.UseVisualStyleBackColor = true;
            this.btnThemChiTietThachDau.Click += new System.EventHandler(this.btnThemChiTietThachDau_Click);
            // 
            // chkChonTatCa
            // 
            this.chkChonTatCa.AutoSize = true;
            this.chkChonTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChonTatCa.Location = new System.Drawing.Point(255, 576);
            this.chkChonTatCa.Name = "chkChonTatCa";
            this.chkChonTatCa.Size = new System.Drawing.Size(93, 20);
            this.chkChonTatCa.TabIndex = 31;
            this.chkChonTatCa.Text = "Chọn tất cả";
            this.chkChonTatCa.UseVisualStyleBackColor = true;
            this.chkChonTatCa.CheckedChanged += new System.EventHandler(this.chkChonTatCa_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbNguoiQuanLy);
            this.groupBox5.Controls.Add(this.dtpThoiGian);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtDiaDiem);
            this.groupBox5.Controls.Add(this.btnSuaThachDau);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.btnThemThachDau);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 393);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 210);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thách Đấu";
            // 
            // cmbNguoiQuanLy
            // 
            this.cmbNguoiQuanLy.FormattingEnabled = true;
            this.cmbNguoiQuanLy.Location = new System.Drawing.Point(89, 125);
            this.cmbNguoiQuanLy.Name = "cmbNguoiQuanLy";
            this.cmbNguoiQuanLy.Size = new System.Drawing.Size(125, 24);
            this.cmbNguoiQuanLy.TabIndex = 43;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(89, 48);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(125, 22);
            this.dtpThoiGian.TabIndex = 41;
            this.dtpThoiGian.Value = new System.DateTime(2010, 10, 7, 0, 0, 0, 0);
            this.dtpThoiGian.ValueChanged += new System.EventHandler(this.dtpThoiGian_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quản lý";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(89, 88);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(125, 22);
            this.txtDiaDiem.TabIndex = 42;
            // 
            // btnSuaThachDau
            // 
            this.btnSuaThachDau.Location = new System.Drawing.Point(145, 178);
            this.btnSuaThachDau.Name = "btnSuaThachDau";
            this.btnSuaThachDau.Size = new System.Drawing.Size(82, 25);
            this.btnSuaThachDau.TabIndex = 45;
            this.btnSuaThachDau.Text = "Sửa";
            this.btnSuaThachDau.UseVisualStyleBackColor = true;
            this.btnSuaThachDau.Click += new System.EventHandler(this.btnSuaThachDau_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa điểm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thời gian";
            // 
            // btnThemThachDau
            // 
            this.btnThemThachDau.Location = new System.Drawing.Point(57, 178);
            this.btnThemThachDau.Name = "btnThemThachDau";
            this.btnThemThachDau.Size = new System.Drawing.Size(82, 25);
            this.btnThemThachDau.TabIndex = 44;
            this.btnThemThachDau.Text = "Tạo Mới";
            this.btnThemThachDau.UseVisualStyleBackColor = true;
            this.btnThemThachDau.Click += new System.EventHandler(this.btnThemThachDau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(897, 578);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 25);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // CapNhatThachDauGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 613);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.chkChonTatCa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "CapNhatThachDauGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CapNhatThachDauGUI";
            this.Activated += new System.EventHandler(this.CapNhatThachDauGUI_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvDanhSachChiTietThachDau;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader MaHoiVien1;
        private System.Windows.Forms.ColumnHeader HoTenHoiVien1;
        private System.Windows.Forms.ColumnHeader MaHoiVien2;
        private System.Windows.Forms.ColumnHeader HoTenHoiVien2;
        private System.Windows.Forms.ColumnHeader KetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenHoiVien1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKetQua;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenHoiVien2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkChonTatCa;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnXoaChiTietThachDau;
        private System.Windows.Forms.Button btnSuaChiTietThachDau;
        private System.Windows.Forms.Button btnThemChiTietThachDau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSuaThachDau;
        private System.Windows.Forms.Button btnThemThachDau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.ComboBox cmbNguoiQuanLy;
        private System.Windows.Forms.ComboBox cmbMaHoiVien2;
        private System.Windows.Forms.ComboBox cmbMaHoiVien1;
    }
}