using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThamSoDTO
    {
        int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        string tenThamSo;

        public string TenThamSo
        {
            get { return tenThamSo; }
            set { tenThamSo = value; }
        }

        // Kiểu của tham số này
        string kieu;

        public string Kieu
        {
            get { return kieu; }
            set { kieu = value; }
        }

        string giaTri;

        public string GiaTri
        {
            get { return giaTri; }
            set { giaTri = value; }
        }

        // Có đang được sử dụng hay không
        bool tinhTrang;

        public bool TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        public ThamSoDTO()
        {
            id = 0;
            tenThamSo = string.Empty;
            kieu = "String";
            giaTri = string.Empty;
            tinhTrang = true;
        }
    }
}
