using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CapBacHoiVienToiCaoDTO
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

        int maHoiVienDat;

        public int MaHoiVienDat
        {
            get { return maHoiVienDat; }
            set { maHoiVienDat = value; }
        }

        public CapBacHoiVienToiCaoDTO()
        {
            id = 0;
            maCapBacHoiVien = 0;
            maHoiVienDat = 0;
        }
    }
}
