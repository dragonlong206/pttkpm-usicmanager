using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class DiemHoiVienDAO
    {
        public static Boolean ThemDiemHoiVien(DiemHoiVienDTO aDiemHoiVien)
        {
            Boolean blnDaThemDuoc = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@IDDiemHoiVien", aDiemHoiVien.IDDiemHoiVien));
                arrParams.Add(new OleDbParameter("@MaHoiVien", aDiemHoiVien.MaHoiVien));
                arrParams.Add(new OleDbParameter("@MaDiem", aDiemHoiVien.MaDiem));
                arrParams.Add(new OleDbParameter("@GiaTri", aDiemHoiVien.GiaTri));

                String strCommand = @"Insert Into DIEM_HOIVIEN(IDDiemHoiVien, MaHoiVien, MaDiem, GiaTri)
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

        public static Boolean XoaDiemHoiVien(DiemHoiVienDTO aDiemHoiVien)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@IDDiemHoiVien", aDiemHoiVien.IDDiemHoiVien));
                String strCommand = @"Delete from DIEM_HOIVIEN
                                      Where IDDiemHoiVien = ?";

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

        public static Boolean CapNhatDiemHoiVien(DiemHoiVienDTO aDiemHoiVien)
        {
            Boolean blnDaUpdate = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();                
                arrParams.Add(new OleDbParameter("@MaHoiVien", aDiemHoiVien.MaHoiVien));
                arrParams.Add(new OleDbParameter("@MaDiem", aDiemHoiVien.MaDiem));
                arrParams.Add(new OleDbParameter("@GiaTri", aDiemHoiVien.GiaTri));
                arrParams.Add(new OleDbParameter("@IDDiemHoiVien", aDiemHoiVien.IDDiemHoiVien));

                String strCommand = @"Update DIEM_HOIVIEN
                                     Set MaHoiVien = ?, MaDiem = ?, GiaTri = ?
                                     Where IDDiemHoiVien = ?";

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

        public static List<DiemHoiVienDTO> DocDanhSachDiemHoiVien(String strTieuChiTimKiem)
        {
            List<DiemHoiVienDTO> lstDiemHoiVien = new List<DiemHoiVienDTO>();

            String strCommand = "Select * from DIEM_HOIVIEN" + strTieuChiTimKiem;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstDiemHoiVien.Add(KhoiTao(aDong));
            }

            return lstDiemHoiVien;
        }

        public static List<DiemHoiVienDTO> DocDanhSachDiemHoiVien(String strTieuChiTimKiem, String strSapXep)
        {
            List<DiemHoiVienDTO> lstDiemHoiVien = new List<DiemHoiVienDTO>();

            String strCommand = "Select * from DIEM_HOIVIEN" + strTieuChiTimKiem + strSapXep;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstDiemHoiVien.Add(KhoiTao(aDong));
            }

            return lstDiemHoiVien;
        }

        public static DTO.DiemHoiVienDTO KhoiTao(DataRow aDong)
        {
            DTO.DiemHoiVienDTO aDiemHoiVien = new DTO.DiemHoiVienDTO();

            aDiemHoiVien.IDDiemHoiVien = int.Parse(aDong["IDDiemHoiVien"].ToString());
            aDiemHoiVien.MaHoiVien = int.Parse(aDong["MaHoiVien"].ToString());
            aDiemHoiVien.MaDiem = int.Parse(aDong["MaDiem"].ToString());
            aDiemHoiVien.GiaTri = double.Parse(aDong["GiaTri"].ToString());

            return aDiemHoiVien;
        }       
    }
}
