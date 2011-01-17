using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class ThamGiaGiaiDauDAO
    {
        public int DemSoGiaiDauThamGia(int maHoiVien, int maCapGiaiDauToiThieu, int thuHangToiThieu)
        {
            try
            {
                CapToChucGiaiDauDAO capToChucDAO = new CapToChucGiaiDauDAO();
                CapToChucGiaiDauDTO capToChucDTO = capToChucDAO.LayThongTinCapToChucTuMa(maCapGiaiDauToiThieu);
                int soThuTuCapToiThieu = 0;
                if (capToChucDTO != null)
                {
                    soThuTuCapToiThieu = capToChucDTO.STT;
                }

                string sql = @"SELECT COUNT(*) FROM (THAM_GIA_GIAI_DAU AS TG INNER JOIN GIAI_DAU AS GD ON TG.MaGiaiDau = GD.ID) 
                                INNER JOIN CAP_TO_CHUC_GIAI_DAU AS CTC ON GD.MaCapToChuc = CTC.ID 
                                WHERE TG.MaHoiVien = ? AND CTC.STT >= ? AND TG.Hang <= ?";

                List<OleDbParameter> sqlParams = new List<OleDbParameter>();

                OleDbParameter prMaHoiVien = new OleDbParameter("@MaHoiVien", OleDbType.Integer);
                prMaHoiVien.Value = maHoiVien;
                sqlParams.Add(prMaHoiVien);

                OleDbParameter prSTT = new OleDbParameter("@STT", OleDbType.Integer);
                prSTT.Value = soThuTuCapToiThieu;
                sqlParams.Add(prSTT);

                OleDbParameter prHangToiThieu = new OleDbParameter("@HangToiThieu", OleDbType.Integer);
                prHangToiThieu.Value = thuHangToiThieu;
                sqlParams.Add(prHangToiThieu);

                DataTable bangKetQua = SqlDataAccessHelper.ExecuteQuery(sql, sqlParams);
                if (bangKetQua.Rows.Count > 0)
                {
                    int ketQua = int.Parse(bangKetQua.Rows[0][0].ToString());
                    return ketQua;
                }

                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
