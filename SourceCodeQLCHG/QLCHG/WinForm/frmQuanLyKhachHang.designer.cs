namespace QLCHG
{
    partial class frmQuanLyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemKH = new System.Windows.Forms.TextBox();
            this.cbbTimKiemKH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataViewQLKH = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MAKHACHHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SODIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAIKHACHHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENTICHLUY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btXoaKH = new System.Windows.Forms.Button();
            this.btSuaKH = new System.Windows.Forms.Button();
            this.btThemKH = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewQLKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(299, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiemKH);
            this.groupBox1.Controls.Add(this.cbbTimKiemKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataViewQLKH);
            this.groupBox1.Controls.Add(this.btXoaKH);
            this.groupBox1.Controls.Add(this.btSuaKH);
            this.groupBox1.Controls.Add(this.btThemKH);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 423);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtTimKiemKH
            // 
            this.txtTimKiemKH.Location = new System.Drawing.Point(189, 38);
            this.txtTimKiemKH.Name = "txtTimKiemKH";
            this.txtTimKiemKH.Size = new System.Drawing.Size(140, 20);
            this.txtTimKiemKH.TabIndex = 2;
            this.txtTimKiemKH.TextChanged += new System.EventHandler(this.txtTimKiemTK_TextChanged);
            // 
            // cbbTimKiemKH
            // 
            this.cbbTimKiemKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemKH.FormattingEnabled = true;
            this.cbbTimKiemKH.Items.AddRange(new object[] {
            "Mã Khách Hàng",
            "Họ Tên",
            "Năm Sinh",
            "Giới Tính",
            "Số Điện Thoại",
            "Địa Chỉ",
            "Loại Khách Hàng"});
            this.cbbTimKiemKH.Location = new System.Drawing.Point(62, 38);
            this.cbbTimKiemKH.Name = "cbbTimKiemKH";
            this.cbbTimKiemKH.Size = new System.Drawing.Size(121, 21);
            this.cbbTimKiemKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm Kiếm";
            // 
            // dataViewQLKH
            // 
            this.dataViewQLKH.AllowUserToAddRows = false;
            this.dataViewQLKH.AllowUserToDeleteRows = false;
            this.dataViewQLKH.BackgroundColor = System.Drawing.Color.White;
            this.dataViewQLKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataViewQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewQLKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.MAKHACHHANG,
            this.HOTEN,
            this.NAMSINH,
            this.GIOITINH,
            this.SODIENTHOAI,
            this.DIACHI,
            this.LOAIKHACHHANG,
            this.TIENTICHLUY});
            this.dataViewQLKH.Location = new System.Drawing.Point(6, 65);
            this.dataViewQLKH.Name = "dataViewQLKH";
            this.dataViewQLKH.RowHeadersVisible = false;
            this.dataViewQLKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataViewQLKH.Size = new System.Drawing.Size(964, 352);
            this.dataViewQLKH.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.Width = 20;
            // 
            // MAKHACHHANG
            // 
            this.MAKHACHHANG.DataPropertyName = "MAKHACHHANG";
            this.MAKHACHHANG.HeaderText = "Mã KH";
            this.MAKHACHHANG.Name = "MAKHACHHANG";
            this.MAKHACHHANG.ReadOnly = true;
            this.MAKHACHHANG.Width = 107;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            this.HOTEN.Width = 171;
            // 
            // NAMSINH
            // 
            this.NAMSINH.DataPropertyName = "NAMSINH";
            this.NAMSINH.HeaderText = "Năm Sinh";
            this.NAMSINH.Name = "NAMSINH";
            this.NAMSINH.ReadOnly = true;
            this.NAMSINH.Width = 107;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới Tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            this.GIOITINH.Width = 87;
            // 
            // SODIENTHOAI
            // 
            this.SODIENTHOAI.DataPropertyName = "SODIENTHOAI";
            this.SODIENTHOAI.HeaderText = "Số Điện Thoại";
            this.SODIENTHOAI.Name = "SODIENTHOAI";
            this.SODIENTHOAI.ReadOnly = true;
            this.SODIENTHOAI.Width = 107;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.DIACHI.Width = 107;
            // 
            // LOAIKHACHHANG
            // 
            this.LOAIKHACHHANG.DataPropertyName = "LOAIKHACHHANG";
            this.LOAIKHACHHANG.HeaderText = "Loại Khách Hàng";
            this.LOAIKHACHHANG.Name = "LOAIKHACHHANG";
            this.LOAIKHACHHANG.ReadOnly = true;
            this.LOAIKHACHHANG.Width = 127;
            // 
            // TIENTICHLUY
            // 
            this.TIENTICHLUY.DataPropertyName = "TIENTICHLUY";
            this.TIENTICHLUY.HeaderText = "Tiền Tích Lũy";
            this.TIENTICHLUY.Name = "TIENTICHLUY";
            this.TIENTICHLUY.ReadOnly = true;
            this.TIENTICHLUY.Width = 130;
            // 
            // btXoaKH
            // 
            this.btXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaKH.ForeColor = System.Drawing.Color.Black;
            this.btXoaKH.Location = new System.Drawing.Point(874, 19);
            this.btXoaKH.Name = "btXoaKH";
            this.btXoaKH.Size = new System.Drawing.Size(96, 40);
            this.btXoaKH.TabIndex = 5;
            this.btXoaKH.Text = "Xóa TT KH";
            this.btXoaKH.UseVisualStyleBackColor = true;
            this.btXoaKH.Click += new System.EventHandler(this.btXoaTK_Click);
            // 
            // btSuaKH
            // 
            this.btSuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaKH.ForeColor = System.Drawing.Color.Black;
            this.btSuaKH.Location = new System.Drawing.Point(772, 19);
            this.btSuaKH.Name = "btSuaKH";
            this.btSuaKH.Size = new System.Drawing.Size(96, 40);
            this.btSuaKH.TabIndex = 4;
            this.btSuaKH.Text = "Sửa TT KH";
            this.btSuaKH.UseVisualStyleBackColor = true;
            this.btSuaKH.Click += new System.EventHandler(this.btSuaTK_Click);
            // 
            // btThemKH
            // 
            this.btThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemKH.ForeColor = System.Drawing.Color.Black;
            this.btThemKH.Location = new System.Drawing.Point(670, 19);
            this.btThemKH.Name = "btThemKH";
            this.btThemKH.Size = new System.Drawing.Size(96, 40);
            this.btThemKH.TabIndex = 3;
            this.btThemKH.Text = "Thêm TT KH";
            this.btThemKH.UseVisualStyleBackColor = true;
            this.btThemKH.Click += new System.EventHandler(this.btThemTK_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExit.BackgroundImage")));
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btExit.Location = new System.Drawing.Point(965, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(35, 25);
            this.btExit.TabIndex = 6;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(12, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 60);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmQuanLyTaiKhoan_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmQuanLyTaiKhoan_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmQuanLyTaiKhoan_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewQLKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataViewQLKH;
        private System.Windows.Forms.Button btXoaKH;
        private System.Windows.Forms.Button btSuaKH;
        private System.Windows.Forms.Button btThemKH;
        private System.Windows.Forms.TextBox txtTimKiemKH;
        private System.Windows.Forms.ComboBox cbbTimKiemKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHACHHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SODIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIKHACHHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENTICHLUY;
    }
}