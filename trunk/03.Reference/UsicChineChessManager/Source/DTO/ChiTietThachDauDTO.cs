using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietThachDauDTO
    {
        #region Attribute
        private int _nIDChiTietThachDau;       
        private int _nMaThachDau;                
        private int _nMaHoiVien1;        
        private int _nMaHoiVien2;              
        private String _strKetQua;        
        #endregion

        #region Access
        public int IDChiTietThachDau
        {
            get { return _nIDChiTietThachDau; }
            set { _nIDChiTietThachDau = value; }
        }
        public int MaThachDau
        {
            get { return _nMaThachDau; }
            set { _nMaThachDau = value; }
        }        
        public int MaHoiVien1
        {
            get { return _nMaHoiVien1; }
            set { _nMaHoiVien1 = value; }
        }
        public int MaHoiVien2
        {
            get { return _nMaHoiVien2; }
            set { _nMaHoiVien2 = value; }
        } 
        public String KetQua
        {
            get { return _strKetQua; }
            set { _strKetQua = value; }
        }
        #endregion

        #region Distribution
        public ChiTietThachDauDTO()
        {
            _nIDChiTietThachDau = -1;
            _nMaThachDau = -1;            
            _nMaHoiVien1 = -1;
            _nMaHoiVien2 = -1;
            _strKetQua = String.Empty;
        }
        #endregion
    }
}
