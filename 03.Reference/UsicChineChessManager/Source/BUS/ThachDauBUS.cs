using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class ThachDauBUS
    {
        public static Boolean ThemThachDau(DTO.ThachDauDTO ThachDau)
        {
            Boolean blnDaThemDuoc = false;

            ThachDau.IDThachDau = 0;
            List<ThachDauDTO> lstThachDau = DocDanhSachThachDau(String.Empty);
            foreach (ThachDauDTO aThachDauTam in lstThachDau)
            {
                if (aThachDauTam.IDThachDau > ThachDau.IDThachDau)
                    ThachDau.IDThachDau = aThachDauTam.IDThachDau;
            }
            ThachDau.IDThachDau++;

            try
            {
                blnDaThemDuoc = ThachDauDAO.ThemThachDau(ThachDau);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnDaThemDuoc;
        }

        public static Boolean XoaThachDau(ThachDauDTO ThachDau)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = ThachDauDAO.XoaThachDau(ThachDau);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }

        public static bool CapNhatThachDau(DTO.ThachDauDTO aThachDau)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.ThachDauDAO.CapNhatThachDau(aThachDau);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static List<ThachDauDTO> DocDanhSachThachDau(String strTieuChiTimKiem)
        {
            List<ThachDauDTO> lstThachDau = ThachDauDAO.DocDanhSachThachDau(strTieuChiTimKiem);
            return lstThachDau;
        }

        public static List<ThachDauDTO> DocDanhSachThachDau(String strTieuChiTimKiem, String strSapXep)
        {
            List<ThachDauDTO> lstThachDau = ThachDauDAO.DocDanhSachThachDau(strTieuChiTimKiem, strSapXep);
            return lstThachDau;
        }

        public static List<ThachDauDTO> LayDSThachDauTheoNQL(int nIDNguoiQuanLy, List<ThachDauDTO> lstThachDau)
        {
            List<ThachDauDTO> lstKetQua = new List<ThachDauDTO>();

            foreach (ThachDauDTO aThachDau in lstThachDau)
            {
                if (aThachDau.NguoiQuanLy == nIDNguoiQuanLy)
                    lstKetQua.Add(aThachDau);
            }
            return lstKetQua;
        }

        public static ThachDauDTO LayThachDauTheoNgay(DateTime timeNgayThachDau)
        {
            ThachDauDTO aThachDau = null;
            
            TimeSpan ts = timeNgayThachDau.TimeOfDay;
            timeNgayThachDau = timeNgayThachDau.Subtract(ts);
            try
            {
                aThachDau = ThachDauDAO.LayThachDauTheoNgay(timeNgayThachDau);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return aThachDau;
        }

        public static ThachDauDTO LayThachDauTheoNgay(DateTime timeNgayThachDau, List<ThachDauDTO> lstThachDau)
        {
            ThachDauDTO aThachDau = null;

            TimeSpan ts = timeNgayThachDau.TimeOfDay;
            timeNgayThachDau = timeNgayThachDau.Subtract(ts);

            foreach(ThachDauDTO aThachDauTam in lstThachDau)
            {
                if (aThachDauTam.ThoiGian == timeNgayThachDau)
                    return aThachDau = aThachDauTam;
            }

            return aThachDau;          
        }
    }
}
