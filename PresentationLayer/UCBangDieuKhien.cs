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
        public UCBangDieuKhien()
        {
            InitializeComponent();
        }

        private void UCBangDieuKhien_Load(object sender, EventArgs e)
        {
            LoadSoPhim();
            LoadDanhSachPhim();
        }
        private void LoadSoPhim()
        {
            lblSoPhim.Text = movieBL.DemSoPhim().ToString();
        }
        private void LoadDanhSachPhim()
        {
            dgvPhim.DataSource = movieBL.LayDanhSachPhim();
            dgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhim.ReadOnly = true;

            dgvPhim.Columns["MovieID"].HeaderText = "Mã phim";
            dgvPhim.Columns["Title"].HeaderText = "Tên phim";
            dgvPhim.Columns["Genre"].HeaderText = "Thể loại";
            dgvPhim.Columns["Duration"].HeaderText = "Thời lượng";
            dgvPhim.Columns["Status"].HeaderText = "Trạng thái";
            dgvPhim.Columns["Capacity"].HeaderText = "Sức chứa";
            dgvPhim.Columns["Price"].HeaderText = "Giá";
            
        }
    }
}
