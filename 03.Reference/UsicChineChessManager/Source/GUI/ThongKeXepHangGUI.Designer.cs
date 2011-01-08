namespace GUI
{
    partial class ThongKeXepHangGUI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSapXep4 = new System.Windows.Forms.Button();
            this.btnSapXep3 = new System.Windows.Forms.Button();
            this.btnSapXep2 = new System.Windows.Forms.Button();
            this.cmbDiem2 = new System.Windows.Forms.ComboBox();
            this.cmbDiem1 = new System.Windows.Forms.ComboBox();
            this.cmbDiem3 = new System.Windows.Forms.ComboBox();
            this.cmbDiem4 = new System.Windows.Forms.ComboBox();
            this.lsvXepHang = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.CapBac = new System.Windows.Forms.ColumnHeader();
            this.MSSV = new System.Windows.Forms.ColumnHeader();
            this.HoTen = new System.Windows.Forms.ColumnHeader();
            this.DiemVuotTroi = new System.Windows.Forms.ColumnHeader();
            this.DiemKinhNghiem = new System.Windows.Forms.ColumnHeader();
            this.DiemTichCuc = new System.Windows.Forms.ColumnHeader();
            this.DiemLienKich = new System.Windows.Forms.ColumnHeader();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSapXep1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCapBac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSapXep4);
            this.groupBox2.Controls.Add(this.btnSapXep3);
            this.groupBox2.Controls.Add(this.btnSapXep2);
            this.groupBox2.Controls.Add(this.cmbDiem2);
            this.groupBox2.Controls.Add(this.cmbDiem1);
            this.groupBox2.Controls.Add(this.cmbDiem3);
            this.groupBox2.Controls.Add(this.cmbDiem4);
            this.groupBox2.Controls.Add(this.lsvXepHang);
            this.groupBox2.Location = new System.Drawing.Point(6, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 466);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Xếp Hạng";
            // 
            // btnSapXep4
            // 
            this.btnSapXep4.Location = new System.Drawing.Point(847, 0);
            this.btnSapXep4.Name = "btnSapXep4";
            this.btnSapXep4.Size = new System.Drawing.Size(120, 12);
            this.btnSapXep4.TabIndex = 48;
            this.btnSapXep4.UseVisualStyleBackColor = true;
            this.btnSapXep4.Click += new System.EventHandler(this.btnSapXep4_Click);
            // 
            // btnSapXep3
            // 
            this.btnSapXep3.Location = new System.Drawing.Point(726, 0);
            this.btnSapXep3.Name = "btnSapXep3";
            this.btnSapXep3.Size = new System.Drawing.Size(120, 12);
            this.btnSapXep3.TabIndex = 47;
            this.btnSapXep3.UseVisualStyleBackColor = true;
            this.btnSapXep3.Click += new System.EventHandler(this.btnSapXep3_Click);
            // 
            // btnSapXep2
            // 
            this.btnSapXep2.Location = new System.Drawing.Point(605, 0);
            this.btnSapXep2.Name = "btnSapXep2";
            this.btnSapXep2.Size = new System.Drawing.Size(120, 12);
            this.btnSapXep2.TabIndex = 46;
            this.btnSapXep2.UseVisualStyleBackColor = true;
            this.btnSapXep2.Click += new System.EventHandler(this.btnSapXep2_Click);
            // 
            // cmbDiem2
            // 
            this.cmbDiem2.FormattingEnabled = true;
            this.cmbDiem2.Location = new System.Drawing.Point(605, 18);
            this.cmbDiem2.Name = "cmbDiem2";
            this.cmbDiem2.Size = new System.Drawing.Size(120, 24);
            this.cmbDiem2.TabIndex = 19;
            this.cmbDiem2.Text = "Điểm 2";
            this.cmbDiem2.SelectedIndexChanged += new System.EventHandler(this.cmbDiem2_SelectedIndexChanged);
            // 
            // cmbDiem1
            // 
            this.cmbDiem1.FormattingEnabled = true;
            this.cmbDiem1.Location = new System.Drawing.Point(484, 18);
            this.cmbDiem1.Name = "cmbDiem1";
            this.cmbDiem1.Size = new System.Drawing.Size(120, 24);
            this.cmbDiem1.TabIndex = 18;
            this.cmbDiem1.Text = "Điểm 1";
            this.cmbDiem1.SelectedIndexChanged += new System.EventHandler(this.cmbDiem1_SelectedIndexChanged);
            // 
            // cmbDiem3
            // 
            this.cmbDiem3.FormattingEnabled = true;
            this.cmbDiem3.Location = new System.Drawing.Point(726, 18);
            this.cmbDiem3.Name = "cmbDiem3";
            this.cmbDiem3.Size = new System.Drawing.Size(120, 24);
            this.cmbDiem3.TabIndex = 16;
            this.cmbDiem3.Text = "Điểm 3";
            this.cmbDiem3.SelectedIndexChanged += new System.EventHandler(this.cmbDiem3_SelectedIndexChanged);
            // 
            // cmbDiem4
            // 
            this.cmbDiem4.FormattingEnabled = true;
            this.cmbDiem4.Location = new System.Drawing.Point(847, 18);
            this.cmbDiem4.Name = "cmbDiem4";
            this.cmbDiem4.Size = new System.Drawing.Size(120, 24);
            this.cmbDiem4.TabIndex = 15;
            this.cmbDiem4.Text = "Điểm 4";
            this.cmbDiem4.SelectedIndexChanged += new System.EventHandler(this.cmbDiem4_SelectedIndexChanged);
            // 
            // lsvXepHang
            // 
            this.lsvXepHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.CapBac,
            this.MSSV,
            this.HoTen,
            this.DiemVuotTroi,
            this.DiemKinhNghiem,
            this.DiemTichCuc,
            this.DiemLienKich});
            this.lsvXepHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvXepHang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvXepHang.FullRowSelect = true;
            this.lsvXepHang.GridLines = true;
            this.lsvXepHang.Location = new System.Drawing.Point(3, 18);
            this.lsvXepHang.Name = "lsvXepHang";
            this.lsvXepHang.Size = new System.Drawing.Size(977, 445);
            this.lsvXepHang.TabIndex = 11;
            this.lsvXepHang.UseCompatibleStateImageBehavior = false;
            this.lsvXepHang.View = System.Windows.Forms.View.Details;
            this.lsvXepHang.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lsvXepHang_ColumnClick);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // CapBac
            // 
            this.CapBac.Text = "Cấp Bậc";
            this.CapBac.Width = 120;
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            this.MSSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MSSV.Width = 100;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ Tên";
            this.HoTen.Width = 200;
            // 
            // DiemVuotTroi
            // 
            this.DiemVuotTroi.Text = "Vượt Trội";
            this.DiemVuotTroi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiemVuotTroi.Width = 120;
            // 
            // DiemKinhNghiem
            // 
            this.DiemKinhNghiem.Text = "Kinh Nghiệm";
            this.DiemKinhNghiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiemKinhNghiem.Width = 120;
            // 
            // DiemTichCuc
            // 
            this.DiemTichCuc.Text = "Tích Cực";
            this.DiemTichCuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiemTichCuc.Width = 120;
            // 
            // DiemLienKich
            // 
            this.DiemLienKich.Text = "Liên Kích";
            this.DiemLienKich.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiemLienKich.Width = 120;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1030, 752);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 29);
            this.btnThoat.TabIndex = 43;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(904, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSapXep1
            // 
            this.btnSapXep1.Location = new System.Drawing.Point(490, 101);
            this.btnSapXep1.Name = "btnSapXep1";
            this.btnSapXep1.Size = new System.Drawing.Size(120, 12);
            this.btnSapXep1.TabIndex = 45;
            this.btnSapXep1.UseVisualStyleBackColor = true;
            this.btnSapXep1.Click += new System.EventHandler(this.btnSapXep1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCapBac);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 73);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra Cứu";
            // 
            // txtCapBac
            // 
            this.txtCapBac.Location = new System.Drawing.Point(290, 41);
            this.txtCapBac.Name = "txtCapBac";
            this.txtCapBac.Size = new System.Drawing.Size(142, 22);
            this.txtCapBac.TabIndex = 2;
            this.txtCapBac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapBac_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cấp bậc";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(78, 41);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(100, 22);
            this.txtMSSV.TabIndex = 1;
            this.txtMSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSSV_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // ThongKeXepHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSapXep1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "ThongKeXepHangGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ThongKeXepHangGUI";
            this.Activated += new System.EventHandler(this.ThongKeXepHangGUI_Activated);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lsvXepHang;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader CapBac;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader DiemVuotTroi;
        private System.Windows.Forms.ColumnHeader DiemKinhNghiem;
        private System.Windows.Forms.ColumnHeader DiemTichCuc;
        private System.Windows.Forms.ColumnHeader DiemLienKich;
        private System.Windows.Forms.ComboBox cmbDiem4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbDiem2;
        private System.Windows.Forms.ComboBox cmbDiem1;
        private System.Windows.Forms.ComboBox cmbDiem3;
        private System.Windows.Forms.Button btnSapXep4;
        private System.Windows.Forms.Button btnSapXep3;
        private System.Windows.Forms.Button btnSapXep2;
        private System.Windows.Forms.Button btnSapXep1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapBac;
    }
}