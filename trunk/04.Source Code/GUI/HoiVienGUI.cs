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
    public partial class HoiVienGUI : Form
    {
        DataTable danhSachHoiVien;

        public HoiVienGUI()
        {
            InitializeComponent();
            this.ucHoiVien_ChiTiet1.Ancestor = this;
        }

        private void HoiVienGUI_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        public void HienThiDuLieu()
        {
            try
            {
                HoiVienBUS hoiVienBUS = new HoiVienBUS();
                danhSachHoiVien = hoiVienBUS.LayDanhSachTatCaHoiVien();
                this.dgvDanhSachHoiVien.AutoGenerateColumns = false;
                this.dgvDanhSachHoiVien.DataSource = danhSachHoiVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDanhSachHoiVien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvDanhSachHoiVien.SelectedRows.Count > 0)
                {
                    int selectedRow = int.Parse(this.dgvDanhSachHoiVien.SelectedRows[0].Cells["STT"].Value.ToString()) - 1;
                    if (selectedRow >= 0)
                    {
                        if (danhSachHoiVien != null && danhSachHoiVien.Rows.Count > 0)
                        {
                            HoiVienDTO hoiVienDTO = HoiVienBUS.LayDuLieuHoiVienTuBang(danhSachHoiVien, selectedRow);
                            ucHoiVien_ChiTiet1.GanDuLieu(hoiVienDTO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (this.txtHoTen.Text == string.Empty && this.txtMSSV.Text == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập tên hoặc MSSV để tìm kiếm");
            }
            else
            {
                try
                {
                    DataTable danhSachTheoTen = null;
                    DataTable danhSachTheoMSSV = null;

                    HoiVienBUS hoiVienBUS = new HoiVienBUS();

                    if (this.txtHoTen.Text != string.Empty)
                    {
                        danhSachTheoTen = hoiVienBUS.LayDanhSachHoiVienTheoHoTen(this.txtHoTen.Text);
                    }

                    if (this.txtMSSV.Text != string.Empty)
                    {
                        danhSachTheoMSSV = hoiVienBUS.LayHoiVienTheoMSSV(this.txtMSSV.Text);
                    }

                    danhSachHoiVien.Clear();
                    
                    if (danhSachTheoTen != null)
                    {
                        danhSachHoiVien = danhSachTheoTen;
                    }
                    
                    if (danhSachTheoMSSV != null && danhSachTheoMSSV.Rows.Count > 0)
                    {
                        bool daTonTai = false;
                        for (int i = 0; i < danhSachHoiVien.Rows.Count; i++)
                        {
                            if (danhSachHoiVien.Rows[i]["MSSV"].ToString() == this.txtMSSV.Text)
                            {
                                daTonTai = true;
                                break;
                            }
                        }

                        if (!daTonTai)
                        {
                            DataRow newRow = danhSachHoiVien.NewRow();
                            newRow["HoTen"] = danhSachTheoMSSV.Rows[0]["HoTen"];
                            newRow["MSSV"] = danhSachTheoMSSV.Rows[0]["MSSV"];
                            newRow["GioiTinh"] = danhSachTheoMSSV.Rows[0]["GioiTinh"];
                            newRow["ELO"] = danhSachTheoMSSV.Rows[0]["ELO"];
                            newRow["TenCapBac"] = danhSachTheoMSSV.Rows[0]["TenCapBac"];
                            newRow["MaCapBac"] = danhSachTheoMSSV.Rows[0]["MaCapBac"];
                            newRow["DiemLienKich"] = danhSachTheoMSSV.Rows[0]["DiemLienKichCaoNhat"];
                            newRow["ThoiGianDatDiemLienKich"] = danhSachTheoMSSV.Rows[0]["ThoiGianDatDiemLienKich"];
                            danhSachHoiVien.Rows.Add(newRow);
                        }
                    }

                    this.dgvDanhSachHoiVien.DataSource = danhSachHoiVien;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.HienThiDuLieu();
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btnTim_Click(null, null);
            }
        }

        private void txtMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btnTim_Click(null, null);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này đang được xây dựng");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này đang được xây dựng");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucHoiVien_ChiTiet1_Load(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachHoiVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
