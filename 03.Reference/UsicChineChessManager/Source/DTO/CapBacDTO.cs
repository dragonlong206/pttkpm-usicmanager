using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CapBacDTO
    {
        #region Attribute
        private int _nIDCapBac;
        private int _nChiSoCapBac;       
        private String _strTenCapBac;        
        private double _dNguongVuotTroi;        
        #endregion

        #region Access
        public int IDCapBac
        {
            get { return _nIDCapBac; }
            set { _nIDCapBac = value; }
        }
        public int ChiSoCapBac
        {
            get { return _nChiSoCapBac; }
            set { _nChiSoCapBac = value; }
        }
        public String TenCapBac
        {
            get { return _strTenCapBac; }
            set { _strTenCapBac = value; }
        }
        public double NguongVuotTroi
        {
            get { return _dNguongVuotTroi; }
            set { _dNguongVuotTroi = value; }
        }
        #endregion

        #region Distribution
        public CapBacDTO()
        {
            _nIDCapBac = -1;
            _nChiSoCapBac = -1;
            _strTenCapBac = String.Empty;
            _dNguongVuotTroi = -1;
        }
        #endregion
    }
}
