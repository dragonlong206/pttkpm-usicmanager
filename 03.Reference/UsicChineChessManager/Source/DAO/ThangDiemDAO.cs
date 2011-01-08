using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class ThangDiemDAO
    {
        public static Boolean ThemDiem(ThangDiemDTO aDiem)
        {
            Boolean blnDaThemDuoc = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@IDDiem", aDiem.IDDiem));
                arrParams.Add(new OleDbParameter("@TenDiem", aDiem.TenDiem));
                arrParams.Add(new OleDbParameter("@CongThucTinh", aDiem.CongThucTinh));

                String strCommand = @"Insert Into THANG_DIEM(IDDiem, TenDiem, CongThucTinh)
                                      Values(?,?,?)";

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

        public static Boolean XoaDiem(ThangDiemDTO aDiem)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@IDDiem", aDiem.IDDiem));
                String strCommand = @"Delete from THANG_DIEM
                                      Where IDDiem = ?";

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

        public static Boolean CapNhatDiem(ThangDiemDTO aDiem)
        {
            Boolean blnDaUpdate = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@TenDiem", aDiem.TenDiem));
                arrParams.Add(new OleDbParameter("@CongThucTinh", aDiem.CongThucTinh));
                arrParams.Add(new OleDbParameter("@IDDiem", aDiem.IDDiem));

                String strCommand = @"Update THANG_DIEM
                                     Set TenDiem = ?, CongThucTinh = ?
                                     Where IDDiem = ?";

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

        public static List<ThangDiemDTO> DocDanhSachDiem(String strTieuChiTimKiem)
        {
            List<ThangDiemDTO> lstDiem = new List<ThangDiemDTO>();

            String strCommand = "Select * from THANG_DIEM" + strTieuChiTimKiem;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstDiem.Add(KhoiTao(aDong));
            }

            return lstDiem;
        }

        public static List<ThangDiemDTO> DocDanhSachDiem(String strTieuChiTimKiem, String strSapXep)
        {
            List<ThangDiemDTO> lstDiem = new List<ThangDiemDTO>();

            String strCommand = "Select * from THANG_DIEM" + strTieuChiTimKiem + strSapXep;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstDiem.Add(KhoiTao(aDong));
            }

            return lstDiem;
        }

        public static DTO.ThangDiemDTO KhoiTao(DataRow aDong)
        {
            DTO.ThangDiemDTO aDiem = new DTO.ThangDiemDTO();

            aDiem.IDDiem = int.Parse(aDong["IDDiem"].ToString());
            aDiem.TenDiem = aDong["TenDiem"].ToString();
            aDiem.CongThucTinh = aDong["CongThucTinh"].ToString();

            return aDiem;
        }       
    }
}
