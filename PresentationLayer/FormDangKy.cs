using BusinessLayer;
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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
            this.Shown += FormDangKy_Shown ;
        }
        RegisterBL registerBL = new RegisterBL();
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirm password")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.ForeColor = Color.Black;
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                txtConfirmPassword.PasswordChar = '\0';
                txtConfirmPassword.Text = "Confirm password";
                txtConfirmPassword.ForeColor = Color.Silver;
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password")
                txtPassword.PasswordChar = chkHienMatKhau.Checked ? '\0' : '*';

            if (txtConfirmPassword.Text != "Confirm password")
                txtConfirmPassword.PasswordChar = chkHienMatKhau.Checked ? '\0' : '*';
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Silver;

            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Silver;
            txtPassword.PasswordChar = '\0';

            txtConfirmPassword.Text = "Confirm password";
            txtConfirmPassword.ForeColor = Color.Silver;
            txtConfirmPassword.PasswordChar = '\0';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();
            string xacNhanMatKhau = txtConfirmPassword.Text.Trim();

            if (tenDangNhap == "Username") tenDangNhap = "";
            if (matKhau == "Password") matKhau = "";
            if (xacNhanMatKhau == "Confirm password") xacNhanMatKhau = "";

            if (tenDangNhap == "" || matKhau == "" || xacNhanMatKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (registerBL.KiemTraTonTaiTaiKhoan(tenDangNhap))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            bool ketQua = registerBL.DangKy(tenDangNhap, matKhau);

            if (ketQua)
            {
                MessageBox.Show("Đăng ký thành công! Hãy đăng nhập lại.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void lnkDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDangKy_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            this.BeginInvoke(new Action(() =>
            {
                this.ActiveControl = null;
            }));
        }
    }
}
