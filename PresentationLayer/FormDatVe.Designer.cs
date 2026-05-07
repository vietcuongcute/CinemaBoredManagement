namespace PresentationLayer
{
    partial class FormDatVe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatVe));
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblManHinh = new System.Windows.Forms.Label();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTinhBapNuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudSoLuongNuoc = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongBap = new System.Windows.Forms.NumericUpDown();
            this.cboNuoc = new System.Windows.Forms.ComboBox();
            this.cboBap = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGheDaChon = new System.Windows.Forms.TextBox();
            this.txtTinhGhe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSeats = new System.Windows.Forms.Panel();
            this.btnSeat = new System.Windows.Forms.Button();
            this.btnTTtienmat = new System.Windows.Forms.Button();
            this.btnTTChuyenKhoan = new System.Windows.Forms.Button();
            this.btnInve = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblThanhtoanthanhcong = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBap)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(259, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(30, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblManHinh
            // 
            this.lblManHinh.AutoSize = true;
            this.lblManHinh.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManHinh.ForeColor = System.Drawing.Color.Purple;
            this.lblManHinh.Location = new System.Drawing.Point(138, 0);
            this.lblManHinh.Name = "lblManHinh";
            this.lblManHinh.Size = new System.Drawing.Size(208, 32);
            this.lblManHinh.TabIndex = 4;
            this.lblManHinh.Text = "Màn hình chiếu";
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.lblThanhtoanthanhcong);
            this.pnlOrder.Controls.Add(this.btnXoa);
            this.pnlOrder.Controls.Add(this.btnInve);
            this.pnlOrder.Controls.Add(this.btnTTChuyenKhoan);
            this.pnlOrder.Controls.Add(this.btnTTtienmat);
            this.pnlOrder.Controls.Add(this.txtTongtien);
            this.pnlOrder.Controls.Add(this.label9);
            this.pnlOrder.Controls.Add(this.txtTinhBapNuoc);
            this.pnlOrder.Controls.Add(this.label8);
            this.pnlOrder.Controls.Add(this.nudSoLuongNuoc);
            this.pnlOrder.Controls.Add(this.nudSoLuongBap);
            this.pnlOrder.Controls.Add(this.cboNuoc);
            this.pnlOrder.Controls.Add(this.cboBap);
            this.pnlOrder.Controls.Add(this.label7);
            this.pnlOrder.Controls.Add(this.label6);
            this.pnlOrder.Controls.Add(this.label5);
            this.pnlOrder.Controls.Add(this.label4);
            this.pnlOrder.Controls.Add(this.panel2);
            this.pnlOrder.Controls.Add(this.btnThoat);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOrder.Location = new System.Drawing.Point(649, 0);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(292, 538);
            this.pnlOrder.TabIndex = 5;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtien.Location = new System.Drawing.Point(112, 284);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(137, 27);
            this.txtTongtien.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tổng tiền : ";
            // 
            // txtTinhBapNuoc
            // 
            this.txtTinhBapNuoc.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhBapNuoc.Location = new System.Drawing.Point(110, 234);
            this.txtTinhBapNuoc.Name = "txtTinhBapNuoc";
            this.txtTinhBapNuoc.ReadOnly = true;
            this.txtTinhBapNuoc.Size = new System.Drawing.Size(137, 27);
            this.txtTinhBapNuoc.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tạm tính : ";
            // 
            // nudSoLuongNuoc
            // 
            this.nudSoLuongNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuongNuoc.Location = new System.Drawing.Point(112, 190);
            this.nudSoLuongNuoc.Name = "nudSoLuongNuoc";
            this.nudSoLuongNuoc.Size = new System.Drawing.Size(51, 24);
            this.nudSoLuongNuoc.TabIndex = 17;
            this.nudSoLuongNuoc.ValueChanged += new System.EventHandler(this.nudSoLuongNuoc_ValueChanged);
            // 
            // nudSoLuongBap
            // 
            this.nudSoLuongBap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuongBap.Location = new System.Drawing.Point(112, 122);
            this.nudSoLuongBap.Name = "nudSoLuongBap";
            this.nudSoLuongBap.Size = new System.Drawing.Size(51, 24);
            this.nudSoLuongBap.TabIndex = 16;
            this.nudSoLuongBap.ValueChanged += new System.EventHandler(this.nudSoLuongBap_ValueChanged);
            // 
            // cboNuoc
            // 
            this.cboNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNuoc.FormattingEnabled = true;
            this.cboNuoc.Location = new System.Drawing.Point(111, 158);
            this.cboNuoc.Name = "cboNuoc";
            this.cboNuoc.Size = new System.Drawing.Size(154, 26);
            this.cboNuoc.TabIndex = 15;
            this.cboNuoc.SelectedIndexChanged += new System.EventHandler(this.cboNuoc_SelectedIndexChanged);
            // 
            // cboBap
            // 
            this.cboBap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBap.FormattingEnabled = true;
            this.cboBap.Location = new System.Drawing.Point(110, 84);
            this.cboBap.Name = "cboBap";
            this.cboBap.Size = new System.Drawing.Size(155, 26);
            this.cboBap.TabIndex = 14;
            this.cboBap.SelectedIndexChanged += new System.EventHandler(this.cboBap_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số lượng : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nước";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bắp : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 38);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "BẮP VÀ NƯỚC";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGheDaChon);
            this.panel1.Controls.Add(this.txtTinhGhe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlSeats);
            this.panel1.Controls.Add(this.lblManHinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 538);
            this.panel1.TabIndex = 6;
            // 
            // txtGheDaChon
            // 
            this.txtGheDaChon.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGheDaChon.Location = new System.Drawing.Point(169, 461);
            this.txtGheDaChon.Name = "txtGheDaChon";
            this.txtGheDaChon.ReadOnly = true;
            this.txtGheDaChon.Size = new System.Drawing.Size(263, 27);
            this.txtGheDaChon.TabIndex = 11;
            // 
            // txtTinhGhe
            // 
            this.txtTinhGhe.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhGhe.Location = new System.Drawing.Point(169, 503);
            this.txtTinhGhe.Name = "txtTinhGhe";
            this.txtTinhGhe.ReadOnly = true;
            this.txtTinhGhe.Size = new System.Drawing.Size(263, 27);
            this.txtTinhGhe.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tạm tính : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ghế đã chọn : ";
            // 
            // pnlSeats
            // 
            this.pnlSeats.Controls.Add(this.btnSeat);
            this.pnlSeats.Location = new System.Drawing.Point(0, 54);
            this.pnlSeats.Name = "pnlSeats";
            this.pnlSeats.Size = new System.Drawing.Size(652, 393);
            this.pnlSeats.TabIndex = 5;
            // 
            // btnSeat
            // 
            this.btnSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeat.Location = new System.Drawing.Point(12, 13);
            this.btnSeat.Name = "btnSeat";
            this.btnSeat.Size = new System.Drawing.Size(75, 23);
            this.btnSeat.TabIndex = 0;
            this.btnSeat.Text = "button1";
            this.btnSeat.UseVisualStyleBackColor = true;
            this.btnSeat.Click += new System.EventHandler(this.btnSeat_Click);
            this.btnSeat.MouseEnter += new System.EventHandler(this.btnSeat_MouseEnter);
            this.btnSeat.MouseLeave += new System.EventHandler(this.btnSeat_MouseLeave);
            // 
            // btnTTtienmat
            // 
            this.btnTTtienmat.BackColor = System.Drawing.Color.White;
            this.btnTTtienmat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTtienmat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTtienmat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTtienmat.ForeColor = System.Drawing.Color.Purple;
            this.btnTTtienmat.Location = new System.Drawing.Point(28, 334);
            this.btnTTtienmat.Name = "btnTTtienmat";
            this.btnTTtienmat.Size = new System.Drawing.Size(252, 33);
            this.btnTTtienmat.TabIndex = 22;
            this.btnTTtienmat.Text = "Thanh toán tiền mặt";
            this.btnTTtienmat.UseVisualStyleBackColor = false;
            this.btnTTtienmat.Click += new System.EventHandler(this.btnTTtienmat_Click);
            // 
            // btnTTChuyenKhoan
            // 
            this.btnTTChuyenKhoan.BackColor = System.Drawing.Color.White;
            this.btnTTChuyenKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTChuyenKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTChuyenKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTChuyenKhoan.ForeColor = System.Drawing.Color.Purple;
            this.btnTTChuyenKhoan.Location = new System.Drawing.Point(28, 373);
            this.btnTTChuyenKhoan.Name = "btnTTChuyenKhoan";
            this.btnTTChuyenKhoan.Size = new System.Drawing.Size(252, 33);
            this.btnTTChuyenKhoan.TabIndex = 23;
            this.btnTTChuyenKhoan.Text = "Thanh toán chuyển khoản";
            this.btnTTChuyenKhoan.UseVisualStyleBackColor = false;
            this.btnTTChuyenKhoan.Click += new System.EventHandler(this.btnTTChuyenKhoan_Click);
            // 
            // btnInve
            // 
            this.btnInve.BackColor = System.Drawing.Color.White;
            this.btnInve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInve.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInve.ForeColor = System.Drawing.Color.Purple;
            this.btnInve.Location = new System.Drawing.Point(28, 481);
            this.btnInve.Name = "btnInve";
            this.btnInve.Size = new System.Drawing.Size(104, 33);
            this.btnInve.TabIndex = 24;
            this.btnInve.Text = "In vé";
            this.btnInve.UseVisualStyleBackColor = false;
            this.btnInve.Click += new System.EventHandler(this.btnInve_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Purple;
            this.btnXoa.Location = new System.Drawing.Point(176, 481);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 33);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblThanhtoanthanhcong
            // 
            this.lblThanhtoanthanhcong.AutoSize = true;
            this.lblThanhtoanthanhcong.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhtoanthanhcong.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblThanhtoanthanhcong.Location = new System.Drawing.Point(23, 432);
            this.lblThanhtoanthanhcong.Name = "lblThanhtoanthanhcong";
            this.lblThanhtoanthanhcong.Size = new System.Drawing.Size(255, 26);
            this.lblThanhtoanthanhcong.TabIndex = 26;
            this.lblThanhtoanthanhcong.Text = "Thanh toán thành công!";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDatVe";
            this.Load += new System.EventHandler(this.FormDatVe_Load);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSeats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblManHinh;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSeats;
        private System.Windows.Forms.Button btnSeat;
        private System.Windows.Forms.TextBox txtGheDaChon;
        private System.Windows.Forms.TextBox txtTinhGhe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSoLuongNuoc;
        private System.Windows.Forms.NumericUpDown nudSoLuongBap;
        private System.Windows.Forms.ComboBox cboNuoc;
        private System.Windows.Forms.ComboBox cboBap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTinhBapNuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblThanhtoanthanhcong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInve;
        private System.Windows.Forms.Button btnTTChuyenKhoan;
        private System.Windows.Forms.Button btnTTtienmat;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}