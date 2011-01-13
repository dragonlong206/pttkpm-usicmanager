using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CapBacHoiVienThuongDTO
    {
        int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        int maCapBacHoiVien;

        public int MaCapBacHoiVien
        {
            get { return maCapBacHoiVien; }
            set { maCapBacHoiVien = value; }
        }

        public CapBacHoiVienThuongDTO()
        {
            id = 0;
            maCapBacHoiVien = 0;
        }
    }
}
