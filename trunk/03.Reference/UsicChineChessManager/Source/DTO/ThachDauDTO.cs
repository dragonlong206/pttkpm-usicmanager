using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThachDauDTO
    {
        #region Attribute
        private int _nIDThachDau;       
        private DateTime _dateThoiGian;
        private String _strDiaDiem;        
        private int _nNguoiQuanLy;        
        #endregion

        #region Access
        public int IDThachDau
        {
            get { return _nIDThachDau; }
            set { _nIDThachDau = value; }
        }
        public DateTime ThoiGian
        {
            get { return _dateThoiGian; }
            set { _dateThoiGian = value; }
        }
        public String DiaDiem
        {
            get { return _strDiaDiem; }
            set { _strDiaDiem = value; }
        }
        public int NguoiQuanLy
        {
            get { return _nNguoiQuanLy; }
            set { _nNguoiQuanLy = value; }
        }
        #endregion

        #region Distribution
        public ThachDauDTO()
        {
            _nIDThachDau = -1;
            _dateThoiGian = DateTime.Today;
            _strDiaDiem = String.Empty;
            _nNguoiQuanLy = -1;
        }
        #endregion
    }
}
