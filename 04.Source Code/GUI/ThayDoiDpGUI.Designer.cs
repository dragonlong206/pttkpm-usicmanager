namespace GUI
{
    partial class ThayDoiDpGUI
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
            this.grbCongThuc = new System.Windows.Forms.GroupBox();
            this.txtHangSo = new System.Windows.Forms.TextBox();
            this.lblDp = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvDp = new System.Windows.Forms.DataGridView();
            this.p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbCongThuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(220, 13);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(153, 26);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THAY ĐỔI DP";
            // 
            // grbCongThuc
            // 
            this.grbCongThuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCongThuc.Controls.Add(this.btnOk);
            this.grbCongThuc.Controls.Add(this.txtHangSo);
            this.grbCongThuc.Controls.Add(this.lblDp);
            this.grbCongThuc.Location = new System.Drawing.Point(13, 51);
            this.grbCongThuc.Name = "grbCongThuc";
            this.grbCongThuc.Size = new System.Drawing.Size(567, 83);
            this.grbCongThuc.TabIndex = 1;
            this.grbCongThuc.TabStop = false;
            this.grbCongThuc.Text = "Công thức";
            // 
            // txtHangSo
            // 
            this.txtHangSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHangSo.Location = new System.Drawing.Point(213, 32);
            this.txtHangSo.Name = "txtHangSo";
            this.txtHangSo.Size = new System.Drawing.Size(100, 26);
            this.txtHangSo.TabIndex = 1;
            this.txtHangSo.TextChanged += new System.EventHandler(this.txtHangSo_TextChanged);
            // 
            // lblDp
            // 
            this.lblDp.AutoSize = true;
            this.lblDp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDp.Location = new System.Drawing.Point(113, 31);
            this.lblDp.Name = "lblDp";
            this.lblDp.Size = new System.Drawing.Size(94, 26);
            this.lblDp.TabIndex = 0;
            this.lblDp.Text = "dp = p * ";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(332, 35);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // dgvDp
            // 
            this.dgvDp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p,
            this.dp,
            this.p2,
            this.dp2});
            this.dgvDp.Location = new System.Drawing.Point(13, 140);
            this.dgvDp.Name = "dgvDp";
            this.dgvDp.RowHeadersVisible = false;
            this.dgvDp.Size = new System.Drawing.Size(567, 371);
            this.dgvDp.TabIndex = 2;
            // 
            // p
            // 
            this.p.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p.HeaderText = "p";
            this.p.Name = "p";
            // 
            // dp
            // 
            this.dp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dp.HeaderText = "dp";
            this.dp.Name = "dp";
            // 
            // p2
            // 
            this.p2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p2.HeaderText = "p";
            this.p2.Name = "p2";
            // 
            // dp2
            // 
            this.dp2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dp2.HeaderText = "dp";
            this.dp2.Name = "dp2";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(424, 517);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(505, 517);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // ThayDoiDpGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 566);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvDp);
            this.Controls.Add(this.grbCongThuc);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "ThayDoiDpGUI";
            this.Text = "Thay Doi Dp";
            this.grbCongThuc.ResumeLayout(false);
            this.grbCongThuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grbCongThuc;
        private System.Windows.Forms.Label lblDp;
        private System.Windows.Forms.TextBox txtHangSo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvDp;
        private System.Windows.Forms.DataGridViewTextBoxColumn p;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp;
        private System.Windows.Forms.DataGridViewTextBoxColumn p2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}