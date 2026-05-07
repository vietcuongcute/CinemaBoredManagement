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
    public partial class FormThanhToanChuyenKhoan : Form
    {

        private decimal _tongTien;
        public int CustomerID { get; private set; }

        public FormThanhToanChuyenKhoan(decimal tongTien)
        {
            InitializeComponent();
            _tongTien = tongTien;
        }

        private void FormThanhToanChuyenKhoan_Load(object sender, EventArgs e)
        {
            btnThanhToan.Focus();
            txtTongtien.Text = _tongTien.ToString("N0");
            lblTrangThai.Visible = false;
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            FormKhachHang f = new FormKhachHang();

            if (f.ShowDialog() == DialogResult.OK)
            {
                CustomerID = f.CustomerID;
                lblTrangThai.Text = "Thanh toán thành công";
                lblTrangThai.Visible = true;
                btnThanhToan.Enabled = false;
            }
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            if (lblTrangThai.Visible)
                this.DialogResult = DialogResult.OK;
            else
                this.Close();
        }
    }
}
