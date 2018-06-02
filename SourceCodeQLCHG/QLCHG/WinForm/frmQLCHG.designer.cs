namespace QLCHG
{
    partial class frmQLCHG
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLCHG));
            this.label1 = new System.Windows.Forms.Label();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btQuanLyBanGao = new System.Windows.Forms.Button();
            this.btQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btQuanLyKhachHang = new System.Windows.Forms.Button();
            this.btQuanLyTTGao = new System.Windows.Forms.Button();
            this.btBaoCaoThongKe = new System.Windows.Forms.Button();
            this.lbDongHo = new System.Windows.Forms.Label();
            this.lbTenTaiKhoan = new System.Windows.Forms.Label();
            this.lbLoaiTK = new System.Windows.Forms.Label();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ CỬA HÀNG BÁN GẠO";
            // 
            // btMinimize
            // 
            this.btMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMinimize.BackgroundImage")));
            this.btMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btMinimize.Location = new System.Drawing.Point(638, 0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(35, 25);
            this.btMinimize.TabIndex = 8;
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExit.BackgroundImage")));
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btExit.Location = new System.Drawing.Point(669, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(35, 25);
            this.btExit.TabIndex = 9;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btQuanLyBanGao
            // 
            this.btQuanLyBanGao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btQuanLyBanGao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuanLyBanGao.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btQuanLyBanGao.ForeColor = System.Drawing.Color.Transparent;
            this.btQuanLyBanGao.Image = ((System.Drawing.Image)(resources.GetObject("btQuanLyBanGao.Image")));
            this.btQuanLyBanGao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btQuanLyBanGao.Location = new System.Drawing.Point(478, 61);
            this.btQuanLyBanGao.Name = "btQuanLyBanGao";
            this.btQuanLyBanGao.Size = new System.Drawing.Size(214, 149);
            this.btQuanLyBanGao.TabIndex = 5;
            this.btQuanLyBanGao.Text = "Quản Lý Bán Gạo";
            this.btQuanLyBanGao.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btQuanLyBanGao.UseVisualStyleBackColor = false;
            this.btQuanLyBanGao.Click += new System.EventHandler(this.btQuanLyBanGao_Click);
            // 
            // btQuanLyTaiKhoan
            // 
            this.btQuanLyTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btQuanLyTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuanLyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btQuanLyTaiKhoan.ForeColor = System.Drawing.Color.Transparent;
            this.btQuanLyTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btQuanLyTaiKhoan.Image")));
            this.btQuanLyTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btQuanLyTaiKhoan.Location = new System.Drawing.Point(12, 61);
            this.btQuanLyTaiKhoan.Name = "btQuanLyTaiKhoan";
            this.btQuanLyTaiKhoan.Size = new System.Drawing.Size(225, 149);
            this.btQuanLyTaiKhoan.TabIndex = 2;
            this.btQuanLyTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.btQuanLyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btQuanLyTaiKhoan.UseVisualStyleBackColor = false;
            this.btQuanLyTaiKhoan.Click += new System.EventHandler(this.btQuanLyTaiKhoan_Click);
            // 
            // btQuanLyKhachHang
            // 
            this.btQuanLyKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btQuanLyKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuanLyKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btQuanLyKhachHang.ForeColor = System.Drawing.Color.Transparent;
            this.btQuanLyKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btQuanLyKhachHang.Image")));
            this.btQuanLyKhachHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btQuanLyKhachHang.Location = new System.Drawing.Point(243, 61);
            this.btQuanLyKhachHang.Name = "btQuanLyKhachHang";
            this.btQuanLyKhachHang.Size = new System.Drawing.Size(229, 149);
            this.btQuanLyKhachHang.TabIndex = 3;
            this.btQuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            this.btQuanLyKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btQuanLyKhachHang.UseVisualStyleBackColor = false;
            this.btQuanLyKhachHang.Click += new System.EventHandler(this.btQuanLyKhachHang_Click);
            // 
            // btQuanLyTTGao
            // 
            this.btQuanLyTTGao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btQuanLyTTGao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuanLyTTGao.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btQuanLyTTGao.ForeColor = System.Drawing.Color.Transparent;
            this.btQuanLyTTGao.Image = ((System.Drawing.Image)(resources.GetObject("btQuanLyTTGao.Image")));
            this.btQuanLyTTGao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuanLyTTGao.Location = new System.Drawing.Point(12, 216);
            this.btQuanLyTTGao.Name = "btQuanLyTTGao";
            this.btQuanLyTTGao.Size = new System.Drawing.Size(311, 156);
            this.btQuanLyTTGao.TabIndex = 4;
            this.btQuanLyTTGao.Text = "     Quản Lý \r\nThông Tin Gạo";
            this.btQuanLyTTGao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuanLyTTGao.UseVisualStyleBackColor = false;
            this.btQuanLyTTGao.Click += new System.EventHandler(this.btQuanLyKho_Click);
            // 
            // btBaoCaoThongKe
            // 
            this.btBaoCaoThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btBaoCaoThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaoCaoThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btBaoCaoThongKe.ForeColor = System.Drawing.Color.Transparent;
            this.btBaoCaoThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btBaoCaoThongKe.Image")));
            this.btBaoCaoThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBaoCaoThongKe.Location = new System.Drawing.Point(329, 216);
            this.btBaoCaoThongKe.Name = "btBaoCaoThongKe";
            this.btBaoCaoThongKe.Size = new System.Drawing.Size(363, 156);
            this.btBaoCaoThongKe.TabIndex = 6;
            this.btBaoCaoThongKe.Text = "Báo Cáo Thống Kê";
            this.btBaoCaoThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBaoCaoThongKe.UseVisualStyleBackColor = false;
            this.btBaoCaoThongKe.Click += new System.EventHandler(this.btBaoCaoThongKe_Click);
            // 
            // lbDongHo
            // 
            this.lbDongHo.AutoSize = true;
            this.lbDongHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDongHo.ForeColor = System.Drawing.Color.White;
            this.lbDongHo.Location = new System.Drawing.Point(0, 375);
            this.lbDongHo.Name = "lbDongHo";
            this.lbDongHo.Size = new System.Drawing.Size(90, 25);
            this.lbDongHo.TabIndex = 5;
            this.lbDongHo.Text = "00:00:00";
            // 
            // lbTenTaiKhoan
            // 
            this.lbTenTaiKhoan.AutoSize = true;
            this.lbTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.lbTenTaiKhoan.Location = new System.Drawing.Point(110, 379);
            this.lbTenTaiKhoan.Name = "lbTenTaiKhoan";
            this.lbTenTaiKhoan.Size = new System.Drawing.Size(137, 18);
            this.lbTenTaiKhoan.TabIndex = 6;
            this.lbTenTaiKhoan.Text = "[Mã] Tên Tài Khoản";
            // 
            // lbLoaiTK
            // 
            this.lbLoaiTK.AutoSize = true;
            this.lbLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiTK.ForeColor = System.Drawing.Color.Black;
            this.lbLoaiTK.Location = new System.Drawing.Point(430, 379);
            this.lbLoaiTK.Name = "lbLoaiTK";
            this.lbLoaiTK.Size = new System.Drawing.Size(107, 18);
            this.lbLoaiTK.TabIndex = 7;
            this.lbLoaiTK.Text = "Loại Tài Khoản";
            // 
            // btDangXuat
            // 
            this.btDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btDangXuat.Location = new System.Drawing.Point(627, 376);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(75, 23);
            this.btDangXuat.TabIndex = 7;
            this.btDangXuat.Text = "Đăng Xuất";
            this.btDangXuat.UseVisualStyleBackColor = true;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmQLCHG
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 400);
            this.Controls.Add(this.btDangXuat);
            this.Controls.Add(this.lbLoaiTK);
            this.Controls.Add(this.lbTenTaiKhoan);
            this.Controls.Add(this.lbDongHo);
            this.Controls.Add(this.btBaoCaoThongKe);
            this.Controls.Add(this.btQuanLyTTGao);
            this.Controls.Add(this.btQuanLyKhachHang);
            this.Controls.Add(this.btQuanLyTaiKhoan);
            this.Controls.Add(this.btQuanLyBanGao);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btMinimize);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLCHG";
            this.Text = "Quản Lý Cửa Hàng Bán Gạo";
            this.Load += new System.EventHandler(this.btQuanLyTaiKhoan_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmQLCHG_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmQLCHG_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmQLCHG_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btQuanLyBanGao;
        private System.Windows.Forms.Button btQuanLyTaiKhoan;
        private System.Windows.Forms.Button btQuanLyKhachHang;
        private System.Windows.Forms.Button btQuanLyTTGao;
        private System.Windows.Forms.Button btBaoCaoThongKe;
        private System.Windows.Forms.Label lbDongHo;
        private System.Windows.Forms.Label lbTenTaiKhoan;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbLoaiTK;
    }
}