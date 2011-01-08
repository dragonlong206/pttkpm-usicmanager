using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class CapBacBUS
    {       
        public static Boolean ThemCapBac(DTO.CapBacDTO CapBac)
        {
            Boolean blnDaThemDuoc = false;

            CapBac.IDCapBac = 0;
            List<CapBacDTO> lstCapBac = DocDanhSachCapBac(String.Empty);
            foreach (CapBacDTO aCapBacTam in lstCapBac)
            {
                if (aCapBacTam.IDCapBac > CapBac.IDCapBac)
                    CapBac.IDCapBac = aCapBacTam.IDCapBac;
            }
            CapBac.IDCapBac++;

            try
            {
                blnDaThemDuoc = CapBacDAO.ThemCapBac(CapBac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnDaThemDuoc;
        }

        public static Boolean XoaCapBac(CapBacDTO CapBac)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = CapBacDAO.XoaCapBac(CapBac);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }

        public static bool CapNhatCapBac(DTO.CapBacDTO aCapBac)
        {
            Boolean blnKetQua = false;
            
            try
            {
                blnKetQua = DAO.CapBacDAO.CapNhatCapBac(aCapBac);                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static List<CapBacDTO> DocDanhSachCapBac(String strTieuChiTimKiem)
        {
            List<CapBacDTO> lstCapBac = CapBacDAO.DocDanhSachCapBac(strTieuChiTimKiem);
            return lstCapBac;
        }

        public static List<CapBacDTO> DocDanhSachCapBac(String strTieuChiTimKiem, String strSapXep)
        {
            List<CapBacDTO> lstCapBac = CapBacDAO.DocDanhSachCapBac(strTieuChiTimKiem, strSapXep);
            return lstCapBac;
        }

        public static List<CapBacDTO> CopyListCapBac(List<CapBacDTO> lstCapBac)
        {
            List<CapBacDTO> lstKetQua = new List<CapBacDTO>();

            foreach(CapBacDTO aCapBac in lstCapBac)
            {
                lstKetQua.Add(aCapBac);
            }
            return lstKetQua;
        }

        public static CapBacDTO LayCapBacTheoID(int nIDCapBac)
        {
            String strLayCapBac = " Where IDCapBac = " + nIDCapBac.ToString();
            List<CapBacDTO> lstCapBac = CapBacDAO.DocDanhSachCapBac(strLayCapBac);
            if (lstCapBac.Count > 0)
                return lstCapBac[0];
            else
                return null;
        }

        public static CapBacDTO LayCapBacTheoID(int nIDCapBac, List<CapBacDTO> lstCapBac)
        {
            CapBacDTO aCapBac = null;

            foreach(CapBacDTO aCapBacTam in lstCapBac)
            {
                if (aCapBacTam.IDCapBac == nIDCapBac)
                    return aCapBac = aCapBacTam;
            }
            return aCapBac;
        }

        public static CapBacDTO LayCapBacTheoChiSo(int nChiSoCapBac, List<CapBacDTO> lstCapBac)
        {
            CapBacDTO aCapBac = null;

            foreach(CapBacDTO aCapBacTam in lstCapBac)
            {
                if (aCapBacTam.ChiSoCapBac == nChiSoCapBac)
                    return aCapBac = aCapBacTam;                
            }
            return aCapBac;
        }

        public static CapBacDTO LayCapBacMacDinh()
        {
            CapBacDTO aCapBac = new CapBacDTO();

            String strLayCapBac = " Where TenCapBac like 'Default'";
            List<CapBacDTO> lstCapBac = CapBacDAO.DocDanhSachCapBac(strLayCapBac);
            if (lstCapBac.Count > 0)
                return aCapBac = lstCapBac[0];

            return aCapBac;
        }

        public static CapBacDTO LayCapBacMacDinh(List<CapBacDTO> lstCapBac)
        {
            CapBacDTO aCapBac = new CapBacDTO();

            foreach(CapBacDTO aCapBacTam in lstCapBac)
            {
                if (aCapBacTam.TenCapBac == "Default")
                    return aCapBac = aCapBacTam;
            }
            
            String strLayCapBac = " Where TenCapBac like 'Default'";
            List<CapBacDTO> lstCapBacTam = CapBacDAO.DocDanhSachCapBac(strLayCapBac);
            if (lstCapBacTam.Count > 0)
                return lstCapBacTam[0];            

            return aCapBac;
        }
    }
}
