using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoiVienDTO
    {       
        #region Attribute
        private int _nIDHoiVien;        
        private String _strMSSV;
        private String _strHoTen;
        private int _nMaCapBac;        
        #endregion

        #region Access
        public int IDHoiVien
        {
            get { return _nIDHoiVien; }
            set { _nIDHoiVien = value; }
        }
        public String MSSV
        {
            get { return _strMSSV; }
            set { _strMSSV = value; }
        }
        public String HoTen
        {
            get { return _strHoTen; }
            set { _strHoTen = value; }
        }
        public int MaCapBac
        {
            get { return _nMaCapBac; }
            set { _nMaCapBac = value; }
        }
        #endregion

        #region Distribution
        public HoiVienDTO()
        {
            _nIDHoiVien = -1;
            _strMSSV = String.Empty; 
            _strHoTen = String.Empty;
            _nMaCapBac = -1;            
        }        
        #endregion
    }
}
