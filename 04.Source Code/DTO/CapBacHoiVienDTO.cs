using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CapBacHoiVienDTO
    {
        protected int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        protected string tenCapBac;

        public string TenCapBac
        {
            get { return tenCapBac; }
            set { tenCapBac = value; }
        }

        protected int stt;

        public int STT
        {
            get { return stt; }
            set { stt = value; }
        }

        protected float eloNhoNhat;

        public float EloNhoNhat
        {
            get { return eloNhoNhat; }
            set { eloNhoNhat = value; }
        }

        protected int soGiaiDauToiThieu;

        public int SoGiaiDauToiThieu
        {
            get { return soGiaiDauToiThieu; }
            set { soGiaiDauToiThieu = value; }
        }

        protected int maCapGiaiDauNhoNhat;

        public int MaCapGiaiDauNhoNhat
        {
            get { return maCapGiaiDauNhoNhat; }
            set { maCapGiaiDauNhoNhat = value; }
        }

        protected int thuHangToiThieu;

        public int ThuHangToiThieu
        {
            get { return thuHangToiThieu; }
            set { thuHangToiThieu = value; }
        }

        protected int gioiTinh;

        public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        protected bool daXoa;

        public bool DaXoa
        {
            get { return daXoa; }
            set { daXoa = value; }
        }

        protected int loaiCapBac;

        public int LoaiCapBac
        {
            get { return loaiCapBac; }
            set { loaiCapBac = value; }
        }

        public CapBacHoiVienDTO()
        {
            id = 0;
            tenCapBac = string.Empty;
            stt = 0;
            eloNhoNhat = 0;
            soGiaiDauToiThieu = 0;
            maCapGiaiDauNhoNhat = 0;
            thuHangToiThieu = 10000;
            gioiTinh = 0;
            daXoa = false;
            loaiCapBac = 1;
        }
    }
}
