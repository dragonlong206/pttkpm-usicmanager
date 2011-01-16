using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using DTO;

namespace DAO
{
    public class CapBacHoiVienDAO
    {
        #region Select
        public DataTable LayDanhSachTatCaCapBac()
        {
            try
            {
                string sql = "SELECT ID, TenCapBac FROM CAP_BAC_HOI_VIEN WHERE DaXoa = 0";
                DataTable danhSachCapBac = SqlDataAccessHelper.ExecuteQuery(sql, null);
                return danhSachCapBac;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string LayTenCapBacTheoMaCapBac(int maCapBac)
        {
            try
            {
                string sql = "SELECT TenCapBac FROM CAP_BAC_HOI_VIEN WHERE ID = ?";

                OleDbParameter prMaCapBac = new OleDbParameter("@MaCapBac", OleDbType.Integer);
                prMaCapBac.Value = maCapBac;

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();
                sqlParams.Add(prMaCapBac);

                DataTable capBac = SqlDataAccessHelper.ExecuteQuery(sql, sqlParams);

                string ketQua = string.Empty;
                if (capBac.Rows.Count > 0)
                {
                    ketQua = capBac.Rows[0][0].ToString();
                }

                return ketQua;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string LayTenCapBacNhoNhat()
        {
            string sql = @"SELECT TenCapBac FROM CAP_BAC_HOI_VIEN 
                            WHERE STT = (SELECT MIN(STT) FROM CAP_BAC_HOI_VIEN)";
            DataTable tenCapBac = SqlDataAccessHelper.ExecuteQuery(sql, null);
            
            string ketQua = string.Empty;
            if (tenCapBac.Rows.Count > 0)
            {
                ketQua = tenCapBac.Rows[0][0].ToString();
            }
            return ketQua;
        }
        #endregion
    }
}
