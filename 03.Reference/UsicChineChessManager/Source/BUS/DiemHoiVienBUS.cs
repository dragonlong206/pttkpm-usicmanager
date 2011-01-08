using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class DiemHoiVienBUS
    {
        private static List<HoiVienDTO> _lstHoiVien = new List<HoiVienDTO>();
        private static List<ThangDiemDTO> _lstThangDiem = new List<ThangDiemDTO>();
        private static List<CapBacDTO> _lstCapBac = new List<CapBacDTO>();
        private static int nSoThangDiem = 7;

        #region Cac ham truy xuat co ban
        public static Boolean ThemDiemHoiVien(DTO.DiemHoiVienDTO DiemHoiVien)
        {
            Boolean blnDaThemDuoc = false;

            DiemHoiVien.IDDiemHoiVien = 0;
            List<DiemHoiVienDTO> lstDiemHoiVien = DocDanhSachDiemHoiVien(String.Empty);
            foreach (DiemHoiVienDTO aDiemHoiVienTam in lstDiemHoiVien)
            {
                if (aDiemHoiVienTam.IDDiemHoiVien > DiemHoiVien.IDDiemHoiVien)
                    DiemHoiVien.IDDiemHoiVien = aDiemHoiVienTam.IDDiemHoiVien;
            }
            DiemHoiVien.IDDiemHoiVien++;

            try
            {
                blnDaThemDuoc = DiemHoiVienDAO.ThemDiemHoiVien(DiemHoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnDaThemDuoc;
        }

        public static Boolean XoaDiemHoiVien(DiemHoiVienDTO DiemHoiVien)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DiemHoiVienDAO.XoaDiemHoiVien(DiemHoiVien);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }

        public static bool CapNhatDiemHoiVien(DTO.DiemHoiVienDTO aDiemHoiVien)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.DiemHoiVienDAO.CapNhatDiemHoiVien(aDiemHoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static List<DiemHoiVienDTO> DocDanhSachDiemHoiVien(String strTieuChiTimKiem)
        {
            List<DiemHoiVienDTO> lstDiemHoiVien = DiemHoiVienDAO.DocDanhSachDiemHoiVien(strTieuChiTimKiem);
            return lstDiemHoiVien;
        }

        public static List<DiemHoiVienDTO> DocDanhSachDiemHoiVien(String strTieuChiTimKiem, String strSapXep)
        {
            List<DiemHoiVienDTO> lstDiemHoiVien = DiemHoiVienDAO.DocDanhSachDiemHoiVien(strTieuChiTimKiem, strSapXep);
            return lstDiemHoiVien;
        }

        public static List<DiemHoiVienDTO> LayDSDiemTheoHoiVien(int nIDHoiVien, List<DiemHoiVienDTO> lstDiemHoiVien)
        {
            List<DiemHoiVienDTO> lstKetQua = new List<DiemHoiVienDTO>();

            int nDem = 0;
            _lstThangDiem = ThangDiemBUS.DocDanhSachDiem(String.Empty);
            nSoThangDiem = _lstThangDiem.Count;            

            foreach(DiemHoiVienDTO aDiemHoiVien in lstDiemHoiVien)
            {
                if (aDiemHoiVien.MaHoiVien == nIDHoiVien)
                {
                    lstKetQua.Add(aDiemHoiVien);
                    nDem++;
                    if (nDem >= nSoThangDiem)
                        return lstKetQua;
                }
            }
            return lstKetQua;
        }        

        public static DiemHoiVienDTO LayDiemTheoHoiVienVaThangDiem(int nIDHoiVien, int nIDDiem)
        {
            String strLayDiemHoiVien = " Where MaHoiVien = " + nIDHoiVien.ToString();
            strLayDiemHoiVien += " And MaDiem = " + nIDDiem.ToString();
            List<DiemHoiVienDTO> lstDiemHoiVien = DiemHoiVienBUS.DocDanhSachDiemHoiVien(strLayDiemHoiVien);
            if (lstDiemHoiVien.Count > 0)
                return lstDiemHoiVien[0];
            return null;
        }
        #endregion

        #region Ham xu ly nghiep vu tinh diem  
        public static void ResetDanhSach(List<HoiVienDTO> lstHoiVien, List<ThangDiemDTO> lstThangDiem, List<CapBacDTO> lstCapBac)
        {
            _lstHoiVien = lstHoiVien;
            _lstThangDiem = lstThangDiem;
            _lstCapBac = lstCapBac;
            nSoThangDiem = _lstThangDiem.Count;
        }

        public static int TinhDiemThachDau(ChiTietThachDauDTO aChiTietThachDau, int nHeSoThaoTac)
        {
            if (nHeSoThaoTac != 1 && nHeSoThaoTac != -1)
                nHeSoThaoTac = 1;

            HoiVienDTO aHoiVien1 = HoiVienBUS.LayHoiVienTheoID(aChiTietThachDau.MaHoiVien1, _lstHoiVien);            
            HoiVienDTO aHoiVien2 = HoiVienBUS.LayHoiVienTheoID(aChiTietThachDau.MaHoiVien2, _lstHoiVien);
            if (aHoiVien1 == null || aHoiVien2 == null)
                return -1;  //Khong tim duoc hoi vien hoac CSDL chua kip cap nhat.

            switch (aChiTietThachDau.KetQua)
            {
                case "1 - 0":
                    {
                        TinhDiemHoiVien(aHoiVien1, 1, aHoiVien2, nHeSoThaoTac);
                        TinhDiemHoiVien(aHoiVien2, -1, aHoiVien1, nHeSoThaoTac);
                        break;
                    }
                case "0 - 1":
                    {
                        TinhDiemHoiVien(aHoiVien1, -1, aHoiVien2, nHeSoThaoTac);
                        TinhDiemHoiVien(aHoiVien2, 1, aHoiVien1, nHeSoThaoTac);
                        break;
                    }
                case "0 - 0":
                    {
                        TinhDiemHoiVien(aHoiVien1, 0, aHoiVien2, nHeSoThaoTac);
                        TinhDiemHoiVien(aHoiVien2, 0, aHoiVien1, nHeSoThaoTac);
                        break;
                    }
            }

            return _lstHoiVien.Count;
        }

        public static void TinhDiemHoiVien(HoiVienDTO aHoiVien, int nKetQua, HoiVienDTO aDoiThu, int nHeSoThaoTac)
        {
            //nKetQua = 1:Thang, -1:Thua, 0:Hoa.
            //nHeSoThaoTac: 1-ThemChiTietThachDau, -1-XoaChiTietThachDau: diem tinh nguoc.                                   

            String strLayDiemHoiVien = " Where MaHoiVien = " + aHoiVien.IDHoiVien.ToString();
            List<DiemHoiVienDTO> lstDiemTam = DiemHoiVienBUS.DocDanhSachDiemHoiVien(strLayDiemHoiVien);
            List<DiemHoiVienDTO> lstDiemHoiVien = new List<DiemHoiVienDTO>(lstDiemTam);            

            #region Xac dinh tung cot diem cua HoiVien luu vao lstDiemHoiVien.
            foreach (DiemHoiVienDTO aDiemHoiVien in lstDiemTam)
            {
                foreach (ThangDiemDTO aDiem in _lstThangDiem)
                {
                    if (aDiemHoiVien.MaDiem == aDiem.IDDiem)
                    {
                        if (aDiem.CongThucTinh == "01DVT")   //Diem Vuot Troi                        
                            lstDiemHoiVien[0] = aDiemHoiVien;
                        else if (aDiem.CongThucTinh == "02DKN") //Diem Kinh Nghiem                        
                            lstDiemHoiVien[1] = aDiemHoiVien;
                        else if (aDiem.CongThucTinh == "03DTC")  //Diem Tich Cuc
                            lstDiemHoiVien[2] = aDiemHoiVien;
                        else if (aDiem.CongThucTinh == "04DLK")  //Diem Lien Kich
                            lstDiemHoiVien[3] = aDiemHoiVien;
                        else if (aDiem.CongThucTinh == "TTD")    //Tong tran dau da tham gia
                            lstDiemHoiVien[4] = aDiemHoiVien;
                        else if (aDiem.CongThucTinh == "TLT")    //So tran thang lien tiep
                            lstDiemHoiVien[5] = aDiemHoiVien;
                        else if (aDiem.CongThucTinh == "KN0")    //Diem kinh nghiem khi len cap/bac hien tai.
                            lstDiemHoiVien[6] = aDiemHoiVien;
                        break;
                    }
                }
            }
            #endregion
                               
            #region Tinh tung cot diem cua HoiVien
            lstDiemHoiVien[0].GiaTri += TinhDiemVuotTroi(aHoiVien, nKetQua, aDoiThu) * nHeSoThaoTac;
            lstDiemHoiVien[1].GiaTri += TinhDiemKinhNghiem(nKetQua) * nHeSoThaoTac;
            lstDiemHoiVien[2].GiaTri += TinhDiemTichCuc(nKetQua) * nHeSoThaoTac;
            lstDiemHoiVien[4].GiaTri += TinhTongTranDau() * nHeSoThaoTac;
            lstDiemHoiVien[5].GiaTri += TinhThangLienTiep(nKetQua, lstDiemHoiVien[5].GiaTri) * nHeSoThaoTac;
            lstDiemHoiVien[3].GiaTri += TinhDiemLienKich(lstDiemHoiVien[5].GiaTri, lstDiemHoiVien[3].GiaTri) * nHeSoThaoTac;            
            #endregion
            
            #region Cap nhat diem hoi vien
            foreach (DiemHoiVienDTO aDiemHoiVien in lstDiemHoiVien)
            {
                DiemHoiVienBUS.CapNhatDiemHoiVien(aDiemHoiVien);
            }
            #endregion            

            XetThangGiangCapBacHoiVien(aHoiVien, lstDiemHoiVien[0], lstDiemHoiVien[1], lstDiemHoiVien[6]);                          
        }        
       
        public static double TinhDiemVuotTroi(HoiVienDTO aHoiVien, int nKetQua, HoiVienDTO aDoiThu)
        {
            CapBacDTO aCapBacHoiVien = CapBacBUS.LayCapBacTheoID(aHoiVien.MaCapBac, _lstCapBac);
            CapBacDTO aCapBacDoiThu = CapBacBUS.LayCapBacTheoID(aDoiThu.MaCapBac, _lstCapBac);
            switch (nKetQua)
            {
                case 1:
                    {
                        if ((aCapBacDoiThu.ChiSoCapBac / 10) < (aCapBacHoiVien.ChiSoCapBac / 10))
                            return 0.125;
                        return 1;                        
                    }
                case 0:
                    {
                        if ((aCapBacDoiThu.ChiSoCapBac / 10) < (aCapBacHoiVien.ChiSoCapBac / 10))
                            return -0.25;
                        return 0.25;
                    }
                case -1:
                    {
                        if ((aCapBacDoiThu.ChiSoCapBac / 10) < (aCapBacHoiVien.ChiSoCapBac / 10))
                            return -0.75;
                        return -0.5;                                                
                    }
                default: return 0;
            }
        }
        
        public static double TinhDiemKinhNghiem(int nKetQua)
        {            
            switch (nKetQua)
            {
                case 1: return 1;
                case 0: return 0.25;
                case -1: return -0.5;
                default: return 0;
            }
        }
        
        public static double TinhDiemTichCuc(int nKetQua)
        {            
            return nKetQua;
        }
        
        public static double TinhDiemLienKich(double nDiemTLTCapNhat, double dDiemHienTai)
        {
            if (nDiemTLTCapNhat > dDiemHienTai)
                return 1;                                                
            return 0;   
        }
        
        public static double TinhTongTranDau()
        {            
            return 1;
        }
        
        public static double TinhThangLienTiep(int nKetQua, double dDiemHienTai)
        {
            if (nKetQua == -1)
                return -dDiemHienTai;
            return nKetQua;
        }
        #endregion

        #region Ham xu ly nghiep vu thang cap bac.
        public static void XetThangGiangCapBacHoiVien(HoiVienDTO aHoiVien, DiemHoiVienDTO aDiemVuotTroi, DiemHoiVienDTO aDiemKinhNghiem, DiemHoiVienDTO aDiemKN0)
        {
            CapBacDTO aCapBac = CapBacBUS.LayCapBacTheoID(aHoiVien.MaCapBac, _lstCapBac);
            if (aCapBac == null)
                return;

            if((aDiemKinhNghiem.GiaTri - aDiemKN0.GiaTri) >= 3)
            {
                if(ThangBacHoiVien(aHoiVien, aCapBac))
                {
                    aDiemKN0.GiaTri = aDiemKinhNghiem.GiaTri;
                    DiemHoiVienBUS.CapNhatDiemHoiVien(aDiemKN0);
                }
            }
            else if((aDiemKinhNghiem.GiaTri - aDiemKN0.GiaTri) <= -3)
            {
                if(GiangBacHoiVien(aHoiVien, aCapBac))
                {
                    aDiemKN0.GiaTri = aDiemKinhNghiem.GiaTri;                    
                    DiemHoiVienBUS.CapNhatDiemHoiVien(aDiemKN0);
                }
            }
            
            if(aDiemVuotTroi.GiaTri >= aCapBac.NguongVuotTroi)
            {                
                if(ThangCapHoiVien(aHoiVien, aCapBac))
                {
                    aDiemVuotTroi.GiaTri = 0;
                    DiemHoiVienBUS.CapNhatDiemHoiVien(aDiemVuotTroi);
                }
            }
            else if(aDiemVuotTroi.GiaTri <= (-aCapBac.NguongVuotTroi))
            {
                if(GiangCapHoiVien(aHoiVien, aCapBac))
                {
                    aDiemVuotTroi.GiaTri = 0;
                    DiemHoiVienBUS.CapNhatDiemHoiVien(aDiemVuotTroi);
                }
            }
        }

        public static Boolean ThangCapHoiVien(HoiVienDTO aHoiVien, CapBacDTO aCapBac)
        {
            //Truoc khi xet dieu kien nay, hoi vien phai co diem VuotTroi dat yeu cau.            
            if((aCapBac.ChiSoCapBac / 10) != 7)
            {
                //Hoi vien phai dat bac cao nhat tai moi cap moi duoc thang cap.
                Boolean blnKiemTraBac = false;
                blnKiemTraBac |= ((aCapBac.ChiSoCapBac/10 == 1) && (aCapBac.ChiSoCapBac%10 == 5));
                blnKiemTraBac |= ((aCapBac.ChiSoCapBac/10 != 1) && (aCapBac.ChiSoCapBac % 10 == 3));
                if (blnKiemTraBac)
                {
                    int nNewChiSoCapBac = aCapBac.ChiSoCapBac + 8; 
                    if ((aCapBac.ChiSoCapBac / 10) == 1)
                        nNewChiSoCapBac = 21;
                    if ((aCapBac.ChiSoCapBac / 10) == 6)
                        nNewChiSoCapBac = 73;

                    CapBacDTO aNewCapBac = CapBacBUS.LayCapBacTheoChiSo(nNewChiSoCapBac, _lstCapBac);                    
                    if (aNewCapBac != null)
                    {
                        aHoiVien.MaCapBac = aNewCapBac.IDCapBac;
                        HoiVienBUS.CapNhatHoiVien(aHoiVien);
                        return true;
                    }
                }                               
            }
            return false;
        }

        public static Boolean GiangCapHoiVien(HoiVienDTO aHoiVien, CapBacDTO aCapBac)
        {
            //Truoc khi xet dieu kien nay, hoi vien phai co diem VuotTroi nho hon nguong.            
            if (aCapBac.ChiSoCapBac / 10 != 1)
            {
                //Hoi vien phai co bac thap nhat tai moi cap moi bi giang cap.
                Boolean blnKiemTraBac = false;
                blnKiemTraBac |= (aCapBac.ChiSoCapBac % 10) == 1;
                blnKiemTraBac |= (aCapBac.ChiSoCapBac / 10) == 7;
                if (blnKiemTraBac)
                {
                    int nNewChiSoCapBac = aCapBac.ChiSoCapBac - 8;
                    if ((aCapBac.ChiSoCapBac / 10) == 2)
                        nNewChiSoCapBac = 15;
                    if (aCapBac.ChiSoCapBac / 10 == 7)
                        nNewChiSoCapBac = 63;

                    CapBacDTO aNewCapBac = CapBacBUS.LayCapBacTheoChiSo(nNewChiSoCapBac, _lstCapBac);                                       
                    if (aNewCapBac != null)
                    {
                        aHoiVien.MaCapBac = aNewCapBac.IDCapBac;
                        HoiVienBUS.CapNhatHoiVien(aHoiVien);
                        return true;
                    }
                }
            }
            return false;
        }

        public static Boolean ThangBacHoiVien(HoiVienDTO aHoiVien, CapBacDTO aCapBac)
        {
            //Truoc khi xet dieu kien nay, hoi vien phai co diem KinhNghiem dat yeu cau.            
            //Hoi vien khong dang o bac cao nhat tai moi cap moi duoc thang bac.
            Boolean blnKiemTraBac = false;
            blnKiemTraBac |= (aCapBac.ChiSoCapBac / 10 == 1) && (aCapBac.ChiSoCapBac % 10 == 5);
            blnKiemTraBac |= (aCapBac.ChiSoCapBac / 10 != 1) && (aCapBac.ChiSoCapBac % 10 == 3);
            if (!blnKiemTraBac)
            {
                int nNewChiSoCapBac = aCapBac.ChiSoCapBac + 1;
                
                CapBacDTO aNewCapBac = CapBacBUS.LayCapBacTheoChiSo(nNewChiSoCapBac, _lstCapBac);                                                       
                if (aNewCapBac != null)
                {
                    aHoiVien.MaCapBac = aNewCapBac.IDCapBac;
                    HoiVienBUS.CapNhatHoiVien(aHoiVien);
                    return true;
                }
            }            
            return false;
        }

        public static Boolean GiangBacHoiVien(HoiVienDTO aHoiVien, CapBacDTO aCapBac)
        {
            //Truoc khi xet dieu kien nay, hoi vien phai bi diem KinhNghiem khong dat yeu cau.            
            //Hoi vien khong dang o bac thap nhat tai moi cap moi bi giang bac.
            Boolean blnKiemTraBac = false;
            blnKiemTraBac |= (aCapBac.ChiSoCapBac % 10) == 1;
            blnKiemTraBac |= (aCapBac.ChiSoCapBac / 10) == 7;
            if (!blnKiemTraBac)
            {
                int nNewChiSoCapBac = aCapBac.ChiSoCapBac - 1;

                CapBacDTO aNewCapBac = CapBacBUS.LayCapBacTheoChiSo(nNewChiSoCapBac, _lstCapBac);                                                       
                if (aNewCapBac != null)
                {
                    aHoiVien.MaCapBac = aNewCapBac.IDCapBac;
                    HoiVienBUS.CapNhatHoiVien(aHoiVien);
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
