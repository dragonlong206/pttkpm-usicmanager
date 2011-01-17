using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class CapToChucGiaiDauDAO
    {
        public CapToChucGiaiDauDTO LayThongTinCapToChucTuMa(int maCapToChuc)
        {
            try
            {
                string sql = "SELECT * FROM CAP_TO_CHUC_GIAI_DAU WHERE ID = ?";

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();

                OleDbParameter prMaCapToChuc = new OleDbParameter("@ID", OleDbType.Integer);
                prMaCapToChuc.Value = maCapToChuc;
                sqlParams.Add(prMaCapToChuc);

                DataTable bangKetQua = SqlDataAccessHelper.ExecuteQuery(sql, sqlParams);
                if (bangKetQua.Rows.Count > 0)
                {
                    return LayDuLieuCapBacTuBang(bangKetQua, 0);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CapToChucGiaiDauDTO LayDuLieuCapBacTuBang(DataTable danhSachCapBac, int chiSoDong)
        {
            CapToChucGiaiDauDTO capToChucGiaiDauDTO = new CapToChucGiaiDauDTO();
            int temp1;
            bool success;
            success = int.TryParse(danhSachCapBac.Rows[chiSoDong]["ID"].ToString(), out temp1);
            if (success)
            {
                capToChucGiaiDauDTO.ID = temp1;
            }

            capToChucGiaiDauDTO.TenCap = danhSachCapBac.Rows[chiSoDong]["TenCap"].ToString();

            success = int.TryParse(danhSachCapBac.Rows[chiSoDong]["STT"].ToString(), out temp1);
            if (success)
            {
                capToChucGiaiDauDTO.STT = temp1;
            }

            return capToChucGiaiDauDTO;
        }
    }
}
