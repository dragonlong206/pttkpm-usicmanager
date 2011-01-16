using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class KetQuaTranDauBUS
    {
        KetQuaTranDauDAO ketQuaDAO;

        public KetQuaTranDauBUS()
        {
            ketQuaDAO = new KetQuaTranDauDAO();
        }

        public DataTable LayDanhSachKetQua()
        {
            try
            {
                return ketQuaDAO.LayDanhSachKetQua();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
