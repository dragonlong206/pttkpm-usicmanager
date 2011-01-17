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
            try
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CapBacHoiVienDTO LayCapBacLienTruoc(int maCapBac, int gioiTinh)
        {
            try
            {
                string sql = @"SELECT * FROM CAP_BAC_HOI_VIEN WHERE 
                                STT = (SELECT STT FROM CAP_BAC_HOI_VIEN
                                        WHERE ID = ?) - 1 
                                AND (GioiTinh = 0 OR GioiTinh = ?)";

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();

                OleDbParameter prMaCapBac = new OleDbParameter("@ID", OleDbType.Integer);
                prMaCapBac.Value = maCapBac;
                sqlParams.Add(prMaCapBac);

                OleDbParameter prGioiTinh = new OleDbParameter("@GioiTinh", OleDbType.Integer);
                prGioiTinh.Value = gioiTinh;
                sqlParams.Add(prGioiTinh);

                DataTable bangKetQua = SqlDataAccessHelper.ExecuteQuery(sql, sqlParams);
                if (bangKetQua.Rows.Count > 0)
                {
                    CapBacHoiVienDTO ketQua = LayDuLieuCapBacTuBang(bangKetQua, 0);
                    return ketQua;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CapBacHoiVienDTO LayCapBacLienSau(int maCapBac, int gioiTinh)
        {
            try
            {
                string sql = @"SELECT * FROM CAP_BAC_HOI_VIEN WHERE 
                                STT = (SELECT STT FROM CAP_BAC_HOI_VIEN
                                        WHERE ID = ?) + 1
                                AND (GioiTinh = 0 OR GioiTinh = ?)";

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();

                OleDbParameter prMaCapBac = new OleDbParameter("@ID", OleDbType.Integer);
                prMaCapBac.Value = maCapBac;
                sqlParams.Add(prMaCapBac);

                OleDbParameter prGioiTinh = new OleDbParameter("@GioiTinh", OleDbType.Integer);
                prGioiTinh.Value = gioiTinh;
                sqlParams.Add(prGioiTinh);

                DataTable bangKetQua = SqlDataAccessHelper.ExecuteQuery(sql, sqlParams);
                if (bangKetQua.Rows.Count > 0)
                {
                    CapBacHoiVienDTO ketQua = LayDuLieuCapBacTuBang(bangKetQua, 0);
                    return ketQua;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CapBacHoiVienDTO LayCapBacTheoMa(int maCapBac)
        {
            try
            {
                string sql = @"SELECT * FROM CAP_BAC_HOI_VIEN WHERE ID = ?";

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();

                OleDbParameter prMaCapBac = new OleDbParameter("@ID", OleDbType.Integer);
                prMaCapBac.Value = maCapBac;
                sqlParams.Add(prMaCapBac);

                DataTable bangKetQua = SqlDataAccessHelper.ExecuteQuery(sql, sqlParams);
                if (bangKetQua.Rows.Count > 0)
                {
                    CapBacHoiVienDTO ketQua = LayDuLieuCapBacTuBang(bangKetQua, 0);
                    return ketQua;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CapBacHoiVienDTO LayDuLieuCapBacTuBang(DataTable danhSachCapBac, int dongCanLay)
        {
            CapBacHoiVienDTO capBacHoiVienDTO = new CapBacHoiVienDTO();
            int temp1;
            bool success;
            success = int.TryParse(danhSachCapBac.Rows[dongCanLay]["ID"].ToString(), out temp1);
            if (success)
            {
                capBacHoiVienDTO.ID = temp1;
            }

            capBacHoiVienDTO.TenCapBac = danhSachCapBac.Rows[dongCanLay]["TenCapBac"].ToString();

            success = int.TryParse(danhSachCapBac.Rows[dongCanLay]["STT"].ToString(), out temp1);
            if (success)
            {
                capBacHoiVienDTO.STT = temp1;
            }

            success = int.TryParse(danhSachCapBac.Rows[dongCanLay]["GioiTinh"].ToString(), out temp1);
            if (success)
            {
                capBacHoiVienDTO.GioiTinh = temp1;
            }

            float temp2;
            success = float.TryParse(danhSachCapBac.Rows[dongCanLay]["ELONhoNhat"].ToString(), out temp2);
            if (success)
            {
                capBacHoiVienDTO.EloNhoNhat = temp2;
            }

            success = int.TryParse(danhSachCapBac.Rows[dongCanLay]["SoGiaiDauToiThieu"].ToString(), out temp1);
            if (success)
            {
                capBacHoiVienDTO.SoGiaiDauToiThieu = temp1;
            }

            success = int.TryParse(danhSachCapBac.Rows[dongCanLay]["MaCapGiaiDauNhoNhat"].ToString(), out temp1);
            if (success)
            {
                capBacHoiVienDTO.MaCapGiaiDauNhoNhat = temp1;
            }

            success = int.TryParse(danhSachCapBac.Rows[dongCanLay]["ThuHangToiThieu"].ToString(), out temp1);
            if (success)
            {
                capBacHoiVienDTO.ThuHangToiThieu = temp1;
            }

            success = int.TryParse(danhSachCapBac.Rows[dongCanLay]["MaLoaiCapBac"].ToString(), out temp1);
            if (success)
            {
                capBacHoiVienDTO.LoaiCapBac = temp1;
            }
            return capBacHoiVienDTO;
        }
        #endregion
    }
}
