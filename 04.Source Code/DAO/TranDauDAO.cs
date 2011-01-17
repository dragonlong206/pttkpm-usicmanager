using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class TranDauDAO
    {
        #region Insert

        public bool ThemTranDau(TranDauDTO tranDauDTO)
        {
            // TODO Kiểm tra nếu null thì không thêm vào
            try
            {
                StringBuilder sql = new StringBuilder("INSERT INTO TRAN_DAU(");

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();

                if (tranDauDTO.MaDauThu1 != 0)
                {
                    OleDbParameter prMaDauThu1 = new OleDbParameter("@MaDauThu1", OleDbType.Integer);
                    prMaDauThu1.Value = tranDauDTO.MaDauThu1;
                    sqlParams.Add(prMaDauThu1);
                }

                if (tranDauDTO.MaDauThu2 != 0)
                {
                    OleDbParameter prMaDauThu2 = new OleDbParameter("@MaDauThu2", OleDbType.Integer);
                    prMaDauThu2.Value = tranDauDTO.MaDauThu2;
                    sqlParams.Add(prMaDauThu2);
                }

                OleDbParameter prThoiGian = new OleDbParameter("@ThoiGian", OleDbType.Date);
                prThoiGian.Value = tranDauDTO.ThoiGian;
                sqlParams.Add(prThoiGian);

                OleDbParameter prDiaDiem = new OleDbParameter("@DiaDiem", OleDbType.VarWChar);
                prDiaDiem.Value = tranDauDTO.DiaDiem;
                sqlParams.Add(prDiaDiem);

                if (tranDauDTO.MaTrongTai != 0)
                {
                    OleDbParameter prMaTrongTai = new OleDbParameter("@MaTrongTai", OleDbType.Integer);
                    prMaTrongTai.Value = tranDauDTO.MaTrongTai;
                    sqlParams.Add(prMaTrongTai);
                }

                if (tranDauDTO.MaKetQua != 0)
                {
                    OleDbParameter prMaKetQua = new OleDbParameter("@MaKetQua", OleDbType.Integer);
                    prMaKetQua.Value = tranDauDTO.MaKetQua;
                    sqlParams.Add(prMaKetQua);

                    OleDbParameter prP1 = new OleDbParameter("@P1", OleDbType.Double);
                    prP1.Value = tranDauDTO.P1;
                    sqlParams.Add(prP1);

                    OleDbParameter prP2 = new OleDbParameter("@P2", OleDbType.Double);
                    prP2.Value = tranDauDTO.P2;
                    sqlParams.Add(prP2);
                }

                if (sqlParams.Count > 0)
                {
                    StringBuilder insertSql = new StringBuilder(sqlParams[0].ParameterName.Substring(1));
                    StringBuilder valueSql = new StringBuilder("?");

                    for (int i = 1; i < sqlParams.Count; i++)
                    {
                        insertSql.Append(", ").Append(sqlParams[i].ParameterName.Substring(1));
                        valueSql.Append(", ?");
                    }

                    sql.Append(insertSql).Append(")").Append(" VALUES (").Append(valueSql).Append(")");

                    int soDongThemDuoc = SqlDataAccessHelper.ExecuteNoneQuery(sql.ToString(), sqlParams);

                    if (soDongThemDuoc == 1)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
