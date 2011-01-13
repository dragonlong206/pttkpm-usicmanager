using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoiVienDTO
    {
        int id;
        string hoTen;
        string mssv;
        int gioiTinh;
        float elo;
        int maCapBac;
        int diemLienKich;
        DateTime thoiGianDatDiemLienKich;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string MSSV
        {
            get { return mssv; }
            set { mssv = value; }
        }

        public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public float ELO
        {
            get { return elo; }
            set { elo = value; }
        }

        public int MaCapBac
        {
            get { return maCapBac; }
            set { maCapBac = value; }
        }

        public int DiemLienKich
        {
            get { return diemLienKich; }
            set { diemLienKich = value; }
        }

        public DateTime ThoiGianDatDiemLienKich
        {
            get { return thoiGianDatDiemLienKich; }
            set { thoiGianDatDiemLienKich = value; }
        }

        public HoiVienDTO()
        {
            id = 0;
            hoTen = string.Empty;
            mssv = string.Empty;
            gioiTinh = 0;
            elo = 0;
            maCapBac = 1;
            diemLienKich = 0;
            thoiGianDatDiemLienKich = DateTime.Now;
        }
    }
}
