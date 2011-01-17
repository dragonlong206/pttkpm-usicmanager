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
        protected CapBacHoiVienDAO capBacHoiVienDAO;
        protected CapBacHoiVienDTO capBacHoiVienDTO;

        public CapBacHoiVienBUS()
        {
            capBacHoiVienDAO = new CapBacHoiVienDAO();
        }

        public CapBacHoiVienBUS(CapBacHoiVienDTO thongTinCapBac) : this()
        {
            capBacHoiVienDTO = thongTinCapBac;
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

        #region Xét đạt cấp bậc
        public bool XetThoaDieuKienTienQuyet(HoiVienDTO hoiVienDTO)
        {
            try
            {
                if (hoiVienDTO.ELO < this.capBacHoiVienDTO.EloNhoNhat)
                {
                    return false;
                }

                if (this.capBacHoiVienDTO.GioiTinh != 0 && this.capBacHoiVienDTO.GioiTinh != hoiVienDTO.GioiTinh)
                {
                    return false;
                }

                if (this.capBacHoiVienDTO.SoGiaiDauToiThieu > 0)
                {
                    ThamGiaGiaiDauDAO thamGiaGiaDau = new ThamGiaGiaiDauDAO();
                    int soGiaiDau = thamGiaGiaDau.DemSoGiaiDauThamGia(hoiVienDTO.ID,
                        this.capBacHoiVienDTO.MaCapGiaiDauNhoNhat, this.capBacHoiVienDTO.ThuHangToiThieu);

                    if (soGiaiDau < capBacHoiVienDTO.SoGiaiDauToiThieu)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual bool XetDatCapBac(HoiVienDTO hoiVienDTO)
        {
            return false;
        }
        #endregion
    }
}
