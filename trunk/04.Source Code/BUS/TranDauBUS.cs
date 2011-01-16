using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class TranDauBUS
    {
        TranDauDAO tranDauDAO;

        public TranDauBUS()
        {
            tranDauDAO = new TranDauDAO();
        }

        public bool ThemTranDau(TranDauDTO tranDauDTO)
        {
            try
            {
                return tranDauDAO.ThemTranDau(tranDauDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
