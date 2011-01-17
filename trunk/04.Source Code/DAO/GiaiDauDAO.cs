using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using DTO;

namespace DAO
{
    public class GiaiDauDAO
    {
        public bool ThemMoiGiaiDau(GiaiDauDTO giaiDau)
        {
            try
            {
                string sql = @"INSERT INTO GIAI_DAU(TenGiaiDau, DonViToChuc, ThoiGian, DiaDiem, MaCapToChuc) 
                            VALUES(?, ?, ?, ?, ?)";

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();
                OleDbParameter prTenGiaiDau = new OleDbParameter("@TenGiaiDau", OleDbType.VarWChar);
                prTenGiaiDau.Value = giaiDau.TenGiaiDau;
                sqlParams.Add(prTenGiaiDau);

                OleDbParameter prDonViToChuc = new OleDbParameter("@DonViToChuc", OleDbType.VarChar);
                prDonViToChuc.Value = giaiDau.DonViToChuc;
                sqlParams.Add(prDonViToChuc);

                OleDbParameter prThoiGian = new OleDbParameter("@ThoiGian", OleDbType.Integer);
                prThoiGian.Value = giaiDau.ThoiGian;
                sqlParams.Add(prThoiGian);

                OleDbParameter prDiaDiem = new OleDbParameter("@DiaDiem", OleDbType.Double);
                prDiaDiem.Value = giaiDau.DiaDiem;
                sqlParams.Add(prDiaDiem);

                OleDbParameter prMaCapToChuc = new OleDbParameter("@MaCapToChuc", OleDbType.Integer);
                prMaCapToChuc.Value = giaiDau.MaCapToChuc;
                sqlParams.Add(prMaCapToChuc);               

                int soDongThemDuoc = SqlDataAccessHelper.ExecuteNoneQuery(sql, sqlParams);
                if (soDongThemDuoc != 1)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool CapNhatGiaiDau(GiaiDauDTO giaiDauDTO)
        {
            try
            {
                // Dùng StringBuilder để cải tiến performance
                // Mỗi lần cộng chuỗi không phải cấp phát lại vùng nhớ
                StringBuilder sql = new StringBuilder("UPDATE GIAI_DAU SET ", 255);
                List<OleDbParameter> sqlParams = new List<OleDbParameter>();

                // Kiểm tra từng thuộc tính của DTO
                // Nếu nó khác với giá trị mặc định trong phương thức thiết lập của lớp này
                // thì mới cập nhật nó
                if (giaiDauDTO.TenGiaiDau != string.Empty)
                {
                    sql.Append("TenGiaiDau = ?");
                    OleDbParameter prTenGiaiDau = new OleDbParameter("@TenGiaiDau", OleDbType.VarWChar);
                    prTenGiaiDau.Value = giaiDauDTO.TenGiaiDau;
                    sqlParams.Add(prTenGiaiDau);
                }

                if (giaiDauDTO.DonViToChuc != string.Empty)
                {
                    if (sqlParams.Count > 0)
                    {
                        sql.Append(", ");
                    }
                    sql.Append("DonViToChuc = ?");
                    OleDbParameter prDonViToChuc = new OleDbParameter("@DonViToChuc", OleDbType.VarChar);
                    prDonViToChuc.Value = giaiDauDTO.DonViToChuc;
                    sqlParams.Add(prDonViToChuc);
                }

                
                
                    if (sqlParams.Count > 0)
                    {
                        sql.Append(", ");
                    }
                    sql.Append("ThoiGian = ?");
                    OleDbParameter prThoiGian = new OleDbParameter("@ThoiGian", OleDbType.Integer);
                    prThoiGian.Value = giaiDauDTO.ThoiGian;
                    sqlParams.Add(prThoiGian);
                

                if (giaiDauDTO.DiaDiem != string.Empty)
                {
                    if (sqlParams.Count > 0)
                    {
                        sql.Append(", ");
                    }
                    sql.Append("DiaDiem = ?");
                    OleDbParameter prDiaDiem = new OleDbParameter("@DiaDiem", OleDbType.Double);
                    prDiaDiem.Value = giaiDauDTO.DiaDiem;
                    sqlParams.Add(prDiaDiem);
                }

                if (giaiDauDTO.MaCapToChuc != 0)
                {
                    if (sqlParams.Count > 0)
                    {
                        sql.Append(", ");
                    }
                    sql.Append("MaCapToChuc = ?");
                    OleDbParameter prMaCapToChuc = new OleDbParameter("@MaCapToChuc", OleDbType.Integer);
                    prMaCapToChuc.Value = giaiDauDTO.MaCapToChuc;
                    sqlParams.Add(prMaCapToChuc);
                }

                if (sqlParams.Count > 0)
                {
                    sql.Append("WHERE ID = ?");

                    OleDbParameter prID = new OleDbParameter("@ID", OleDbType.Integer);
                    prID.Value = giaiDauDTO.ID;
                    sqlParams.Add(prID);

                    int soDongDuocCapNhat = SqlDataAccessHelper.ExecuteNoneQuery(sql.ToString(), sqlParams);
                    if (soDongDuocCapNhat == 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return false;
        }

        public bool XoaGiaiDau(int ID)
        {
            try
            {
                string sql = "UPDATE GIAI_DAU SET DaXoa = 1 WHERE ID = ?";
                List<OleDbParameter> sqlParams = new List<OleDbParameter>();
                sqlParams.Add(new OleDbParameter("@ID", ID));

                int soDongBiXoa = SqlDataAccessHelper.ExecuteNoneQuery(sql, sqlParams);
                if (soDongBiXoa == 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return false;
        }

        #region Select
        public DataTable LayDanhSachTatCaGiaiDau()
        {
            //List<HoiVienDTO> ketQua = new List<HoiVienDTO>();

            try
            {
                string sql = @"SELECT GD.ID, TenGiaiDau, DonViToChuc, ThoiGian, DiaDiem, MaCapToChuc,
                                FROM GIAI_DAU AS GD INNER JOIN CAP_TO_CHUC_GIAI_DAU AS CTC ON GD.MaCapToChuc = CTC.ID 
                                WHERE GD.DaXoa = 0";
                DataTable danhSachGiaiDau = SqlDataAccessHelper.ExecuteQuery(sql);
                //if (danhSachHoiVien.Rows.Count > 0)
                //{
                //    for (int i = 0; i < danhSachHoiVien.Rows.Count; i++)
                //    {
                //        HoiVienDTO hoiVienDTO = LayDuLieuHoiVienTuBang(danhSachHoiVien, i);
                //        ketQua.Add(hoiVienDTO);
                //    }
                //}
                return SqlDataAccessHelper.AutoNumberedTable(danhSachGiaiDau);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
