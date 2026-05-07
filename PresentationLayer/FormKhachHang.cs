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
    public partial class FormKhachHang : Form
    {
        private CustomerBL customerBL = new CustomerBL();

        public int CustomerID { get; private set; }
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoten.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (hoTen == "" || sdt == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và số điện thoại!");
                return;
            }

            int customerID = customerBL.ThemKhachHangVaLayID(hoTen, sdt, email);

            if (customerID > 0)
            {
                CustomerID = customerID;
                MessageBox.Show("Lưu thông tin khách hàng thành công!");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Lưu thông tin khách hàng thất bại!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
           
            

            txtHoten.Text = "Tên khách hàng";
            txtHoten.ForeColor = Color.Silver;

            txtSoDienThoai.Text = "Số điện thoại";
            txtSoDienThoai.ForeColor = Color.Silver;

            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Silver;
        }

        

        private void txtHoten_Enter(object sender, EventArgs e)
        {
            if (txtHoten.Text == "Tên khách hàng")
            {
                txtHoten.Text = "";
                txtHoten.ForeColor = Color.Black;
            }
        }

        private void txtHoten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoten.Text))
            {
                txtHoten.Text = "Tên khách hàng";
                txtHoten.ForeColor = Color.Silver;
            }
        }

        private void txtSoDienThoai_Enter(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text == "Số điện thoại")
            {
                txtSoDienThoai.Text = "";
                txtSoDienThoai.ForeColor = Color.Black;
            }
        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                txtSoDienThoai.Text = "Số điện thoại";
                txtSoDienThoai.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
            }
        }
    }
}
