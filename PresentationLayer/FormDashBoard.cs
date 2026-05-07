using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PresentationLayer
{
    public partial class FormDashBoard : Form
    {
        private string _tenDangNhap;
        private string _vaiTro;
        public FormDashBoard(string tenDangNhap, string vaiTro)
        {
            InitializeComponent();
            _tenDangNhap = tenDangNhap;
            _vaiTro = vaiTro;
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            MoUserControl(new UCTrangChinh());

        }

        private void MoUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
            uc.BringToFront();
        }
        

        private void btnMuave_Click(object sender, EventArgs e)
        {
            MoUserControl(new UCMuaVe());
        }
        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            MoUserControl(new UCKhachHang());
        }
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBangDieuKhien_Click_1(object sender, EventArgs e)
        {
            MoUserControl(new UCBangDieuKhien());
        }
    }
}
