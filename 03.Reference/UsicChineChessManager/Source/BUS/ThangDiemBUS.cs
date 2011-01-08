using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class ThangDiemBUS
    {
        public static Boolean ThemDiem(DTO.ThangDiemDTO Diem)
        {
            Boolean blnDaThemDuoc = false;

            Diem.IDDiem = 0;
            List<ThangDiemDTO> lstDiem = DocDanhSachDiem(String.Empty);
            foreach (ThangDiemDTO aDiemTam in lstDiem)
            {
                if (aDiemTam.IDDiem > Diem.IDDiem)
                    Diem.IDDiem = aDiemTam.IDDiem;
            }
            Diem.IDDiem++;

            try
            {
                blnDaThemDuoc = ThangDiemDAO.ThemDiem(Diem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnDaThemDuoc;
        }

        public static Boolean XoaDiem(ThangDiemDTO Diem)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = ThangDiemDAO.XoaDiem(Diem);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }

        public static bool CapNhatDiem(DTO.ThangDiemDTO aDiem)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.ThangDiemDAO.CapNhatDiem(aDiem);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static List<ThangDiemDTO> DocDanhSachDiem(String strTieuChiTimKiem)
        {
            List<ThangDiemDTO> lstDiem = ThangDiemDAO.DocDanhSachDiem(strTieuChiTimKiem);
            return lstDiem;
        }

        public static List<ThangDiemDTO> DocDanhSachDiem(String strTieuChiTimKiem, String strSapXep)
        {
            List<ThangDiemDTO> lstDiem = ThangDiemDAO.DocDanhSachDiem(strTieuChiTimKiem, strSapXep);
            return lstDiem;
        }

        public static List<ThangDiemDTO> CopyListThangDiem(List<ThangDiemDTO> lstThangDiem)
        {
            List<ThangDiemDTO> lstKetQua = new List<ThangDiemDTO>();

            foreach(ThangDiemDTO aDiem in lstThangDiem)
            {
                lstKetQua.Add(aDiem);
            }
            return lstKetQua;
        }

        public static ThangDiemDTO LayThangDiemTheoID(int nID)
        {
            String strLayThangDiem = " Where IDDiem = " + nID.ToString();
            List<ThangDiemDTO> lstThangDiem = ThangDiemDAO.DocDanhSachDiem(strLayThangDiem);
            if (lstThangDiem.Count > 0)
                return lstThangDiem[0];
            else
                return null;
        }

        public static ThangDiemDTO LayThangDiemTheoID(int nID, List<ThangDiemDTO> lstThangDiem)
        {
            ThangDiemDTO aThangDiem = null;

            foreach(ThangDiemDTO aThangDiemTam in lstThangDiem)
            {
                if (aThangDiemTam.IDDiem == nID)
                    return aThangDiem = aThangDiemTam;
            }
            return aThangDiem;
        }

        public static ThangDiemDTO LayThangDiemTheoCongThuc(String strCongThuc, List<ThangDiemDTO> lstThangDiem)
        {
            ThangDiemDTO aDiem = null;

            foreach(ThangDiemDTO aDiemTam in lstThangDiem)
            {
                if (aDiemTam.CongThucTinh == strCongThuc)
                    return aDiem = aDiemTam;
            }
            return aDiem;
        }
    }
}
