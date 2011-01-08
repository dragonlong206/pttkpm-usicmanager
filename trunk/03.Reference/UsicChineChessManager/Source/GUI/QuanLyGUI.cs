using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class QuanLyGUI : Form
    {
        private int nKiemTraBanDau = 0;
        private List<HoiVienDTO> _lstHoiVien = new List<HoiVienDTO>();
        private List<CapBacDTO> _lstCapBac = new List<CapBacDTO>();
        private List<ThangDiemDTO> _lstThangDiem = new List<ThangDiemDTO>();
        private List<ThachDauDTO> _lstThachDau = new List<ThachDauDTO>();

        public QuanLyGUI()
        {
            InitializeComponent();                  
        }

        private void QuanLyGUI_Activated(object sender, EventArgs e)
        {            
            try
            {
                String strSapXepHoiVien = " Order By MSSV";
                _lstHoiVien = HoiVienBUS.DocDanhSachHoiVien(String.Empty, strSapXepHoiVien);
                String strSapXepCapBac = " Order By ChiSoCapbac";
                _lstCapBac = CapBacBUS.DocDanhSachCapBac(String.Empty, strSapXepCapBac);
                String strSapXepThangDiem = " Order By CongThucTinh";
                _lstThangDiem = ThangDiemBUS.DocDanhSachDiem(String.Empty, strSapXepThangDiem);
                String strSapXepThachDau = " Order By ThoiGian DESC";
                _lstThachDau = ThachDauBUS.DocDanhSachThachDau(String.Empty, strSapXepThachDau);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            if (nKiemTraBanDau == 1)
            {
                LoadDanhSachHoiVien();
                nKiemTraBanDau = 0;
            }
        }

        #region Xuat danh sach: HoiVien, CapBac, ThangDiem, ThachDau.                                   

        #region Load danh sach HoiVien.
        private void tpgHoiVien_Enter(object sender, EventArgs e)
        {
            if (_lstHoiVien.Count == 0)
                nKiemTraBanDau = 1; //TabHoiVien chua duoc load.
            
            LoadDanhSachHoiVien();
        }

        private void LoadDanhSachHoiVien()
        {
            try
            {
                XuatDanhSachHoiVien(_lstHoiVien);

                // Load danh sach cap bac trong combobox.               
                List<CapBacDTO> lstCapBac = CapBacBUS.CopyListCapBac(_lstCapBac);
                cmbCapBac.DataSource = lstCapBac;
                cmbCapBac.DisplayMember = "TenCapBac";
                cmbCapBac.ValueMember = "IDCapBac";
                cmbCapBac.Text = String.Empty;                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachHoiVien(List<DTO.HoiVienDTO> lstHoiVien)
        {
            if (lstHoiVien == null)
                return;     //khong lam gi ca.          

            lsvDanhSachHoiVien.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.HoiVienDTO aHoiVienTemp in lstHoiVien)
            {
                ListViewItem aItem = TheHienListItem(nSoThuTu, aHoiVienTemp);
                if(aItem != null)
                    lsvDanhSachHoiVien.Items.Add(aItem);
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.HoiVienDTO aHoiVien)
        {
            if (aHoiVien == null)
                return null;

            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aHoiVien.MSSV);            
            itemKetQua.SubItems.Add(aHoiVien.HoTen.ToString());            

            CapBacDTO aCapBac = CapBacBUS.LayCapBacTheoID(aHoiVien.MaCapBac, _lstCapBac);
            if (aCapBac != null)
                itemKetQua.SubItems.Add(aCapBac.TenCapBac);
            else
                itemKetQua.SubItems.Add(CapBacBUS.LayCapBacMacDinh(_lstCapBac).TenCapBac);
            
            itemKetQua.Tag = aHoiVien;
            return itemKetQua;
        }

        private void lsvDanhSachHoiVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachHoiVien.SelectedItems.Count > 0)
            {
                ListViewItem itemHoiVien = lsvDanhSachHoiVien.SelectedItems[0];                
                XuatChiTietHoiVien(itemHoiVien);
            }
        }

        private void XuatChiTietHoiVien(ListViewItem itemHoiVien)
        {
            if (itemHoiVien.SubItems.Count < 4)
                return;

            txtMSSV.Text = itemHoiVien.SubItems[1].Text;
            txtTenHoiVien.Text = itemHoiVien.SubItems[2].Text;
            cmbCapBac.Text = itemHoiVien.SubItems[3].Text;            
        }       
        #endregion        

        #region Load danh sach CapBac.
        private void tpgCapBac_Enter(object sender, EventArgs e)
        {            
            LoadDanhSachCapBac();
        }

        private void LoadDanhSachCapBac()
        {
            try
            {                
                XuatDanhSachCapBac(_lstCapBac);                                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachCapBac(List<DTO.CapBacDTO> lstCapBac)
        {
            if (lstCapBac == null)
                return;     //khong lam gi ca.          

            lsvDanhSachCapBac.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.CapBacDTO aCapBacTemp in lstCapBac)
            {
                ListViewItem aItem = TheHienListItem(nSoThuTu, aCapBacTemp);
                if(aItem != null)
                    lsvDanhSachCapBac.Items.Add(aItem);
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.CapBacDTO aCapBac)
        {
            if (aCapBac == null)
                return null;

            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aCapBac.ChiSoCapBac.ToString());
            itemKetQua.SubItems.Add(aCapBac.TenCapBac.ToString());
            itemKetQua.SubItems.Add(aCapBac.NguongVuotTroi.ToString());
            itemKetQua.Tag = aCapBac;

            return itemKetQua;
        }

        private void lsvDanhSachCapBac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachCapBac.SelectedItems.Count > 0)
            {
                ListViewItem itemCapBac = lsvDanhSachCapBac.SelectedItems[0];                
                XuatChiTietCapBac(itemCapBac);
            }
        }

        private void XuatChiTietCapBac(ListViewItem itemCapBac)
        {
            if (itemCapBac.SubItems.Count < 4)
                return;

            txtChiSoCapBac.Text = itemCapBac.SubItems[1].Text;
            txtTenCapBac.Text = itemCapBac.SubItems[2].Text;
            txtNguongVuotTroi.Text = itemCapBac.SubItems[3].Text;
        }
        #endregion  
      
        #region Load danh sach Diem.
        private void tpgThangDiem_Enter(object sender, EventArgs e)
        {            
            LoadDanhSachDiem();
        }

        private void LoadDanhSachDiem()
        {
            try
            {                
                XuatDanhSachDiem(_lstThangDiem);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachDiem(List<DTO.ThangDiemDTO> lstDiem)
        {
            if (lstDiem == null)
                return;     //khong lam gi ca.          

            lsvDanhSachDiem.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.ThangDiemDTO aDiemTemp in lstDiem)
            {
                ListViewItem aItem = TheHienListItem(nSoThuTu, aDiemTemp);
                if(aItem != null)
                    lsvDanhSachDiem.Items.Add(aItem);
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.ThangDiemDTO aDiem)
        {
            if (aDiem == null)
                return null;

            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());            
            itemKetQua.SubItems.Add(aDiem.TenDiem);
            itemKetQua.SubItems.Add(aDiem.CongThucTinh);
            itemKetQua.Tag = aDiem;

            return itemKetQua;
        }

        private void lsvDanhSachDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachDiem.SelectedItems.Count > 0)
            {
                ListViewItem itemDiem = lsvDanhSachDiem.SelectedItems[0];                
                XuatChiTietDiem(itemDiem);
            }
        }

        private void XuatChiTietDiem(ListViewItem itemDiem)
        {
            if (itemDiem.SubItems.Count < 3)
                return;

            txtTenDiem.Text = itemDiem.SubItems[1].Text;
            txtCongThucTinh.Text = itemDiem.SubItems[2].Text;
        }
        #endregion               

        #region Load danh sach ThachDau
        private void tpgThachDau_Enter(object sender, EventArgs e)
        {            
            LoadDanhSachThachDau();
        }

        private void LoadDanhSachThachDau()
        {
            try
            {                
                XuatDanhSachThachDau(_lstThachDau);                

                //Load danh sach nguoi quan ly.
                List<HoiVienDTO> lstNguoiQuanLy = HoiVienBUS.CopyListHoiVien(_lstHoiVien);
                cmbNguoiQuanLy.DataSource = lstNguoiQuanLy;
                cmbNguoiQuanLy.DisplayMember = "MSSV";
                cmbNguoiQuanLy.ValueMember = "IDHoiVien";
                cmbNguoiQuanLy.Text = String.Empty;                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachThachDau(List<DTO.ThachDauDTO> lstThachDau)
        {
            if (lstThachDau == null)
                return;     //khong lam gi ca.          

            lsvThachDau.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.ThachDauDTO aThachDauTemp in lstThachDau)
            {
                ListViewItem aItem = TheHienListItem(nSoThuTu, aThachDauTemp);
                if(aItem != null)
                    lsvThachDau.Items.Add(aItem);
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.ThachDauDTO aThachDau)
        {
            if (aThachDau == null)
                return null;

            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aThachDau.ThoiGian.ToString());
            itemKetQua.SubItems.Add(aThachDau.DiaDiem);

            HoiVienDTO aHoiVien = HoiVienBUS.LayHoiVienTheoID(aThachDau.NguoiQuanLy, _lstHoiVien);
            if (aHoiVien != null)
                itemKetQua.SubItems.Add(aHoiVien.HoTen);
            else
                itemKetQua.SubItems.Add(HoiVienBUS.LayHoiVienMacDinh(_lstHoiVien).HoTen);

            itemKetQua.Tag = aThachDau;
            return itemKetQua;
        }

        private void lsvThachDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvThachDau.SelectedItems.Count > 0)
            {
                ListViewItem itemThachDau = lsvThachDau.SelectedItems[0];                
                XuatChiTietThachDau(itemThachDau);
            }
        }

        private void XuatChiTietThachDau(ListViewItem itemThachDau)
        {
            if (itemThachDau == null)
                return;

            ThachDauDTO aThachDau = (ThachDauDTO)itemThachDau.Tag;
            dtpThoiGian.Value = aThachDau.ThoiGian;
            txtDiaDiem.Text = aThachDau.DiaDiem;            

            HoiVienDTO aHoiVien = HoiVienBUS.LayHoiVienTheoID(aThachDau.NguoiQuanLy, _lstHoiVien);
            if (aHoiVien != null)
                cmbNguoiQuanLy.Text = aHoiVien.MSSV;
            else
                cmbNguoiQuanLy.Text = HoiVienBUS.LayHoiVienMacDinh(_lstHoiVien).MSSV;
        }
        #endregion
        #endregion

        #region Them thong tin HoiVien, CapBac, ThangDiem, ThachDau.

        #region Them HoiVien.

        private void btnThemHoiVien_Click(object sender, EventArgs e)
        {
            DTO.HoiVienDTO aHoiVien = NhapHoiVien();
            if (aHoiVien == null)
                return; //khong lam gi ca.  
            
            try
            {                
                if (BUS.HoiVienBUS.ThemHoiVien(aHoiVien))
                {
                    String strSapXepHoiVien = " Order By MSSV";
                    _lstHoiVien = HoiVienBUS.DocDanhSachHoiVien(String.Empty, strSapXepHoiVien);

                    ListViewItem aItem = TheHienListItem(lsvDanhSachHoiVien.Items.Count + 1, aHoiVien);
                    lsvDanhSachHoiVien.Items.Add(aItem);
                    ClearFrmHoiVien();                    

                    foreach(ThangDiemDTO aDiem in _lstThangDiem)
                    {
                        DiemHoiVienDTO aDiemHoiVien = new DiemHoiVienDTO();
                        aDiemHoiVien.MaDiem = aDiem.IDDiem;
                        aDiemHoiVien.MaHoiVien = aHoiVien.IDHoiVien;
                        aDiemHoiVien.GiaTri = 0;

                        DiemHoiVienBUS.ThemDiemHoiVien(aDiemHoiVien);
                    }
                }
                else
                {
                    MessageBox.Show("Vui long kiem tra du lieu nhap");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }

        private DTO.HoiVienDTO NhapHoiVien()
        {
            DTO.HoiVienDTO aHoiVien = new DTO.HoiVienDTO();
            if (!KiemTraNhapHoiVien())
                return null;

            aHoiVien.MSSV = txtMSSV.Text;
            aHoiVien.HoTen = txtTenHoiVien.Text;            
            aHoiVien.MaCapBac = int.Parse(cmbCapBac.SelectedValue.ToString());

            return aHoiVien;
        }

        private bool KiemTraNhapHoiVien()
        {
            bool blnKetQua = true;

            blnKetQua &= !String.IsNullOrEmpty(txtMSSV.Text);
            blnKetQua &= !String.IsNullOrEmpty(txtTenHoiVien.Text);            
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            return blnKetQua;
        }

        private void ClearFrmHoiVien()
        {
            txtMSSV.Text = String.Empty;
            txtTenHoiVien.Text = String.Empty;            
        }
        #endregion       

        #region Them CapBac.

        private void btnThemCapBac_Click(object sender, EventArgs e)
        {
            DTO.CapBacDTO aCapBac = NhapCapBac();
            if (aCapBac == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.CapBacBUS.ThemCapBac(aCapBac))
                {
                    String strSapXepCapBac = " Order By ChiSoCapbac";
                    _lstCapBac = CapBacBUS.DocDanhSachCapBac(String.Empty, strSapXepCapBac);

                    ListViewItem aItem = TheHienListItem(lsvDanhSachCapBac.Items.Count + 1, aCapBac);
                    lsvDanhSachCapBac.Items.Add(aItem);
                    ClearFrmCapBac();
                }
                else
                {
                    MessageBox.Show("Vui long kiem tra du lieu nhap");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }

        private DTO.CapBacDTO NhapCapBac()
        {
            DTO.CapBacDTO aCapBac = new DTO.CapBacDTO();
            if (!KiemTraNhapCapBac())
                return null;

            aCapBac.ChiSoCapBac= int.Parse(txtChiSoCapBac.Text);
            aCapBac.TenCapBac = txtTenCapBac.Text;
            aCapBac.NguongVuotTroi = double.Parse(txtNguongVuotTroi.Text);

            return aCapBac;
        }

        private bool KiemTraNhapCapBac()
        {
            bool blnKetQua = true;

            blnKetQua &= !String.IsNullOrEmpty(txtChiSoCapBac.Text);
            blnKetQua &= !String.IsNullOrEmpty(txtTenCapBac.Text);
            blnKetQua &= !String.IsNullOrEmpty(txtNguongVuotTroi.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            return blnKetQua;
        }

        private void ClearFrmCapBac()
        {
            txtChiSoCapBac.Text = String.Empty;
            txtTenCapBac.Text = String.Empty;
            txtNguongVuotTroi.Text = String.Empty;
        }
        #endregion

        #region Them Diem.        

        private void btnThemDiem_Click(object sender, EventArgs e)
        {
            DTO.ThangDiemDTO aDiem = NhapDiem();
            if (aDiem == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.ThangDiemBUS.ThemDiem(aDiem))
                {
                    String strSapXepThangDiem = " Order By CongThucTinh";
                    _lstThangDiem = ThangDiemBUS.DocDanhSachDiem(String.Empty, strSapXepThangDiem);

                    ListViewItem aItem = TheHienListItem(lsvDanhSachDiem.Items.Count + 1, aDiem);
                    lsvDanhSachDiem.Items.Add(aItem);
                    ClearFrmDiem();
                    
                    foreach(HoiVienDTO aHoiVien in _lstHoiVien)
                    {
                        DiemHoiVienDTO aDiemHoiVien = new DiemHoiVienDTO();
                        aDiemHoiVien.MaDiem = aDiem.IDDiem;
                        aDiemHoiVien.MaHoiVien = aHoiVien.IDHoiVien;
                        aDiemHoiVien.GiaTri = 0;

                        DiemHoiVienBUS.ThemDiemHoiVien(aDiemHoiVien);
                    }
                }
                else
                {
                    MessageBox.Show("Vui long kiem tra du lieu nhap");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }

        private DTO.ThangDiemDTO NhapDiem()
        {
            DTO.ThangDiemDTO aDiem = new DTO.ThangDiemDTO();
            if (!KiemTraNhapDiem())
                return null;
            
            aDiem.TenDiem = txtTenDiem.Text;
            aDiem.CongThucTinh = txtCongThucTinh.Text;

            return aDiem;
        }

        private bool KiemTraNhapDiem()
        {
            bool blnKetQua = true;
            
            blnKetQua &= !String.IsNullOrEmpty(txtTenDiem.Text);
            blnKetQua &= !String.IsNullOrEmpty(txtCongThucTinh.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            return blnKetQua;
        }

        private void ClearFrmDiem()
        {            
            txtTenDiem.Text = String.Empty;
            txtCongThucTinh.Text = String.Empty;
        }
        #endregion        
        
        #region Them ThachDau        
        private void btnThemThachDau_Click(object sender, EventArgs e)
        {
            //Moi ngay chi co mot dot thach dau.            
            ThachDauDTO aThachDauTam = ThachDauBUS.LayThachDauTheoNgay(dtpThoiGian.Value);
            if (aThachDauTam != null)
            {
                MessageBox.Show("ThachDau cho ngay duoc chon da ton tai");
                return;
            }

            DTO.ThachDauDTO aThachDau = NhapThachDau();
            if (aThachDau == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.ThachDauBUS.ThemThachDau(aThachDau))
                {
                    String strSapXepThachDau = " Order By ThoiGian DESC";
                    _lstThachDau = ThachDauBUS.DocDanhSachThachDau(String.Empty, strSapXepThachDau);

                    ListViewItem aItem = TheHienListItem(lsvThachDau.Items.Count + 1, aThachDau);
                    lsvThachDau.Items.Add(aItem);
                    ClearFrmThachDau();
                }
                else
                {
                    MessageBox.Show("Vui long kiem tra du lieu nhap");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }  

        private DTO.ThachDauDTO NhapThachDau()
        {
            DTO.ThachDauDTO aThachDau = new DTO.ThachDauDTO();
            if (!KiemTraNhapThachDau())
                return null;

            HoiVienDTO aHoiVien = HoiVienBUS.LayHoiVienTheoMSSV(cmbNguoiQuanLy.Text, _lstHoiVien);
            if (aHoiVien == null)
            {
                MessageBox.Show("Nguoi quan li khong ton tai");
                return null;
            }

            aThachDau.ThoiGian = dtpThoiGian.Value;
            aThachDau.DiaDiem = txtDiaDiem.Text;
            aThachDau.NguoiQuanLy = aHoiVien.IDHoiVien;

            return aThachDau;
        }

        private bool KiemTraNhapThachDau()
        {
            bool blnKetQua = true;

            blnKetQua &= !String.IsNullOrEmpty(dtpThoiGian.Text);
            blnKetQua &= !String.IsNullOrEmpty(txtDiaDiem.Text);
            blnKetQua &= !String.IsNullOrEmpty(cmbNguoiQuanLy.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            return blnKetQua;
        }

        private void ClearFrmThachDau()
        {
            txtDiaDiem.Text = String.Empty;
            cmbNguoiQuanLy.Text = String.Empty;            
        }
        #endregion         

        #endregion

        #region Xoa thong tin HoiVien, CapBac, ThangDiem, ThachDau.

        #region Xoa HoiVien.

        private void btnXoaHoiVien_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co chac muon xoa hoi vien duoc chon\n\rMoi thong tin ve hoi vien se bi xoa va khong khoi phuc lai duoc.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                #region Xoa nhieu hoi vien
                if (lsvDanhSachHoiVien.CheckedItems.Count > 0)
                {
                    try
                    {
                        HoiVienDTO aHoiVienMacDinh = HoiVienBUS.LayHoiVienMacDinh(_lstHoiVien);
                        String strSapXepDiemHoiVien = " Order By MaHoiVien";
                        List<DiemHoiVienDTO> _lstDiemHoiVien = DiemHoiVienBUS.DocDanhSachDiemHoiVien(String.Empty, strSapXepDiemHoiVien);

                        foreach (ListViewItem itemHoiVien in lsvDanhSachHoiVien.CheckedItems)
                        {
                            DTO.HoiVienDTO aHoiVien = (DTO.HoiVienDTO)itemHoiVien.Tag;
                            if (aHoiVien.MSSV == "Default")
                            {
                                MessageBox.Show("Ban khong duoc xoa hoi vien MacDinh cua he thong", "Warning", MessageBoxButtons.OK);
                                return;
                            }

                            if (BUS.HoiVienBUS.XoaHoiVien(aHoiVien))
                            {
                                lsvDanhSachHoiVien.Items.Remove(itemHoiVien);

                                List<DiemHoiVienDTO> lstDiemHoiVien = DiemHoiVienBUS.LayDSDiemTheoHoiVien(aHoiVien.IDHoiVien, _lstDiemHoiVien);
                                foreach (DiemHoiVienDTO aDiemHoiVien in lstDiemHoiVien)
                                {
                                    DiemHoiVienBUS.XoaDiemHoiVien(aDiemHoiVien);
                                }

                                List<ThachDauDTO> lstThachDau = ThachDauBUS.LayDSThachDauTheoNQL(aHoiVien.IDHoiVien, _lstThachDau);
                                foreach (ThachDauDTO aThachDau in lstThachDau)
                                {
                                    aThachDau.NguoiQuanLy = HoiVienBUS.LayHoiVienMacDinh(_lstHoiVien).IDHoiVien;
                                    ThachDauBUS.CapNhatThachDau(aThachDau);
                                }

                                String strLayDSChiTietThachDau = " Where MaHoiVien1 = " + aHoiVien.IDHoiVien.ToString() + " OR MaHoiVien2 = " + aHoiVien.IDHoiVien.ToString();
                                List<ChiTietThachDauDTO> lstChiTietThachDau = ChiTietThachDauBUS.DocDanhSachChiTietThachDau(strLayDSChiTietThachDau);
                                foreach (ChiTietThachDauDTO aChiTietThachDau in lstChiTietThachDau)
                                {
                                    if (aChiTietThachDau.MaHoiVien1 == aHoiVien.IDHoiVien)
                                        aChiTietThachDau.MaHoiVien1 = aHoiVienMacDinh.IDHoiVien;

                                    if (aChiTietThachDau.MaHoiVien2 == aHoiVien.IDHoiVien)
                                        aChiTietThachDau.MaHoiVien2 = aHoiVienMacDinh.IDHoiVien;

                                    ChiTietThachDauBUS.CapNhatChiTietThachDau(aChiTietThachDau);
                                }
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                #endregion

                #region Xoa mot hoi vien
                else
                {
                    if (lsvDanhSachHoiVien.SelectedItems.Count > 0)
                    {
                        try
                        {
                            HoiVienDTO aHoiVienMacDinh = HoiVienBUS.LayHoiVienMacDinh(_lstHoiVien);

                            foreach (ListViewItem itemHoiVien in lsvDanhSachHoiVien.SelectedItems)
                            {
                                DTO.HoiVienDTO aHoiVien = (DTO.HoiVienDTO)itemHoiVien.Tag;
                                if(aHoiVien.MSSV == "Default")
                                {
                                    MessageBox.Show("Ban khong duoc xoa hoi vien MacDinh cua he thong", "Warning", MessageBoxButtons.OK);
                                    return;
                                }
                                
                                if (BUS.HoiVienBUS.XoaHoiVien(aHoiVien))
                                {
                                    lsvDanhSachHoiVien.Items.Remove(itemHoiVien);

                                    String strLayDSDiemHoiVien = " Where MaHoiVien = " + aHoiVien.IDHoiVien.ToString();
                                    List<DiemHoiVienDTO> lstDiemHoiVien = DiemHoiVienBUS.DocDanhSachDiemHoiVien(strLayDSDiemHoiVien);
                                    foreach (DiemHoiVienDTO aDiemHoiVien in lstDiemHoiVien)
                                    {
                                        DiemHoiVienBUS.XoaDiemHoiVien(aDiemHoiVien);
                                    }

                                    List<ThachDauDTO> lstThachDau = ThachDauBUS.LayDSThachDauTheoNQL(aHoiVien.IDHoiVien, _lstThachDau);
                                    foreach (ThachDauDTO aThachDau in lstThachDau)
                                    {
                                        aThachDau.NguoiQuanLy = HoiVienBUS.LayHoiVienMacDinh(_lstHoiVien).IDHoiVien;
                                        ThachDauBUS.CapNhatThachDau(aThachDau);
                                    }

                                    String strLayDSChiTietThachDau = " Where MaHoiVien1 = " + aHoiVien.IDHoiVien.ToString() + " OR MaHoiVien2 = " + aHoiVien.IDHoiVien.ToString();
                                    List<ChiTietThachDauDTO> lstChiTietThachDau = ChiTietThachDauBUS.DocDanhSachChiTietThachDau(strLayDSChiTietThachDau);
                                    foreach (ChiTietThachDauDTO aChiTietThachDau in lstChiTietThachDau)
                                    {
                                        if (aChiTietThachDau.MaHoiVien1 == aHoiVien.IDHoiVien)
                                            aChiTietThachDau.MaHoiVien1 = aHoiVienMacDinh.IDHoiVien;

                                        if (aChiTietThachDau.MaHoiVien2 == aHoiVien.IDHoiVien)
                                            aChiTietThachDau.MaHoiVien2 = aHoiVienMacDinh.IDHoiVien;

                                        ChiTietThachDauBUS.CapNhatChiTietThachDau(aChiTietThachDau);
                                    }
                                }
                            }
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("Exception: " + ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("Chua co hoi vien nao duoc chon");
                }
                #endregion

                #region Cap nhat danh sach HoiVien va ThachDau
                try
                {
                    String strSapXepHoiVien = " Order By MSSV";
                    _lstHoiVien = HoiVienBUS.DocDanhSachHoiVien(String.Empty, strSapXepHoiVien);
                    String strSapXepThachDau = " Order By ThoiGian DESC";
                    _lstThachDau = ThachDauBUS.DocDanhSachThachDau(String.Empty, strSapXepThachDau);
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
                #endregion
            }           
        }        

        private void chkChonTatCaHoiVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonTatCaHoiVien.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemHoiVien in lsvDanhSachHoiVien.Items)
                {
                    itemHoiVien.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemHoiVien in lsvDanhSachHoiVien.Items)
                {
                    itemHoiVien.Checked = false;
                }
            }
        }
        #endregion

        #region Xoa CapBac.        

        private void btnXoaCapBac_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon xoa cap bac duoc chon?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                #region Xoa nhieu cap bac mot luc
                if (lsvDanhSachCapBac.CheckedItems.Count > 0)
                {
                    try
                    {
                        CapBacDTO aCapBacMacDinh = CapBacBUS.LayCapBacMacDinh(_lstCapBac);
                        foreach (ListViewItem itemCapBac in lsvDanhSachCapBac.CheckedItems)
                        {
                            DTO.CapBacDTO aCapBac = (DTO.CapBacDTO)itemCapBac.Tag;
                            if (aCapBac.TenCapBac == "Default")
                            {
                                MessageBox.Show("Ban khong duoc xoa CapBacMacDinh cua he thong", "Warning", MessageBoxButtons.OK);
                                return;
                            }

                            if (BUS.CapBacBUS.XoaCapBac(aCapBac))
                            {
                                lsvDanhSachCapBac.Items.Remove(itemCapBac);

                                List<HoiVienDTO> lstHoiVien = HoiVienBUS.LayDSHoiVienTheoCapBac(aCapBac.IDCapBac, _lstHoiVien);
                                foreach (HoiVienDTO aHoiVien in lstHoiVien)
                                {
                                    aHoiVien.MaCapBac = aCapBacMacDinh.IDCapBac;
                                    HoiVienBUS.CapNhatHoiVien(aHoiVien);
                                }
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                #endregion

                #region Xoa mot cap bac
                else
                {
                    if (lsvDanhSachCapBac.SelectedItems.Count > 0)
                    {
                        try
                        {
                            CapBacDTO aCapBacMacDinh = CapBacBUS.LayCapBacMacDinh(_lstCapBac);
                            foreach (ListViewItem itemCapBac in lsvDanhSachCapBac.SelectedItems)
                            {
                                DTO.CapBacDTO aCapBac = (DTO.CapBacDTO)itemCapBac.Tag;
                                if (aCapBac.TenCapBac == "Default")
                                {
                                    MessageBox.Show("Ban khong duoc xoa CapBacMacDinh cua he thong", "Warning", MessageBoxButtons.OK);
                                    return;
                                }

                                if (BUS.CapBacBUS.XoaCapBac(aCapBac))
                                {
                                    lsvDanhSachCapBac.Items.Remove(itemCapBac);

                                    List<HoiVienDTO> lstHoiVien = HoiVienBUS.LayDSHoiVienTheoCapBac(aCapBac.IDCapBac, _lstHoiVien);
                                    foreach (HoiVienDTO aHoiVien in lstHoiVien)
                                    {
                                        aHoiVien.MaCapBac = CapBacBUS.LayCapBacMacDinh().IDCapBac;
                                        HoiVienBUS.CapNhatHoiVien(aHoiVien);
                                    }
                                }
                            }
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("Exception: " + ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("Chua co cap bac nao duoc chon");
                }
                #endregion

                #region Cap nhat danh sach HoiVien va CapBac
                String strSapXepHoiVien = " Order By MSSV";
                _lstHoiVien = HoiVienBUS.DocDanhSachHoiVien(String.Empty, strSapXepHoiVien);
                String strSapXepCapBac = " Order By ChiSoCapbac";
                _lstCapBac = CapBacBUS.DocDanhSachCapBac(String.Empty, strSapXepCapBac);
                #endregion
            }           
        }

        private void chkChonTatCaCapBac_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonTatCaCapBac.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemCapBac in lsvDanhSachCapBac.Items)
                {
                    itemCapBac.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemCapBac in lsvDanhSachCapBac.Items)
                {
                    itemCapBac.Checked = false;
                }
            }
        }
        #endregion

        #region Xoa Diem.       

        private void btnXoaDiem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon xoa ThangDiem duoc chon ?\n\rDiem cua tat ca hoi vien lien quan cung se bi xoa", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                #region Xoa nhieu ThangDiem.
                if (lsvDanhSachDiem.CheckedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemDiem in lsvDanhSachDiem.CheckedItems)
                        {
                            DTO.ThangDiemDTO aDiem = (DTO.ThangDiemDTO)itemDiem.Tag;

                            if (BUS.ThangDiemBUS.XoaDiem(aDiem))
                            {
                                lsvDanhSachDiem.Items.Remove(itemDiem);

                                String strLayDSDiemHoiVien = " Where MaDiem = " + aDiem.IDDiem.ToString();
                                List<DiemHoiVienDTO> lstDiemHoiVien = DiemHoiVienBUS.DocDanhSachDiemHoiVien(strLayDSDiemHoiVien);
                                foreach (DiemHoiVienDTO aDiemHoiVien in lstDiemHoiVien)
                                {
                                    DiemHoiVienBUS.XoaDiemHoiVien(aDiemHoiVien);
                                }
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                #endregion

                #region Xoa ThangDiem
                else
                {
                    if (lsvDanhSachDiem.SelectedItems.Count > 0)
                    {
                        try
                        {
                            foreach (ListViewItem itemDiem in lsvDanhSachDiem.SelectedItems)
                            {
                                DTO.ThangDiemDTO aDiem = (DTO.ThangDiemDTO)itemDiem.Tag;

                                if (BUS.ThangDiemBUS.XoaDiem(aDiem))
                                {
                                    lsvDanhSachDiem.Items.Remove(itemDiem);

                                    String strLayDSDiemHoiVien = " Where MaDiem = " + aDiem.IDDiem.ToString();
                                    List<DiemHoiVienDTO> lstDiemHoiVien = DiemHoiVienBUS.DocDanhSachDiemHoiVien(strLayDSDiemHoiVien);
                                    foreach (DiemHoiVienDTO aDiemHoiVien in lstDiemHoiVien)
                                    {
                                        DiemHoiVienBUS.XoaDiemHoiVien(aDiemHoiVien);
                                    }
                                }
                            }
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("Exception: " + ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("Chua co thang diem nao duoc chon");
                }
                #endregion

                String strSapXepThangDiem = " Order By CongThucTinh";
                _lstThangDiem = ThangDiemBUS.DocDanhSachDiem(String.Empty, strSapXepThangDiem);
            }
        }

        private void chkChonTatCaDiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonTatCaDiem.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemDiem in lsvDanhSachDiem.Items)
                {
                    itemDiem.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemDiem in lsvDanhSachDiem.Items)
                {
                    itemDiem.Checked = false;
                }
            }
        }
        #endregion              
      
        #region Xoa ThachDau.
        private void btnXoaThachDau_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co chac muon xoa ThachDau duoc chon?\n\rTat ca tran dau dien ra trong ngay cung se bi xoa", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                #region Xoa nhieu ThachDau
                if (lsvThachDau.CheckedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemThachDau in lsvThachDau.CheckedItems)
                        {
                            DTO.ThachDauDTO aThachDau = (DTO.ThachDauDTO)itemThachDau.Tag;

                            if (BUS.ThachDauBUS.XoaThachDau(aThachDau))
                            {
                                lsvThachDau.Items.Remove(itemThachDau);

                                String strLayDSChiTietThachDau = " Where MaThachDau = " + aThachDau.IDThachDau.ToString();
                                List<ChiTietThachDauDTO> lstChiTietThachDau = ChiTietThachDauBUS.DocDanhSachChiTietThachDau(strLayDSChiTietThachDau);
                                foreach (ChiTietThachDauDTO aChiTietThachDau in lstChiTietThachDau)
                                {
                                    ChiTietThachDauBUS.XoaChiTietThachDau(aChiTietThachDau);
                                }
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                #endregion

                #region Xoa ThachDau
                else
                {
                    if (lsvThachDau.SelectedItems.Count > 0)
                    {
                        try
                        {
                            foreach (ListViewItem itemThachDau in lsvThachDau.SelectedItems)
                            {
                                DTO.ThachDauDTO aThachDau = (DTO.ThachDauDTO)itemThachDau.Tag;
                                if (BUS.ThachDauBUS.XoaThachDau(aThachDau))
                                {
                                    lsvThachDau.Items.Remove(itemThachDau);

                                    String strLayDSChiTietThachDau = " Where MaThachDau = " + aThachDau.IDThachDau.ToString();
                                    List<ChiTietThachDauDTO> lstChiTietThachDau = ChiTietThachDauBUS.DocDanhSachChiTietThachDau(strLayDSChiTietThachDau);
                                    foreach (ChiTietThachDauDTO aChiTietThachDau in lstChiTietThachDau)
                                    {
                                        ChiTietThachDauBUS.XoaChiTietThachDau(aChiTietThachDau);
                                    }
                                }
                            }
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("Exception: " + ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("Chua co thach dau nao duoc chon");
                }
                #endregion

                String strSapXepThachDau = " Order By ThoiGian DESC";
                _lstThachDau = ThachDauBUS.DocDanhSachThachDau(String.Empty, strSapXepThachDau);
            }         
        }

        private void chkChonTatCaThachDau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonTatCaThachDau.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemThachDau in lsvThachDau.Items)
                {
                    itemThachDau.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemThachDau in lsvThachDau.Items)
                {
                    itemThachDau.Checked = false;
                }
            }
        }   
        #endregion
        #endregion

        #region Sua thong tin HoiVien, CapBac, ThangDiem, ThachDau.        

        #region Sua HoiVien

        private void btnSuaHoiVien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon thay doi thong tin HoiVien duoc chon", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lsvDanhSachHoiVien.CheckedItems.Count > 0)
                {
                    int nMaCapBac = int.Parse(cmbCapBac.SelectedValue.ToString());
                    try
                    {
                        foreach (ListViewItem itemHoiVien in lsvDanhSachHoiVien.CheckedItems)
                        {
                            DTO.HoiVienDTO aHoiVien = (DTO.HoiVienDTO)itemHoiVien.Tag;
                            aHoiVien.MaCapBac = nMaCapBac;

                            if (HoiVienBUS.CapNhatHoiVien(aHoiVien))
                            {
                                ListViewItem aItem = TheHienListItem(itemHoiVien.Index, aHoiVien);
                                lsvDanhSachHoiVien.Items[itemHoiVien.Index] = aItem;
                                ClearFrmHoiVien();
                            }
                        }

                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                {
                    if (lsvDanhSachHoiVien.SelectedItems.Count > 0)
                    {
                        try
                        {
                            foreach (ListViewItem itemHoiVien in lsvDanhSachHoiVien.SelectedItems)
                            {
                                DTO.HoiVienDTO aHoiVien = NhapHoiVien();
                                if (aHoiVien == null)
                                    return; //khong lam gi ca.   

                                aHoiVien.IDHoiVien = ((DTO.HoiVienDTO)itemHoiVien.Tag).IDHoiVien;
                                if (HoiVienBUS.CapNhatHoiVien(aHoiVien))
                                {
                                    ListViewItem aItem = TheHienListItem(itemHoiVien.Index, aHoiVien);
                                    lsvDanhSachHoiVien.Items[itemHoiVien.Index] = aItem;
                                    ClearFrmHoiVien();
                                }
                            }

                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("Exception: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chua co hoi vien nao dc chon");
                    }
                }
            }                                             
        }
        #endregion

        #region Sua CapBac

        private void btnSuaCapBac_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon thay doi thong tin CapBac duoc chon?\n\rChu y han che thay doi chi so CapBac", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lsvDanhSachCapBac.CheckedItems.Count > 0)
                {
                    double dNguongVuotTroi = double.Parse(txtNguongVuotTroi.Text);
                    try
                    {
                        foreach (ListViewItem itemCapBac in lsvDanhSachCapBac.CheckedItems)
                        {
                            DTO.CapBacDTO aCapBac = (DTO.CapBacDTO)itemCapBac.Tag;
                            aCapBac.NguongVuotTroi = dNguongVuotTroi;

                            if (CapBacBUS.CapNhatCapBac(aCapBac))
                            {
                                ListViewItem aItem = TheHienListItem(itemCapBac.Index, aCapBac);
                                lsvDanhSachCapBac.Items[itemCapBac.Index] = aItem;
                                ClearFrmCapBac();
                            }
                        }

                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                {
                    if (lsvDanhSachCapBac.SelectedItems.Count > 0)
                    {
                        try
                        {
                            foreach (ListViewItem itemCapBac in lsvDanhSachCapBac.SelectedItems)
                            {
                                DTO.CapBacDTO aCapBac = NhapCapBac();
                                if (aCapBac == null)
                                    return; //khong lam gi ca.   

                                aCapBac.IDCapBac = ((DTO.CapBacDTO)itemCapBac.Tag).IDCapBac;
                                if (CapBacBUS.CapNhatCapBac(aCapBac))
                                {
                                    ListViewItem aItem = TheHienListItem(itemCapBac.Index, aCapBac);
                                    lsvDanhSachCapBac.Items[itemCapBac.Index] = aItem;
                                    ClearFrmCapBac();
                                }
                            }

                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("Exception: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chua co cap bac nao dc chon");
                    }
                } 
            }               
        }
        
        #endregion               

        #region Sua Diem
        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon thay doi ThangDiem duoc chon?\n\rChu y thay doi MaCongThuc tinh se anh huong den viec tinh diem HoiVien ", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lsvDanhSachDiem.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemDiem in lsvDanhSachDiem.SelectedItems)
                        {
                            DTO.ThangDiemDTO aDiem = NhapDiem();
                            if (aDiem == null)
                                return; //khong lam gi ca.   

                            aDiem.IDDiem = ((DTO.ThangDiemDTO)itemDiem.Tag).IDDiem;
                            if (ThangDiemBUS.CapNhatDiem(aDiem))
                            {
                                ListViewItem aItem = TheHienListItem(itemDiem.Index, aDiem);
                                lsvDanhSachDiem.Items[itemDiem.Index] = aItem;
                                ClearFrmDiem();
                            }
                        }

                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Chua co thang diem nao dc chon");
                }  
            }            
        }
        #endregion        
       
        #region Sua ThachDau

        private void btnSuaThachDau_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon thay doi thong tin ThachDau duoc chon?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lsvThachDau.CheckedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemThachDau in lsvThachDau.CheckedItems)
                        {
                            DTO.ThachDauDTO aThachDau = (DTO.ThachDauDTO)itemThachDau.Tag;

                            if (txtDiaDiem.Text != String.Empty)
                                aThachDau.DiaDiem = txtDiaDiem.Text;

                            HoiVienDTO aHoiVien = HoiVienBUS.LayHoiVienTheoMSSV(cmbNguoiQuanLy.Text);
                            if (aHoiVien != null)
                                aThachDau.NguoiQuanLy = aHoiVien.IDHoiVien;
                            if (ThachDauBUS.CapNhatThachDau(aThachDau))
                            {
                                ListViewItem aItem = TheHienListItem(itemThachDau.Index, aThachDau);
                                lsvThachDau.Items[itemThachDau.Index] = aItem;
                                ClearFrmThachDau();
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                {
                    if (lsvThachDau.SelectedItems.Count > 0)
                    {
                        try
                        {
                            foreach (ListViewItem itemThachDau in lsvThachDau.SelectedItems)
                            {
                                DTO.ThachDauDTO aThachDau = NhapThachDau();
                                if (aThachDau == null)
                                    return; //khong lam gi ca.   

                                aThachDau.IDThachDau = ((DTO.ThachDauDTO)itemThachDau.Tag).IDThachDau;
                                if (ThachDauBUS.CapNhatThachDau(aThachDau))
                                {
                                    ListViewItem aItem = TheHienListItem(itemThachDau.Index, aThachDau);
                                    lsvThachDau.Items[itemThachDau.Index] = aItem;
                                    ClearFrmThachDau();
                                }
                            }
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("Exception: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chua co thach dau nao dc chon");
                    }
                }
            }            
        }   
        #endregion
        #endregion

        #region TraCuu va su kien khac
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCapBac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                String strLayHoiVien = String.Empty;
                if (cmbCapBac.Text != String.Empty)
                {
                    String strLayCapBac = " Where TenCapBac like '%" + cmbCapBac.Text + "%'";
                    List<CapBacDTO> lstCapBac = CapBacBUS.DocDanhSachCapBac(strLayCapBac);
                    if (lstCapBac.Count > 0)
                    {
                        strLayHoiVien = " Where ";
                        for (int i = 0; i < lstCapBac.Count; i++)
                        {
                            strLayHoiVien += " MaCapBac = " + lstCapBac[i].IDCapBac.ToString();
                            if (i < lstCapBac.Count - 1)
                                strLayHoiVien += " Or ";
                        }
                    }
                }
                String strSapXepHoiVien = " Order By MSSV";
                List<HoiVienDTO> lstHoiVien = HoiVienBUS.DocDanhSachHoiVien(strLayHoiVien, strSapXepHoiVien);
                XuatDanhSachHoiVien(lstHoiVien);
            }
        }

        private void txtDiaDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                String strLayThachDau = String.Empty;
                if (txtDiaDiem.Text != String.Empty)
                    strLayThachDau = " Where DiaDiem like '%" + txtDiaDiem.Text + "%'";

                String strSapXepThachDau = " Order By ThoiGian";
                List<ThachDauDTO> lstThachDau = ThachDauBUS.DocDanhSachThachDau(strLayThachDau, strSapXepThachDau);
                XuatDanhSachThachDau(lstThachDau);
            }
        }

        private void cmbNguoiQuanLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                String strLayThachDau = String.Empty;
                if (cmbNguoiQuanLy.Text != String.Empty)
                {
                    String strLayNguoiQuanLy = " Where MSSV like '%" + cmbNguoiQuanLy.Text + "%'";
                    List<HoiVienDTO> lstNguoiQuanLy = HoiVienBUS.DocDanhSachHoiVien(strLayNguoiQuanLy);
                    if (lstNguoiQuanLy.Count > 0)
                    {
                        strLayThachDau = " Where ";
                        for (int i = 0; i < lstNguoiQuanLy.Count; i++)
                        {
                            strLayThachDau += " NguoiQuanLy = " + lstNguoiQuanLy[i].IDHoiVien;
                            if (i < lstNguoiQuanLy.Count - 1)
                                strLayThachDau += " Or ";
                        }
                    }
                }
                String strSapXepThachDau = " Order By ThoiGian";
                List<ThachDauDTO> lstThachDau = ThachDauBUS.DocDanhSachThachDau(strLayThachDau, strSapXepThachDau);
                XuatDanhSachThachDau(lstThachDau);
            }
        }
        #endregion                               
    }
}
