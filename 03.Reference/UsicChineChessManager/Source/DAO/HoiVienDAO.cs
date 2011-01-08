using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class HoiVienDAO
    {
        public static Boolean ThemHoiVien(HoiVienDTO aHoiVien)
        {
            Boolean blnDaThemDuoc = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@IDHoiVien", aHoiVien.IDHoiVien));
                arrParams.Add(new OleDbParameter("@MSSV", aHoiVien.MSSV));
                arrParams.Add(new OleDbParameter("@HoTen", aHoiVien.HoTen));
                arrParams.Add(new OleDbParameter("@MaCapBac", aHoiVien.MaCapBac));

                String strCommand = @"Insert Into HOI_VIEN(IDHoiVien, MSSV, HoTen, MaCapBac)
                                      Values(?,?,?,?)";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    return blnDaThemDuoc = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaThemDuoc;
        }

        public static Boolean XoaHoiVien(HoiVienDTO aHoiVien)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@IDHoiVien", aHoiVien.IDHoiVien));
                String strCommand = @"Delete from HOI_VIEN
                                      Where IDHoiVien = ?";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    blnKetQua = true;
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean CapNhatHoiVien(HoiVienDTO aHoiVien)
        {
            Boolean blnDaUpdate = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@MSSV", aHoiVien.MSSV));
                arrParams.Add(new OleDbParameter("@HoTen", aHoiVien.HoTen));
                arrParams.Add(new OleDbParameter("@MaCapBac", aHoiVien.MaCapBac));
                arrParams.Add(new OleDbParameter("@IDHoiVien", aHoiVien.IDHoiVien));

                String strCommand = @"Update HOI_VIEN
                                     Set MSSV = ?, HoTen = ?, MaCapBac = ?
                                     Where IDHoiVien = ?";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    return blnDaUpdate = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaUpdate;
        }

        public static List<HoiVienDTO> DocDanhSachHoiVien(String strTieuChiTimKiem)
        {
            List<HoiVienDTO> lstHoiVien = new List<HoiVienDTO>();

            String strCommand = "Select * from HOI_VIEN" + strTieuChiTimKiem;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstHoiVien.Add(KhoiTao(aDong));
            }

            return lstHoiVien;
        }

        public static List<HoiVienDTO> DocDanhSachHoiVien(String strTieuChiTimKiem, String strSortOrder)
        {
            List<HoiVienDTO> lstHoiVien = new List<HoiVienDTO>();

            String strCommand = "Select * from HOI_VIEN" + strTieuChiTimKiem + strSortOrder;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstHoiVien.Add(KhoiTao(aDong));
            }

            return lstHoiVien;
        }

        public static DTO.HoiVienDTO KhoiTao(DataRow aDong)
        {
            DTO.HoiVienDTO aHoiVien = new DTO.HoiVienDTO();

            aHoiVien.IDHoiVien = int.Parse(aDong["IDHoiVien"].ToString());
            aHoiVien.MSSV = aDong["MSSV"].ToString();
            aHoiVien.HoTen = aDong["HoTen"].ToString();
            aHoiVien.MaCapBac = int.Parse(aDong["MaCapBac"].ToString());

            return aHoiVien;
        }       
    }
}
