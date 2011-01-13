using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThamGiaGiaiDauDTO
    {
        int maHoiVien;

        public int MaHoiVien
        {
            get { return maHoiVien; }
            set { maHoiVien = value; }
        }
        int maTranDau;

        public int MaTranDau
        {
            get { return maTranDau; }
            set { maTranDau = value; }
        }
        int hang;

        public int Hang
        {
            get { return hang; }
            set { hang = value; }
        }

        public ThamGiaGiaiDauDTO()
        {
            maHoiVien = 0;
            maTranDau = 0;
            hang = 0;
        }
    }
}
