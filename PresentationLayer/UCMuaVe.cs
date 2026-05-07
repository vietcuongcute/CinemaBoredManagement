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
            LoadDanhSachPhim();
        }
        private void LoadDanhSachPhim()
        {
            dgvPhim.DataSource = movieBL.LayDanhSachPhim();
            dgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhim.AllowUserToAddRows = false;
            dgvPhim.ReadOnly = true;

            dgvPhim.Columns["MovieID"].HeaderText = "Mã phim";
            dgvPhim.Columns["Title"].HeaderText = "Tên phim";
            dgvPhim.Columns["Genre"].HeaderText = "Thể loại";
            dgvPhim.Columns["Duration"].HeaderText = "Thời lượng";
            dgvPhim.Columns["Status"].HeaderText = "Trạng thái";
            dgvPhim.Columns["Capacity"].HeaderText = "Sức chứa";
            dgvPhim.Columns["Price"].HeaderText = "Giá";
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

            FormDatVe f = new FormDatVe(movieID, tenPhim, theLoai, thoiLuong, giaVe, duongDanAnh);
            f.ShowDialog();
        }
    }

}
