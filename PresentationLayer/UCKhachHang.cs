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
    public partial class UCKhachHang : UserControl
    {
        CustomerBL customerBL = new CustomerBL();
        public UCKhachHang()
        {
            InitializeComponent();
        }

        private void UCKhachHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
        }
        private void LoadDanhSachKhachHang()
        {
            dgvKhachHang.DataSource = customerBL.LayDanhSachKhachHang();

            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.ReadOnly = true;

            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.MultiSelect = false;

            dgvKhachHang.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dgvKhachHang.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            

            dgvKhachHang.Columns["CustomerID"].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns["FullName"].HeaderText = "Họ và tên";
            dgvKhachHang.Columns["Phone"].HeaderText = "Số điện thoại";
            dgvKhachHang.Columns["Email"].HeaderText = "Email";
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
    }
}
