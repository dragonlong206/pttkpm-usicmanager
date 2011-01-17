using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class CapBacHoiVienToiCaoBUS : CapBacHoiVienBUS
    {

        int maDauThu;

        public int MaDauThu
        {
            get { return maDauThu; }
            set { maDauThu = value; }
        }

        public CapBacHoiVienToiCaoBUS(CapBacHoiVienDTO thongTinCapBac)
            : base(thongTinCapBac)
        {
            maDauThu = 0;
        }

        public override bool XetDatCapBac(HoiVienDTO hoiVienDTO)
        {
            try
            {
                bool thoaDieuKienTienQuyet = this.XetThoaDieuKienTienQuyet(hoiVienDTO);

                if (!thoaDieuKienTienQuyet)
                {
                    return false;
                }

                DataTable bangHoiVienGiuCapBac = (new HoiVienDAO()).LayDuLieuHoiVienTheoCapBac(this.capBacHoiVienDTO.ID);
                if (bangHoiVienGiuCapBac.Rows.Count > 0)
                {
                    HoiVienDTO hoiVienGiuCapBac = HoiVienBUS.LayDuLieuHoiVienTuBang(bangHoiVienGiuCapBac, 0);
                    if (hoiVienGiuCapBac.ID != maDauThu)
                    {
                        return false;
                    }
                }
                else if (bangHoiVienGiuCapBac.Rows.Count > 1)
                {
                    throw new Exception("Hiện tại có 2 hội viên đạt cấp bậc này");
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
