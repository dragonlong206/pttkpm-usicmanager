using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class CapBacHoiVienThuongBUS : CapBacHoiVienBUS
    {
        public CapBacHoiVienThuongBUS(CapBacHoiVienDTO thongTinCapBac)
            : base(thongTinCapBac)
        { 
        }

        public override bool XetDatCapBac(HoiVienDTO hoiVienDTO)
        {
            try
            {
                if (hoiVienDTO != null)
                {
                    return this.XetThoaDieuKienTienQuyet(hoiVienDTO);
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
