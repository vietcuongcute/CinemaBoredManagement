using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class UCThemPhim : UserControl
    {
        MovieBL themPhimBL = new MovieBL();
        string duongDanAnh = "";
        public UCThemPhim()
        {
            InitializeComponent();

        }

        private void UCThemPhim_Load(object sender, EventArgs e)
        {
            txtGiaVe.Enabled = false;
            button1.Visible = true;
            txtMaPhim.Enabled = false;
            txtSucChua.Enabled = false;
            cbTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTinhTrang.Items.Clear();
            cbTinhTrang.Items.Add("Có sẵn");
            cbTinhTrang.Items.Add("Ngưng chiếu");
            cbTinhTrang.SelectedIndex = 0;
            txtSucChua.Text = "49";
            txtGiaVe.Text = "75,000 VND";
            TaiDuLieuPhim();
        }
        private void TaiDuLieuPhim()
        {
            dgvPhim.DataSource = themPhimBL.LayDanhSachTatCaPhim();
            dgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            dgvPhim.Columns["MovieID"].HeaderText = "Mã phim";
            dgvPhim.Columns["Title"].HeaderText = "Tên phim";
            dgvPhim.Columns["Genre"].HeaderText = "Thể loại";
            dgvPhim.Columns["Duration"].HeaderText = "Thời lượng";
            dgvPhim.Columns["Status"].HeaderText = "Trạng thái";
            dgvPhim.Columns["Capacity"].HeaderText = "Sức chứa";
            dgvPhim.Columns["Price"].HeaderText = "Giá";
        }
        private void LamMoi()
        {
            txtMaPhim.Text = "";
            txtTenPhim.Text = "";
            txtTheLoai.Text = "";
            txtThoiLuong.Text = "";
            cbTinhTrang.SelectedIndex = 0;
            txtSucChua.Text = "49";
            txtGiaVe.Text = "75,000 VND";
            duongDanAnh = "";
            picPoster.Image = null;
            txtTenPhim.Focus();
            button1.Visible= false;
        }

        private void ResetFormThemPhim()
        {
            txtMaPhim.Text = "";
            txtTenPhim.Text = "";
            txtTheLoai.Text = "";
            txtThoiLuong.Text = "";
            cbTinhTrang.SelectedIndex = 0;

            txtSucChua.Text = "49";
            txtGiaVe.Text = "75,000";

            duongDanAnh = "";
            picPoster.Image = null;

            txtSucChua.Enabled = false;
            txtGiaVe.Enabled = false;

            button1.Visible = true;   
            txtTenPhim.Focus();

            
        }

        

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaPhim.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn phim cần cập nhật!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMaPhim.Text.Trim(), out int movieID))
            {
                MessageBox.Show("Mã phim không hợp lệ!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            string title = txtTenPhim.Text.Trim();
            string genre = txtTheLoai.Text.Trim();
            string status = cbTinhTrang.Text.Trim();

            if (!int.TryParse(txtThoiLuong.Text.Trim(), out int duration))
            {
                MessageBox.Show("Thời lượng phải là số nguyên!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int capacity = 49;
            decimal price = 75000;
            string picture = duongDanAnh;

            bool kq = themPhimBL.CapNhatPhim(movieID, title, genre, duration, status, capacity, price, duongDanAnh);

            if (kq)
            {
                MessageBox.Show("Cập nhật phim thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                TaiDuLieuPhim();
                LamMoi();
            }
            else
            {
                MessageBox.Show("Cập nhật phim thất bại!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhim.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn phim cần xóa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int movieID = int.Parse(txtMaPhim.Text.Trim());

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa phim này không?",
                                              "Xác nhận",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                bool kq = themPhimBL.XoaPhim(movieID);

                if (kq)
                {
                    MessageBox.Show("Xóa phim thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    TaiDuLieuPhim();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Xóa phim thất bại!",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ phim không?",
                                              "Xác nhận",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
            {
                bool kq = themPhimBL.XoaHetPhim();

                if (kq)
                {
                    MessageBox.Show("Xóa toàn bộ phim thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    TaiDuLieuPhim();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Xóa toàn bộ phim thất bại!",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn poster phim";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                duongDanAnh = ofd.FileName;
                picPoster.Image = Image.FromFile(duongDanAnh);
                picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Visible= false;
            if (e.RowIndex >= 0)
            {
                txtMaPhim.Text = dgvPhim.Rows[e.RowIndex].Cells["MovieID"].Value.ToString();
                txtTenPhim.Text = dgvPhim.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                txtTheLoai.Text = dgvPhim.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
                txtThoiLuong.Text = dgvPhim.Rows[e.RowIndex].Cells["Duration"].Value.ToString();
                cbTinhTrang.Text = dgvPhim.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                txtSucChua.Text = dgvPhim.Rows[e.RowIndex].Cells["Capacity"].Value.ToString();
                txtGiaVe.Text = dgvPhim.Rows[e.RowIndex].Cells["Price"].Value.ToString();

                object giaTriAnh = dgvPhim.Rows[e.RowIndex].Cells["Picture"].Value;
                duongDanAnh = giaTriAnh != null ? giaTriAnh.ToString() : "";

                if (!string.IsNullOrEmpty(duongDanAnh) && File.Exists(duongDanAnh))
                {
                    picPoster.Image = Image.FromFile(duongDanAnh);
                    picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picPoster.Image = null;
                }
            }
        }

        private void btnMoii_Click(object sender, EventArgs e)
        {
            ResetFormThemPhim();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            string title = txtTenPhim.Text.Trim();
            string genre = txtTheLoai.Text.Trim();
            string status = cbTinhTrang.Text.Trim();

            if (title == "" || genre == "" || txtThoiLuong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phim!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtThoiLuong.Text.Trim(), out int duration))
            {
                MessageBox.Show("Thời lượng phải là số nguyên!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int capacity = 49;
            decimal price = 75000;
            string picture = duongDanAnh;

            bool kq = themPhimBL.ThemPhim(title, genre, duration, status, capacity, price, picture);

            if (kq)
            {
                MessageBox.Show("Thêm phim thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                TaiDuLieuPhim();
                LamMoi();
            }
            else
            {
                MessageBox.Show("Thêm phim thất bại!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
