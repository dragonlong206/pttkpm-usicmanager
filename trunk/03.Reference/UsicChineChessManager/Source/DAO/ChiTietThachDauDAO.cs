using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class ChiTietThachDauDAO
    {
        public static Boolean ThemChiTietThachDau(ChiTietThachDauDTO aChiTietThachDau)
        {
            Boolean blnDaThemDuoc = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@IDChiTietThachDau", aChiTietThachDau.IDChiTietThachDau));
                arrParams.Add(new OleDbParameter("@MaThachDau", aChiTietThachDau.MaThachDau));                
                arrParams.Add(new OleDbParameter("@MaHoiVien1", aChiTietThachDau.MaHoiVien1));
                arrParams.Add(new OleDbParameter("@MaHoiVien2", aChiTietThachDau.MaHoiVien2));
                arrParams.Add(new OleDbParameter("@KetQua", aChiTietThachDau.KetQua));

                String strCommand = @"Insert Into CHITIET_THACHDAU(IDChiTietThachDau, MaThachDau, MaHoiVien1, MaHoiVien2, KetQua)
                                      Values(?,?,?,?,?)";

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

        public static Boolean XoaChiTietThachDau(ChiTietThachDauDTO aChiTietThachDau)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@IDChiTietThachDau", aChiTietThachDau.IDChiTietThachDau));
                String strCommand = @"Delete from CHITIET_THACHDAU
                                      Where IDChiTietThachDau = ?";

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

        public static Boolean CapNhatChiTietThachDau(ChiTietThachDauDTO aChiTietThachDau)
        {
            Boolean blnDaUpdate = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();                
                arrParams.Add(new OleDbParameter("@MaThachDau", aChiTietThachDau.MaThachDau));                
                arrParams.Add(new OleDbParameter("@MaHoiVien1", aChiTietThachDau.MaHoiVien1));
                arrParams.Add(new OleDbParameter("@MaHoiVien2", aChiTietThachDau.MaHoiVien2));
                arrParams.Add(new OleDbParameter("@KetQua", aChiTietThachDau.KetQua));
                arrParams.Add(new OleDbParameter("@IDChiTietThachDau", aChiTietThachDau.IDChiTietThachDau));

                String strCommand = @"Update CHITIET_THACHDAU
                                     Set MaThachDau = ?, MaHoiVien1 = ?, MaHoiVien2 = ?, KetQua = ?
                                     Where IDChiTietThachDau = ?";

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

        public static List<ChiTietThachDauDTO> DocDanhSachChiTietThachDau(String strTieuChiTimKiem)
        {
            List<ChiTietThachDauDTO> lstChiTietThachDau = new List<ChiTietThachDauDTO>();

            String strCommand = "Select * from CHITIET_THACHDAU" + strTieuChiTimKiem;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstChiTietThachDau.Add(KhoiTao(aDong));
            }

            return lstChiTietThachDau;
        }

        public static DTO.ChiTietThachDauDTO KhoiTao(DataRow aDong)
        {
            DTO.ChiTietThachDauDTO aChiTietThachDau = new DTO.ChiTietThachDauDTO();

            aChiTietThachDau.IDChiTietThachDau = int.Parse(aDong["IDChiTietThachDau"].ToString());
            aChiTietThachDau.MaThachDau = int.Parse(aDong["MaThachDau"].ToString());           
            aChiTietThachDau.MaHoiVien1 = int.Parse(aDong["MaHoiVien1"].ToString());
            aChiTietThachDau.MaHoiVien2 = int.Parse(aDong["MaHoiVien2"].ToString());
            aChiTietThachDau.KetQua = aDong["KetQua"].ToString();

            return aChiTietThachDau;
        }       
    }
}
