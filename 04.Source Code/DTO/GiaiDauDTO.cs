using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class GiaiDauDTO
    {
        int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        string tenGiaiDau;

        public string TenGiaiDau
        {
            get { return tenGiaiDau; }
            set { tenGiaiDau = value; }
        }
        string donViToChuc;

        public string DonViToChuc
        {
            get { return donViToChuc; }
            set { donViToChuc = value; }
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
        int maCapToChuc;

        public int MaCapToChuc
        {
            get { return maCapToChuc; }
            set { maCapToChuc = value; }
        }

        public GiaiDauDTO()
        {
            id = 0;
            tenGiaiDau = string.Empty;
            donViToChuc = string.Empty;
            thoiGian = DateTime.Now;
            diaDiem = string.Empty;
            maCapToChuc = 0;
        }
    }
}
