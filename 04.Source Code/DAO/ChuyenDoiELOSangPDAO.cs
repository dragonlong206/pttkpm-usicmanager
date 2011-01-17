using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public enum KET_QUA
    {
        THANG,
        HOA,
        THUA
    };

    public class ChuyenDoiELOSangPDAO
    {
        public double[] TinhP(double ELO1, double ELO2, string ketQuaTranDau)
        {
            try
            {
                KET_QUA loaiKetQua;
                //string ketQuaTranDau = (new KetQuaTranDauDAO()).LayKetQuaTuMa(maKetQua).Trim();
                string selectSql = string.Empty;

                if (ketQuaTranDau.Equals("1-0"))
                {
                    loaiKetQua = KET_QUA.THANG;
                }
                else if (ketQuaTranDau.Equals("0-0"))
                {
                    loaiKetQua = KET_QUA.HOA;
                }
                else
                {
                    loaiKetQua = KET_QUA.THUA;
                }

                double [] p = this.LayHpLp(ELO1, ELO2);
                if (p != null)
                {
                double p1 = 0;
                double p2 = 0;

                if (ELO1 > ELO2)
                {
                    if (loaiKetQua == KET_QUA.THANG)
                    {
                        // Nếu người có ELO lớn hơn thắng thì dùng Lp để tính toán
                        p1 = p[1];
                        p2 = -p[1];
                    }
                    else if (loaiKetQua == KET_QUA.HOA)
                    {
                        p1 = -p[1];
                        p2 = p[0];
                    }
                    else
                    {
                        p1 = -p[0];
                        p2 = p[0];
                    }
                }
                else
                {
                    if (loaiKetQua == KET_QUA.THANG)
                    {
                        // Nếu người có ELO lớn hơn thắng thì dùng Lp để tính toán
                        p1 = p[0];
                        p2 = -p[0];
                    }
                    else if (loaiKetQua == KET_QUA.HOA)
                    {
                        p1 = p[0];
                        p2 = -p[1];
                    }
                    else
                    {
                        p1 = -p[1];
                        p2 = p[1];
                    }
                }
                    return new double[] {p1, p2};
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double[] LayHpLp(double ELO1, double ELO2)
        {
            try
            {
                int D = (int)(Math.Abs(ELO1 - ELO2) + 0.5);
                string sql = @"SELECT Hp, Lp FROM CHUYEN_DOI_ELO_P 
                            WHERE DMin <= @D AND DMax >= @D";

                OleDbParameter prD = new OleDbParameter("@D", OleDbType.Integer);
                prD.Value = D;

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();
                sqlParams.Add(prD);
                //sqlParams.Add(prD);

                DataTable ketQua = SqlDataAccessHelper.ExecuteQuery(sql, sqlParams);

                if (ketQua.Rows.Count > 0)
                {
                    double Hp = double.Parse(ketQua.Rows[0]["Hp"].ToString());
                    double Lp = double.Parse(ketQua.Rows[0]["Lp"].ToString());
                    return new double[] { Hp, Lp };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
