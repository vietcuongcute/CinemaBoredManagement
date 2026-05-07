using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            this.Shown += FormDangNhap_Shown;

        }
        LoginBL loginBL = new LoginBL();
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Silver;

            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Silver;
            txtPassword.PasswordChar = '\0';
        }

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

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
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

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password")
            {
                if (chkHienMatKhau.Checked)
                    txtPassword.PasswordChar = '\0';
                else
                    txtPassword.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();

            if (tenDangNhap == "Username") tenDangNhap = "";
            if (matKhau == "Password") matKhau = "";

            if (tenDangNhap == "" || matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            bool ketQua = loginBL.DangNhap(tenDangNhap, matKhau);

            if (ketQua)
            {
                string vaiTro = loginBL.LayVaiTro(tenDangNhap);

                //MessageBox.Show("Đăng nhập thành công!",
                //                "Thông báo",
                //                MessageBoxButtons.OK,
                //                MessageBoxIcon.Information);
                if (vaiTro == "Admin")
                {
                    FormDashBoardAdmin admin = new FormDashBoardAdmin(tenDangNhap, vaiTro);
                    admin.ShowDialog();
                }
                else
                {
                    FormDashBoard dash = new FormDashBoard(tenDangNhap, vaiTro);
                    dash.ShowDialog();
                }

                this.Hide();
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void lnkDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy f = new FormDangKy();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDangNhap_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            this.BeginInvoke(new Action(() =>
            {
                this.ActiveControl = null;
            }));
        }
    }
}
