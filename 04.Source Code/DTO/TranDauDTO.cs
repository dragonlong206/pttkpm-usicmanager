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
        float diemTiLeP;

        public float DiemTiLeP
        {
            get { return diemTiLeP; }
            set { diemTiLeP = value; }
        }
        float diemRatingDp;

        public float DiemRatingDp
        {
            get { return diemRatingDp; }
            set { diemRatingDp = value; }
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
            diemTiLeP = 0;
            diemRatingDp = 0;
            daXoa = false;
        }
    }
}
