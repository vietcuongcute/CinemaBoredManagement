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
            this.dgvSuatChieu = new System.Windows.Forms.DataGridView();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.btnChonSuat = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSuatChieu
            // 
            this.dgvSuatChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuatChieu.Location = new System.Drawing.Point(55, 135);
            this.dgvSuatChieu.Name = "dgvSuatChieu";
            this.dgvSuatChieu.Size = new System.Drawing.Size(828, 267);
            this.dgvSuatChieu.TabIndex = 0;
            this.dgvSuatChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuatChieu_CellClick_1);
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhim.ForeColor = System.Drawing.Color.Purple;
            this.lblTenPhim.Location = new System.Drawing.Point(49, 56);
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
            this.btnChonSuat.Location = new System.Drawing.Point(556, 455);
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
            this.btnQuayLai.Location = new System.Drawing.Point(762, 455);
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
            this.btnThoat.Location = new System.Drawing.Point(887, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(30, 23);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormChonSuatChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 538);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnChonSuat);
            this.Controls.Add(this.lblTenPhim);
            this.Controls.Add(this.dgvSuatChieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChonSuatChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChonSuatChieu";
            this.Load += new System.EventHandler(this.FormChonSuatChieu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSuatChieu;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Button btnChonSuat;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnThoat;
    }
}