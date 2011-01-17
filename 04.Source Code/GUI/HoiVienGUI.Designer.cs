namespace GUI
{
    partial class HoiVienGUI
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
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grbDanhSachHoiVien = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachHoiVien = new System.Windows.Forms.DataGridView();
            this.grbChiTietHoiVien = new System.Windows.Forms.GroupBox();
            this.pnlChiTietHoiVien = new System.Windows.Forms.Panel();
            this.ucHoiVien_ChiTiet1 = new GUI.ucHoiVien_ChiTiet();
            this.btnImport = new System.Windows.Forms.Button();
            this.ttToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHuongDan = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapBac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLienKichCaoNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDanhSachHoiVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoiVien)).BeginInit();
            this.grbChiTietHoiVien.SuspendLayout();
            this.pnlChiTietHoiVien.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(299, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(213, 26);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ HỘI VIÊN";
            // 
            // grbDanhSachHoiVien
            // 
            this.grbDanhSachHoiVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDanhSachHoiVien.Controls.Add(this.dgvDanhSachHoiVien);
            this.grbDanhSachHoiVien.Location = new System.Drawing.Point(258, 50);
            this.grbDanhSachHoiVien.Name = "grbDanhSachHoiVien";
            this.grbDanhSachHoiVien.Size = new System.Drawing.Size(522, 475);
            this.grbDanhSachHoiVien.TabIndex = 1;
            this.grbDanhSachHoiVien.TabStop = false;
            this.grbDanhSachHoiVien.Text = "Danh sách hội viên";
            // 
            // dgvDanhSachHoiVien
            // 
            this.dgvDanhSachHoiVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHoiVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.HoTen,
            this.MSSV,
            this.ELO,
            this.CapBac,
            this.DiemLienKichCaoNhat});
            this.dgvDanhSachHoiVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHoiVien.Location = new System.Drawing.Point(3, 16);
            this.dgvDanhSachHoiVien.MultiSelect = false;
            this.dgvDanhSachHoiVien.Name = "dgvDanhSachHoiVien";
            this.dgvDanhSachHoiVien.ReadOnly = true;
            this.dgvDanhSachHoiVien.RowHeadersVisible = false;
            this.dgvDanhSachHoiVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHoiVien.Size = new System.Drawing.Size(516, 456);
            this.dgvDanhSachHoiVien.TabIndex = 0;
            this.dgvDanhSachHoiVien.SelectionChanged += new System.EventHandler(this.dgvDanhSachHoiVien_SelectionChanged);
            // 
            // grbChiTietHoiVien
            // 
            this.grbChiTietHoiVien.Controls.Add(this.pnlChiTietHoiVien);
            this.grbChiTietHoiVien.Location = new System.Drawing.Point(13, 50);
            this.grbChiTietHoiVien.Name = "grbChiTietHoiVien";
            this.grbChiTietHoiVien.Size = new System.Drawing.Size(239, 322);
            this.grbChiTietHoiVien.TabIndex = 2;
            this.grbChiTietHoiVien.TabStop = false;
            this.grbChiTietHoiVien.Text = "Chi tiết hội viên";
            // 
            // pnlChiTietHoiVien
            // 
            this.pnlChiTietHoiVien.Controls.Add(this.ucHoiVien_ChiTiet1);
            this.pnlChiTietHoiVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChiTietHoiVien.Location = new System.Drawing.Point(3, 16);
            this.pnlChiTietHoiVien.Name = "pnlChiTietHoiVien";
            this.pnlChiTietHoiVien.Size = new System.Drawing.Size(233, 303);
            this.pnlChiTietHoiVien.TabIndex = 0;
            // 
            // ucHoiVien_ChiTiet1
            // 
            this.ucHoiVien_ChiTiet1.Ancestor = null;
            this.ucHoiVien_ChiTiet1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ucHoiVien_ChiTiet1.AutoSize = true;
            this.ucHoiVien_ChiTiet1.CheDoHienTai = GUI.CheDoXemHienTai.XEM;
            this.ucHoiVien_ChiTiet1.Location = new System.Drawing.Point(0, 0);
            this.ucHoiVien_ChiTiet1.Name = "ucHoiVien_ChiTiet1";
            this.ucHoiVien_ChiTiet1.Size = new System.Drawing.Size(233, 303);
            this.ucHoiVien_ChiTiet1.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.Location = new System.Drawing.Point(13, 529);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "&Import";
            this.ttToolTip.SetToolTip(this.btnImport, "Import từ tập tin excel");
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Location = new System.Drawing.Point(94, 529);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "&Export";
            this.ttToolTip.SetToolTip(this.btnExport, "Export ra tập tin excel");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(702, 529);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.btnTim);
            this.grbTimKiem.Controls.Add(this.txtMSSV);
            this.grbTimKiem.Controls.Add(this.lblMSSV);
            this.grbTimKiem.Controls.Add(this.txtHoTen);
            this.grbTimKiem.Controls.Add(this.lblHoTen);
            this.grbTimKiem.Location = new System.Drawing.Point(13, 379);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(236, 109);
            this.grbTimKiem.TabIndex = 7;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(145, 84);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm &kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(72, 58);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(148, 20);
            this.txtMSSV.TabIndex = 1;
            this.txtMSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSSV_KeyPress);
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(15, 61);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(37, 13);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(72, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(148, 20);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 25);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(39, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtHuongDan
            // 
            this.txtHuongDan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHuongDan.Location = new System.Drawing.Point(13, 494);
            this.txtHuongDan.Multiline = true;
            this.txtHuongDan.Name = "txtHuongDan";
            this.txtHuongDan.ReadOnly = true;
            this.txtHuongDan.Size = new System.Drawing.Size(236, 28);
            this.txtHuongDan.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(258, 529);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            this.MSSV.Width = 70;
            // 
            // ELO
            // 
            this.ELO.DataPropertyName = "ELO";
            this.ELO.HeaderText = "ELO";
            this.ELO.Name = "ELO";
            this.ELO.ReadOnly = true;
            this.ELO.Width = 70;
            // 
            // CapBac
            // 
            this.CapBac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CapBac.DataPropertyName = "TenCapBac";
            this.CapBac.HeaderText = "Cấp bậc";
            this.CapBac.Name = "CapBac";
            this.CapBac.ReadOnly = true;
            // 
            // DiemLienKichCaoNhat
            // 
            this.DiemLienKichCaoNhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemLienKichCaoNhat.DataPropertyName = "DiemLienKichCaoNhat";
            this.DiemLienKichCaoNhat.HeaderText = "Điểm liên kích";
            this.DiemLienKichCaoNhat.Name = "DiemLienKichCaoNhat";
            this.DiemLienKichCaoNhat.ReadOnly = true;
            // 
            // HoiVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtHuongDan);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.grbChiTietHoiVien);
            this.Controls.Add(this.grbDanhSachHoiVien);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "HoiVienGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quan Ly Hoi Vien";
            this.Load += new System.EventHandler(this.HoiVienGUI_Load);
            this.grbDanhSachHoiVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoiVien)).EndInit();
            this.grbChiTietHoiVien.ResumeLayout(false);
            this.pnlChiTietHoiVien.ResumeLayout(false);
            this.pnlChiTietHoiVien.PerformLayout();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grbDanhSachHoiVien;
        private System.Windows.Forms.DataGridView dgvDanhSachHoiVien;
        private System.Windows.Forms.GroupBox grbChiTietHoiVien;
        private System.Windows.Forms.Panel pnlChiTietHoiVien;
        private ucHoiVien_ChiTiet ucHoiVien_ChiTiet1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ToolTip ttToolTip;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtHuongDan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapBac;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLienKichCaoNhat;
    }
}