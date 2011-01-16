﻿using System;
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

        public static HoiVienDTO LayDuLieuHoiVienTuBang(DataTable danhSachHoiVien, int i)
        {
            return HoiVienDAO.LayDuLieuHoiVienTuBang(danhSachHoiVien, i);
        }
        #endregion

    }
}