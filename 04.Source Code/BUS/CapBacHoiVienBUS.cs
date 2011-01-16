using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class CapBacHoiVienBUS
    {
        CapBacHoiVienDAO capBacHoiVienDAO;

        public CapBacHoiVienBUS()
        {
            capBacHoiVienDAO = new CapBacHoiVienDAO();
        }

        #region Select
        public DataTable LayDanhSachTatCaCapBac()
        {
            try
            {
                return capBacHoiVienDAO.LayDanhSachTatCaCapBac();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string LayTenCapBacTheoMaCapBac(int maCapBac)
        {
            if (maCapBac <= 0)
            {
                return string.Empty;
            }

            try
            {
                return capBacHoiVienDAO.LayTenCapBacTheoMaCapBac(maCapBac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string LayTenCapBacNhoNhat()
        {
            try
            {
                return capBacHoiVienDAO.LayTenCapBacNhoNhat();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
