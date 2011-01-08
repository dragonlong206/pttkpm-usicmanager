using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class ChiTietThachDauBUS
    {
        public static Boolean ThemChiTietThachDau(DTO.ChiTietThachDauDTO ChiTietThachDau)
        {
            Boolean blnDaThemDuoc = false;

            ChiTietThachDau.IDChiTietThachDau = 0;
            List<ChiTietThachDauDTO> lstChiTietThachDau = DocDanhSachChiTietThachDau(String.Empty);
            foreach (ChiTietThachDauDTO aChiTietThachDauTam in lstChiTietThachDau)
            {
                if (aChiTietThachDauTam.IDChiTietThachDau > ChiTietThachDau.IDChiTietThachDau)
                    ChiTietThachDau.IDChiTietThachDau = aChiTietThachDauTam.IDChiTietThachDau;
            }
            ChiTietThachDau.IDChiTietThachDau++;

            try
            {
                blnDaThemDuoc = ChiTietThachDauDAO.ThemChiTietThachDau(ChiTietThachDau);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnDaThemDuoc;
        }

        public static Boolean XoaChiTietThachDau(ChiTietThachDauDTO ChiTietThachDau)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = ChiTietThachDauDAO.XoaChiTietThachDau(ChiTietThachDau);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }

        public static bool CapNhatChiTietThachDau(DTO.ChiTietThachDauDTO aChiTietThachDau)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.ChiTietThachDauDAO.CapNhatChiTietThachDau(aChiTietThachDau);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static List<ChiTietThachDauDTO> DocDanhSachChiTietThachDau(String strTieuChiTimKiem)
        {
            List<ChiTietThachDauDTO> lstChiTietThachDau = ChiTietThachDauDAO.DocDanhSachChiTietThachDau(strTieuChiTimKiem);
            return lstChiTietThachDau;
        }
    }
}
