using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainGUI : Form
    {
        private CapNhatThachDauGUI frmCapNhatThachDau = null;
        private QuanLyGUI frmQuanLy = null;
        private ThongKeXepHangGUI frmThongKeXepHang = null;        

        public MainGUI()
        {
            InitializeComponent();

            frmCapNhatThachDau = new CapNhatThachDauGUI();
            frmCapNhatThachDau.MdiParent = this;
            frmCapNhatThachDau.Show();                            
        }       

        private void cậpNhậtTháchĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            frmCapNhatThachDau = new CapNhatThachDauGUI();
            frmCapNhatThachDau.MdiParent = this;
            frmCapNhatThachDau.Show();                                                            
        }     

        private void thốngKêXếpHạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeXepHang = new ThongKeXepHangGUI();
            frmThongKeXepHang.MdiParent = this;
            frmThongKeXepHang.Show();
        }

        private void quảnLýChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLy = new QuanLyGUI();
            frmQuanLy.MdiParent = this;
            frmQuanLy.Show();
        }                                
    }
}
