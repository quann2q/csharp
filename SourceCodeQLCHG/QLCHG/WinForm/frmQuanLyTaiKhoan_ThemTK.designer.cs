namespace QLCHG
{
    partial class frmQuanLyTaiKhoan_ThemTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiKhoan_ThemTK));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtNamSinh = new System.Windows.Forms.DateTimePicker();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.btDangKy = new System.Windows.Forms.Button();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.cbHienMatKhau = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbLoaiTK = new System.Windows.Forms.ComboBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbQLTK = new System.Windows.Forms.CheckBox();
            this.cbQLKH = new System.Windows.Forms.CheckBox();
            this.cbQLTTG = new System.Windows.Forms.CheckBox();
            this.cbQLBG = new System.Windows.Forms.CheckBox();
            this.cbBCTK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ Tên (*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Năm Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Địa Chỉ";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(96, 48);
            this.txtTaiKhoan.MaxLength = 30;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(182, 20);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
            this.txtTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoan_KeyPress);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(96, 83);
            this.txtMatKhau.MaxLength = 30;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(182, 20);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoan_KeyPress);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(96, 118);
            this.txtHoTen.MaxLength = 50;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(182, 20);
            this.txtHoTen.TabIndex = 4;
            this.txtHoTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(96, 237);
            this.txtDiaChi.MaxLength = 50;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(182, 20);
            this.txtDiaChi.TabIndex = 9;
            this.txtDiaChi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
            // 
            // dtNamSinh
            // 
            this.dtNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNamSinh.Location = new System.Drawing.Point(96, 154);
            this.dtNamSinh.Name = "dtNamSinh";
            this.dtNamSinh.Size = new System.Drawing.Size(182, 20);
            this.dtNamSinh.TabIndex = 5;
            this.dtNamSinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(96, 213);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 7;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(172, 213);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 8;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            this.rbNu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
            // 
            // btDangKy
            // 
            this.btDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangKy.Location = new System.Drawing.Point(28, 438);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(122, 23);
            this.btDangKy.TabIndex = 16;
            this.btDangKy.Text = "Đồng Ý";
            this.btDangKy.UseVisualStyleBackColor = true;
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangNhap.Location = new System.Drawing.Point(160, 438);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(122, 23);
            this.btDangNhap.TabIndex = 17;
            this.btDangNhap.Text = "Hủy Bỏ";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao.Location = new System.Drawing.Point(30, 420);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(0, 13);
            this.lbThongBao.TabIndex = 10;
            this.lbThongBao.UseMnemonic = false;
            // 
            // cbHienMatKhau
            // 
            this.cbHienMatKhau.AutoSize = true;
            this.cbHienMatKhau.Location = new System.Drawing.Point(282, 87);
            this.cbHienMatKhau.Name = "cbHienMatKhau";
            this.cbHienMatKhau.Size = new System.Drawing.Size(15, 14);
            this.cbHienMatKhau.TabIndex = 3;
            this.cbHienMatKhau.UseVisualStyleBackColor = true;
            this.cbHienMatKhau.CheckedChanged += new System.EventHandler(this.cbHienMatKhau_CheckedChanged);
            this.cbHienMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "ĐĂNG KÝ TÀI KHOẢN";
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
            this.btThoat.TabIndex = 18;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Loại TK";
            // 
            // cbbLoaiTK
            // 
            this.cbbLoaiTK.BackColor = System.Drawing.Color.White;
            this.cbbLoaiTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiTK.FormattingEnabled = true;
            this.cbbLoaiTK.Items.AddRange(new object[] {
            "Nhân Viên Bán Hàng",
            "Nhân Viên Kho",
            "Administrator"});
            this.cbbLoaiTK.Location = new System.Drawing.Point(96, 272);
            this.cbbLoaiTK.Name = "cbbLoaiTK";
            this.cbbLoaiTK.Size = new System.Drawing.Size(182, 21);
            this.cbbLoaiTK.TabIndex = 10;
            this.cbbLoaiTK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(96, 187);
            this.txtSoDienThoai.MaxLength = 15;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(182, 20);
            this.txtSoDienThoai.TabIndex = 6;
            this.txtSoDienThoai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Số điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Quyền Hạn";
            // 
            // cbQLTK
            // 
            this.cbQLTK.AutoSize = true;
            this.cbQLTK.Location = new System.Drawing.Point(96, 307);
            this.cbQLTK.Name = "cbQLTK";
            this.cbQLTK.Size = new System.Drawing.Size(118, 17);
            this.cbQLTK.TabIndex = 11;
            this.cbQLTK.Text = "Quản Lý Tài Khoản";
            this.cbQLTK.UseVisualStyleBackColor = true;
            // 
            // cbQLKH
            // 
            this.cbQLKH.AutoSize = true;
            this.cbQLKH.Location = new System.Drawing.Point(96, 330);
            this.cbQLKH.Name = "cbQLKH";
            this.cbQLKH.Size = new System.Drawing.Size(129, 17);
            this.cbQLKH.TabIndex = 12;
            this.cbQLKH.Text = "Quản Lý Khách Hàng";
            this.cbQLKH.UseVisualStyleBackColor = true;
            // 
            // cbQLTTG
            // 
            this.cbQLTTG.AutoSize = true;
            this.cbQLTTG.Location = new System.Drawing.Point(96, 353);
            this.cbQLTTG.Name = "cbQLTTG";
            this.cbQLTTG.Size = new System.Drawing.Size(141, 17);
            this.cbQLTTG.TabIndex = 13;
            this.cbQLTTG.Text = "Quản Lý Thông Tin Gạo";
            this.cbQLTTG.UseVisualStyleBackColor = true;
            // 
            // cbQLBG
            // 
            this.cbQLBG.AutoSize = true;
            this.cbQLBG.Location = new System.Drawing.Point(96, 376);
            this.cbQLBG.Name = "cbQLBG";
            this.cbQLBG.Size = new System.Drawing.Size(111, 17);
            this.cbQLBG.TabIndex = 14;
            this.cbQLBG.Text = "Quản Lý Bán Gạo";
            this.cbQLBG.UseVisualStyleBackColor = true;
            // 
            // cbBCTK
            // 
            this.cbBCTK.AutoSize = true;
            this.cbBCTK.Location = new System.Drawing.Point(96, 399);
            this.cbBCTK.Name = "cbBCTK";
            this.cbBCTK.Size = new System.Drawing.Size(117, 17);
            this.cbBCTK.TabIndex = 15;
            this.cbBCTK.Text = "Báo Cáo Thống Kê";
            this.cbBCTK.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyTaiKhoan_ThemTK
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 467);
            this.Controls.Add(this.cbBCTK);
            this.Controls.Add(this.cbQLBG);
            this.Controls.Add(this.cbQLTTG);
            this.Controls.Add(this.cbQLKH);
            this.Controls.Add(this.cbQLTK);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbLoaiTK);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbHienMatKhau);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.btDangKy);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.dtNamSinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmQuanLyTaiKhoan_ThemTK";
            this.Text = "Đăng Ký Tài Khoản";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDangKy_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDangKy_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDangKy_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtNamSinh;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Button btDangKy;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.CheckBox cbHienMatKhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbLoaiTK;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbQLTK;
        private System.Windows.Forms.CheckBox cbQLKH;
        private System.Windows.Forms.CheckBox cbQLTTG;
        private System.Windows.Forms.CheckBox cbQLBG;
        private System.Windows.Forms.CheckBox cbBCTK;
    }
}