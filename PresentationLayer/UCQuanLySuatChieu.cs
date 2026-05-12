using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class UCQuanLySuatChieu : UserControl
    {
        SuatChieuBL suatChieuBL = new SuatChieuBL();
        MovieBL movieBL = new MovieBL();
        private int movieIDDangChon = 0;
        public UCQuanLySuatChieu()
        {
            InitializeComponent();
        }

        private void UCQuanLySuatChieu_Load(object sender, EventArgs e)
        {
            txtMaSuatChieu.Enabled = false;

            SetupComboBox();
            LoadPhimComboBox();

            dgvSuatChieu.DataSource = null;
        }
        private void SetupComboBox()
        {
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;

            cboGioChieu.Enabled = true;
            cboGioChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioChieu.Items.Clear();
            cboGioChieu.Items.Add("08:00");
            cboGioChieu.Items.Add("09:00");
            cboGioChieu.Items.Add("10:00");
            cboGioChieu.Items.Add("13:30");
            cboGioChieu.Items.Add("14:00");
            cboGioChieu.Items.Add("18:30");
            cboGioChieu.Items.Add("19:00");
            cboGioChieu.Items.Add("20:00");
            cboGioChieu.Items.Add("22:00");
            cboGioChieu.SelectedIndex = -1;

            cboPhongChieu.Enabled = true;
            cboPhongChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhongChieu.Items.Clear();
            cboPhongChieu.Items.Add("Phòng 1");
            cboPhongChieu.Items.Add("Phòng 2");
            cboPhongChieu.Items.Add("Phòng 3");
            cboPhongChieu.Items.Add("Phòng 4");
            cboPhongChieu.SelectedIndex = -1;

            cboTrangThai.Enabled = true;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Có sẵn");
            cboTrangThai.Items.Add("Ngưng chiếu");
            cboTrangThai.SelectedIndex = 0;
        }
        private void LoadPhimComboBox()
        {
            cboPhim.SelectedIndexChanged -= cboPhim_SelectedIndexChanged;

            cboPhim.DataSource = movieBL.LayDanhSachTatCaPhim();
            cboPhim.DisplayMember = "Title";
            cboPhim.ValueMember = "MovieID";
            cboPhim.SelectedIndex = -1;

            cboPhim.SelectedIndexChanged += cboPhim_SelectedIndexChanged;
        }

        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhim.SelectedValue == null || cboPhim.SelectedValue is DataRowView)
                return;

            movieIDDangChon = Convert.ToInt32(cboPhim.SelectedValue);

            LoadSuatChieuTheoPhim();
            LamMoiSuatChieu();
        }

        private void LoadSuatChieuTheoPhim()
        {
            if (movieIDDangChon <= 0)
            {
                dgvSuatChieu.DataSource = null;
                return;
            }

            dgvSuatChieu.DataSource = suatChieuBL.LaySuatChieuTheoPhim(movieIDDangChon);

            dgvSuatChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuatChieu.AllowUserToAddRows = false;
            dgvSuatChieu.ReadOnly = true;
            dgvSuatChieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuatChieu.MultiSelect = false;

            if (dgvSuatChieu.Columns.Contains("SuatChieuID"))
                dgvSuatChieu.Columns["SuatChieuID"].HeaderText = "Mã suất";

            if (dgvSuatChieu.Columns.Contains("MovieID"))
                dgvSuatChieu.Columns["MovieID"].Visible = false;

            if (dgvSuatChieu.Columns.Contains("Title"))
                dgvSuatChieu.Columns["Title"].HeaderText = "Tên phim";

            if (dgvSuatChieu.Columns.Contains("NgayChieu"))
                dgvSuatChieu.Columns["NgayChieu"].HeaderText = "Ngày chiếu";

            if (dgvSuatChieu.Columns.Contains("GioChieu"))
                dgvSuatChieu.Columns["GioChieu"].HeaderText = "Giờ chiếu";

            if (dgvSuatChieu.Columns.Contains("PhongChieu"))
                dgvSuatChieu.Columns["PhongChieu"].HeaderText = "Phòng";

            if (dgvSuatChieu.Columns.Contains("TrangThai"))
                dgvSuatChieu.Columns["TrangThai"].HeaderText = "Trạng thái";
        }


        private void LamMoiSuatChieu()
        {
            txtMaSuatChieu.Text = "";
            dtpNgayChieu.Value = DateTime.Now;
            cboGioChieu.SelectedIndex = -1;
            cboPhongChieu.SelectedIndex = -1;

            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;
        }
        

        private void dgvSuatChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSuatChieu.Rows[e.RowIndex];

                txtMaSuatChieu.Text = row.Cells["SuatChieuID"].Value.ToString();
                dtpNgayChieu.Value = Convert.ToDateTime(row.Cells["NgayChieu"].Value);

                object gioValue = row.Cells["GioChieu"].Value;

                if (gioValue is TimeSpan)
                {
                    TimeSpan gio = (TimeSpan)gioValue;
                    cboGioChieu.Text = gio.ToString(@"hh\:mm");
                }
                else
                {
                    cboGioChieu.Text = gioValue.ToString();
                }

                cboPhongChieu.Text = row.Cells["PhongChieu"].Value.ToString();
                cboTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (movieIDDangChon <= 0)
            {
                MessageBox.Show("Vui lòng chọn phim trước!");
                return;
            }

            if (cboGioChieu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giờ chiếu!");
                return;
            }

            if (cboPhongChieu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu!");
                return;
            }

            DateTime ngayChieu = dtpNgayChieu.Value.Date;
            TimeSpan gioChieu = TimeSpan.Parse(cboGioChieu.Text);
            string phongChieu = cboPhongChieu.Text.Trim();
            string trangThai = cboTrangThai.Text.Trim();

            bool kq = suatChieuBL.ThemSuatChieu(
                movieIDDangChon,
                ngayChieu,
                gioChieu,
                phongChieu,
                trangThai
            );

            if (kq)
            {
                MessageBox.Show("Thêm suất chiếu thành công!");
                LoadSuatChieuTheoPhim();
                LamMoiSuatChieu();
            }
            else
            {
                MessageBox.Show("Thêm suất chiếu thất bại!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaSuatChieu.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn suất chiếu cần cập nhật!");
                return;
            }

            if (movieIDDangChon <= 0)
            {
                MessageBox.Show("Vui lòng chọn phim!");
                return;
            }

            if (cboGioChieu.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cboGioChieu.Text))
            {
                MessageBox.Show("Vui lòng chọn giờ chiếu!");
                return;
            }

            if (cboPhongChieu.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cboPhongChieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu!");
                return;
            }

            int suatChieuID = Convert.ToInt32(txtMaSuatChieu.Text);
            DateTime ngayChieu = dtpNgayChieu.Value.Date;
            TimeSpan gioChieu = TimeSpan.Parse(cboGioChieu.Text);
            string phongChieu = cboPhongChieu.Text.Trim();
            string trangThai = cboTrangThai.Text.Trim();

            bool kq = suatChieuBL.CapNhatSuatChieu(
                suatChieuID,
                movieIDDangChon,
                ngayChieu,
                gioChieu,
                phongChieu,
                trangThai
            );

            if (kq)
            {
                MessageBox.Show("Cập nhật suất chiếu thành công!");
                LoadSuatChieuTheoPhim();
                LamMoiSuatChieu();
            }
            else
            {
                MessageBox.Show("Cập nhật suất chiếu thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSuatChieu.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn suất chiếu cần xóa!");
                return;
            }

            int suatChieuID = Convert.ToInt32(txtMaSuatChieu.Text);

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa suất chiếu này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rs == DialogResult.Yes)
            {
                bool kq = suatChieuBL.XoaSuatChieu(suatChieuID);

                if (kq)
                {
                    MessageBox.Show("Xóa suất chiếu thành công!");
                    LoadSuatChieuTheoPhim();
                    LamMoiSuatChieu();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Suất chiếu này có thể đã có vé.");
                }
            }
        }
        

        private void btnMoi_Click(object sender, EventArgs e)
        {
            LamMoiSuatChieu();
        }
    }
}
