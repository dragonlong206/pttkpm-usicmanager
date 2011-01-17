using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class ChuyenDoiPSangDpDAO
    {
        public double LayDpTuP(double p)
        {
            try
            {
                string sql = "SELECT dp FROM CHUYEN_DOI_P_DP WHERE p = ?";

                OleDbParameter prP = new OleDbParameter("@P", OleDbType.Double);
                prP.Value = p;
                
                List<OleDbParameter> sqlParams = new List<OleDbParameter>();
                sqlParams.Add(prP);

                DataTable bangKetQua = SqlDataAccessHelper.ExecuteQuery(sql, sqlParams);
                if (bangKetQua.Rows.Count > 0)
                {
                    double ketQua = double.Parse(bangKetQua.Rows[0][0].ToString());
                    return ketQua;
                }

                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
