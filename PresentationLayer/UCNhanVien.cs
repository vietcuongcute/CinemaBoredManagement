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
    public partial class UCNhanVien : UserControl
    {
        NhanVienBL nhanvienBL = new NhanVienBL();
        public UCNhanVien()
        {
            InitializeComponent();
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            
            txtMaTK.Enabled= false;
            cbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChucVu.Items.Clear();
            cbChucVu.Items.Add("Admin");
            cbChucVu.Items.Add("Nhân viên");
            cbChucVu.SelectedIndex = -1;
            TaiDuLieuNhanVien();
        }
        private void TaiDuLieuNhanVien()
        {
            dgvNhanVien.DataSource = nhanvienBL.LayDanhSachNhanVien();

            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.ReadOnly = true;

            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.MultiSelect = false;

            dgvNhanVien.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dgvNhanVien.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;


            dgvNhanVien.Columns["MaTK"].HeaderText = "Mã tài khoản";
            dgvNhanVien.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dgvNhanVien.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dgvNhanVien.Columns["VaiTro"].HeaderText = "Vai trò";
        }
        private void LamMoi()
        {
            txtTenNhanVien.Text = "";
            txtMatKhau.Text = "";
            cbChucVu.SelectedItem = 1;
            txtTenNhanVien.Focus();
        }

        private void btnThêm_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenNhanVien.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string vaiTro = cbChucVu.Text.Trim();

            if(tenDangNhap =="" || matKhau == "" || vaiTro == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool kq = nhanvienBL.ThemNhanVien(tenDangNhap, matKhau, vaiTro);
            if(kq )
            {
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieuNhanVien();
                LamMoi();
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Đã tồn tại tên đăng nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(txtTenNhanVien.Text.Trim()== "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTK = int.Parse(txtMaTK.Text);
            string tenDangNhap = txtTenNhanVien.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string vaiTro = cbChucVu.Text.Trim();

            if(tenDangNhap == "" || matKhau == "" || vaiTro == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool kq = nhanvienBL.CapNhatNhanVien(maTK, tenDangNhap, matKhau, vaiTro);
            if (kq)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieuNhanVien();
                LamMoi();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaTK.Text.Trim()== "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            int maTK = int.Parse(txtMaTK.Text);

            DialogResult rs= MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không?","Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                bool kq = nhanvienBL.XoaNhanVien(maTK);
                if (kq)
                {
                    MessageBox.Show("Xóa thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    TaiDuLieuNhanVien();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            bool kq = nhanvienBL.XoaHetNhanVien();

            if (kq)
            {
                MessageBox.Show("Xóa tất cả thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                TaiDuLieuNhanVien();
                LamMoi();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa hoặc xóa thất bại!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtMaTK.Text = dgvNhanVien.Rows[e.RowIndex].Cells["MaTK"].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = dgvNhanVien.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
                cbChucVu.Text = dgvNhanVien.Rows[e.RowIndex].Cells["VaiTro"].Value.ToString();
            }
        }
    }
}
