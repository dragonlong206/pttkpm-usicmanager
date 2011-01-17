using System;
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
                DialogResult luaChon = MessageBox.Show("Bạn có chắc muốn reset toàn bộ điểm liên kích", "Xac nhan", MessageBoxButtons.YesNo);
                if (luaChon == DialogResult.Yes)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void thêmGiảiĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemGiaiDauGUI frmThemGiaDau = new ThemGiaiDauGUI();
            frmThemGiaDau.MdiParent = this;
            //frmThemGiaDau.WindowState = FormWindowState.Maximized;
            frmThemGiaDau.Show();
        }

        private void thayĐổiCáchTínhPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThayDoiPGUI frmThayDoiP = new ThayDoiPGUI();
            frmThayDoiP.MdiParent = this;
            frmThayDoiP.Show();
        }

        private void cậpNhậtThôngTinGiảiĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatGiaiDauGUI frmCapNhatGiaiDau = new CapNhatGiaiDauGUI();
            frmCapNhatGiaiDau.MdiParent = this;
            frmCapNhatGiaiDau.Show();
        }

        private void xóaGiảiĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaGiaiDauGUI frmXoaGiaiDau = new XoaGiaiDauGUI();
            frmXoaGiaiDau.MdiParent = this;
            frmXoaGiaiDau.Show();
        }
    }
}
