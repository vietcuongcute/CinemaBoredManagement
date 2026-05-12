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
    public partial class UCBangDieuKhien : UserControl
    {
        
        MovieBL movieBL = new MovieBL();
        NhanVienBL nhanVienBL = new NhanVienBL();
        DoanhThuBL doanhThuBL = new DoanhThuBL();
        public UCBangDieuKhien()
        {
            InitializeComponent();
        }

        private void UCBangDieuKhien_Load(object sender, EventArgs e)
        {
            LoadSoPhim();
            LoadDanhSachPhim();
            LoadTongDoanhThu();
            LoadSoNhanVien();
        }
        private void LoadSoPhim()
        {
            lblSoPhim.Text = movieBL.DemSoPhim().ToString();
        }
        private void LoadSoNhanVien()
        {
            lblSoNhanVien.Text = nhanVienBL.DemSoNhanVien().ToString();
        }

        private void LoadTongDoanhThu()
        {
            decimal tongDoanhThu = doanhThuBL.TinhTongDoanhThu();
            lblTongTien.Text = tongDoanhThu.ToString("N0") + " VND";
        }

        private void LoadDanhSachPhim()
        {
            dgvPhim.DataSource = movieBL.LayDanhSachPhim();

            dgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhim.ReadOnly = true;
            dgvPhim.AllowUserToAddRows = false;
            dgvPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhim.MultiSelect = false;

            if (dgvPhim.Columns.Contains("MovieID"))
                dgvPhim.Columns["MovieID"].HeaderText = "Mã phim";

            if (dgvPhim.Columns.Contains("Title"))
                dgvPhim.Columns["Title"].HeaderText = "Tên phim";

            if (dgvPhim.Columns.Contains("Genre"))
                dgvPhim.Columns["Genre"].HeaderText = "Thể loại";

            if (dgvPhim.Columns.Contains("Duration"))
                dgvPhim.Columns["Duration"].HeaderText = "Thời lượng";

            if (dgvPhim.Columns.Contains("Status"))
                dgvPhim.Columns["Status"].HeaderText = "Trạng thái";

            if (dgvPhim.Columns.Contains("Capacity"))
                dgvPhim.Columns["Capacity"].HeaderText = "Sức chứa";

            if (dgvPhim.Columns.Contains("Price"))
                dgvPhim.Columns["Price"].HeaderText = "Giá";

            if (dgvPhim.Columns.Contains("Picture"))
                dgvPhim.Columns["Picture"].HeaderText = "Picture";
        }
        
    }
}
