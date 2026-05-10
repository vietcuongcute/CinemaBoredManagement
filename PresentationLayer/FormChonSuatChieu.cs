using BusinessLayer;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormChonSuatChieu : Form
    {
        private int _movieID;
        private string _tenPhim;
        private string _theLoai;
        private int _thoiLuong;
        private decimal _giaVe;
        private string _duongDanAnh;
        private string _ngayChieu = "";
        private string _gioChieu = "";
        private string _phongChieu = "";

        private int _suatChieuID = 0;

        SuatChieuBL suatChieuBL = new SuatChieuBL();
        public FormChonSuatChieu(int movieID, string tenPhim, string theLoai, int thoiLuong, decimal giaVe, string duongDanAnh)
        {
            InitializeComponent();
            _movieID = movieID;
            _tenPhim = tenPhim;
            _theLoai = theLoai;
            _thoiLuong = thoiLuong;
            _giaVe = giaVe;
            _duongDanAnh = duongDanAnh;
        }

        private void FormChonSuatChieu_Load_1(object sender, EventArgs e)
        {
            lblTenPhim.Text = "Chọn suất chiếu - " + _tenPhim;
            LoadSuatChieu();
        }
        private void LoadSuatChieu()
        {
            dgvSuatChieu.DataSource = suatChieuBL.LaySuatChieuTheoPhim(_movieID);

            dgvSuatChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuatChieu.AllowUserToAddRows = false;
            dgvSuatChieu.ReadOnly = true;
            dgvSuatChieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuatChieu.MultiSelect = false;

            if (dgvSuatChieu.Columns.Contains("SuatChieuID"))
                dgvSuatChieu.Columns["SuatChieuID"].HeaderText = "Mã suất";

            if (dgvSuatChieu.Columns.Contains("MovieID"))
                dgvSuatChieu.Columns["MovieID"].Visible = false;

            if (dgvSuatChieu.Columns.Contains("NgayChieu"))
                dgvSuatChieu.Columns["NgayChieu"].HeaderText = "Ngày chiếu";

            if (dgvSuatChieu.Columns.Contains("GioChieu"))
                dgvSuatChieu.Columns["GioChieu"].HeaderText = "Giờ chiếu";

            if (dgvSuatChieu.Columns.Contains("PhongChieu"))
                dgvSuatChieu.Columns["PhongChieu"].HeaderText = "Phòng chiếu";

            if (dgvSuatChieu.Columns.Contains("TrangThai"))
                dgvSuatChieu.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void dgvSuatChieu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSuatChieu.Rows[e.RowIndex];

                _suatChieuID = Convert.ToInt32(row.Cells["SuatChieuID"].Value);

                _ngayChieu = Convert.ToDateTime(row.Cells["NgayChieu"].Value).ToString("dd/MM/yyyy");
                _gioChieu = row.Cells["GioChieu"].Value.ToString();
                _phongChieu = row.Cells["PhongChieu"].Value.ToString();
            }
        }

        private void btnChonSuat_Click_1(object sender, EventArgs e)
        {
            if (_suatChieuID == 0)
            {
                MessageBox.Show("Vui lòng chọn suất chiếu!");
                return;
            }

            FormDatVe f = new FormDatVe(
                _movieID,
                _suatChieuID,
                _tenPhim,
                _theLoai,
                _thoiLuong,
                _giaVe,
                _duongDanAnh,
                _ngayChieu,
                 _gioChieu,
                _phongChieu
            );
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




