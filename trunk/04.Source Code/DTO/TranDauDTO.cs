using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TranDauDTO
    {
        int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        int maDauThu1;

        public int MaDauThu1
        {
            get { return maDauThu1; }
            set { maDauThu1 = value; }
        }
        int maDauThu2;

        public int MaDauThu2
        {
            get { return maDauThu2; }
            set { maDauThu2 = value; }
        }
        DateTime thoiGian;

        public DateTime ThoiGian
        {
            get { return thoiGian; }
            set { thoiGian = value; }
        }
        string diaDiem;

        public string DiaDiem
        {
            get { return diaDiem; }
            set { diaDiem = value; }
        }
        int maTrongTai;

        public int MaTrongTai
        {
            get { return maTrongTai; }
            set { maTrongTai = value; }
        }
        int maKetQua;

        public int MaKetQua
        {
            get { return maKetQua; }
            set { maKetQua = value; }
        }
        double p1;

        public double P1
        {
            get { return p1; }
            set { p1 = value; }
        }
        double p2;

        public double P2
        {
            get { return p2; }
            set { p2 = value; }
        }

        bool daXoa;

        public bool DaXoa
        {
            get { return daXoa; }
            set { daXoa = value; }
        }

        public TranDauDTO()
        {
            id = 0;
            maDauThu1 = 0;
            maDauThu1 = 0;
            thoiGian = DateTime.Now;
            diaDiem = string.Empty;
            maTrongTai = 0;
            maKetQua = 0;
            p1 = 0;
            P2 = 0;
            daXoa = false;
        }
    }
}
