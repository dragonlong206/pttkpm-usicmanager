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
    public partial class CapNhatThachDauGUI : Form
    {
        private int[] arrKiemTra = new int[5];
        private List<HoiVienDTO> _lstHoiVien = new List<HoiVienDTO>();
        private List<ThachDauDTO> _lstThachDau = new List<ThachDauDTO>();
        private List<ThangDiemDTO> _lstThangDiem = new List<ThangDiemDTO>();
        private List<CapBacDTO> _lstCapBac = new List<CapBacDTO>();

        public CapNhatThachDauGUI()
        {
            InitializeComponent();            
        }

        private void CapNhatThachDauGUI_Activated(object sender, EventArgs e)
        {            
            String strSapXepHoiVien = " Order By MSSV";
            _lstHoiVien = HoiVienBUS.DocDanhSachHoiVien(String.Empty, strSapXepHoiVien);
            String strSapXepThachDau = " Order By ThoiGian DESC";
            _lstThachDau = ThachDauBUS.DocDanhSachThachDau(String.Empty, strSapXepThachDau);
            String strSapXepThangDiem = " Order By CongThucTinh";
            _lstThangDiem = ThangDiemBUS.DocDanhSachDiem(String.Empty, strSapXepThangDiem);            
            String strSapXepCapBac = " Order By ChiSoCapBac";
            _lstCapBac = CapBacBUS.DocDanhSachCapBac(String.Empty, strSapXepCapBac);
            DiemHoiVienBUS.ResetDanhSach(_lstHoiVien, _lstThangDiem, _lstCapBac);
            
            LoadCapNhatThachDau();
        }

        #region Load form cap nhat thach dau
        private void LoadCapNhatThachDau()
        {
            try
            {
                LoadCacTuyChonCombobox(_lstHoiVien);
                arrKiemTra[0] = 1;  //Bo qua su kien TimeChange.
                dtpThoiGian.Value = DateTime.Today;

                ThachDauDTO aThachDau = ThachDauBUS.LayThachDauTheoNgay(dtpThoiGian.Value, _lstThachDau);
                if (aThachDau != null)
                {
                    txtDiaDiem.Text = aThachDau.DiaDiem;
                    cmbNguoiQuanLy.SelectedValue = aThachDau.NguoiQuanLy;
                    btnThemThachDau.Enabled = false;

                    String strLayDSChiTietThachDau = " Where MaThachDau = " + aThachDau.IDThachDau.ToString();
                    List<ChiTietThachDauDTO> lstChiTietThachDau = ChiTietThachDauBUS.DocDanhSachChiTietThachDau(strLayDSChiTietThachDau);
                    XuatDanhSachChiTietThachDau(lstChiTietThachDau);
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            arrKiemTra[0] = 0;
        }

        private void LoadCacTuyChonCombobox(List<HoiVienDTO> lstHoiVien)
        {
            //Load danh sach NguoiQuanLy, ChiTietThachDau1, HoiVien2:

            List<HoiVienDTO> lstNguoiQuanLy = HoiVienBUS.CopyListHoiVien(lstHoiVien);
            if (lstNguoiQuanLy.Count > 0)
            {
                cmbNguoiQuanLy.DataSource = lstNguoiQuanLy;
                cmbNguoiQuanLy.DisplayMember = "MSSV";
                cmbNguoiQuanLy.ValueMember = "IDHoiVien";
                cmbNguoiQuanLy.Text = String.Empty;
            }
           
            List<HoiVienDTO> lstHoiVien1 = HoiVienBUS.CopyListHoiVien(lstHoiVien);
            if (lstHoiVien1.Count > 0)
            {
                cmbMaHoiVien1.DataSource = lstHoiVien1;
                cmbMaHoiVien1.DisplayMember = "MSSV";
                cmbMaHoiVien1.ValueMember = "IDHoiVien";
                cmbMaHoiVien1.Text = String.Empty;
            }

            List<HoiVienDTO> lstHoiVien2 = HoiVienBUS.CopyListHoiVien(lstHoiVien);
            if (lstHoiVien2.Count > 0)
            {
                cmbMaHoiVien2.DataSource = lstHoiVien2;
                cmbMaHoiVien2.DisplayMember = "MSSV";
                cmbMaHoiVien2.ValueMember = "IDHoiVien";
                cmbMaHoiVien2.Text = String.Empty;
            }
        }

        private void XuatDanhSachChiTietThachDau(List<ChiTietThachDauDTO> lstChiTietThachDau)
        {
            if (lstChiTietThachDau == null)
                return;     //khong lam gi ca.          

            lsvDanhSachChiTietThachDau.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.ChiTietThachDauDTO aChiTietThachDauTemp in lstChiTietThachDau)
            {
                ListViewItem aItem = TheHienListItem(nSoThuTu, aChiTietThachDauTemp);
                if(aItem != null)
                    lsvDanhSachChiTietThachDau.Items.Add(aItem);
                nSoThuTu++;
            }            
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.ChiTietThachDauDTO aChiTietThachDau)
        {
            if (aChiTietThachDau == null)
                return null;

            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());

            HoiVienDTO HoiVien1 = HoiVienBUS.LayHoiVienTheoID(aChiTietThachDau.MaHoiVien1, _lstHoiVien);
            if (HoiVien1 != null)
            {
                itemKetQua.SubItems.Add(HoiVien1.MSSV);
                itemKetQua.SubItems.Add(HoiVien1.HoTen);
            }
            else
            {
                itemKetQua.SubItems.Add(HoiVienBUS.LayHoiVienMacDinh(_lstHoiVien).MSSV);
                itemKetQua.SubItems.Add(HoiVienBUS.LayHoiVienMacDinh(_lstHoiVien).HoTen);
            }

            HoiVienDTO HoiVien2 = HoiVienBUS.LayHoiVienTheoID(aChiTietThachDau.MaHoiVien2, _lstHoiVien);
            if (HoiVien2 != null)
            {
                itemKetQua.SubItems.Add(HoiVien2.MSSV);
                itemKetQua.SubItems.Add(HoiVien2.HoTen);
            }
            else
            {
                itemKetQua.SubItems.Add(HoiVienBUS.LayHoiVienMacDinh(_lstHoiVien).MSSV);
                itemKetQua.SubItems.Add(HoiVienBUS.LayHoiVienMacDinh(_lstHoiVien).HoTen);
            }
            itemKetQua.SubItems.Add(aChiTietThachDau.KetQua);

            itemKetQua.Tag = aChiTietThachDau;
            return itemKetQua;
        }

        private void lsvDanhSachChiTietThachDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachChiTietThachDau.SelectedItems.Count > 0)
            {
                ListViewItem itemChiTietThachDau = lsvDanhSachChiTietThachDau.SelectedItems[0];                
                XuatChiTietThachDau(itemChiTietThachDau);
            }
        }

        private void XuatChiTietThachDau(ListViewItem itemChiTietThachDau)
        {
            if (itemChiTietThachDau.SubItems.Count < 6)
                return;
            
            cmbMaHoiVien1.Text = itemChiTietThachDau.SubItems[1].Text;
            txtTenHoiVien1.Text = itemChiTietThachDau.SubItems[2].Text;

            cmbMaHoiVien2.Text = itemChiTietThachDau.SubItems[3].Text;
            txtTenHoiVien2.Text = itemChiTietThachDau.SubItems[4].Text;

            cmbKetQua.Text = itemChiTietThachDau.SubItems[5].Text;                                                   
        }        

        private void ClearForm()
        {
            lsvDanhSachChiTietThachDau.Items.Clear();            
            cmbMaHoiVien1.Text = String.Empty;
            txtTenHoiVien1.Text = String.Empty;
            cmbMaHoiVien2.Text = String.Empty;
            txtTenHoiVien2.Text = String.Empty;
            cmbKetQua.Text = String.Empty;
            chkChonTatCa.CheckState = CheckState.Unchecked;
        }        
        #endregion        

        #region Them ThachDau va ChiTietThachDau.
        #region Them ThachDau      
        private void btnThemThachDau_Click(object sender, EventArgs e)
        {
            //Moi ngay chi co mot dot thach dau.            
            ThachDauDTO aThachDauTam = ThachDauBUS.LayThachDauTheoNgay(dtpThoiGian.Value, _lstThachDau);
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
                    MessageBox.Show("Them Thach Dau thanh cong!");

                    String strSapXepThachDau = " Order By ThoiGian DESC";
                    _lstThachDau = ThachDauBUS.DocDanhSachThachDau(String.Empty, strSapXepThachDau);
                    ClearForm();
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
                return null;
                       
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
                
        #endregion

        #region Them ChiTietThachDau               
        private void btnThemChiTietThachDau_Click(object sender, EventArgs e)
        {           
            DTO.ChiTietThachDauDTO aChiTietThachDau = NhapChiTietThachDau();
            if (aChiTietThachDau == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.ChiTietThachDauBUS.ThemChiTietThachDau(aChiTietThachDau))
                {            
        
                    ListViewItem aItem = TheHienListItem(lsvDanhSachChiTietThachDau.Items.Count + 1, aChiTietThachDau);
                    lsvDanhSachChiTietThachDau.Items.Add(aItem);                            
                    ClearFrmChiTietThachDau();
                    
                    if(DiemHoiVienBUS.TinhDiemThachDau(aChiTietThachDau, 1) == -1)                    
                        MessageBox.Show("HoiVien khong ton tai.\n\rHoac CSDL chua cap nhat");                                            
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

        private DTO.ChiTietThachDauDTO NhapChiTietThachDau()
        {
            DTO.ChiTietThachDauDTO aChiTietThachDau = new DTO.ChiTietThachDauDTO();
            if (!KiemTraNhapChiTietThachDau())
                return null;
            
            ThachDauDTO aThachDau = ThachDauBUS.LayThachDauTheoNgay(dtpThoiGian.Value, _lstThachDau);
            if (aThachDau == null)
            {
                MessageBox.Show("Can khoi tao ThachDau cho ngay hien tai truoc");
                return null;
            }

            HoiVienDTO aHoiVien1 = HoiVienBUS.LayHoiVienTheoMSSV(cmbMaHoiVien1.Text, _lstHoiVien);
            if (aHoiVien1 == null)
            {
                MessageBox.Show("HoiVien1: khong ton tai");
                return null;
            }
            HoiVienDTO aHoiVien2 = HoiVienBUS.LayHoiVienTheoMSSV(cmbMaHoiVien2.Text, _lstHoiVien);
            if (aHoiVien2 == null)
            {
                MessageBox.Show("HoiVien2: khong ton tai");
                return null;
            }

            aChiTietThachDau.MaThachDau = aThachDau.IDThachDau;
            aChiTietThachDau.MaHoiVien1 = aHoiVien1.IDHoiVien;
            aChiTietThachDau.MaHoiVien2 = aHoiVien2.IDHoiVien;                        
            aChiTietThachDau.KetQua = cmbKetQua.Text;
           
            return aChiTietThachDau;
        }

        private bool KiemTraNhapChiTietThachDau()
        {
            bool blnKetQua = true;
            
            blnKetQua &= !String.IsNullOrEmpty(cmbMaHoiVien1.Text);
            blnKetQua &= !String.IsNullOrEmpty(cmbMaHoiVien2.Text);
            blnKetQua &= !String.IsNullOrEmpty(cmbKetQua.Text);
            if (!blnKetQua)
            {                
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            blnKetQua = (cmbMaHoiVien1.Text != cmbMaHoiVien2.Text);            
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu khong hop le: HoiVien1 trung HoiVien2");
                return blnKetQua;
            }            

            return blnKetQua;
        }

        private void ClearFrmChiTietThachDau()
        {            
            cmbMaHoiVien1.Text = String.Empty;
            txtTenHoiVien1.Text = String.Empty;
            cmbMaHoiVien2.Text = String.Empty;
            txtTenHoiVien2.Text = String.Empty;
            cmbKetQua.Text = String.Empty;
        }           
        #endregion                               

       
        #endregion       

        #region Xoa ChiTietThachDau.  
        private void btnXoaChiTietThachDau_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co chac muon xoa cac tran thach dau nay?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lsvDanhSachChiTietThachDau.CheckedItems.Count > 0)
                {
                    try
                    {                        
                        foreach (ListViewItem itemChiTietThachDau in lsvDanhSachChiTietThachDau.CheckedItems)
                        {
                            DTO.ChiTietThachDauDTO aChiTietThachDau = (DTO.ChiTietThachDauDTO)itemChiTietThachDau.Tag;                            
                            if (BUS.ChiTietThachDauBUS.XoaChiTietThachDau(aChiTietThachDau))
                            {
                                lsvDanhSachChiTietThachDau.Items.Remove(itemChiTietThachDau);    
                                DiemHoiVienBUS.TinhDiemThachDau(aChiTietThachDau, -1);
                               
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
                    if (lsvDanhSachChiTietThachDau.SelectedItems.Count > 0)
                    {
                        try
                        {
                            foreach (ListViewItem itemChiTietThachDau in lsvDanhSachChiTietThachDau.SelectedItems)
                            {
                                DTO.ChiTietThachDauDTO aChiTietThachDau = (DTO.ChiTietThachDauDTO)itemChiTietThachDau.Tag;                                                                
                                ListViewItem aItem = itemChiTietThachDau;
                                if (BUS.ChiTietThachDauBUS.XoaChiTietThachDau(aChiTietThachDau))
                                {
                                    lsvDanhSachChiTietThachDau.Items.Remove(itemChiTietThachDau);
                                    if(DiemHoiVienBUS.TinhDiemThachDau(aChiTietThachDau, -1) == -1)
                                        MessageBox.Show("HoiVien khong ton tai.\n\rHoac CSDL chua cap nhat");
                                }                                                           
                            }
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("Exception: " + ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("Chua co tran dau nao duoc chon");
                }
            }            
        }

        private void chkChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonTatCa.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemChiTietThachDau in lsvDanhSachChiTietThachDau.Items)
                {
                    itemChiTietThachDau.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemChiTietThachDau in lsvDanhSachChiTietThachDau.Items)
                {
                    itemChiTietThachDau.Checked = false;
                }
            }
        }
        #endregion       

        #region Sua ThachDau va ChiTietThachDau.

        #region Sua ThachDau
        private void btnSuaThachDau_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.ThachDauDTO aThachDau = NhapThachDau();
                if (aThachDau == null)
                    return; //khong lam gi ca.   
                                
                ThachDauDTO aThachDauTam = ThachDauBUS.LayThachDauTheoNgay(dtpThoiGian.Value, _lstThachDau);                
                if(aThachDauTam == null)
                {
                    MessageBox.Show("ThachDau nay chua ton tai.", "Thong Bao", MessageBoxButtons.OK);
                    return;
                }

                aThachDau.IDThachDau = aThachDauTam.IDThachDau;
                if (ThachDauBUS.CapNhatThachDau(aThachDau))
                {
                    MessageBox.Show("Cap nhat thach dau thanh cong", "Thong Bao", MessageBoxButtons.OK);

                    String strSapXepThachDau = " Order By ThoiGian DESC";
                    _lstThachDau = ThachDauBUS.DocDanhSachThachDau(String.Empty, strSapXepThachDau);
                }
                else
                    MessageBox.Show("Loi thuc thi!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
        #endregion
        
        #region Sua ChiTietThachDau
        private void btnSuaChiTietThachDau_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co chac thay doi ket qua tran dau", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lsvDanhSachChiTietThachDau.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemChiTietThachDau in lsvDanhSachChiTietThachDau.SelectedItems)
                        {
                            DTO.ChiTietThachDauDTO aChiTietThachDau = NhapChiTietThachDau();
                            if (aChiTietThachDau == null)
                                return; //khong lam gi ca.   

                            aChiTietThachDau.IDChiTietThachDau = ((DTO.ChiTietThachDauDTO)itemChiTietThachDau.Tag).IDChiTietThachDau;
                            if (ChiTietThachDauBUS.CapNhatChiTietThachDau(aChiTietThachDau))
                            {
                                lsvDanhSachChiTietThachDau.Items[itemChiTietThachDau.Index] = TheHienListItem(itemChiTietThachDau.Index, aChiTietThachDau);
                                ClearFrmChiTietThachDau();
                                DiemHoiVienBUS.TinhDiemThachDau((ChiTietThachDauDTO)itemChiTietThachDau.Tag, -1);
                                DiemHoiVienBUS.TinhDiemThachDau(aChiTietThachDau, 1);
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
                    MessageBox.Show("Chua co chi tiet thach dau nao dc chon", "Thong Bao", MessageBoxButtons.OK);
                }
            }
           
        }
        #endregion                       
        #endregion        

        #region Cac ham su kien tren Form.
        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {
            if (arrKiemTra[0] != 1)
            {
                try
                {
                    ThachDauDTO aThachDau = ThachDauBUS.LayThachDauTheoNgay(dtpThoiGian.Value, _lstThachDau);
                    if (aThachDau != null)
                    {
                        txtDiaDiem.Text = aThachDau.DiaDiem;

                        HoiVienDTO aNguoiQuanLy = HoiVienBUS.LayHoiVienTheoID(aThachDau.NguoiQuanLy, _lstHoiVien);
                        cmbNguoiQuanLy.Text = aNguoiQuanLy.MSSV; 
                        btnThemThachDau.Enabled = false;

                        String strLayDSChiTietThachDau = " Where MaThachDau = " + aThachDau.IDThachDau.ToString();
                        List<ChiTietThachDauDTO> lstChiTietThachDau = ChiTietThachDauBUS.DocDanhSachChiTietThachDau(strLayDSChiTietThachDau);
                        XuatDanhSachChiTietThachDau(lstChiTietThachDau);
                    }
                    else
                    {
                        txtDiaDiem.Text = String.Empty;
                        cmbNguoiQuanLy.Text = String.Empty;
                        btnThemThachDau.Enabled = true;

                        lsvDanhSachChiTietThachDau.Items.Clear();
                    }
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void cmbMaHoiVien1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HoiVienDTO aHoiVien = HoiVienBUS.LayHoiVienTheoMSSV(cmbMaHoiVien1.Text, _lstHoiVien);
            if (aHoiVien != null)
            {
                txtTenHoiVien1.Text = aHoiVien.HoTen;
            }            
        }

        private void cmbMaHoiVien1_TextUpdate(object sender, EventArgs e)
        {
            HoiVienDTO aHoiVien = HoiVienBUS.LayHoiVienTheoMSSV(cmbMaHoiVien1.Text, _lstHoiVien);
            if (aHoiVien != null)
            {
                txtTenHoiVien1.Text = aHoiVien.HoTen;
            }
            else
                txtTenHoiVien1.Text = String.Empty;
        }

        private void cmbMaHoiVien2_SelectedIndexChanged(object sender, EventArgs e)
        {
            HoiVienDTO aHoiVien = HoiVienBUS.LayHoiVienTheoMSSV(cmbMaHoiVien2.Text, _lstHoiVien);
            if (aHoiVien != null)
            {
                txtTenHoiVien2.Text = aHoiVien.HoTen;
            }
        }

        private void cmbMaHoiVien2_TextUpdate(object sender, EventArgs e)
        {
            HoiVienDTO aHoiVien = HoiVienBUS.LayHoiVienTheoMSSV(cmbMaHoiVien2.Text, _lstHoiVien);
            if (aHoiVien != null)
            {
                txtTenHoiVien2.Text = aHoiVien.HoTen;
            }
            else
                txtTenHoiVien2.Text = String.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion        
    }
}
