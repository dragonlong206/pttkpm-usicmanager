using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CapToChucGiaiDauDTO
    {
        int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        string tenCap;

        public string TenCap
        {
            get { return tenCap; }
            set { tenCap = value; }
        }
        int stt;

        public int STT
        {
            get { return stt; }
            set { stt = value; }
        }

        public CapToChucGiaiDauDTO()
        {
            id = 0;
            tenCap = string.Empty;
            stt = 0;
        }
    }
}
