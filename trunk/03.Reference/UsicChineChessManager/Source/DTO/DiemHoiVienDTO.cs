using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DiemHoiVienDTO
    {
        #region Attribute
        private int _nIDDiemHoiVien;        
        private int _nMaDiem;       
        private int _nMaHoiVien;       
        private double _dGiaTri;        
        #endregion

        #region Access
        public int IDDiemHoiVien
        {
            get { return _nIDDiemHoiVien; }
            set { _nIDDiemHoiVien = value; }
        }
        public int MaDiem
        {
            get { return _nMaDiem; }
            set { _nMaDiem = value; }
        }
        public int MaHoiVien
        {
            get { return _nMaHoiVien; }
            set { _nMaHoiVien = value; }
        }
        public double GiaTri
        {
            get { return _dGiaTri; }
            set { _dGiaTri = value; }
        }
        #endregion

        #region Distribution
        public DiemHoiVienDTO()
        {
            _nIDDiemHoiVien = -1;
            _nMaDiem = -1;
            _nMaHoiVien = -1;
            _dGiaTri = 0;
        }

        public DiemHoiVienDTO(DiemHoiVienDTO aDiemHoiVien)
        {
            _nIDDiemHoiVien = aDiemHoiVien.IDDiemHoiVien;
            _nMaDiem = aDiemHoiVien.MaDiem;
            _nMaHoiVien = aDiemHoiVien.MaHoiVien;
            _dGiaTri = aDiemHoiVien.GiaTri;
        }
        #endregion
    }
}
