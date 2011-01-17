using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using DTO;

namespace DAO
{
    public class HoiVienDAO
    {
        #region Insert
        public bool ThemMoiHoiVien(HoiVienDTO hoiVien)
        {
            try
            {
                string sql = @"INSERT INTO HOI_VIEN(HoTen, MSSV, GioiTinh, ELO, MaCapBac, DiemLienKich, ThoiGianDatDiemLienKich) 
                            VALUES(?, ?, ?, ?, ?, ?, ?)";

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();
                OleDbParameter prHoTen = new OleDbParameter("@HoTen", OleDbType.VarWChar);
                prHoTen.Value = hoiVien.HoTen;
                sqlParams.Add(prHoTen);

                OleDbParameter prMSSV = new OleDbParameter("@MSSV", OleDbType.VarChar);
                prMSSV.Value = hoiVien.MSSV;
                sqlParams.Add(prMSSV);

                OleDbParameter prGioiTinh = new OleDbParameter("@GioiTinh", OleDbType.Integer);
                prGioiTinh.Value = hoiVien.GioiTinh;
                sqlParams.Add(prGioiTinh);

                OleDbParameter prELO = new OleDbParameter("@ELO", OleDbType.Double);
                prELO.Value = hoiVien.ELO;
                sqlParams.Add(prELO);

                OleDbParameter prMaCapBac = new OleDbParameter("@MaCapBac", OleDbType.Integer);
                prMaCapBac.Value = hoiVien.MaCapBac;
                sqlParams.Add(prMaCapBac);

                OleDbParameter prDiemLienKich = new OleDbParameter("@DiemLienKich", OleDbType.Integer);
                prDiemLienKich.Value = hoiVien.DiemLienKich;
                sqlParams.Add(prDiemLienKich);

                OleDbParameter prThoiGianDatDiemLienKich = new OleDbParameter("@ThoiGianDatDiemLienKich", OleDbType.Date);
                prThoiGianDatDiemLienKich.Value = hoiVien.ThoiGianDatDiemLienKich;
                sqlParams.Add(prThoiGianDatDiemLienKich);

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
        #endregion

        #region Update
        public bool CapNhatHoiVien(HoiVienDTO hoiVienDTO)
        {
            try
            {
                // Dùng StringBuilder để cải tiến performance
                // Mỗi lần cộng chuỗi không phải cấp phát lại vùng nhớ
                StringBuilder sql = new StringBuilder("UPDATE HOI_VIEN SET ", 255);
                List<OleDbParameter> sqlParams = new List<OleDbParameter>();

                // Kiểm tra từng thuộc tính của DTO
                // Nếu nó khác với giá trị mặc định trong phương thức thiết lập của lớp này
                // thì mới cập nhật nó
                if (hoiVienDTO.HoTen != string.Empty)
                {
                    sql.Append("HoTen = ?");
                    OleDbParameter prHoTen = new OleDbParameter("@HoTen", OleDbType.VarWChar);
                    prHoTen.Value = hoiVienDTO.HoTen;
                    sqlParams.Add(prHoTen);
                }

                if (hoiVienDTO.MSSV != string.Empty)
                {
                    if (sqlParams.Count > 0)
                    {
                        sql.Append(", ");
                    }
                    sql.Append("MSSV = ?");
                    OleDbParameter prMSSV = new OleDbParameter("@MSSV", OleDbType.VarChar);
                    prMSSV.Value = hoiVienDTO.MSSV;
                    sqlParams.Add(prMSSV);
                }

                if (hoiVienDTO.GioiTinh > 0 && hoiVienDTO.GioiTinh < 3)
                {
                    if (sqlParams.Count > 0)
                    {
                        sql.Append(", ");
                    }
                    sql.Append("GioiTinh = ?");
                    OleDbParameter prGioiTinh = new OleDbParameter("@GioiTinh", OleDbType.Integer);
                    prGioiTinh.Value = hoiVienDTO.GioiTinh;
                    sqlParams.Add(prGioiTinh);
                }

                if (hoiVienDTO.ELO >= 0)
                {
                    if (sqlParams.Count > 0)
                    {
                        sql.Append(", ");
                    }
                    sql.Append("ELO = ?");
                    OleDbParameter prELO = new OleDbParameter("@ELO", OleDbType.Double);
                    prELO.Value = hoiVienDTO.ELO;
                    sqlParams.Add(prELO);
                }

                if (hoiVienDTO.DiemLienKich >= 0)
                {
                    if (sqlParams.Count > 0)
                    {
                        sql.Append(", ");
                    }
                    sql.Append("DiemLienKich = ?");
                    OleDbParameter prDiemLienKich = new OleDbParameter("@DiemLienKich", OleDbType.Integer);
                    prDiemLienKich.Value = hoiVienDTO.DiemLienKich;
                    sqlParams.Add(prDiemLienKich);
                }

                if (sqlParams.Count > 0)
                {
                    sql.Append("WHERE ID = ?");

                    OleDbParameter prID = new OleDbParameter("@ID", OleDbType.Integer);
                    prID.Value = hoiVienDTO.ID;
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

        public bool CapNhatELO(int maHoiVien, double ELO)
        {
            try
            {
                string sql = "UPDATE HOI_VIEN SET ELO = ELO + ? WHERE ID = ?";

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();
                
                OleDbParameter prELO = new OleDbParameter("@ELO", OleDbType.Double);
                prELO.Value = ELO;
                sqlParams.Add(prELO);

                OleDbParameter prMaHoiVien = new OleDbParameter("@MaHoiVien", OleDbType.Integer);
                prMaHoiVien.Value = maHoiVien;
                sqlParams.Add(prMaHoiVien);

                int soDongCapNhat = SqlDataAccessHelper.ExecuteNoneQuery(sql, sqlParams);
                if (soDongCapNhat == 1)
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

        public bool TangDiemLienKich(HoiVienDTO hoiVienDTO, DateTime thoiGianDat)
        {
            try
            {
                string sql = string.Empty;

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();

                if (hoiVienDTO.DiemLienKich + 1 <= hoiVienDTO.DiemLienKichCaoNhat)
                {
                    sql = @"UPDATE HOI_VIEN SET DiemLienKich = DiemLienKich + 1  
                                WHERE ID = ?";
                }
                else 
                {
                    sql = @"UPDATE HOI_VIEN SET DiemLienKich = DiemLienKich + 1, 
                                DiemLienKichCaoNhat = DiemLienKich, 
                                ThoiGianDatDiemLienKich = ? 
                                WHERE ID = ?";


                    OleDbParameter prThoiGianDat = new OleDbParameter("@ThoiGianDat", OleDbType.Date);
                    prThoiGianDat.Value = thoiGianDat;
                    sqlParams.Add(prThoiGianDat);
                }                

                OleDbParameter prMaHoiVien = new OleDbParameter("@ID", OleDbType.Integer);
                prMaHoiVien.Value = hoiVienDTO.ID;
                sqlParams.Add(prMaHoiVien);

                int soDongCapNhat = SqlDataAccessHelper.ExecuteNoneQuery(sql, sqlParams);
                if (soDongCapNhat == 1)
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

        public bool ResetDiemLienKich(int maHoiVien)
        {
            try
            {
                string sql = "UPDATE HOI_VIEN SET DiemLienKich = 0 WHERE ID = ?";

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();

                OleDbParameter prMaHoiVien = new OleDbParameter("@ID", OleDbType.Integer);
                prMaHoiVien.Value = maHoiVien;
                sqlParams.Add(prMaHoiVien);

                int soDongCapNhat = SqlDataAccessHelper.ExecuteNoneQuery(sql, sqlParams);
                if (soDongCapNhat == 1)
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

        public bool CapNhatCapBac(int maHoiVien, int maCapBacMoi)
        {
            try
            {
                string sql = "UPDATE HOI_VIEN SET maCapBac = ? WHERE ID = ?";

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();

                OleDbParameter prCapBacMoi = new OleDbParameter("@MaCapBac", OleDbType.Integer);
                prCapBacMoi.Value = maCapBacMoi;
                sqlParams.Add(prCapBacMoi);

                OleDbParameter prMaHoiVien = new OleDbParameter("@ID", OleDbType.Integer);
                prMaHoiVien.Value = maHoiVien;
                sqlParams.Add(prMaHoiVien);

                int soDongCapNhat = SqlDataAccessHelper.ExecuteNoneQuery(sql, sqlParams);
                if (soDongCapNhat == 1)
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

        #region Delete
        public bool XoaHoiVien(int ID)
        {
            try
            {
                string sql = "UPDATE HOI_VIEN SET DaXoa = 1 WHERE ID = ?";
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
        #endregion

        #region Select
        public DataTable LayDanhSachTatCaHoiVien()
        {
            //List<HoiVienDTO> ketQua = new List<HoiVienDTO>();

            try
            {
                string sql = @"SELECT HV.ID, HoTen, MSSV, HV.GioiTinh, ELO, MaCapBac, TenCapBac, DiemLienKich, DiemLienKichCaoNhat, ThoiGianDatDiemLienKich 
                                FROM HOI_VIEN AS HV INNER JOIN CAP_BAC_HOI_VIEN AS CB ON HV.MaCapBac = CB.ID 
                                WHERE HV.DaXoa = 0 ORDER BY MaCapBac DESC, ELO DESC, DiemLienKich DESC";
                DataTable danhSachHoiVien = SqlDataAccessHelper.ExecuteQuery(sql);
                //if (danhSachCapBac.Rows.Count > 0)
                //{
                //    for (int chiSoDong = 0; chiSoDong < danhSachCapBac.Rows.Count; chiSoDong++)
                //    {
                //        HoiVienDTO capToChucGiaiDauDTO = LayDuLieuHoiVienTuBang(danhSachCapBac, chiSoDong);
                //        ketQua.Add(capToChucGiaiDauDTO);
                //    }
                //}
                return SqlDataAccessHelper.AutoNumberedTable(danhSachHoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayDanhSachHoTenVaMSSVTatCaHoiVien()
        {
            try
            {
                string sql = @"SELECT HV.ID, HoTen, MSSV 
                                FROM HOI_VIEN AS HV 
                                WHERE HV.DaXoa = 0";
                DataTable danhSachHoiVien = SqlDataAccessHelper.ExecuteQuery(sql);
                
                return danhSachHoiVien;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayDanhSachHoiVienTheoHoTen(string hoTen)
        {
            try
            {
                string sql = @"SELECT HV.ID, HoTen, MSSV, HV.GioiTinh, ELO, MaCapBac, TenCapBac, DiemLienKich, DiemLienKichCaoNhat, ThoiGianDatDiemLienKich 
                                FROM HOI_VIEN AS HV INNER JOIN CAP_BAC_HOI_VIEN AS CB ON HV.MaCapBac = CB.ID 
                                WHERE HV.DaXoa = 0 AND HoTen LIKE '%" + hoTen + "%'";

                DataTable danhSachHoiVien = SqlDataAccessHelper.ExecuteQuery(sql);

                return SqlDataAccessHelper.AutoNumberedTable(danhSachHoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayHoiVienTheoMSSV(string MSSV)
        {
            string sql = @"SELECT HV.ID, HoTen, MSSV, HV.GioiTinh, ELO, MaCapBac, TenCapBac, DiemLienKich, DiemLienKichCaoNhat, ThoiGianDatDiemLienKich 
                                FROM HOI_VIEN AS HV INNER JOIN CAP_BAC_HOI_VIEN AS CB ON HV.MaCapBac = CB.ID 
                                WHERE HV.DaXoa = 0 AND MSSV = ?";

            OleDbParameter prMSSV = new OleDbParameter("@MSSV", OleDbType.VarChar);
            prMSSV.Value = MSSV;
            List<OleDbParameter> sqlParams = new List<OleDbParameter>();
            sqlParams.Add(prMSSV);

            DataTable danhSachHoiVien = SqlDataAccessHelper.ExecuteQuery(sql, sqlParams);

            return SqlDataAccessHelper.AutoNumberedTable(danhSachHoiVien);
        }

        public HoiVienDTO LayThongTinHoiVienTheoMa(int maHoiVien)
        {
            try
            {
                string sql = "SELECT * FROM HOI_VIEN WHERE ID = ?";

                OleDbParameter prMaHoiVien = new OleDbParameter("@ID", OleDbType.Integer);
                prMaHoiVien.Value = maHoiVien;

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();
                sqlParams.Add(prMaHoiVien);

                DataTable hoiVien = SqlDataAccessHelper.ExecuteQuery(sql, sqlParams);

                if (hoiVien.Rows.Count > 0)
                {
                    HoiVienDTO ketQua = LayDuLieuHoiVienTuBang(hoiVien, 0);
                    return ketQua;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayDuLieuHoiVienTheoCapBac(int maCapBac)
        {
            try
            {
                string sql = "SELECT * FROM HOI_VIEN WHERE MaCapBac = ?";

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();

                OleDbParameter prMaCapBac = new OleDbParameter("@MaCapBac", OleDbType.Integer);
                prMaCapBac.Value = maCapBac;
                sqlParams.Add(prMaCapBac);

                DataTable ketQua = SqlDataAccessHelper.ExecuteQuery(sql, sqlParams);

                return ketQua;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static HoiVienDTO LayDuLieuHoiVienTuBang(DataTable danhSachHoiVien, int i)
        {
            HoiVienDTO hoiVienDTO = new HoiVienDTO();
            int temp1;
            bool success;
            success = int.TryParse(danhSachHoiVien.Rows[i]["ID"].ToString(), out temp1);
            if (success)
            {
                hoiVienDTO.ID = temp1;
            }

            hoiVienDTO.HoTen = danhSachHoiVien.Rows[i]["HoTen"].ToString();

            hoiVienDTO.MSSV = danhSachHoiVien.Rows[i]["MSSV"].ToString();

            success = int.TryParse(danhSachHoiVien.Rows[i]["GioiTinh"].ToString(), out temp1);
            if (success)
            {
                hoiVienDTO.GioiTinh = temp1;
            }

            float temp2;
            success = float.TryParse(danhSachHoiVien.Rows[i]["ELO"].ToString(), out temp2);
            if (success)
            {
                hoiVienDTO.ELO = temp2;
            }

            success = int.TryParse(danhSachHoiVien.Rows[i]["MaCapBac"].ToString(), out temp1);
            if (success)
            {
                hoiVienDTO.MaCapBac = temp1;
                CapBacHoiVienDAO capBacHoiVienDAO = new CapBacHoiVienDAO();
                hoiVienDTO.TenCapBac = capBacHoiVienDAO.LayTenCapBacTheoMaCapBac(temp1);
            }

            success = int.TryParse(danhSachHoiVien.Rows[i]["DiemLienKich"].ToString(), out temp1);
            if (success)
            {
                hoiVienDTO.DiemLienKich = temp1;
            }

            success = int.TryParse(danhSachHoiVien.Rows[i]["DiemLienKichCaoNhat"].ToString(), out temp1);
            if (success)
            {
                hoiVienDTO.DiemLienKichCaoNhat = temp1;
            }

            DateTime temp3;
            success = DateTime.TryParse(danhSachHoiVien.Rows[i]["ThoiGianDatDiemLienKich"].ToString(), out temp3);
            if (success)
            {
                hoiVienDTO.ThoiGianDatDiemLienKich = temp3;
            }
            return hoiVienDTO;
        }
        #endregion
    }
}
