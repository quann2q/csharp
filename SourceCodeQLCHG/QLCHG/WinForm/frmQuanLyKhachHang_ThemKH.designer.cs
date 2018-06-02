namespace QLCHG
{
    partial class frmQuanLyKhachHang_ThemKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKhachHang_ThemKH));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtNamSinh = new System.Windows.Forms.DateTimePicker();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.btDangKy = new System.Windows.Forms.Button();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ Tên (*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Năm Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Địa Chỉ";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(96, 48);
            this.txtMaKH.MaxLength = 30;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(182, 20);
            this.txtMaKH.TabIndex = 10;
            this.txtMaKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoan_KeyPress);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(96, 85);
            this.txtHoTen.MaxLength = 50;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(182, 20);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(96, 204);
            this.txtDiaChi.MaxLength = 50;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(182, 20);
            this.txtDiaChi.TabIndex = 6;
            this.txtDiaChi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            // 
            // dtNamSinh
            // 
            this.dtNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNamSinh.Location = new System.Drawing.Point(96, 121);
            this.dtNamSinh.Name = "dtNamSinh";
            this.dtNamSinh.Size = new System.Drawing.Size(182, 20);
            this.dtNamSinh.TabIndex = 2;
            this.dtNamSinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(96, 180);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 4;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(172, 180);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 5;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            this.rbNu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            // 
            // btDangKy
            // 
            this.btDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangKy.Location = new System.Drawing.Point(28, 251);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(122, 23);
            this.btDangKy.TabIndex = 7;
            this.btDangKy.Text = "Đồng Ý";
            this.btDangKy.UseVisualStyleBackColor = true;
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangNhap.Location = new System.Drawing.Point(161, 251);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(122, 23);
            this.btDangNhap.TabIndex = 8;
            this.btDangNhap.Text = "Hủy Bỏ";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao.Location = new System.Drawing.Point(35, 233);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(0, 13);
            this.lbThongBao.TabIndex = 10;
            this.lbThongBao.UseMnemonic = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // btThoat
            // 
            this.btThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThoat.BackgroundImage")));
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.Location = new System.Drawing.Point(291, 0);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(20, 18);
            this.btThoat.TabIndex = 9;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(96, 154);
            this.txtSoDienThoai.MaxLength = 15;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(182, 20);
            this.txtSoDienThoai.TabIndex = 3;
            this.txtSoDienThoai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Số điện thoại";
            // 
            // frmQuanLyKhachHang_ThemKH
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 286);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.btDangKy);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.dtNamSinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmQuanLyKhachHang_ThemKH";
            this.Text = "Thêm Thông Tin Khách Hàng";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDangKy_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDangKy_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDangKy_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtNamSinh;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Button btDangKy;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label9;
    }
}