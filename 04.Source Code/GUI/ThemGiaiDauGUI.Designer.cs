namespace GUI
{
    partial class ThemGiaiDauGUI
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grbChiTietGiaiDau = new System.Windows.Forms.GroupBox();
            this.pnlChiTietGiaiDau = new System.Windows.Forms.Panel();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.cboCap = new System.Windows.Forms.ComboBox();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtDonViToChuc = new System.Windows.Forms.TextBox();
            this.txtTenGiaiDau = new System.Windows.Forms.TextBox();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblCap = new System.Windows.Forms.Label();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.lblDonViToChuc = new System.Windows.Forms.Label();
            this.lblTenGiaiDau = new System.Windows.Forms.Label();
            this.grbChiTietDiemThuong = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGiaiBa = new System.Windows.Forms.TextBox();
            this.txtGiaiNhi = new System.Windows.Forms.TextBox();
            this.txtGiaiNhat = new System.Windows.Forms.TextBox();
            this.lblGiaiBa = new System.Windows.Forms.Label();
            this.lblGiaiNhi = new System.Windows.Forms.Label();
            this.lblGiaiNhat = new System.Windows.Forms.Label();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSachHoiVien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbChiTietGiaiDau.SuspendLayout();
            this.pnlChiTietGiaiDau.SuspendLayout();
            this.grbChiTietDiemThuong.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbDanhSach.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoiVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(295, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(176, 26);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "THÊM GIẢI ĐẤU";
            // 
            // grbChiTietGiaiDau
            // 
            this.grbChiTietGiaiDau.Controls.Add(this.pnlChiTietGiaiDau);
            this.grbChiTietGiaiDau.Location = new System.Drawing.Point(12, 52);
            this.grbChiTietGiaiDau.Name = "grbChiTietGiaiDau";
            this.grbChiTietGiaiDau.Size = new System.Drawing.Size(282, 194);
            this.grbChiTietGiaiDau.TabIndex = 3;
            this.grbChiTietGiaiDau.TabStop = false;
            this.grbChiTietGiaiDau.Text = "Chi tiết giải đấu";
            // 
            // pnlChiTietGiaiDau
            // 
            this.pnlChiTietGiaiDau.Controls.Add(this.dtpThoiGian);
            this.pnlChiTietGiaiDau.Controls.Add(this.cboCap);
            this.pnlChiTietGiaiDau.Controls.Add(this.txtDiaDiem);
            this.pnlChiTietGiaiDau.Controls.Add(this.txtDonViToChuc);
            this.pnlChiTietGiaiDau.Controls.Add(this.txtTenGiaiDau);
            this.pnlChiTietGiaiDau.Controls.Add(this.lblThoiGian);
            this.pnlChiTietGiaiDau.Controls.Add(this.lblCap);
            this.pnlChiTietGiaiDau.Controls.Add(this.lblDiaDiem);
            this.pnlChiTietGiaiDau.Controls.Add(this.lblDonViToChuc);
            this.pnlChiTietGiaiDau.Controls.Add(this.lblTenGiaiDau);
            this.pnlChiTietGiaiDau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChiTietGiaiDau.Location = new System.Drawing.Point(3, 16);
            this.pnlChiTietGiaiDau.Name = "pnlChiTietGiaiDau";
            this.pnlChiTietGiaiDau.Size = new System.Drawing.Size(276, 175);
            this.pnlChiTietGiaiDau.TabIndex = 0;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "hh:mm tt dd/MM/yyyy";
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(103, 73);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(148, 20);
            this.dtpThoiGian.TabIndex = 10;
            // 
            // cboCap
            // 
            this.cboCap.FormattingEnabled = true;
            this.cboCap.Location = new System.Drawing.Point(103, 132);
            this.cboCap.Name = "cboCap";
            this.cboCap.Size = new System.Drawing.Size(148, 21);
            this.cboCap.TabIndex = 8;
            this.cboCap.SelectedIndexChanged += new System.EventHandler(this.cboCap_SelectedIndexChanged);
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(103, 104);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(148, 20);
            this.txtDiaDiem.TabIndex = 7;
            // 
            // txtDonViToChuc
            // 
            this.txtDonViToChuc.Location = new System.Drawing.Point(103, 44);
            this.txtDonViToChuc.Name = "txtDonViToChuc";
            this.txtDonViToChuc.Size = new System.Drawing.Size(148, 20);
            this.txtDonViToChuc.TabIndex = 6;
            // 
            // txtTenGiaiDau
            // 
            this.txtTenGiaiDau.Location = new System.Drawing.Point(103, 16);
            this.txtTenGiaiDau.Name = "txtTenGiaiDau";
            this.txtTenGiaiDau.Size = new System.Drawing.Size(148, 20);
            this.txtTenGiaiDau.TabIndex = 5;
            this.txtTenGiaiDau.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(13, 80);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(51, 13);
            this.lblThoiGian.TabIndex = 4;
            this.lblThoiGian.Text = "Thời gian";
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Location = new System.Drawing.Point(13, 140);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(26, 13);
            this.lblCap.TabIndex = 3;
            this.lblCap.Text = "Cấp";
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(13, 111);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(49, 13);
            this.lblDiaDiem.TabIndex = 2;
            this.lblDiaDiem.Text = "Địa điểm";
            // 
            // lblDonViToChuc
            // 
            this.lblDonViToChuc.AutoSize = true;
            this.lblDonViToChuc.Location = new System.Drawing.Point(13, 51);
            this.lblDonViToChuc.Name = "lblDonViToChuc";
            this.lblDonViToChuc.Size = new System.Drawing.Size(77, 13);
            this.lblDonViToChuc.TabIndex = 1;
            this.lblDonViToChuc.Text = "Đơn vị tổ chức";
            // 
            // lblTenGiaiDau
            // 
            this.lblTenGiaiDau.AutoSize = true;
            this.lblTenGiaiDau.Location = new System.Drawing.Point(13, 23);
            this.lblTenGiaiDau.Name = "lblTenGiaiDau";
            this.lblTenGiaiDau.Size = new System.Drawing.Size(67, 13);
            this.lblTenGiaiDau.TabIndex = 0;
            this.lblTenGiaiDau.Text = "Tên giải đấu";
            // 
            // grbChiTietDiemThuong
            // 
            this.grbChiTietDiemThuong.Controls.Add(this.panel1);
            this.grbChiTietDiemThuong.Location = new System.Drawing.Point(15, 271);
            this.grbChiTietDiemThuong.Name = "grbChiTietDiemThuong";
            this.grbChiTietDiemThuong.Size = new System.Drawing.Size(282, 129);
            this.grbChiTietDiemThuong.TabIndex = 4;
            this.grbChiTietDiemThuong.TabStop = false;
            this.grbChiTietDiemThuong.Text = "Chi tiết điểm thưởng ELO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGiaiBa);
            this.panel1.Controls.Add(this.txtGiaiNhi);
            this.panel1.Controls.Add(this.txtGiaiNhat);
            this.panel1.Controls.Add(this.lblGiaiBa);
            this.panel1.Controls.Add(this.lblGiaiNhi);
            this.panel1.Controls.Add(this.lblGiaiNhat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 110);
            this.panel1.TabIndex = 0;
            // 
            // txtGiaiBa
            // 
            this.txtGiaiBa.Location = new System.Drawing.Point(103, 70);
            this.txtGiaiBa.Name = "txtGiaiBa";
            this.txtGiaiBa.ReadOnly = true;
            this.txtGiaiBa.Size = new System.Drawing.Size(148, 20);
            this.txtGiaiBa.TabIndex = 7;
            // 
            // txtGiaiNhi
            // 
            this.txtGiaiNhi.Location = new System.Drawing.Point(103, 44);
            this.txtGiaiNhi.Name = "txtGiaiNhi";
            this.txtGiaiNhi.ReadOnly = true;
            this.txtGiaiNhi.Size = new System.Drawing.Size(148, 20);
            this.txtGiaiNhi.TabIndex = 6;
            // 
            // txtGiaiNhat
            // 
            this.txtGiaiNhat.Location = new System.Drawing.Point(103, 16);
            this.txtGiaiNhat.Name = "txtGiaiNhat";
            this.txtGiaiNhat.ReadOnly = true;
            this.txtGiaiNhat.Size = new System.Drawing.Size(148, 20);
            this.txtGiaiNhat.TabIndex = 5;
            // 
            // lblGiaiBa
            // 
            this.lblGiaiBa.AutoSize = true;
            this.lblGiaiBa.Location = new System.Drawing.Point(13, 77);
            this.lblGiaiBa.Name = "lblGiaiBa";
            this.lblGiaiBa.Size = new System.Drawing.Size(40, 13);
            this.lblGiaiBa.TabIndex = 2;
            this.lblGiaiBa.Text = "Giải ba";
            // 
            // lblGiaiNhi
            // 
            this.lblGiaiNhi.AutoSize = true;
            this.lblGiaiNhi.Location = new System.Drawing.Point(13, 51);
            this.lblGiaiNhi.Name = "lblGiaiNhi";
            this.lblGiaiNhi.Size = new System.Drawing.Size(42, 13);
            this.lblGiaiNhi.TabIndex = 1;
            this.lblGiaiNhi.Text = "Giải nhì";
            // 
            // lblGiaiNhat
            // 
            this.lblGiaiNhat.AutoSize = true;
            this.lblGiaiNhat.Location = new System.Drawing.Point(13, 23);
            this.lblGiaiNhat.Name = "lblGiaiNhat";
            this.lblGiaiNhat.Size = new System.Drawing.Size(49, 13);
            this.lblGiaiNhat.TabIndex = 0;
            this.lblGiaiNhat.Text = "Giải nhất";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.panel2);
            this.grbDanhSach.Location = new System.Drawing.Point(307, 52);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(453, 351);
            this.grbDanhSach.TabIndex = 5;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách hội viên tham gia";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhSachHoiVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 332);
            this.panel2.TabIndex = 0;
            // 
            // dgvDanhSachHoiVien
            // 
            this.dgvDanhSachHoiVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHoiVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MSSV,
            this.HoTen,
            this.ELO});
            this.dgvDanhSachHoiVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHoiVien.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachHoiVien.MultiSelect = false;
            this.dgvDanhSachHoiVien.Name = "dgvDanhSachHoiVien";
            this.dgvDanhSachHoiVien.ReadOnly = true;
            this.dgvDanhSachHoiVien.RowHeadersVisible = false;
            this.dgvDanhSachHoiVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHoiVien.Size = new System.Drawing.Size(447, 332);
            this.dgvDanhSachHoiVien.TabIndex = 1;
            this.dgvDanhSachHoiVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHoiVien_CellContentClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            this.MSSV.Width = 70;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // ELO
            // 
            this.ELO.DataPropertyName = "Hạng";
            this.ELO.HeaderText = "Hạng";
            this.ELO.Name = "ELO";
            this.ELO.ReadOnly = true;
            this.ELO.Width = 70;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.Location = new System.Drawing.Point(682, 406);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Location = new System.Drawing.Point(15, 420);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "&Lưu";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.Location = new System.Drawing.Point(118, 420);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.Location = new System.Drawing.Point(219, 420);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // ThemGiaiDauGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 455);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.grbChiTietDiemThuong);
            this.Controls.Add(this.grbChiTietGiaiDau);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "ThemGiaiDauGUI";
            this.Text = "GiaiDauGUI";
            this.Load += new System.EventHandler(this.GiaiDauGUI_Load);
            this.grbChiTietGiaiDau.ResumeLayout(false);
            this.pnlChiTietGiaiDau.ResumeLayout(false);
            this.pnlChiTietGiaiDau.PerformLayout();
            this.grbChiTietDiemThuong.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbDanhSach.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoiVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grbChiTietGiaiDau;
        private System.Windows.Forms.Panel pnlChiTietGiaiDau;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label lblDonViToChuc;
        private System.Windows.Forms.Label lblTenGiaiDau;
        private System.Windows.Forms.TextBox txtTenGiaiDau;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtDonViToChuc;
        private System.Windows.Forms.ComboBox cboCap;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.GroupBox grbChiTietDiemThuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGiaiBa;
        private System.Windows.Forms.TextBox txtGiaiNhi;
        private System.Windows.Forms.TextBox txtGiaiNhat;
        private System.Windows.Forms.Label lblGiaiBa;
        private System.Windows.Forms.Label lblGiaiNhi;
        private System.Windows.Forms.Label lblGiaiNhat;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhSachHoiVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ELO;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
    }
}