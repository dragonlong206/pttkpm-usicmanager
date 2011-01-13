using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CapBacHoiVienDTO
    {
        int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        string tenCapBac;

        public string TenCapBac
        {
            get { return tenCapBac; }
            set { tenCapBac = value; }
        }

        int stt;

        public int STT
        {
            get { return stt; }
            set { stt = value; }
        }

        float eloNhoNhat;

        public float EloNhoNhat
        {
            get { return eloNhoNhat; }
            set { eloNhoNhat = value; }
        }

        int soGiaiDauToiThieu;

        public int SoGiaiDauToiThieu
        {
            get { return soGiaiDauToiThieu; }
            set { soGiaiDauToiThieu = value; }
        }

        int maCapGiaiDauNhoNhat;

        public int MaCapGiaiDauNhoNhat
        {
            get { return maCapGiaiDauNhoNhat; }
            set { maCapGiaiDauNhoNhat = value; }
        }

        int thuHangToiThieu;

        public int ThuHangToiThieu
        {
            get { return thuHangToiThieu; }
            set { thuHangToiThieu = value; }
        }

        int gioiTinh;

        public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        bool daXoa;

        public bool DaXoa
        {
            get { return daXoa; }
            set { daXoa = value; }
        }

        public CapBacHoiVienDTO()
        {
            id = 0;
            tenCapBac = string.Empty;
            stt = 0;
            eloNhoNhat = 0;
            soGiaiDauToiThieu = 0;
            maCapGiaiDauNhoNhat = 0;
            thuHangToiThieu = 0;
            gioiTinh = 0;
            daXoa = false;
        }
    }
}
