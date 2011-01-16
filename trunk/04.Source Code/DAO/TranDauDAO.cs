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
                string sql = @"INSERT INTO TRAN_DAU(MaDauThu1, MaDauThu2, ThoiGian, DiaDiem, MaTrongTai, MaKetQua) 
                                VALUES (?, ?, ?, ?, ?, ?)";

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();

                OleDbParameter prMaDauThu1 = new OleDbParameter("@MaDauThu1", OleDbType.Integer);
                prMaDauThu1.Value = tranDauDTO.MaDauThu1;
                sqlParams.Add(prMaDauThu1);

                OleDbParameter prMaDauThu2 = new OleDbParameter("@MaDauThu2", OleDbType.Integer);
                prMaDauThu2.Value = tranDauDTO.MaDauThu2;
                sqlParams.Add(prMaDauThu2);

                OleDbParameter prThoiGian = new OleDbParameter("@ThoiGian", OleDbType.Date);
                prThoiGian.Value = tranDauDTO.ThoiGian;
                sqlParams.Add(prThoiGian);

                OleDbParameter prDiaDiem = new OleDbParameter("@DiaDiem", OleDbType.VarWChar);
                prDiaDiem.Value = tranDauDTO.DiaDiem;
                sqlParams.Add(prDiaDiem);

                OleDbParameter prMaTrongTai = new OleDbParameter("@MaTrongTai", OleDbType.Integer);
                prMaTrongTai.Value = tranDauDTO.MaTrongTai;
                sqlParams.Add(prMaTrongTai);

                OleDbParameter prMaKetQua = new OleDbParameter("@MaKetQua", OleDbType.Integer);
                prMaKetQua.Value = tranDauDTO.MaKetQua;
                sqlParams.Add(prMaKetQua);

                int soDongThemDuoc = SqlDataAccessHelper.ExecuteNoneQuery(sql, sqlParams);

                if (soDongThemDuoc == 1)
                {
                    return true;
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
