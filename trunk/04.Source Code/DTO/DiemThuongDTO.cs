using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DiemThuongDTO
    {
        int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        int hang;

        public int Hang
        {
            get { return hang; }
            set { hang = value; }
        }
        float diemThuong;

        public float DiemThuong
        {
            get { return diemThuong; }
            set { diemThuong = value; }
        }
        int maCapToChuc;

        public int MaCapToChuc
        {
            get { return maCapToChuc; }
            set { maCapToChuc = value; }
        }

        public DiemThuongDTO()
        {
            id = 0;
            hang = 0;
            diemThuong = 0;
            maCapToChuc = 0;
        }
    }
}
