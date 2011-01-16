namespace GUI
{
    partial class ThemTranDauGUI
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
            this.dgvDanhSachTranDau = new System.Windows.Forms.DataGridView();
            this.MSSV1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HoTen1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MSSV2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HoTen2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TrongTai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.KetQua = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTranDau)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(268, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(254, 26);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "GHI NHẬN THÁCH ĐẤU";
            // 
            // dgvDanhSachTranDau
            // 
            this.dgvDanhSachTranDau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachTranDau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTranDau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MSSV1,
            this.HoTen1,
            this.MSSV2,
            this.HoTen2,
            this.DiaDiem,
            this.TrongTai,
            this.KetQua});
            this.dgvDanhSachTranDau.Location = new System.Drawing.Point(13, 55);
            this.dgvDanhSachTranDau.Name = "dgvDanhSachTranDau";
            this.dgvDanhSachTranDau.RowHeadersVisible = false;
            this.dgvDanhSachTranDau.Size = new System.Drawing.Size(767, 449);
            this.dgvDanhSachTranDau.TabIndex = 1;
            this.dgvDanhSachTranDau.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDanhSachTranDau_RowsAdded);
            this.dgvDanhSachTranDau.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDanhSachTranDau_EditingControlShowing);
            this.dgvDanhSachTranDau.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDanhSachTranDau_RowsRemoved);
            // 
            // MSSV1
            // 
            this.MSSV1.HeaderText = "MSSV 1";
            this.MSSV1.Name = "MSSV1";
            this.MSSV1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MSSV1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MSSV1.Width = 70;
            // 
            // HoTen1
            // 
            this.HoTen1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen1.HeaderText = "Họ tên 1";
            this.HoTen1.Name = "HoTen1";
            this.HoTen1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HoTen1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MSSV2
            // 
            this.MSSV2.HeaderText = "MSSV 2";
            this.MSSV2.Name = "MSSV2";
            this.MSSV2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MSSV2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MSSV2.Width = 70;
            // 
            // HoTen2
            // 
            this.HoTen2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen2.HeaderText = "Họ tên 2";
            this.HoTen2.Name = "HoTen2";
            this.HoTen2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HoTen2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TrongTai
            // 
            this.TrongTai.HeaderText = "Trọng tài";
            this.TrongTai.Name = "TrongTai";
            this.TrongTai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrongTai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // KetQua
            // 
            this.KetQua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KetQua.HeaderText = "Kết quả";
            this.KetQua.Name = "KetQua";
            this.KetQua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.KetQua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Location = new System.Drawing.Point(543, 520);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(705, 520);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapLai.Location = new System.Drawing.Point(624, 520);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(75, 23);
            this.btnNhapLai.TabIndex = 2;
            this.btnNhapLai.Text = "&Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Địa điểm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // DiaDiem
            // 
            this.DiaDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaDiem.HeaderText = "Địa điểm";
            this.DiaDiem.Name = "DiaDiem";
            // 
            // ThemTranDauGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvDanhSachTranDau);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "ThemTranDauGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ghi Nhan Thach Dau";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTranDau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView dgvDanhSachTranDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn MSSV1;
        private System.Windows.Forms.DataGridViewComboBoxColumn HoTen1;
        private System.Windows.Forms.DataGridViewComboBoxColumn MSSV2;
        private System.Windows.Forms.DataGridViewComboBoxColumn HoTen2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewComboBoxColumn TrongTai;
        private System.Windows.Forms.DataGridViewComboBoxColumn KetQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNhapLai;
    }
}