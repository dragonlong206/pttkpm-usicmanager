using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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
    }
}
