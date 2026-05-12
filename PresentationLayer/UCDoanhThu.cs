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
    public partial class UCDoanhThu : UserControl
    {
        DoanhThuBL doanhThuBL = new DoanhThuBL();
        public UCDoanhThu()
        {
            InitializeComponent();
        }

        private void UCDoanhThu_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.Date;
            dtpDenNgay.Value = DateTime.Now.Date;

            LoadDoanhThu();
        }
        private void LoadDoanhThu()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày!");
                return;
            }

            DataTable dt = doanhThuBL.LayDoanhThuTheoNgay(tuNgay, denNgay);
            dgvDoanhThu.DataSource = dt;

            dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThu.AllowUserToAddRows = false;
            dgvDoanhThu.ReadOnly = true;
            dgvDoanhThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoanhThu.MultiSelect = false;

            if (dgvDoanhThu.Columns.Contains("BillID"))
                dgvDoanhThu.Columns["BillID"].HeaderText = "Mã hóa đơn";

            if (dgvDoanhThu.Columns.Contains("FullName"))
                dgvDoanhThu.Columns["FullName"].HeaderText = "Khách hàng";

            if (dgvDoanhThu.Columns.Contains("Title"))
                dgvDoanhThu.Columns["Title"].HeaderText = "Tên phim";

            if (dgvDoanhThu.Columns.Contains("GheDaChon"))
                dgvDoanhThu.Columns["GheDaChon"].HeaderText = "Ghế";

            if (dgvDoanhThu.Columns.Contains("TienGhe"))
                dgvDoanhThu.Columns["TienGhe"].HeaderText = "Tiền ghế";

            if (dgvDoanhThu.Columns.Contains("TienDoAn"))
                dgvDoanhThu.Columns["TienDoAn"].HeaderText = "Tiền đồ ăn";

            if (dgvDoanhThu.Columns.Contains("TongTien"))
                dgvDoanhThu.Columns["TongTien"].HeaderText = "Tổng tiền";

            if (dgvDoanhThu.Columns.Contains("PhuongThucThanhToan"))
                dgvDoanhThu.Columns["PhuongThucThanhToan"].HeaderText = "Thanh toán";

            if (dgvDoanhThu.Columns.Contains("NgayMua"))
                dgvDoanhThu.Columns["NgayMua"].HeaderText = "Ngày mua";

            LoadThongKe(tuNgay, denNgay);
        }

        private void LoadThongKe(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = doanhThuBL.LayThongKeDoanhThu(tuNgay, denNgay);

            if (dt.Rows.Count == 0)
            {
                lblTongHoaDon.Text = "0";
                lblTongVe.Text = "0";
                lblTienVe.Text = "0 VND";
                lblDoan.Text = "0 VND";
                lblTongDoanhthu.Text = "0 VND";
                return;
            }

            DataRow row = dt.Rows[0];

            lblTongHoaDon.Text = row["TongHoaDon"].ToString();
            lblTongVe.Text = row["TongVe"].ToString();

            decimal tongTienVe = Convert.ToDecimal(row["TongTienVe"]);
            decimal tongTienDoAn = Convert.ToDecimal(row["TongTienDoAn"]);
            decimal tongDoanhThu = Convert.ToDecimal(row["TongDoanhThu"]);

            lblTienVe.Text = tongTienVe.ToString("N0") + " VND";
            lblDoan.Text = tongTienDoAn.ToString("N0") + " VND";
            lblTongDoanhthu.Text = tongDoanhThu.ToString("N0") + " VND";
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.Date;
            dtpDenNgay.Value = DateTime.Now.Date;
            LoadDoanhThu();
        }

        private void btnXuatReport_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày!");
                return;
            }

            FormReportDoanhThu f = new FormReportDoanhThu(tuNgay, denNgay);
            f.ShowDialog();
        }
    }
}
