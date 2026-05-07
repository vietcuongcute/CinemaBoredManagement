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
using System.Drawing.Drawing2D;

namespace PresentationLayer
{
    public partial class FormDatVe : Form
    {
        private int _movieID;
        private string _tenPhim;
        private string _theLoai;
        private int _thoiLuong;
        private decimal _giaVe;
        private string _duongDanAnh;
        private FoodBL foodBL = new FoodBL();
        private int _customerID = 0;
        private string _phuongThucThanhToan = "";

        private TicketBL ticketBL = new TicketBL();
        private BillBL billBL = new BillBL();
        public FormDatVe(int movieID, string tenPhim, string theLoai, int thoiLuong, decimal giaVe, string duongDanAnh)
        {

            InitializeComponent();
            _movieID = movieID;
            _tenPhim = tenPhim;
            _theLoai = theLoai;
            _thoiLuong = thoiLuong;
            _giaVe = giaVe;
            _duongDanAnh = duongDanAnh;
        }


        private List<int> dsGheDaChon = new List<int>();
        private Dictionary<int, Button> danhsachNutGhe = new Dictionary<int, Button>();
        private void FormDatVe_Load(object sender, EventArgs e)
        {
            lblManHinh.Text = "Màn hình chiếu - " + _tenPhim;
            TaoGhe();
            DanhDauGheDaBan();
            LoadDoAn();

            txtTinhBapNuoc.Text = "";
            txtTongtien.Text = "";
            txtTinhGhe.Text = "";
            lblThanhtoanthanhcong.Visible = false;
            btnInve.Visible = false;
        }
        private void TaoGhe()
        {
            pnlSeats.Controls.Clear();
            dsGheDaChon.Clear();
            danhsachNutGhe.Clear();

            int seatNumber = 1;
            int x = 10;
            int y = 20;
            int width = 77;
            int height = 40;
            int gapX = 13;
            int gapY = 13;

            for (int row = 0; row < 7; row++)
            {
                x = 10;
                for (int col = 0; col < 7; col++)
                {
                    Button btnSeat = new Button();
                    btnSeat.Width = width;
                    btnSeat.Height = height;
                    btnSeat.Left = x;
                    btnSeat.Top = y;
                    btnSeat.Text = seatNumber.ToString();
                    btnSeat.Tag = seatNumber;
                    btnSeat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    btnSeat.FlatStyle = FlatStyle.Flat;
                    btnSeat.FlatAppearance.BorderSize = 1;
                    btnSeat.FlatAppearance.BorderColor = Color.White;
                    btnSeat.BackColor = Color.White;
                    btnSeat.ForeColor = Color.DimGray;
                    btnSeat.Cursor = Cursors.Hand;
                    btnSeat.Click += btnSeat_Click;

                    BoTronButton(btnSeat,6);
                    pnlSeats.Controls.Add(btnSeat);
                    danhsachNutGhe.Add(seatNumber, btnSeat);

                    x += width + gapX;
                    seatNumber++;
                }
                y += height + gapY;
            }
        }

        private void BoTronButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.StartFigure();
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(btn.Width - d, 0, d, d, 270, 90);
            path.AddArc(btn.Width - d, btn.Height - d, d, d, 0, 90);
            path.AddArc(0, btn.Height - d, d, d, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }
        private void btnSeat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            int seat = Convert.ToInt32(btn.Tag);

            if (dsGheDaChon.Contains(seat))
            {
                dsGheDaChon.Remove(seat);
                SetSeatUnselectedStyle(btn);
                
            }
            else
            {
                dsGheDaChon.Add(seat);
                SetSeatSelectedStyle(btn);
                
            }

            CapNhatGheDaChon();
            CapNhatTien();

        }
        private void SetSeatUnselectedStyle(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.DimGray;
            btn.FlatAppearance.BorderColor = Color.White;
            
        }
        private void SetSeatSelectedStyle(Button btn)
        {
            btn.BackColor = Color.Violet;
            btn.ForeColor = Color.White;
            
        }

        private void CapNhatGheDaChon()
        {
            txtGheDaChon.Text = string.Join(", ", dsGheDaChon.OrderBy(x => x));
        }
        
        private void SetSeatBookedStyle(Button btn)
        {
            btn.BackColor = Color.LightGray;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderColor = Color.LightGray;
            btn.Enabled = false;
        }
        private void DanhDauGheDaBan()
        {
            List<int> gheDaBan = ticketBL.LayDanhSachGheDaDat(_movieID);

            foreach (int seat in gheDaBan)
            {
                if (danhsachNutGhe.ContainsKey(seat))
                {
                    SetSeatBookedStyle(danhsachNutGhe[seat]);
                }
            }
        }

        private void btnSeat_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int seat = Convert.ToInt32(btn.Tag);

            if (!dsGheDaChon.Contains(seat) && btn.Enabled)
            {
                btn.BackColor = Color.FromArgb(245, 245, 245);
            }
        }

        private void btnSeat_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int seat = Convert.ToInt32(btn.Tag);

            if (!dsGheDaChon.Contains(seat) && btn.Enabled)
            {
                btn.BackColor = Color.White;
            }
        }
        private void LoadDoAn()
        {
            cboBap.DataSource = foodBL.LayDoAnTheoLoai("Bap");
            cboBap.DisplayMember = "FoodName";
            cboBap.ValueMember = "FoodID";
            cboBap.SelectedIndex = -1;

            cboNuoc.DataSource = foodBL.LayDoAnTheoLoai("Nuoc");
            cboNuoc.DisplayMember = "FoodName";
            cboNuoc.ValueMember = "FoodID";
            cboNuoc.SelectedIndex = -1;

            nudSoLuongBap.Value = 0;
            nudSoLuongNuoc.Value = 0;
        }

        private decimal LayGiaDoAn(ComboBox cbo)
        {
            if (cbo.SelectedItem == null) return 0;

            DataRowView row = cbo.SelectedItem as DataRowView;
            if(row == null) return 0;

            return Convert.ToDecimal(row["Price"]);
        }

        private decimal TienGhe()
        {
            return dsGheDaChon.Count * _giaVe;
        }
        private decimal TienBapNuoc()
        {
            decimal tienBap = LayGiaDoAn(cboBap) * nudSoLuongBap.Value;
            decimal tienNuoc = LayGiaDoAn(cboNuoc) * nudSoLuongNuoc.Value;

            return tienBap + tienNuoc;
        }
        private void CapNhatTien()
        {
            decimal tienGhe = TienGhe();
            decimal tienBapNuoc = TienBapNuoc();
            decimal tongTien = tienGhe + tienBapNuoc;

            txtTinhGhe.Text = tienGhe.ToString("N0") + " VND";
            txtTinhBapNuoc.Text = tienBapNuoc.ToString("N0") + " VND";
            txtTongtien.Text = tongTien.ToString("N0") + " VND";

        }
        private void LuuHoaDonVaVe(int customerID, string phuongThucThanhToan)
        {
            decimal tienGhe = TienGhe();
            decimal tienDoAn = TienBapNuoc();
            decimal tongTien = tienGhe + tienDoAn;

            string gheDaChon = string.Join(", ", dsGheDaChon.OrderBy(x => x));

            int billID = billBL.ThemHoaDonVaLayBillID(customerID, _movieID, gheDaChon, tienGhe, tienDoAn, tongTien, phuongThucThanhToan);

            foreach (int seat in dsGheDaChon)
            {
                ticketBL.ThemVe(billID, seat, _movieID);
            }
        }
        private bool KiemTraGheTrung()
        {
            foreach (int seat in dsGheDaChon)
            {
                if (ticketBL.KiemTraGheDaDat(_movieID, seat))
                {
                    MessageBox.Show("Ghế " + seat + " đã được đặt!");
                    DanhDauGheDaBan();
                    return false;
                }
            }
            return true;
        }

        private void cboBap_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTien();
        }

        private void nudSoLuongBap_ValueChanged(object sender, EventArgs e)
        {
            if (cboBap.SelectedIndex == -1 && nudSoLuongBap.Value > 0)
            {
                MessageBox.Show("Vui lòng chọn loại bắp trước!");
                nudSoLuongBap.Value = 0;
                return;
            }
            CapNhatTien();
        }

        private void cboNuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTien();
        }

        private void nudSoLuongNuoc_ValueChanged(object sender, EventArgs e)
        {
            if (cboNuoc.SelectedIndex == -1 && nudSoLuongNuoc.Value > 0)
            {
                MessageBox.Show("Vui lòng chọn loại nước trước!");
                nudSoLuongNuoc.Value = 0;
                return;
            }
            CapNhatTien();
        }

        private void btnTTtienmat_Click(object sender, EventArgs e)
        {
            if (dsGheDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!");
                return;
            }

            if (!KiemTraGheTrung()) return;

            decimal tongTien;
            string sTongTien = txtTongtien.Text
                .Replace("VND", "")
                .Replace(".", "")
                .Replace(",", "")
                .Trim();

            if (!decimal.TryParse(sTongTien, out tongTien))
            {
                MessageBox.Show("Tổng tiền không hợp lệ!");
                return;
            }

            FormThanhToanTienMat f = new FormThanhToanTienMat(tongTien);

            if (f.ShowDialog() == DialogResult.OK)
            {
                _customerID = f.CustomerID;
                _phuongThucThanhToan = "Tiền mặt";

                LuuHoaDonVaVe(_customerID, _phuongThucThanhToan);

                lblThanhtoanthanhcong.Text = "Thanh toán thành công!";
                lblThanhtoanthanhcong.Visible = true;
                btnInve.Visible = true;

                DanhDauGheDaBan();
                
            }
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (int seat in dsGheDaChon.ToList())
            {
                if (danhsachNutGhe.ContainsKey(seat) && danhsachNutGhe[seat].Enabled)
                {
                    SetSeatUnselectedStyle(danhsachNutGhe[seat]);
                }
            }

            dsGheDaChon.Clear();
            txtTongtien.Text = "";
            txtGheDaChon.Text = "";
            cboBap.SelectedIndex = -1;
            cboNuoc.SelectedIndex = -1;
            nudSoLuongBap.Value = 0;
            nudSoLuongNuoc.Value = 0;

            txtTinhBapNuoc.Text = "0";
            txtTongtien.Text = "0";
            txtTinhGhe.Text = "0 VND";

            lblThanhtoanthanhcong.Visible = false;
            btnInve.Visible = false;

            DanhDauGheDaBan();
        }

        private void btnInve_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 100;

            e.Graphics.DrawString("CINEMA BORED", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Purple, 250, y);
            y += 50;

            e.Graphics.DrawString("Tên phim: " + _tenPhim, new Font("Times New Roman", 18 ,FontStyle.Bold), Brushes.Black, 100, y); y += 30;
            e.Graphics.DrawString("Ghế đã mua: " + txtGheDaChon.Text, new Font("Times New Roman", 18), Brushes.Black, 100, y); y += 30;
            e.Graphics.DrawString("Tạm tính ghế: " + txtTinhGhe.Text, new Font("Times New Roman", 23), Brushes.Black, 100, y); y += 30;
            e.Graphics.DrawString("Bắp: " + cboBap.Text + " x" + nudSoLuongBap.Value, new Font("Times New Roman", 18), Brushes.Black, 100, y);
            y += 30;

            e.Graphics.DrawString("Nước: " + cboNuoc.Text + " x" + nudSoLuongNuoc.Value, new Font("Times New Roman", 18), Brushes.Black, 100, y);
            y += 30;
            e.Graphics.DrawString("Tạm tính bắp nước: " + txtTinhBapNuoc.Text ,  new Font("Times New Roman", 18), Brushes.Black, 100, y); y += 30;
            e.Graphics.DrawString("Tổng tiền: " + txtTongtien.Text, new Font("Times New Roman", 18), Brushes.Black, 100, y); y += 30;
            e.Graphics.DrawString("Phương thức thanh toán: " + _phuongThucThanhToan, new Font("Times New Roman", 18), Brushes.Black, 100, y); y += 30;
            e.Graphics.DrawLine(Pens.Black, 100, y, 500, y);
            y += 20;
            e.Graphics.DrawString("Ngày mua: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), new Font("Times New Roman", 18), Brushes.Black, 100, y);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTTChuyenKhoan_Click(object sender, EventArgs e)
        {
            if (dsGheDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!");
                return;
            }

            if (!KiemTraGheTrung()) return;

            decimal tongTien;
            string sTongTien = txtTongtien.Text
                .Replace("VND", "")
                .Replace(".", "")
                .Replace(",", "")
                .Trim();

            if (!decimal.TryParse(sTongTien, out tongTien))
            {
                MessageBox.Show("Tổng tiền không hợp lệ!");
                return;
            }

            FormThanhToanChuyenKhoan f = new FormThanhToanChuyenKhoan(tongTien);

            if (f.ShowDialog() == DialogResult.OK)
            {
                _customerID = f.CustomerID;
                _phuongThucThanhToan = "Chuyển khoản";

                LuuHoaDonVaVe(_customerID, _phuongThucThanhToan);

                lblThanhtoanthanhcong.Text = "Thanh toán thành công!";
                lblThanhtoanthanhcong.Visible = true;
                btnInve.Visible = true;

                DanhDauGheDaBan();
                
            }
        }
    }
}
