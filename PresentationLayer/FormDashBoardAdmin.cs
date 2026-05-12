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
    public partial class FormDashBoardAdmin : Form
    {
        private string _tenDangNhap;
        private string _vaiTro;
        public FormDashBoardAdmin(string tenDangNhap, string vaiTro)
        {
            InitializeComponent();
            _tenDangNhap = tenDangNhap;
            _vaiTro = vaiTro;
        }
        private void MoUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
            uc.BringToFront();
        }

        private void FormDashBoardAdmin_Load(object sender, EventArgs e)
        {
            MoUserControl(new UCTrangChinh());
        }
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            MoUserControl(new UCNhanVien());
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            MoUserControl(new UCThemPhim());
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            MoUserControl(new UCDoanhThu());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            MoUserControl(new UCKhachHangAdmin());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBangDieuKhien_Click(object sender, EventArgs e)
        {
            MoUserControl(new UCBangDieuKhien());
        }

        private void btnSuatChieu_Click(object sender, EventArgs e)
        {
            MoUserControl(new UCQuanLySuatChieu());
        }
    }
}
