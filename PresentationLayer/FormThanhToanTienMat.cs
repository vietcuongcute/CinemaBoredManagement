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
    public partial class FormThanhToanTienMat : Form
    {
        private decimal _tongTien;
        public int CustomerID { get; private set;  }

        public FormThanhToanTienMat(decimal tongTien)
        {
            InitializeComponent();
            _tongTien = tongTien;
        }

        private void FormThanhToanTienMat_Load(object sender, EventArgs e)
        {
            txtTienthua.Focus();
            txtTongtien.Text= _tongTien.ToString("N0");
            txtTienthua.Text = "";
            lblTrangThai.Visible = false;
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            decimal tienKhachDua;
            if (!decimal.TryParse(txtTienKhachdua.Text.Replace(",", ""), out tienKhachDua))
            {
                MessageBox.Show("Tiền khách đưa không hợp lệ!");
                return;
            }
            if(tienKhachDua < _tongTien)
            {
                MessageBox.Show("Tiền khách đưa không đủ!");
                return;
            }
            txtTienthua.Text = (tienKhachDua - _tongTien).ToString("N0");
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
