﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class HoiVienDAO
    {
        public bool ThemMoiHoiVien(HoiVienDTO hoiVien)
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

            return true;
        }

        public bool CapNhatHoiVien(HoiVienDTO hoiVienDTO)
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

            return false;
        }

        //public bool XoaHoiVien
    }
}
