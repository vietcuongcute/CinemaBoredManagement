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

        private int _suatChieuID = 0;
        private string _ngayChieu = "";
        private string _gioChieu = "";
        private string _phongChieu = "";
        private DateTime _ngayChieuDangChon;
        SuatChieuBL suatChieuBL = new SuatChieuBL();
        public FormChonSuatChieu(int movieID, string tenPhim, string theLoai, int thoiLuong, decimal giaVe, string duongDanAnh, DateTime ngayChieu)
        {
            InitializeComponent();
            _movieID = movieID;
            _tenPhim = tenPhim;
            _theLoai = theLoai;
            _thoiLuong = thoiLuong;
            _giaVe = giaVe;
            _duongDanAnh = duongDanAnh;
            _ngayChieuDangChon = ngayChieu.Date;
        }

        private void FormChonSuatChieu_Load_1(object sender, EventArgs e)
        {
            lblTenPhim.Text = "Chọn suất chiếu - " + _tenPhim ;
            label2.Text = _ngayChieuDangChon.ToString("dd/MM/yyyy");

            cboSuatChieu.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadSuatChieu();
        }
        private void LoadSuatChieu()
        {
            DataTable dt = suatChieuBL.LaySuatChieuTheoPhimVaNgay(_movieID, _ngayChieuDangChon);

            dt.Columns.Add("GioHienThi", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                string gio = "";

                if (row["GioChieu"] is TimeSpan)
                {
                    TimeSpan time = (TimeSpan)row["GioChieu"];
                    gio = time.ToString(@"hh\:mm");
                }
                else
                {
                    gio = row["GioChieu"].ToString();

                    if (TimeSpan.TryParse(gio, out TimeSpan time))
                        gio = time.ToString(@"hh\:mm");
                }

                row["GioHienThi"] = gio;
            }

            cboSuatChieu.DataSource = dt;
            cboSuatChieu.DisplayMember = "GioHienThi";
            cboSuatChieu.ValueMember = "SuatChieuID";
            cboSuatChieu.SelectedIndex = -1;
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

            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboSuatChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSuatChieu.SelectedIndex == -1 || cboSuatChieu.SelectedItem == null)
                return;

            DataRowView row = cboSuatChieu.SelectedItem as DataRowView;

            if (row == null)
                return;

            _suatChieuID = Convert.ToInt32(row["SuatChieuID"]);

            DateTime ngay = Convert.ToDateTime(row["NgayChieu"]);
            _ngayChieu = ngay.ToString("dd/MM/yyyy");

            if (row["GioChieu"] is TimeSpan)
            {
                TimeSpan gio = (TimeSpan)row["GioChieu"];
                _gioChieu = gio.ToString(@"hh\:mm");
            }
            else
            {
                if (TimeSpan.TryParse(row["GioChieu"].ToString(), out TimeSpan gio))
                    _gioChieu = gio.ToString(@"hh\:mm");
                else
                    _gioChieu = row["GioChieu"].ToString();
            }

            _phongChieu = row["PhongChieu"].ToString();
        }
    }
}




