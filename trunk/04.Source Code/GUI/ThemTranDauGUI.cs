using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class ThemTranDauGUI : Form
    {
        // TODO Sửa enter giống như tab
        // TODO Khi ấn Tab thì set selected index
        public ThemTranDauGUI()
        {
            InitializeComponent();
            CalendarColumn thoiGianColumn = new CalendarColumn();
            thoiGianColumn.Name = "ThoiGian";
            thoiGianColumn.HeaderText = "Thời gian";
            thoiGianColumn.Width = 100;
            thoiGianColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDanhSachTranDau.Columns.Insert(5, thoiGianColumn);
            this.dgvDanhSachTranDau.EditMode = DataGridViewEditMode.EditOnEnter;

            // Lấy dữ liệu đổ lên các combobox
            this.LayDuLieuVaoComboBox();
        }

        public void LayDuLieuVaoComboBox()
        {
            try
            {
                HoiVienBUS hoiVienBus = new HoiVienBUS();
                DataTable danhSachHoiVien = hoiVienBus.LayDanhSachHoTenVaMSSVTatCaHoiVien();

                DataGridViewComboBoxColumn mssv1Col = this.dgvDanhSachTranDau.Columns["MSSV1"] as DataGridViewComboBoxColumn;
                mssv1Col.DataSource = danhSachHoiVien;
                mssv1Col.DisplayMember = "MSSV";
                mssv1Col.ValueMember = "ID";

                DataGridViewComboBoxColumn hoTen1Col = this.dgvDanhSachTranDau.Columns["HoTen1"] as DataGridViewComboBoxColumn;
                hoTen1Col.DataSource = danhSachHoiVien;
                hoTen1Col.DisplayMember = "HoTen";
                hoTen1Col.ValueMember = "ID";

                DataGridViewComboBoxColumn mssv2Col = this.dgvDanhSachTranDau.Columns["MSSV2"] as DataGridViewComboBoxColumn;
                mssv2Col.DataSource = danhSachHoiVien;
                mssv2Col.DisplayMember = "MSSV";
                mssv2Col.ValueMember = "ID";

                DataGridViewComboBoxColumn hoTen2Col = this.dgvDanhSachTranDau.Columns["HoTen2"] as DataGridViewComboBoxColumn;
                hoTen2Col.DataSource = danhSachHoiVien;
                hoTen2Col.DisplayMember = "HoTen";
                hoTen2Col.ValueMember = "ID";

                DataGridViewComboBoxColumn trongTaiCol = this.dgvDanhSachTranDau.Columns["TrongTai"] as DataGridViewComboBoxColumn;
                trongTaiCol.DataSource = danhSachHoiVien;
                trongTaiCol.DisplayMember = "HoTen";
                trongTaiCol.ValueMember = "ID";

                KetQuaTranDauBUS ketQuaBUS = new KetQuaTranDauBUS();
                DataTable ketQuaTranDau = ketQuaBUS.LayDanhSachKetQua();
                DataGridViewComboBoxColumn ketQuaCol = this.dgvDanhSachTranDau.Columns["KetQua"] as DataGridViewComboBoxColumn;
                ketQuaCol.DataSource = ketQuaTranDau;
                ketQuaCol.DisplayMember = "TheHien";
                ketQuaCol.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvDanhSachTranDau_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control.GetType() == typeof(DataGridViewComboBoxEditingControl))
            {
                DataGridViewComboBoxEditingControl cbo = e.Control as DataGridViewComboBoxEditingControl;
                cbo.DropDownStyle = ComboBoxStyle.DropDown;
                cbo.KeyPress += new KeyPressEventHandler(cbo_KeyPress);
                cbo.SelectedIndexChanged += new EventHandler(cbo_SelectedIndexChanged);
            }
        }

        void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewComboBoxEditingControl cbo = (DataGridViewComboBoxEditingControl)sender;
            //int col = this.dgvDanhSachTranDau.CurrentCell.ColumnIndex;
            if (cbo.SelectedIndex >= 0 && cbo.SelectedValue is int)
            {
                int id = (int)cbo.SelectedValue;
                int chiSoCotHienTai = this.dgvDanhSachTranDau.CurrentCell.ColumnIndex;
                DataGridViewRow dongHienTai = this.dgvDanhSachTranDau.CurrentRow;
                if (chiSoCotHienTai == 1)
                {
                    dongHienTai.Cells["HoTen1"].Value = id;
                }
                else if (chiSoCotHienTai == 2)
                {
                    dongHienTai.Cells["MSSV1"].Value = id;
                }
                else if (chiSoCotHienTai == 3)
                {
                    dongHienTai.Cells["HoTen2"].Value = id;
                }
                else if (chiSoCotHienTai == 4)
                {
                    dongHienTai.Cells["MSSV2"].Value = id;
                }
            }
        }

        private void cbo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.AutoComplete(sender as ComboBox, e, true);
        }

        // Ref: http://www.codeproject.com/KB/combobox/AutoCompleteComboBox.aspx
        public void AutoComplete(ComboBox cb, System.Windows.Forms.KeyPressEventArgs e, bool blnLimitToList)
        {
            string strFindStr = "";

            // Backspace char
            if (e.KeyChar == (char)Keys.Back)
            {
                if (cb.SelectionStart <= 1)
                {
                    cb.Text = "";
                    return;
                }

                if (cb.SelectionLength == 0)
                    strFindStr = cb.Text.Substring(0, cb.Text.Length - 1);
                else
                    strFindStr = cb.Text.Substring(0, cb.SelectionStart - 1);
            }
            else
            {
                if (cb.SelectionLength == 0)
                    strFindStr = cb.Text + e.KeyChar;
                else
                    strFindStr = cb.Text.Substring(0, cb.SelectionStart) + e.KeyChar;
            }

            int intIdx = -1;

            // Search the string in the ComboBox list.

            intIdx = cb.FindString(strFindStr);

            if (intIdx != -1)
            {
                cb.SelectedText = "";
                cb.SelectedIndex = intIdx;
                cb.SelectionStart = strFindStr.Length;
                cb.SelectionLength = cb.Text.Length;
                e.Handled = true;
            }
            else
            {
                e.Handled = blnLimitToList;
            }

        }

        private void dgvDanhSachTranDau_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.DanhSoThuTu();
        }

        public void DanhSoThuTu()
        {
            if (this.dgvDanhSachTranDau != null)
            {
                for (int i = 0; i < this.dgvDanhSachTranDau.Rows.Count; i++)
                {
                    this.dgvDanhSachTranDau[0, i].Value = i + 1;
                }
            }
        }

        private void dgvDanhSachTranDau_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.DanhSoThuTu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                TranDauBUS tranDauBUS = new TranDauBUS();

                bool themThanhCong = true;
                int soDongThucTe = this.dgvDanhSachTranDau.Rows.Count - 1;
                if (soDongThucTe == 0)
                {
                    MessageBox.Show("Chưa có dữ liệu");
                }
                else
                {
                    for (int i = 0; i < soDongThucTe; i++)
                    {
                        try
                        {
                            TranDauDTO tranDauDTO = LayThongTinTranDauTuBang(this.dgvDanhSachTranDau, i);
                            if (tranDauDTO != null)
                            {
                                themThanhCong &= tranDauBUS.ThemTranDau(tranDauDTO);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Dòng " + (i + 1) + " :" + ex.Message);
                            themThanhCong = false;
                        }
                    }

                    if (themThanhCong)
                    {
                        MessageBox.Show("Lưu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại");
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor = Cursors.Default;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            this.dgvDanhSachTranDau.Rows.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static TranDauDTO LayThongTinTranDauTuBang(DataGridView bangDuLieu, int dongCanLay)
        {
            try
            {
                TranDauDTO tranDauDTO = new TranDauDTO();

                if (bangDuLieu.Rows[dongCanLay].Cells["MSSV1"].Value != null)
                {
                    tranDauDTO.MaDauThu1 = int.Parse(bangDuLieu.Rows[dongCanLay].Cells["MSSV1"].Value.ToString());
                }
                else
                {
                    throw new Exception("Đấu thủ 1 không thể để trống");
                }

                if (bangDuLieu.Rows[dongCanLay].Cells["MSSV2"].Value != null)
                {
                    tranDauDTO.MaDauThu2 = int.Parse(bangDuLieu.Rows[dongCanLay].Cells["MSSV2"].Value.ToString());
                }
                else
                {
                    throw new Exception("Đấu thủ 2 không thể để trống");
                }

                tranDauDTO.ThoiGian = DateTime.Parse(bangDuLieu.Rows[dongCanLay].Cells["ThoiGian"].Value.ToString());

                if (bangDuLieu.Rows[dongCanLay].Cells["DiaDiem"].Value != null)
                {
                    tranDauDTO.DiaDiem = bangDuLieu.Rows[dongCanLay].Cells["DiaDiem"].Value.ToString();
                }

                if (bangDuLieu.Rows[dongCanLay].Cells["TrongTai"].Value != null)
                {
                    tranDauDTO.MaTrongTai = int.Parse(bangDuLieu.Rows[dongCanLay].Cells["TrongTai"].Value.ToString());
                }

                if (bangDuLieu.Rows[dongCanLay].Cells["KetQua"].Value != null)
                {
                    tranDauDTO.MaKetQua = int.Parse(bangDuLieu.Rows[dongCanLay].Cells["KetQua"].Value.ToString());
                }

                return tranDauDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
