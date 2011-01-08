using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThangDiemDTO
    {
        #region Attribute
        private int _nIDDiem;       
        private String _strTenDiem;       
        private String _strCongThucTinh;      
        #endregion
        
        #region Access
        public int IDDiem
        {
            get { return _nIDDiem; }
            set { _nIDDiem = value; }
        }
        public String TenDiem
        {
            get { return _strTenDiem; }
            set { _strTenDiem = value; }
        }
        public String CongThucTinh
        {
            get { return _strCongThucTinh; }
            set { _strCongThucTinh = value; }
        }
        #endregion

        #region Distribution
        public ThangDiemDTO()
        {
            _nIDDiem = -1;
            _strTenDiem = String.Empty;
            _strCongThucTinh = String.Empty;
        }
        #endregion
    }
}
