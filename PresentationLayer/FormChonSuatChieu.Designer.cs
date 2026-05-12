namespace PresentationLayer
{
    partial class FormChonSuatChieu
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
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.btnChonSuat = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSuatChieu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhim.ForeColor = System.Drawing.Color.Purple;
            this.lblTenPhim.Location = new System.Drawing.Point(16, 57);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(208, 32);
            this.lblTenPhim.TabIndex = 5;
            this.lblTenPhim.Text = "Màn hình chiếu";
            // 
            // btnChonSuat
            // 
            this.btnChonSuat.BackColor = System.Drawing.Color.White;
            this.btnChonSuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonSuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonSuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonSuat.ForeColor = System.Drawing.Color.Purple;
            this.btnChonSuat.Location = new System.Drawing.Point(37, 455);
            this.btnChonSuat.Name = "btnChonSuat";
            this.btnChonSuat.Size = new System.Drawing.Size(178, 33);
            this.btnChonSuat.TabIndex = 25;
            this.btnChonSuat.Text = "Chọn suất chiếu";
            this.btnChonSuat.UseVisualStyleBackColor = false;
            this.btnChonSuat.Click += new System.EventHandler(this.btnChonSuat_Click_1);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.White;
            this.btnQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.Purple;
            this.btnQuayLai.Location = new System.Drawing.Point(269, 455);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(121, 33);
            this.btnQuayLai.TabIndex = 26;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(369, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(30, 23);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(16, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Chọn suất chiếu";
            // 
            // cboSuatChieu
            // 
            this.cboSuatChieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuatChieu.FormattingEnabled = true;
            this.cboSuatChieu.Location = new System.Drawing.Point(22, 244);
            this.cboSuatChieu.Name = "cboSuatChieu";
            this.cboSuatChieu.Size = new System.Drawing.Size(182, 30);
            this.cboSuatChieu.TabIndex = 54;
            this.cboSuatChieu.SelectedIndexChanged += new System.EventHandler(this.cboSuatChieu_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 32);
            this.label2.TabIndex = 55;
            this.label2.Text = "Màn hình chiếu";
            // 
            // FormChonSuatChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSuatChieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnChonSuat);
            this.Controls.Add(this.lblTenPhim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChonSuatChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChonSuatChieu";
            this.Load += new System.EventHandler(this.FormChonSuatChieu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Button btnChonSuat;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSuatChieu;
        private System.Windows.Forms.Label label2;
    }
}