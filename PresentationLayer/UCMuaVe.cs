using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class UCMuaVe : UserControl
    {
        private SuatChieuBL suatChieuBL = new SuatChieuBL();
        MovieBL movieBL = new MovieBL();
        private int movieID = 0;
        private string tenPhim = "";
        private string theLoai = "";
        private int thoiLuong = 0;
        private decimal giaVe = 0;
        private string duongDanAnh = "";
        public UCMuaVe()
        {

            InitializeComponent();
        }

        private void UCMuaVe_Load(object sender, EventArgs e)
        {
            dtpNgayChieu.Value = DateTime.Now;
            LoadDanhSachPhimTheoNgay();
        }
        private void LoadDanhSachPhimTheoNgay()
        {
            DateTime ngayChieu = dtpNgayChieu.Value.Date;

            dgvPhim.DataSource = suatChieuBL.LayPhimTheoNgay(ngayChieu);

            dgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhim.AllowUserToAddRows = false;
            dgvPhim.ReadOnly = true;
            dgvPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhim.MultiSelect = false;

            if (dgvPhim.Columns.Contains("MovieID"))
                dgvPhim.Columns["MovieID"].HeaderText = "Mã phim";

            if (dgvPhim.Columns.Contains("Title"))
                dgvPhim.Columns["Title"].HeaderText = "Tên phim";

            if (dgvPhim.Columns.Contains("Genre"))
                dgvPhim.Columns["Genre"].HeaderText = "Thể loại";

            if (dgvPhim.Columns.Contains("Duration"))
                dgvPhim.Columns["Duration"].HeaderText = "Thời lượng";

            if (dgvPhim.Columns.Contains("Status"))
                dgvPhim.Columns["Status"].HeaderText = "Trạng thái";

            if (dgvPhim.Columns.Contains("Capacity"))
                dgvPhim.Columns["Capacity"].HeaderText = "Sức chứa";

            if (dgvPhim.Columns.Contains("Price"))
                dgvPhim.Columns["Price"].HeaderText = "Giá";

            if (dgvPhim.Columns.Contains("Picture"))
                dgvPhim.Columns["Picture"].HeaderText = "Picture";

            LamMoiThongTinPhim();
        }

        private void LamMoiThongTinPhim()
        {
            movieID = 0;
            tenPhim = "";
            theLoai = "";
            thoiLuong = 0;
            giaVe = 0;
            duongDanAnh = "";

            lblMaPhim.Text = "___";
            lblTenPhim.Text = "___";
            lblTheLoai.Text = "___";
            lblThoiLuong.Text = "___";
            lblGiaVe.Text = "___";
            picPoster.Image = null;
        }

        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhim.Rows[e.RowIndex];

                movieID = Convert.ToInt32(row.Cells["MovieID"].Value);
                tenPhim = row.Cells["Title"].Value.ToString();
                theLoai = row.Cells["Genre"].Value.ToString();
                thoiLuong = Convert.ToInt32(row.Cells["Duration"].Value);
                giaVe = Convert.ToDecimal(row.Cells["Price"].Value);
                duongDanAnh = row.Cells["Picture"].Value.ToString();

                lblMaPhim.Text = movieID.ToString();
                lblTenPhim.Text = tenPhim;
                lblTheLoai.Text = theLoai;
                lblThoiLuong.Text = thoiLuong.ToString();
                lblGiaVe.Text = giaVe.ToString("N0");

                if (System.IO.File.Exists(duongDanAnh))
                {
                    using (var imgTemp = Image.FromFile(duongDanAnh))
                    {
                        picPoster.Image = new Bitmap(imgTemp);
                    }

                    picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picPoster.Image = null;
                }
            }
        }
        

        private void btnChonPhim_Click(object sender, EventArgs e)
        {
            if (movieID == 0)
            {
                MessageBox.Show("Vui lòng chọn phim trước!");
                return;
            }

            DateTime ngayChieu = dtpNgayChieu.Value.Date;

            FormChonSuatChieu f = new FormChonSuatChieu(
                movieID,
                tenPhim,
                theLoai,
                thoiLuong,
                giaVe,
                duongDanAnh,
                ngayChieu
            );

            f.ShowDialog();

            
        }


        private void dtpNgayChieu_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSachPhimTheoNgay();
        }
    }

}
