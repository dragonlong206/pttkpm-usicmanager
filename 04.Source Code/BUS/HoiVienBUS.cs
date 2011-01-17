using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class HoiVienBUS
    {        
        HoiVienDAO hoiVienDAO = new HoiVienDAO();

        public HoiVienBUS()
        {
            hoiVienDAO = new HoiVienDAO();
        }

        #region Insert
        public bool ThemMoiHoiVien(HoiVienDTO hoiVienDTO)
        {
            try
            {
                return hoiVienDAO.ThemMoiHoiVien(hoiVienDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update
        public bool CapNhatHoiVien(HoiVienDTO hoiVienDTO)
        {
            try
            {
                return hoiVienDAO.CapNhatHoiVien(hoiVienDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ResetDiemLienKichCaoNhat(int maHoiVien)
        {
            try
            {
                return hoiVienDAO.ResetDiemLienKichCaoNhat(maHoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ResetToanBoDiemLienKich()
        {
            try
            {
                DataTable danhSachHoiVien = hoiVienDAO.LayDanhSachTatCaHoiVien();
                bool resetThanhCong = true;

                if (danhSachHoiVien.Rows.Count > 0)
                {
                    for (int i = 0; i < danhSachHoiVien.Rows.Count; i++)
                    {
                        try
                        {
                            int maHoiVien = int.Parse(danhSachHoiVien.Rows[i]["ID"].ToString());
                            resetThanhCong &= hoiVienDAO.ResetDiemLienKichCaoNhat(maHoiVien);
                        }
                        catch (Exception ex)
                        {
                            resetThanhCong = false;
                        }
                    }
                }

                return resetThanhCong;
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
            if (ID > 0)
            {
                try
                {
                    return hoiVienDAO.XoaHoiVien(ID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return false;
        }
        #endregion

        #region Select
        public DataTable LayDanhSachTatCaHoiVien()
        {
            try
            {
                return hoiVienDAO.LayDanhSachTatCaHoiVien();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayDanhSachHoiVienTheoHoTen(string hoTen)
        {
            if (hoTen != string.Empty)
            {
                try
                {
                    return hoiVienDAO.LayDanhSachHoiVienTheoHoTen(hoTen);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return null;
        }

        public DataTable LayDanhSachHoTenVaMSSVTatCaHoiVien()
        {
            try
            {
                return hoiVienDAO.LayDanhSachHoTenVaMSSVTatCaHoiVien();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayHoiVienTheoMSSV(string MSSV)
        {
            if (MSSV != string.Empty)
            {
                try
                {
                    return hoiVienDAO.LayHoiVienTheoMSSV(MSSV);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return null;
        }

        public HoiVienDTO LayThongTinHoiVienTheoMa(int maHoiVien)
        {
            try
            {
                if (maHoiVien > 0)
                {
                    return hoiVienDAO.LayThongTinHoiVienTheoMa(maHoiVien);
                }
                
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static HoiVienDTO LayDuLieuHoiVienTuBang(DataTable danhSachHoiVien, int i)
        {
            return HoiVienDAO.LayDuLieuHoiVienTuBang(danhSachHoiVien, i);
        }
        #endregion

    }
}
