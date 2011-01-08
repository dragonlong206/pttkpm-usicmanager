using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class CapBacDAO
    {        
        public static Boolean ThemCapBac(CapBacDTO aCapBac)
        {
            Boolean blnDaThemDuoc = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@IDCapBac", aCapBac.IDCapBac));
                arrParams.Add(new OleDbParameter("@ChiSoCapBac", aCapBac.ChiSoCapBac));
                arrParams.Add(new OleDbParameter("@TenCapBac", aCapBac.TenCapBac));
                arrParams.Add(new OleDbParameter("@NguongVuotTroi", aCapBac.NguongVuotTroi));               

                String strCommand = @"Insert Into CAP_BAC(IDCapBac, ChiSoCapBac, TenCapBac, NguongVuotTroi)
                                      Values(?,?,?,?)";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    return blnDaThemDuoc = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaThemDuoc;
        }       
        
        public static Boolean XoaCapBac(CapBacDTO aCapBac)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@IDCapBac", aCapBac.IDCapBac));
                String strCommand = @"Delete from CAP_BAC
                                      Where IDCapBac = ?";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    blnKetQua = true;
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }        
        
        public static Boolean CapNhatCapBac(CapBacDTO aCapBac)
        {
            Boolean blnDaUpdate = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@ChiSoCapBac", aCapBac.ChiSoCapBac));
                arrParams.Add(new OleDbParameter("@TenCapBac", aCapBac.TenCapBac));                
                arrParams.Add(new OleDbParameter("@NguongVuotTroi", aCapBac.NguongVuotTroi));
                arrParams.Add(new OleDbParameter("@IDCapBac", aCapBac.IDCapBac));

                String strCommand = @"Update CAP_BAC
                                     Set ChiSoCapBac = ?, TenCapBac = ?, NguongVuotTroi = ?
                                     Where IDCapBac = ?";
                
                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    return blnDaUpdate = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaUpdate;
        }        
        
        public static List<CapBacDTO> DocDanhSachCapBac(String strTieuChiTimKiem)
        {
            List<CapBacDTO> lstCapBac = new List<CapBacDTO>();

            String strCommand = "Select * from CAP_BAC" + strTieuChiTimKiem;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstCapBac.Add(KhoiTao(aDong));
            }

            return lstCapBac;
        }

        public static List<CapBacDTO> DocDanhSachCapBac(String strTieuChiTimKiem, String strSapXep)
        {
            List<CapBacDTO> lstCapBac = new List<CapBacDTO>();

            String strCommand = "Select * from CAP_BAC" + strTieuChiTimKiem + strSapXep;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstCapBac.Add(KhoiTao(aDong));
            }

            return lstCapBac;
        }

        public static DTO.CapBacDTO KhoiTao(DataRow aDong)
        {
            DTO.CapBacDTO aCapBac = new DTO.CapBacDTO();

            aCapBac.IDCapBac = int.Parse(aDong["IDCapBac"].ToString());
            aCapBac.ChiSoCapBac = int.Parse(aDong["ChiSoCapBac"].ToString());
            aCapBac.TenCapBac = aDong["TenCapBac"].ToString();
            aCapBac.NguongVuotTroi = double.Parse(aDong["NguongVuotTroi"].ToString());          

            return aCapBac;
        }       
    }
}
