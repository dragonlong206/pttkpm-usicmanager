using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using BUS;
using DTO;

namespace GUI
{
    public partial class ThongKeXepHangGUI : Form
    {
        static int[] arrTrangThaiSort = new int[8]{1,1,1,1,1,1,1,1};
        private List<HoiVienDTO> _lstHoiVien = new List<HoiVienDTO>();
        private List<CapBacDTO> _lstCapBac = new List<CapBacDTO>();
        private List<ThangDiemDTO> _lstThangDiem = new List<ThangDiemDTO>();        
        private List<DiemHoiVienDTO> _lstDiemHoiVien = new List<DiemHoiVienDTO>();


        public ThongKeXepHangGUI()
        {
            InitializeComponent();

            String strSapXepThangDiem = " Order By CongThucTinh";
            _lstThangDiem = ThangDiemBUS.DocDanhSachDiem(String.Empty, strSapXepThangDiem);                
            LoadThangDiemTrenListView();
        }

        private void ThongKeXepHangGUI_Activated(object sender, EventArgs e)
        {            
            try
            {
                String strSapXepHoiVien = " Order By MaCapBac DESC, MSSV";
                _lstHoiVien = HoiVienBUS.DocDanhSachHoiVien(String.Empty, strSapXepHoiVien);
                String strSapXepCapBac = " Order By ChiSoCapbac";
                _lstCapBac = CapBacBUS.DocDanhSachCapBac(String.Empty, strSapXepCapBac);
                String strSapXepThangDiem = " Order By CongThucTinh";
                _lstThangDiem = ThangDiemBUS.DocDanhSachDiem(String.Empty, strSapXepThangDiem);                
            }
            catch (System.Exception ex)
            {
                throw ex;
            }             

            LoadThongKeXepHang();
        }
        
        #region Load Form ThongKeXepHang.           
        private void LoadThongKeXepHang()
        {            
            try
            {                
                XuatDanhSachXepHang(_lstHoiVien);                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            } 
        }

        private void LoadThangDiemTrenListView()
        {            
            //Load cot diem 1:
            List<ThangDiemDTO> lstDiem1 = ThangDiemBUS.CopyListThangDiem(_lstThangDiem);                        
            cmbDiem1.DataSource = lstDiem1;
            cmbDiem1.DisplayMember = "TenDiem";
            cmbDiem1.ValueMember = "IDDiem";
            cmbDiem1.SelectedIndex = 0;            
            
            //Load cot diem 2:
            List<ThangDiemDTO> lstDiem2 = ThangDiemBUS.CopyListThangDiem(_lstThangDiem);
            cmbDiem2.DataSource = lstDiem2;
            cmbDiem2.DisplayMember = "TenDiem";
            cmbDiem2.ValueMember = "IDDiem";
            cmbDiem2.SelectedIndex = 1;
            
            //Load cot diem 3:
            List<ThangDiemDTO> lstDiem3 = ThangDiemBUS.CopyListThangDiem(_lstThangDiem);
            cmbDiem3.DataSource = lstDiem3;
            cmbDiem3.DisplayMember = "TenDiem";
            cmbDiem3.ValueMember = "IDDiem";
            cmbDiem3.SelectedIndex = 2;
            
            //Load cot diem 4:
            List<ThangDiemDTO> lstDiem4 = ThangDiemBUS.CopyListThangDiem(_lstThangDiem);
            cmbDiem4.DataSource = lstDiem4;
            cmbDiem4.DisplayMember = "TenDiem";
            cmbDiem4.ValueMember = "IDDiem";
            cmbDiem4.SelectedIndex = 3;
        }        

        private void XuatDanhSachXepHang(List<HoiVienDTO> lstHoiVien)
        {            
            if (lstHoiVien == null)
                return;     //khong lam gi ca.          

            int[] arrMaDiem = new int[4];
            arrMaDiem[0] = int.Parse(cmbDiem1.SelectedValue.ToString());
            arrMaDiem[1] = int.Parse(cmbDiem2.SelectedValue.ToString());
            arrMaDiem[2] = int.Parse(cmbDiem3.SelectedValue.ToString());
            arrMaDiem[3] = int.Parse(cmbDiem4.SelectedValue.ToString());
            String strSapXepDiemHoiVien = " Order By MaHoiVien";
            _lstDiemHoiVien = DiemHoiVienBUS.DocDanhSachDiemHoiVien(String.Empty, strSapXepDiemHoiVien);                

            lsvXepHang.Items.Clear();
            int nSoThuTu = 1;
            foreach (HoiVienDTO aHoiVien in lstHoiVien)
            {
                ListViewItem aItem = TheHienListItem(nSoThuTu, aHoiVien, arrMaDiem);
                if (aItem != null)
                    lsvXepHang.Items.Add(aItem);
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, HoiVienDTO aHoiVien, int[] arrMaDiem)
        {
            if (aHoiVien == null)
                return null;
            
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            CapBacDTO aCapBac = CapBacBUS.LayCapBacTheoID(aHoiVien.MaCapBac, _lstCapBac);
            if(aCapBac != null)
                itemKetQua.SubItems.Add(aCapBac.TenCapBac);
            else
                itemKetQua.SubItems.Add(CapBacBUS.LayCapBacMacDinh(_lstCapBac).TenCapBac);
            itemKetQua.SubItems.Add(aHoiVien.MSSV);
            itemKetQua.SubItems.Add(aHoiVien.HoTen);            

            itemKetQua.SubItems.Add("None");
            itemKetQua.SubItems.Add("None");
            itemKetQua.SubItems.Add("None");
            itemKetQua.SubItems.Add("None");           

            List<DiemHoiVienDTO> lstDiemHoiVien = DiemHoiVienBUS.LayDSDiemTheoHoiVien(aHoiVien.IDHoiVien, _lstDiemHoiVien);            
            foreach(DiemHoiVienDTO aDiemHoiVien in lstDiemHoiVien)
            {                                
                if(aDiemHoiVien.MaDiem == arrMaDiem[0])
                {
                    ListViewItem.ListViewSubItem aSubItem = new ListViewItem.ListViewSubItem(itemKetQua, aDiemHoiVien.GiaTri.ToString());                
                    itemKetQua.SubItems[4] = aSubItem;
                }
                else if(aDiemHoiVien.MaDiem == arrMaDiem[1])
                {
                    ListViewItem.ListViewSubItem aSubItem = new ListViewItem.ListViewSubItem(itemKetQua, aDiemHoiVien.GiaTri.ToString());                
                    itemKetQua.SubItems[5] = aSubItem;
                }
                else if(aDiemHoiVien.MaDiem == arrMaDiem[2])
                {
                    ListViewItem.ListViewSubItem aSubItem = new ListViewItem.ListViewSubItem(itemKetQua, aDiemHoiVien.GiaTri.ToString());                
                    itemKetQua.SubItems[6] = aSubItem;
                }
                else if(aDiemHoiVien.MaDiem == arrMaDiem[3])
                {
                    ListViewItem.ListViewSubItem aSubItem = new ListViewItem.ListViewSubItem(itemKetQua, aDiemHoiVien.GiaTri.ToString());                
                    itemKetQua.SubItems[7] = aSubItem;
                }                                                                                  
            }                      

            itemKetQua.Tag = aHoiVien;
            return itemKetQua;
        }        
       
        #endregion                   

        #region Chuyen doi view DiemHoiVien                      
        private void cmbDiem1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nMaDiem = int.Parse(cmbDiem1.SelectedValue.ToString());
            foreach (ListViewItem aItem in lsvXepHang.Items)
            {
                HoiVienDTO aHoiVien = (HoiVienDTO)aItem.Tag;                
                List<DiemHoiVienDTO> lstDiemHoiVien = DiemHoiVienBUS.LayDSDiemTheoHoiVien(aHoiVien.IDHoiVien, _lstDiemHoiVien);
                foreach (DiemHoiVienDTO aDiemHoiVien in lstDiemHoiVien)
                {                    
                    if(aDiemHoiVien.MaDiem == nMaDiem)
                    {
                        ListViewItem.ListViewSubItem aSubItem = new ListViewItem.ListViewSubItem(aItem, aDiemHoiVien.GiaTri.ToString());
                        aItem.SubItems[4] = aSubItem;
                        break;
                    }                    
                }
            }            
        }               

        private void cmbDiem2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nMaDiem = int.Parse(cmbDiem2.SelectedValue.ToString());
            foreach (ListViewItem aItem in lsvXepHang.Items)
            {
                HoiVienDTO aHoiVien = (HoiVienDTO)aItem.Tag;
                List<DiemHoiVienDTO> lstDiemHoiVien = DiemHoiVienBUS.LayDSDiemTheoHoiVien(aHoiVien.IDHoiVien, _lstDiemHoiVien);
                foreach (DiemHoiVienDTO aDiemHoiVien in lstDiemHoiVien)
                {                    
                    if (aDiemHoiVien.MaDiem == nMaDiem)
                    {
                        ListViewItem.ListViewSubItem aSubItem = new ListViewItem.ListViewSubItem(aItem, aDiemHoiVien.GiaTri.ToString());
                        aItem.SubItems[5] = aSubItem;
                        break;
                    }
                }                
            }            
        }

        private void cmbDiem3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nMaDiem = int.Parse(cmbDiem3.SelectedValue.ToString());
            foreach (ListViewItem aItem in lsvXepHang.Items)
            {
                HoiVienDTO aHoiVien = (HoiVienDTO)aItem.Tag;
                List<DiemHoiVienDTO> lstDiemHoiVien = DiemHoiVienBUS.LayDSDiemTheoHoiVien(aHoiVien.IDHoiVien, _lstDiemHoiVien);
                foreach (DiemHoiVienDTO aDiemHoiVien in lstDiemHoiVien)
                {
                    if (aDiemHoiVien.MaDiem == nMaDiem)
                    {
                        ListViewItem.ListViewSubItem aSubItem = new ListViewItem.ListViewSubItem(aItem, aDiemHoiVien.GiaTri.ToString());
                        aItem.SubItems[6] = aSubItem;
                        break;
                    }
                }
            }                        
        }

        private void cmbDiem4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nMaDiem = int.Parse(cmbDiem4.SelectedValue.ToString());
            foreach (ListViewItem aItem in lsvXepHang.Items)
            {
                HoiVienDTO aHoiVien = (HoiVienDTO)aItem.Tag;
                List<DiemHoiVienDTO> lstDiemHoiVien = DiemHoiVienBUS.LayDSDiemTheoHoiVien(aHoiVien.IDHoiVien, _lstDiemHoiVien);
                foreach (DiemHoiVienDTO aDiemHoiVien in lstDiemHoiVien)
                {
                    if (aDiemHoiVien.MaDiem == nMaDiem)
                    {
                        ListViewItem.ListViewSubItem aSubItem = new ListViewItem.ListViewSubItem(aItem, aDiemHoiVien.GiaTri.ToString());
                        aItem.SubItems[7] = aSubItem;
                        break;
                    }
                }
            }            
        }      
        
        #endregion        

        #region Sap xep        
        private void SapXepListViewByDouble(int nChiSoCot, int nChieu)
        {
            //nChieu = 1: tang, nChieu = -1: giam.
            if (nChieu != 1 && nChieu != -1)
                nChieu = 1;           

            int n = lsvXepHang.Items.Count;
            for (int i = 0; i < n; i++)
            {
                ListViewItem aItemI = lsvXepHang.Items[i];
                for (int j = i + 1; j < n; j++)
                {
                    ListViewItem aItemJ = lsvXepHang.Items[j];
                    if (SoSanhListViewItemByDouble(lsvXepHang.Items[j], lsvXepHang.Items[i], nChiSoCot)*nChieu < 0)
                    {
                        lsvXepHang.Items.Remove(aItemI);
                        lsvXepHang.Items.Remove(aItemJ);
                        lsvXepHang.Items.Insert(i, aItemJ);
                        lsvXepHang.Items.Insert(j, aItemI);
                    }
                }
            }
        }

        private void SapXepListViewByText(int nChiSoCot, int nChieu)
        {
            //nChieu = 1: tang, nChieu = -1: giam.
            if (nChieu != 1 && nChieu != -1)
                nChieu = 1;

            int n = lsvXepHang.Items.Count;
            for (int i = 0; i < n; i++)
            {
                ListViewItem aItemI = lsvXepHang.Items[i];
                for (int j = i + 1; j < n; j++)
                {
                    ListViewItem aItemJ = lsvXepHang.Items[j];
                    if (SoSanhListViewItemByText(lsvXepHang.Items[j], lsvXepHang.Items[i], nChiSoCot) * nChieu < 0)
                    {
                        lsvXepHang.Items.Remove(aItemI);
                        lsvXepHang.Items.Remove(aItemJ);
                        lsvXepHang.Items.Insert(i, aItemJ);
                        lsvXepHang.Items.Insert(j, aItemI);
                    }
                }
            }
        }

        private int SoSanhListViewItemByDouble(ListViewItem aItem1, ListViewItem aItem2, int nChiSoCot)
        {
            if (nChiSoCot < aItem1.SubItems.Count)
            {
                double nGiaTri1 = double.Parse(aItem1.SubItems[nChiSoCot].Text);
                double nGiaTri2 = double.Parse(aItem2.SubItems[nChiSoCot].Text);
                if (nGiaTri1 < nGiaTri2)
                    return -1;
                if (nGiaTri1 > nGiaTri2)
                    return 1;
            }
            return 0;
        }

        private int SoSanhListViewItemByText(ListViewItem aItem1, ListViewItem aItem2, int nChiSoCot)
        {
            if (nChiSoCot < aItem1.SubItems.Count)
            {
                String strGiaTri1 = aItem1.SubItems[nChiSoCot].Text;
                String strGiaTri2 = aItem2.SubItems[nChiSoCot].Text;
                return String.Compare(strGiaTri1, strGiaTri2);
            }
            return 0;
        }

        private void btnSapXep1_Click(object sender, EventArgs e)
        {
            SapXepListViewByDouble(4, arrTrangThaiSort[4]);
            arrTrangThaiSort[4] = -arrTrangThaiSort[4];
        }

        private void btnSapXep2_Click(object sender, EventArgs e)
        {
            SapXepListViewByDouble(5, arrTrangThaiSort[5]);
            arrTrangThaiSort[5] = -arrTrangThaiSort[5];
        }

        private void btnSapXep3_Click(object sender, EventArgs e)
        {
            SapXepListViewByDouble(6, arrTrangThaiSort[6]);
            arrTrangThaiSort[6] = -arrTrangThaiSort[6];
        }

        private void btnSapXep4_Click(object sender, EventArgs e)
        {
            SapXepListViewByDouble(7, arrTrangThaiSort[7]);
            arrTrangThaiSort[7] = -arrTrangThaiSort[7];
        }

        private void lsvXepHang_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
                SapXepListViewByDouble(e.Column, arrTrangThaiSort[0]);            
            else            
                SapXepListViewByText(e.Column, arrTrangThaiSort[e.Column]);
            arrTrangThaiSort[e.Column] = -arrTrangThaiSort[e.Column];
        }
        #endregion               

        #region TraCuu
        private void txtMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                String strLayHoiVien = String.Empty;
                if(txtMSSV.Text != String.Empty)
                    strLayHoiVien = " Where MSSV like '%" + txtMSSV.Text + "%'";
                String strSapXepHoiVien = " Order By MSSV";
                List<HoiVienDTO> lstHoiVien = HoiVienBUS.DocDanhSachHoiVien(strLayHoiVien, strSapXepHoiVien);
                XuatDanhSachXepHang(lstHoiVien);
            }
        }

        private void txtCapBac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                String strLayHoiVien = String.Empty;
                if (txtCapBac.Text != String.Empty)
                {
                    String strLayCapBac = " Where TenCapBac like '%" + txtCapBac.Text + "%'";
                    List<CapBacDTO> lstCapBac = CapBacBUS.DocDanhSachCapBac(strLayCapBac);
                    if(lstCapBac.Count > 0)
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
                String strSapXepHoiVien = " Order By MaCapBac DESC";
                List<HoiVienDTO> lstHoiVien = HoiVienBUS.DocDanhSachHoiVien(strLayHoiVien, strSapXepHoiVien);
                XuatDanhSachXepHang(lstHoiVien);
            }
        }
        #endregion                               
    } 
}
