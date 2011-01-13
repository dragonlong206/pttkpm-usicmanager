using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KetQuaTranDauDTO
    {
        int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        string theHien;

        public string TheHien
        {
            get { return theHien; }
            set { theHien = value; }
        }

        public KetQuaTranDauDTO()
        {
            id = 0;
            theHien = string.Empty;
        }
    }
}
