using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public enum CheDoXemHienTai
    {
        XEM,
        THEM,
        SUA,
        XOA
    };

    public enum GioiTinh
    {
        CA_HAI = 0,
        NAM = 1,
        NU = 2
    };

    public partial class ucHoiVien_ChiTiet : UserControl
    {      
        private CheDoXemHienTai cheDoHienTai;
        private HoiVienDTO hoiVienHienTai;
        private Control ancestor;

        public Control Ancestor
        {
            get { return ancestor; }
            set { ancestor = value; }
        }

        public CheDoXemHienTai CheDoHienTai
        {
            get { return cheDoHienTai; }
            set { cheDoHienTai = value; }
        }

        public ucHoiVien_ChiTiet()
        {
            InitializeComponent();
            CheDoHienTai = CheDoXemHienTai.XEM;
        }

        protected void SetVisibleXem(bool value)
        {
            this.btnThem.Visible = value;
            this.btnXoa.Visible = value;
            this.btnSua.Visible = value;
        }

        protected void SetVisibleThemSua(bool value)
        {
            this.btnLuu.Visible = value;
            this.btnHuy.Visible = value;
            this.btnHoanTat.Visible = value;
            //this.lblThoiGianDatDiemLienKich.Visible = !value;
            //this.txtThoiGianDat.Visible = !value;
            this.cboGioiTinh.Visible = value;
            this.txtGioiTinh.Visible = !value;
        }

        protected void SetEditableTextBox(bool value, bool resetOption)
        {
            this.txtHoTen.ReadOnly = value;
            this.txtMSSV.ReadOnly = value;

            if (resetOption)
            {
                this.txtHoTen.Text = string.Empty;
                
                this.txtMSSV.Text = string.Empty;
                
                this.cboGioiTinh.SelectedIndex = 0;
                
                this.txtELO.Text = "0";
                
                try
                {
                    this.txtCapBac.Text = (new CapBacHoiVienBUS()).LayTenCapBacNhoNhat();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                this.txtDiemLienKich.Text = "0";

                this.txtThoiGianDat.Text = string.Empty;
            }
        }

        protected void ChuyenSangCheDoXem()
        {
            this.CheDoHienTai = CheDoXemHienTai.XEM;
            this.SetVisibleXem(true);
            this.SetVisibleThemSua(false);
            this.SetEditableTextBox(true, false);
        }

        protected void ChuyenSangCheDoThem()
        {
            this.CheDoHienTai = CheDoXemHienTai.THEM;
            this.SetVisibleThemSua(true);
            this.SetVisibleXem(false);
            this.SetEditableTextBox(false, true);
            this.cboGioiTinh.SelectedIndex = 0;
            
            this.txtHoTen.Focus();
        }

        protected void ChuyenSangCheDoSua()
        {
            this.CheDoHienTai = CheDoXemHienTai.SUA;
            this.SetVisibleThemSua(true);
            this.SetVisibleXem(false);

            this.SetEditableTextBox(false, false);
            
            this.cboGioiTinh.SelectedItem = this.txtGioiTinh.Text;

            this.txtHoTen.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.ChuyenSangCheDoThem();            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult luaChon = MessageBox.Show("Bạn có chắc muốn xóa hội viên này?", "Xac nhan", MessageBoxButtons.YesNo);
                if (luaChon == DialogResult.Yes)
                {
                    HoiVienBUS hoiVienBUS = new HoiVienBUS();
                    bool xoaThanhCong = hoiVienBUS.XoaHoiVien(hoiVienHienTai.ID);
                    if (!xoaThanhCong)
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                    else
                    {
                        if (ancestor is HoiVienGUI)
                        {
                            ((HoiVienGUI)ancestor).HienThiDuLieu();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.ChuyenSangCheDoSua();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cheDoHienTai == CheDoXemHienTai.SUA)
                {
                    // TODO Kiểm tra MSSV đã tồn tại
                    HoiVienDTO hoiVienDTO = new HoiVienDTO();
                    if (hoiVienHienTai != null)
                    {
                        hoiVienDTO.ID = hoiVienHienTai.ID;
                    }
                    hoiVienDTO.HoTen = this.txtHoTen.Text;
                    hoiVienDTO.MSSV = this.txtMSSV.Text;
                    hoiVienDTO.GioiTinh = this.cboGioiTinh.SelectedIndex + 1;
                    HoiVienBUS hoiVienBUS = new HoiVienBUS();
                    bool capNhatThanhCong = hoiVienBUS.CapNhatHoiVien(hoiVienDTO);
                    if (capNhatThanhCong)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        if (ancestor is HoiVienGUI)
                        {
                            ((HoiVienGUI)ancestor).HienThiDuLieu();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
                else if (cheDoHienTai == CheDoXemHienTai.THEM)
                {
                    // TODO Kiểm tra MSSV đã tồn tại
                    HoiVienDTO hoiVienDTO = new HoiVienDTO();
                    
                    hoiVienDTO.HoTen = this.txtHoTen.Text;
                    
                    hoiVienDTO.MSSV = this.txtMSSV.Text;
                    
                    hoiVienDTO.GioiTinh = this.cboGioiTinh.SelectedIndex + 1;
                    
                    bool coTheParse = true;
                    float temp1;
                    coTheParse = float.TryParse(this.txtELO.Text, out temp1);
                    if (coTheParse)
                    {
                        hoiVienDTO.ELO = temp1;
                    }
                    else
                    {
                        MessageBox.Show("ELO nhập không đúng");
                        return;
                    }

                    int temp2;
                    coTheParse = int.TryParse(this.txtDiemLienKich.Text, out temp2);
                    if (coTheParse)
                    {
                        hoiVienDTO.DiemLienKich = temp2;
                    }
                    else
                    {
                        MessageBox.Show("Điểm liên kích nhập không đúng");
                        return;
                    }

                    HoiVienBUS hoiVienBUS = new HoiVienBUS();
                    bool themThanhCong = hoiVienBUS.ThemMoiHoiVien(hoiVienDTO);
                    if (themThanhCong)
                    { 
                        MessageBox.Show("Thêm thành công");
                        if (ancestor is HoiVienGUI)
                        {
                            ((HoiVienGUI)ancestor).HienThiDuLieu();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.HienThiDuLieu();
            this.btnHoanTat_Click(null, null);            
        }

        public void GanDuLieu(HoiVienDTO hoiVienDTO)
        {
            if (CheDoHienTai == CheDoXemHienTai.XEM || CheDoHienTai == CheDoXemHienTai.SUA)
            {
                hoiVienHienTai = hoiVienDTO;
                HienThiDuLieu();                
            }
        }

        private void HienThiDuLieu()
        {
            this.txtHoTen.Text = hoiVienHienTai.HoTen;
            this.txtMSSV.Text = hoiVienHienTai.MSSV;
            if (hoiVienHienTai.GioiTinh == (int)GioiTinh.NU)
            {
                this.txtGioiTinh.Text = "Nữ";
            }
            else if (hoiVienHienTai.GioiTinh == (int)GioiTinh.NAM)
            {
                this.txtGioiTinh.Text = "Nam";
            }

            this.txtELO.Text = hoiVienHienTai.ELO.ToString();

            this.txtCapBac.Text = hoiVienHienTai.TenCapBac;

            this.txtDiemLienKich.Text = hoiVienHienTai.DiemLienKichCaoNhat.ToString();

            if (hoiVienHienTai.DiemLienKichCaoNhat > 0)
            {
                this.txtThoiGianDat.Text = hoiVienHienTai.ThoiGianDatDiemLienKich.ToString("dd/MM/yyyy");
            }
            else
            {
                this.txtThoiGianDat.Text = "";
            }

            if (CheDoHienTai == CheDoXemHienTai.SUA)
            {
                this.cboGioiTinh.SelectedItem = this.txtGioiTinh.Text;
            }
        }

        //private void KhoiTaoDuLieuChoComboBox()
        //{
        //    if (this.danhSachCapBac == null || this.danhSachCapBac.Rows.Count == 0)
        //    {
        //        CapBacHoiVienBUS capBacHoiVienBUS = new CapBacHoiVienBUS();
        //        danhSachCapBac = capBacHoiVienBUS.LayDanhSachTatCaCapBac();
        //        this.cboCapBac.DataSource = danhSachCapBac;
        //        this.cboCapBac.ValueMember = "ID";
        //        this.cboCapBac.DisplayMember = "TenCapBac";
        //    }
        //}

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            this.SetVisibleThemSua(false);
            this.SetVisibleXem(true);
            this.ChuyenSangCheDoXem();
        }
    }
}
