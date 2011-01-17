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
        double elo;
        int maCapBac;
        string tenCapBac;
        int diemLienKich;
        int diemLienKichCaoNhat;
        DateTime thoiGianDatDiemLienKich;
        bool daXoa;

        public bool DaXoa
        {
            get { return daXoa; }
            set { daXoa = value; }
        }

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

        public double ELO
        {
            get { return elo; }
            set { elo = value; }
        }

        public int MaCapBac
        {
            get { return maCapBac; }
            set 
            {
                maCapBac = value;
            }
        }

        public int DiemLienKich
        {
            get { return diemLienKich; }
            set { diemLienKich = value; }
        }

        public int DiemLienKichCaoNhat
        {
            get { return diemLienKichCaoNhat; }
            set { diemLienKichCaoNhat = value; }
        }

        public DateTime ThoiGianDatDiemLienKich
        {
            get { return thoiGianDatDiemLienKich; }
            set { thoiGianDatDiemLienKich = value; }
        }

        public string TenCapBac
        {
            get { return tenCapBac; }
            set { tenCapBac = value; }
        }

        public HoiVienDTO()
        {
            id = 0;
            hoTen = string.Empty;
            mssv = string.Empty;
            gioiTinh = -1;
            elo = -1;
            maCapBac = 1;
            tenCapBac = string.Empty;
            diemLienKich = -1;
            diemLienKichCaoNhat = -1;
            thoiGianDatDiemLienKich = DateTime.Now;
            daXoa = false;
        }
    }
}
