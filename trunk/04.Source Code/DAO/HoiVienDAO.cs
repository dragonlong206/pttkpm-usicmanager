using System;
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
    }
}
