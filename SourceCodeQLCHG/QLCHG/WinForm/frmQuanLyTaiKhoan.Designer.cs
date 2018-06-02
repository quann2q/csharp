namespace QLCHG
{
    partial class frmQuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemTK = new System.Windows.Forms.TextBox();
            this.cbbTimKiemTK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataViewQLTK = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MATAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SODIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAITAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUYENHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btXoaTK = new System.Windows.Forms.Button();
            this.btSuaTK = new System.Windows.Forms.Button();
            this.btThemTK = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewQLTK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(321, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiemTK);
            this.groupBox1.Controls.Add(this.cbbTimKiemTK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataViewQLTK);
            this.groupBox1.Controls.Add(this.btXoaTK);
            this.groupBox1.Controls.Add(this.btSuaTK);
            this.groupBox1.Controls.Add(this.btThemTK);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 423);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtTimKiemTK
            // 
            this.txtTimKiemTK.Location = new System.Drawing.Point(189, 39);
            this.txtTimKiemTK.Name = "txtTimKiemTK";
            this.txtTimKiemTK.Size = new System.Drawing.Size(140, 20);
            this.txtTimKiemTK.TabIndex = 2;
            this.txtTimKiemTK.TextChanged += new System.EventHandler(this.txtTimKiemTK_TextChanged);
            // 
            // cbbTimKiemTK
            // 
            this.cbbTimKiemTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemTK.FormattingEnabled = true;
            this.cbbTimKiemTK.Items.AddRange(new object[] {
            "Tài Khoản",
            "Mật Khẩu",
            "Họ Tên",
            "Năm Sinh",
            "Số Điện Thoại",
            "Giới Tính",
            "Địa Chỉ",
            "Loại Tài Khoản"});
            this.cbbTimKiemTK.Location = new System.Drawing.Point(62, 38);
            this.cbbTimKiemTK.Name = "cbbTimKiemTK";
            this.cbbTimKiemTK.Size = new System.Drawing.Size(121, 21);
            this.cbbTimKiemTK.TabIndex = 1;
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
            // dataViewQLTK
            // 
            this.dataViewQLTK.AllowUserToAddRows = false;
            this.dataViewQLTK.AllowUserToDeleteRows = false;
            this.dataViewQLTK.BackgroundColor = System.Drawing.Color.White;
            this.dataViewQLTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataViewQLTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewQLTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.MATAIKHOAN,
            this.MATKHAU,
            this.HOTEN,
            this.NAMSINH,
            this.SODIENTHOAI,
            this.GIOITINH,
            this.DIACHI,
            this.LOAITAIKHOAN,
            this.QUYENHAN});
            this.dataViewQLTK.Location = new System.Drawing.Point(6, 65);
            this.dataViewQLTK.Name = "dataViewQLTK";
            this.dataViewQLTK.RowHeadersVisible = false;
            this.dataViewQLTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataViewQLTK.Size = new System.Drawing.Size(964, 352);
            this.dataViewQLTK.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.Width = 20;
            // 
            // MATAIKHOAN
            // 
            this.MATAIKHOAN.DataPropertyName = "MATAIKHOAN";
            this.MATAIKHOAN.HeaderText = "Tài Khoản";
            this.MATAIKHOAN.Name = "MATAIKHOAN";
            this.MATAIKHOAN.ReadOnly = true;
            this.MATAIKHOAN.Width = 107;
            // 
            // MATKHAU
            // 
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "Mật Khẩu";
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.ReadOnly = true;
            this.MATKHAU.Width = 107;
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
            // SODIENTHOAI
            // 
            this.SODIENTHOAI.DataPropertyName = "SODIENTHOAI";
            this.SODIENTHOAI.HeaderText = "Số Điện Thoại";
            this.SODIENTHOAI.Name = "SODIENTHOAI";
            this.SODIENTHOAI.ReadOnly = true;
            this.SODIENTHOAI.Width = 107;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới Tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            this.GIOITINH.Width = 107;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.DIACHI.Width = 107;
            // 
            // LOAITAIKHOAN
            // 
            this.LOAITAIKHOAN.DataPropertyName = "LOAITAIKHOAN";
            this.LOAITAIKHOAN.HeaderText = "Loại Tài Khoản";
            this.LOAITAIKHOAN.Name = "LOAITAIKHOAN";
            this.LOAITAIKHOAN.ReadOnly = true;
            this.LOAITAIKHOAN.Width = 130;
            // 
            // QUYENHAN
            // 
            this.QUYENHAN.DataPropertyName = "QUYENHAN";
            this.QUYENHAN.HeaderText = "QH";
            this.QUYENHAN.Name = "QUYENHAN";
            this.QUYENHAN.Visible = false;
            // 
            // btXoaTK
            // 
            this.btXoaTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaTK.ForeColor = System.Drawing.Color.Black;
            this.btXoaTK.Location = new System.Drawing.Point(874, 19);
            this.btXoaTK.Name = "btXoaTK";
            this.btXoaTK.Size = new System.Drawing.Size(96, 40);
            this.btXoaTK.TabIndex = 5;
            this.btXoaTK.Text = "Xóa Tài Khoản";
            this.btXoaTK.UseVisualStyleBackColor = true;
            this.btXoaTK.Click += new System.EventHandler(this.btXoaTK_Click);
            // 
            // btSuaTK
            // 
            this.btSuaTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaTK.ForeColor = System.Drawing.Color.Black;
            this.btSuaTK.Location = new System.Drawing.Point(772, 19);
            this.btSuaTK.Name = "btSuaTK";
            this.btSuaTK.Size = new System.Drawing.Size(96, 40);
            this.btSuaTK.TabIndex = 4;
            this.btSuaTK.Text = "Sửa Tài Khoản";
            this.btSuaTK.UseVisualStyleBackColor = true;
            this.btSuaTK.Click += new System.EventHandler(this.btSuaTK_Click);
            // 
            // btThemTK
            // 
            this.btThemTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemTK.ForeColor = System.Drawing.Color.Black;
            this.btThemTK.Location = new System.Drawing.Point(670, 19);
            this.btThemTK.Name = "btThemTK";
            this.btThemTK.Size = new System.Drawing.Size(96, 40);
            this.btThemTK.TabIndex = 3;
            this.btThemTK.Text = "Thêm Tài Khoản";
            this.btThemTK.UseVisualStyleBackColor = true;
            this.btThemTK.Click += new System.EventHandler(this.btThemTK_Click);
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
            // frmQuanLyTaiKhoan
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
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmQuanLyTaiKhoan_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmQuanLyTaiKhoan_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmQuanLyTaiKhoan_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewQLTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataViewQLTK;
        private System.Windows.Forms.Button btXoaTK;
        private System.Windows.Forms.Button btSuaTK;
        private System.Windows.Forms.Button btThemTK;
        private System.Windows.Forms.TextBox txtTimKiemTK;
        private System.Windows.Forms.ComboBox cbbTimKiemTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATAIKHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SODIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAITAIKHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUYENHAN;
    }
}