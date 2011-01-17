using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    class GiaiDauBUS
    {
        GiaiDauDAO giaiDauDAO = new GiaiDauDAO();

        public GiaiDauBUS()
        {
            giaiDauDAO = new GiaiDauDAO();            
        }

        #region Insert
        public bool ThemMoiGiaiDau(GiaiDauDTO giaiDauDTO)
        {
            try
            {
                return giaiDauDAO.ThemMoiGiaiDau(giaiDauDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update
        public bool CapNhatGiaiDau(GiaiDauDTO giaiDauDTO)
        {
            try
            {
                return giaiDauDAO.CapNhatGiaiDau(giaiDauDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Delete
        public bool XoaGiaiDau(int ID)
        {
            if (ID > 0)
            {
                try
                {
                    return giaiDauDAO.XoaGiaiDau(ID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return false;
        }
        #endregion     

      
        public DataTable LayDanhSachTatCaGiaiDau()
        {
            try
            {
                return giaiDauDAO.LayDanhSachTatCaGiaiDau();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
