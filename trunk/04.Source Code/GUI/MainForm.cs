﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void quảnLýhộiViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoiVienGUI frmQuanLyHoiVien = new HoiVienGUI();
            frmQuanLyHoiVien.MdiParent = this;
            frmQuanLyHoiVien.WindowState = FormWindowState.Maximized;
            frmQuanLyHoiVien.Show();
        }

        private void thêmTrậnĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTranDauGUI frmThemTranDau = new ThemTranDauGUI();
            frmThemTranDau.MdiParent = this;
            frmThemTranDau.WindowState = FormWindowState.Maximized;
            frmThemTranDau.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetĐiểmLiênKíchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool resetThanhCong = (new HoiVienBUS()).ResetToanBoDiemLienKich();

                if (resetThanhCong)
                {
                    MessageBox.Show("Reset thành công");
                }
                else
                {
                    MessageBox.Show("Reset thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
