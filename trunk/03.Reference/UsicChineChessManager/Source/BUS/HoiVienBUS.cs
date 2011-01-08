using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class HoiVienBUS
    {        
        public static Boolean ThemHoiVien(DTO.HoiVienDTO HoiVien)
        {
            Boolean blnDaThemDuoc = false;

            HoiVien.IDHoiVien = 0;
            List<HoiVienDTO> lstHoiVien = DocDanhSachHoiVien(String.Empty);
            foreach (HoiVienDTO aHoiVienTam in lstHoiVien)
            {
                if (aHoiVienTam.IDHoiVien > HoiVien.IDHoiVien)
                    HoiVien.IDHoiVien = aHoiVienTam.IDHoiVien;
            }
            HoiVien.IDHoiVien++;

            try
            {
                blnDaThemDuoc = HoiVienDAO.ThemHoiVien(HoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnDaThemDuoc;
        }

        public static Boolean XoaHoiVien(HoiVienDTO HoiVien)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = HoiVienDAO.XoaHoiVien(HoiVien);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }

        public static bool CapNhatHoiVien(DTO.HoiVienDTO aHoiVien)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.HoiVienDAO.CapNhatHoiVien(aHoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static List<HoiVienDTO> DocDanhSachHoiVien(String strTieuChiTimKiem)
        {
            List<HoiVienDTO> lstHoiVien = HoiVienDAO.DocDanhSachHoiVien(strTieuChiTimKiem);
            return lstHoiVien;
        }

        public static List<HoiVienDTO> DocDanhSachHoiVien(String strTieuChiTimKiem, String strSortOrder)
        {
            List<HoiVienDTO> lstHoiVien = HoiVienDAO.DocDanhSachHoiVien(strTieuChiTimKiem, strSortOrder);
            return lstHoiVien;
        }


        #region Cac ham ho tro truy xuat HoiVien tuy bien.
        public static List<HoiVienDTO> CopyListHoiVien(List<HoiVienDTO> lstHoiVien)
        {
            //Ham nay dung khi can han che load du lieu nhieu lan tu Database => Tang toc do thuc thi.
            List<HoiVienDTO> lstKetQua = new List<HoiVienDTO>();

            foreach(HoiVienDTO aHoiVien in lstHoiVien)
            {                
                lstKetQua.Add(aHoiVien);
            }

            return lstKetQua;
        }

        public static List<HoiVienDTO> LayDSHoiVienTheoCapBac(int nIDCapBac, List<HoiVienDTO> lstHoiVien)
        {
            List<HoiVienDTO> lstKetQua = new List<HoiVienDTO>();

            foreach(HoiVienDTO aHoiVien in lstHoiVien)
            {
                if(aHoiVien.MaCapBac == nIDCapBac)
                    lstKetQua.Add(aHoiVien);
            }
            return lstKetQua;
        }

        public static HoiVienDTO LayHoiVienTheoID(int nIDHoiVien)
        {
            String strLayHoiVien = " Where IDHoiVien = " + nIDHoiVien.ToString();
            List<HoiVienDTO> lstHoiVien = HoiVienBUS.DocDanhSachHoiVien(strLayHoiVien);
            if (lstHoiVien.Count > 0)            
                return lstHoiVien[0];           
            else
                return null;
        }

        public static HoiVienDTO LayHoiVienTheoID(int nIDHoiVien, List<HoiVienDTO> lstHoiVien)
        {
            HoiVienDTO aHoiVien = null;

            foreach(HoiVienDTO aHoiVienTam in lstHoiVien)
            {
                if (aHoiVienTam.IDHoiVien == nIDHoiVien)                
                    return aHoiVien = aHoiVienTam;                                   
            }

            return aHoiVien;
        }

        public static HoiVienDTO LayHoiVienTheoMSSV(String strMSSV)
        {
            String strLayHoiVien = " Where MSSV = '" + strMSSV + "'";
            List<HoiVienDTO> lstHoiVien = HoiVienBUS.DocDanhSachHoiVien(strLayHoiVien);
            if (lstHoiVien.Count > 0)
                return lstHoiVien[0];
            else
                return null;
        }

        public static HoiVienDTO LayHoiVienTheoMSSV(String strMSSV, List<HoiVienDTO> lstHoiVien)
        {
            HoiVienDTO aHoiVien = null;

            foreach(HoiVienDTO aHoiVienTam in lstHoiVien)
            {
                if (aHoiVienTam.MSSV == strMSSV)
                    return aHoiVien = aHoiVienTam;
            }

            return aHoiVien;
        }        

        public static HoiVienDTO LayHoiVienMacDinh()
        {
            HoiVienDTO aHoiVien = new HoiVienDTO();
            
            String strLayHoiVien = " Where MSSV like 'Default'";
            List<HoiVienDTO> lstHoiVienTam = HoiVienDAO.DocDanhSachHoiVien(strLayHoiVien);
            if (lstHoiVienTam.Count > 0)
                return aHoiVien = lstHoiVienTam[0];

            return aHoiVien;
        }

        public static HoiVienDTO LayHoiVienMacDinh(List<HoiVienDTO> lstHoiVien)
        {
            HoiVienDTO aHoiVien = new HoiVienDTO();

            if(lstHoiVien.Count > 0)
            {
                foreach(HoiVienDTO aHoiVienTam in lstHoiVien)
                {
                    if (aHoiVienTam.MSSV == "Default")
                        return aHoiVien = aHoiVienTam;
                }                
            }
           
            String strLayHoiVien = " Where MSSV like 'Default'";
            List<HoiVienDTO> lstHoiVienTam = HoiVienDAO.DocDanhSachHoiVien(strLayHoiVien);
            if (lstHoiVienTam.Count > 0)
                return lstHoiVienTam[0];            

            return aHoiVien;
        }
        #endregion
    }
}
