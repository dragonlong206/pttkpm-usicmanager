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
                if (tranDauDTO.MaDauThu1 == tranDauDTO.MaDauThu2)
                {
                    throw new Exception("Đấu thủ 1 và 2 phải khác nhau");
                }

                // TODO Kiểm tra ràng buộc khoảng thách đấu

                CapNhatELOCapBacDiemLienKich(tranDauDTO);                              

                bool themThanhCong = tranDauDAO.ThemTranDau(tranDauDTO);

                return themThanhCong;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CapNhatELOCapBacDiemLienKich(TranDauDTO tranDauDTO)
        {
            if (tranDauDTO.MaKetQua != 0)
            {
                HoiVienDAO hoiVienDAO = new HoiVienDAO();
                HoiVienDTO dauThu1 = hoiVienDAO.LayThongTinHoiVienTheoMa(tranDauDTO.MaDauThu1);
                HoiVienDTO dauThu2 = hoiVienDAO.LayThongTinHoiVienTheoMa(tranDauDTO.MaDauThu2);


                // TODO Cập nhật cấp bậc
                ChuyenDoiELOSangPDAO chuyenDoiELO_P = new ChuyenDoiELOSangPDAO();
                string ketQuaTranDau = (new KetQuaTranDauDAO()).LayKetQuaTuMa(tranDauDTO.MaKetQua).Trim();
                double[] p = chuyenDoiELO_P.TinhP(dauThu1.ELO, dauThu2.ELO, ketQuaTranDau);

                if (p != null)
                {
                    ChuyenDoiPSangDpDAO chuyenDoiP_Dp = new ChuyenDoiPSangDpDAO();
                    double dp = 0;
                    int dau = 1;

                    tranDauDTO.P1 = p[0];
                    if (p[0] >= 0)
                    {
                        dau = 1;
                    }
                    else
                    {
                        p[0] = -p[0];
                        dau = -1;
                    }
                    dp = chuyenDoiP_Dp.LayDpTuP(p[0]);
                    if (ketQuaTranDau.Equals("0-0"))
                    {
                        dp = dp/3;
                    }
                    hoiVienDAO.CapNhatELO(tranDauDTO.MaDauThu1, dp * dau);
                    dauThu1.ELO += (dp * dau);

                    CapNhatCapBacVaDiemLienKich(tranDauDTO, hoiVienDAO, dauThu1, dauThu2, dau);

                    tranDauDTO.P2 = p[1];
                    if (p[1] >= 0)
                    {
                        dau = 1;
                    }
                    else
                    {
                        p[1] = -p[1];
                        dau = -1;
                    }
                    dp = chuyenDoiP_Dp.LayDpTuP(p[1]);
                    if (ketQuaTranDau.Equals("0-0"))
                    {
                        dp = dp/3;
                    }
                    hoiVienDAO.CapNhatELO(tranDauDTO.MaDauThu2, dp * dau);
                    dauThu2.ELO += (dp * dau);

                    CapNhatCapBacVaDiemLienKich(tranDauDTO, hoiVienDAO, dauThu2, dauThu1, dau);
                }
            }
        }

        private void CapNhatCapBacVaDiemLienKich(TranDauDTO tranDauDTO, HoiVienDAO hoiVienDAO, HoiVienDTO dauThu1, HoiVienDTO dauThu2, int dau)
        {
            //Cập nhật cấp bậc và điểm liên kích
            CapBacHoiVienDAO capBacHoiVienDAO = new CapBacHoiVienDAO();
            CapBacHoiVienDTO capBacHienTai = capBacHoiVienDAO.LayCapBacTheoMa(dauThu1.MaCapBac);
            CapBacHoiVienBUS capBacHoiVienBUS = null;

            if (dau > 0)
            {
                CapBacHoiVienDTO capBacKeTiep = capBacHoiVienDAO.LayCapBacLienSau(dauThu1.MaCapBac, dauThu1.GioiTinh);
                CapBacHoiVienBUS capBacKeTiepBUS = null;

                // TODO Sửa lại code cứng
                if (capBacKeTiep != null)
                {
                    if (capBacKeTiep.LoaiCapBac == 2)
                    {
                        capBacKeTiepBUS = new CapBacHoiVienToiCaoBUS(capBacKeTiep);
                        ((CapBacHoiVienToiCaoBUS)capBacKeTiepBUS).MaDauThu = dauThu2.ID;
                    }
                    else
                    {
                        capBacKeTiepBUS = new CapBacHoiVienThuongBUS(capBacKeTiep);
                    }

                    if (capBacKeTiepBUS.XetDatCapBac(dauThu1))
                    {
                        hoiVienDAO.CapNhatCapBac(dauThu1.ID, capBacKeTiep.ID);
                    }
                }

                hoiVienDAO.TangDiemLienKich(dauThu1, tranDauDTO.ThoiGian);
            }
            else
            {
                // TODO Sửa lại code cứng
                if (capBacHienTai.LoaiCapBac == 2)
                {
                    capBacHoiVienBUS = new CapBacHoiVienToiCaoBUS(capBacHienTai);
                    ((CapBacHoiVienToiCaoBUS)capBacHoiVienBUS).MaDauThu = dauThu2.ID;
                }
                else
                {
                    capBacHoiVienBUS = new CapBacHoiVienThuongBUS(capBacHienTai);
                }

                if (!capBacHoiVienBUS.XetDatCapBac(dauThu1))
                {
                    CapBacHoiVienDTO capBacTruocDo = capBacHoiVienDAO.LayCapBacLienTruoc(dauThu1.MaCapBac, dauThu1.GioiTinh);
                    if (capBacTruocDo != null)
                    {
                        hoiVienDAO.CapNhatCapBac(dauThu1.ID, capBacTruocDo.ID);
                    }
                }

                hoiVienDAO.ResetDiemLienKich(dauThu1.ID);
            }
        }
    }
}
