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
    public partial class UCKhachHangAdmin : UserControl
    {
        CustomerBL customerBL = new CustomerBL();
        public UCKhachHangAdmin()
        {
            InitializeComponent();
        }

        private void UCKhachHangAdmin_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = false;
            LoadDanhSachKhachHang();
            LamMoi();
        }
        private void LoadDanhSachKhachHang()
        {
            dgvKhachHang.DataSource = customerBL.LayDanhSachKhachHang();

            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.ReadOnly = true;

            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.MultiSelect = false;

            if (dgvKhachHang.Columns.Contains("CustomerID"))
                dgvKhachHang.Columns["CustomerID"].HeaderText = "Mã khách hàng";

            if (dgvKhachHang.Columns.Contains("FullName"))
                dgvKhachHang.Columns["FullName"].HeaderText = "Họ và tên";

            if (dgvKhachHang.Columns.Contains("Phone"))
                dgvKhachHang.Columns["Phone"].HeaderText = "Số điện thoại";

            if (dgvKhachHang.Columns.Contains("Email"))
                dgvKhachHang.Columns["Email"].HeaderText = "Email";
        }

        private void LamMoi()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
            txtTimKiem.Text = "";

            txtTenKhachHang.Focus();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                txtMaKhachHang.Text = row.Cells["CustomerID"].Value.ToString();
                txtTenKhachHang.Text = row.Cells["FullName"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["Phone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật!");
                return;
            }

            int customerID = Convert.ToInt32(txtMaKhachHang.Text);
            string hoTen = txtTenKhachHang.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (hoTen == "" || sdt == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và số điện thoại!");
                return;
            }

            bool kq = customerBL.CapNhatKhachHang(customerID, hoTen, sdt, email);

            if (kq)
            {
                MessageBox.Show("Cập nhật khách hàng thành công!");
                LoadDanhSachKhachHang();
                LamMoi();
            }
            else
            {
                MessageBox.Show("Cập nhật khách hàng thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                return;
            }

            int customerID = Convert.ToInt32(txtMaKhachHang.Text);

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa khách hàng này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rs == DialogResult.Yes)
            {
                bool kq = customerBL.XoaKhachHang(customerID);

                if (kq)
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    LoadDanhSachKhachHang();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Khách hàng này có thể đã có hóa đơn.");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
            LamMoi();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            dgvKhachHang.DataSource = customerBL.TimKiemKhachHang(tuKhoa);

            if (dgvKhachHang.Columns.Contains("CustomerID"))
                dgvKhachHang.Columns["CustomerID"].HeaderText = "Mã khách hàng";

            if (dgvKhachHang.Columns.Contains("FullName"))
                dgvKhachHang.Columns["FullName"].HeaderText = "Họ và tên";

            if (dgvKhachHang.Columns.Contains("Phone"))
                dgvKhachHang.Columns["Phone"].HeaderText = "Số điện thoại";

            if (dgvKhachHang.Columns.Contains("Email"))
                dgvKhachHang.Columns["Email"].HeaderText = "Email";
        }
    }
}
