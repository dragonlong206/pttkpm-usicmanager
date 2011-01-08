using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class ThachDauDAO
    {
        public static Boolean ThemThachDau(ThachDauDTO aThachDau)
        {
            Boolean blnDaThemDuoc = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@IDThachDau", aThachDau.IDThachDau));
                arrParams.Add(new OleDbParameter("@ThoiGian", aThachDau.ThoiGian));
                arrParams.Add(new OleDbParameter("@DiaDiem", aThachDau.DiaDiem));
                arrParams.Add(new OleDbParameter("@NguoiQuanLy", aThachDau.NguoiQuanLy));

                String strCommand = @"Insert Into THACH_DAU(IDThachDau, ThoiGian, DiaDiem, NguoiQuanLy)
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

        public static Boolean XoaThachDau(ThachDauDTO aThachDau)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@IDThachDau", aThachDau.IDThachDau));
                String strCommand = @"Delete from THACH_DAU
                                      Where IDThachDau = ?";

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

        public static Boolean CapNhatThachDau(ThachDauDTO aThachDau)
        {
            Boolean blnDaUpdate = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();                
                arrParams.Add(new OleDbParameter("@ThoiGian", aThachDau.ThoiGian));
                arrParams.Add(new OleDbParameter("@DiaDiem", aThachDau.DiaDiem));
                arrParams.Add(new OleDbParameter("@NguoiQuanLy", aThachDau.NguoiQuanLy));
                arrParams.Add(new OleDbParameter("@IDThachDau", aThachDau.IDThachDau));

                String strCommand = @"Update THACH_DAU
                                     Set ThoiGian = ?, DiaDiem = ?, NguoiQuanLy = ?
                                     Where IDThachDau = ?";

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

        public static List<ThachDauDTO> DocDanhSachThachDau(String strTieuChiTimKiem)
        {
            List<ThachDauDTO> lstThachDau = new List<ThachDauDTO>();

            try
            {
                String strCommand = "Select * from THACH_DAU" + strTieuChiTimKiem;
                DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

                foreach (DataRow aDong in table.Rows)
                {
                    lstThachDau.Add(KhoiTao(aDong));
                }
            }
            catch (System.Exception ex)
            {
            	throw ex;
            }
           

            return lstThachDau;
        }

        public static List<ThachDauDTO> DocDanhSachThachDau(String strTieuChiTimKiem, String strSapXep)
        {
            List<ThachDauDTO> lstThachDau = new List<ThachDauDTO>();

            try
            {
                String strCommand = "Select * from THACH_DAU" + strTieuChiTimKiem + strSapXep;
                DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

                foreach (DataRow aDong in table.Rows)
                {
                    lstThachDau.Add(KhoiTao(aDong));
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }


            return lstThachDau;
        }

        public static ThachDauDTO LayThachDauTheoNgay(DateTime timeNgayThachDau)
        {
            ThachDauDTO aThachDau = null;

            try
            {
                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@ThoiGian", timeNgayThachDau));

                String strCommand = @"Select * from THACH_DAU
                                      where ThoiGian = ?";

                DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, lstParams);
                if (table.Rows.Count > 0)
                {
                    aThachDau = KhoiTao(table.Rows[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aThachDau;
        }

        public static DTO.ThachDauDTO KhoiTao(DataRow aDong)
        {
            DTO.ThachDauDTO aThachDau = new DTO.ThachDauDTO();

            aThachDau.IDThachDau = int.Parse(aDong["IDThachDau"].ToString());
            aThachDau.ThoiGian = DateTime.Parse(aDong["ThoiGian"].ToString());
            aThachDau.DiaDiem = aDong["DiaDiem"].ToString();
            aThachDau.NguoiQuanLy = int.Parse(aDong["NguoiQuanLy"].ToString());

            return aThachDau;
        }               
    }
}
