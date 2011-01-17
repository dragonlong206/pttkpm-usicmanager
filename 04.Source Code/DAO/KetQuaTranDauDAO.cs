using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class KetQuaTranDauDAO
    {
        public DataTable LayDanhSachKetQua()
        {
            try
            {
                string sql = "SELECT * FROM KET_QUA_TRAN_DAU";

                DataTable ketQua = SqlDataAccessHelper.ExecuteQuery(sql, null);

                return ketQua;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string LayKetQuaTuMa(int maKetQua)
        {
            try
            {
                string sql = "SELECT TheHien FROM KET_QUA_TRAN_DAU WHERE ID = ?";

                OleDbParameter prMaKetQua = new OleDbParameter("@ID", OleDbType.Integer);
                prMaKetQua.Value = maKetQua;

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();
                sqlParams.Add(prMaKetQua);

                DataTable ketQuaTranDau = SqlDataAccessHelper.ExecuteQuery(sql, sqlParams);

                string ketQua = string.Empty;

                if (ketQuaTranDau.Rows.Count > 0)
                {
                    ketQua = ketQuaTranDau.Rows[0]["TheHien"].ToString();
                }

                return ketQua;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
