namespace QLCHG
{
    partial class frmQuanLyTTGao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTTGao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btHuyBo = new System.Windows.Forms.Button();
            this.btDongY_Sua = new System.Windows.Forms.Button();
            this.btDongY_Them = new System.Windows.Forms.Button();
            this.dataViewQLTTG = new System.Windows.Forms.DataGridView();
            this.SELECT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MAGAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENGAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAIGAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRONGLUONGGAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XUATXU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbLoaiGao = new System.Windows.Forms.ComboBox();
            this.txtMaGao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenGao = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrongLuong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNoiDungTimKiem = new System.Windows.Forms.TextBox();
            this.cbbTieuChiTimKiem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewQLTTG)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btHuyBo);
            this.groupBox1.Controls.Add(this.btDongY_Sua);
            this.groupBox1.Controls.Add(this.btDongY_Them);
            this.groupBox1.Controls.Add(this.dataViewQLTTG);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 423);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btHuyBo
            // 
            this.btHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuyBo.Location = new System.Drawing.Point(855, 346);
            this.btHuyBo.Name = "btHuyBo";
            this.btHuyBo.Size = new System.Drawing.Size(75, 23);
            this.btHuyBo.TabIndex = 20;
            this.btHuyBo.Text = "Hủy Bỏ";
            this.btHuyBo.UseVisualStyleBackColor = true;
            this.btHuyBo.Visible = false;
            this.btHuyBo.Click += new System.EventHandler(this.btHuyBo_Click);
            // 
            // btDongY_Sua
            // 
            this.btDongY_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDongY_Sua.Location = new System.Drawing.Point(759, 346);
            this.btDongY_Sua.Name = "btDongY_Sua";
            this.btDongY_Sua.Size = new System.Drawing.Size(75, 23);
            this.btDongY_Sua.TabIndex = 19;
            this.btDongY_Sua.Text = "Đồng Ý";
            this.btDongY_Sua.UseVisualStyleBackColor = true;
            this.btDongY_Sua.Visible = false;
            this.btDongY_Sua.Click += new System.EventHandler(this.btDongY_Sua_Click);
            // 
            // btDongY_Them
            // 
            this.btDongY_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDongY_Them.Location = new System.Drawing.Point(759, 346);
            this.btDongY_Them.Name = "btDongY_Them";
            this.btDongY_Them.Size = new System.Drawing.Size(75, 23);
            this.btDongY_Them.TabIndex = 10;
            this.btDongY_Them.Text = "Đồng Ý";
            this.btDongY_Them.UseVisualStyleBackColor = true;
            this.btDongY_Them.Visible = false;
            this.btDongY_Them.Click += new System.EventHandler(this.btDongY_Them_Click);
            // 
            // dataViewQLTTG
            // 
            this.dataViewQLTTG.AllowUserToAddRows = false;
            this.dataViewQLTTG.AllowUserToDeleteRows = false;
            this.dataViewQLTTG.BackgroundColor = System.Drawing.Color.White;
            this.dataViewQLTTG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataViewQLTTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewQLTTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECT,
            this.MAGAO,
            this.TENGAO,
            this.LOAIGAO,
            this.TRONGLUONGGAO,
            this.GIANHAP,
            this.GIABAN,
            this.XUATXU});
            this.dataViewQLTTG.Location = new System.Drawing.Point(6, 12);
            this.dataViewQLTTG.Name = "dataViewQLTTG";
            this.dataViewQLTTG.RowHeadersVisible = false;
            this.dataViewQLTTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataViewQLTTG.Size = new System.Drawing.Size(704, 403);
            this.dataViewQLTTG.TabIndex = 1;
            this.dataViewQLTTG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewQLTTG_CellDoubleClick);
            // 
            // SELECT
            // 
            this.SELECT.HeaderText = "";
            this.SELECT.Name = "SELECT";
            this.SELECT.Width = 20;
            // 
            // MAGAO
            // 
            this.MAGAO.DataPropertyName = "MAGAO";
            this.MAGAO.HeaderText = "Mã Gạo";
            this.MAGAO.Name = "MAGAO";
            this.MAGAO.ReadOnly = true;
            this.MAGAO.Width = 83;
            // 
            // TENGAO
            // 
            this.TENGAO.DataPropertyName = "TENGAO";
            this.TENGAO.HeaderText = "Tên Gạo";
            this.TENGAO.Name = "TENGAO";
            this.TENGAO.ReadOnly = true;
            // 
            // LOAIGAO
            // 
            this.LOAIGAO.DataPropertyName = "LOAIGAO";
            this.LOAIGAO.HeaderText = "Loại Gạo";
            this.LOAIGAO.Name = "LOAIGAO";
            this.LOAIGAO.ReadOnly = true;
            // 
            // TRONGLUONGGAO
            // 
            this.TRONGLUONGGAO.DataPropertyName = "TRONGLUONGGAO";
            this.TRONGLUONGGAO.HeaderText = "Trọng Lượng  (KG)";
            this.TRONGLUONGGAO.Name = "TRONGLUONGGAO";
            this.TRONGLUONGGAO.ReadOnly = true;
            // 
            // GIANHAP
            // 
            this.GIANHAP.DataPropertyName = "GIANHAP";
            this.GIANHAP.HeaderText = "Giá Nhập  (VNĐ/1KG)";
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.ReadOnly = true;
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.HeaderText = "Giá Bán  (VNĐ/1KG)";
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.ReadOnly = true;
            // 
            // XUATXU
            // 
            this.XUATXU.DataPropertyName = "XUATXU";
            this.XUATXU.HeaderText = "Xuất Xứ";
            this.XUATXU.Name = "XUATXU";
            this.XUATXU.ReadOnly = true;
            // 
            // btXoa
            // 
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Location = new System.Drawing.Point(890, 375);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(80, 40);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Location = new System.Drawing.Point(802, 375);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(82, 40);
            this.btSua.TabIndex = 4;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Location = new System.Drawing.Point(716, 375);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 40);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbLoaiGao);
            this.groupBox3.Controls.Add(this.txtMaGao);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtXuatXu);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTenGao);
            this.groupBox3.Controls.Add(this.txtGiaBan);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtGiaNhap);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTrongLuong);
            this.groupBox3.Location = new System.Drawing.Point(719, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 224);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Gạo";
            // 
            // cbbLoaiGao
            // 
            this.cbbLoaiGao.BackColor = System.Drawing.Color.White;
            this.cbbLoaiGao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiGao.FormattingEnabled = true;
            this.cbbLoaiGao.Items.AddRange(new object[] {
            "",
            "Gạo Khô",
            "Gạo Dẻo",
            "Gạo Nếp"});
            this.cbbLoaiGao.Location = new System.Drawing.Point(75, 80);
            this.cbbLoaiGao.Name = "cbbLoaiGao";
            this.cbbLoaiGao.Size = new System.Drawing.Size(170, 21);
            this.cbbLoaiGao.TabIndex = 14;
            // 
            // txtMaGao
            // 
            this.txtMaGao.BackColor = System.Drawing.Color.White;
            this.txtMaGao.Location = new System.Drawing.Point(75, 28);
            this.txtMaGao.Name = "txtMaGao";
            this.txtMaGao.Size = new System.Drawing.Size(170, 20);
            this.txtMaGao.TabIndex = 12;
            this.txtMaGao.TextChanged += new System.EventHandler(this.txtMaGao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Gạo";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.BackColor = System.Drawing.Color.White;
            this.txtXuatXu.Location = new System.Drawing.Point(75, 184);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(170, 20);
            this.txtXuatXu.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Gạo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Xuất Xứ";
            // 
            // txtTenGao
            // 
            this.txtTenGao.BackColor = System.Drawing.Color.White;
            this.txtTenGao.Location = new System.Drawing.Point(75, 54);
            this.txtTenGao.Name = "txtTenGao";
            this.txtTenGao.Size = new System.Drawing.Size(170, 20);
            this.txtTenGao.TabIndex = 13;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.Color.White;
            this.txtGiaBan.Location = new System.Drawing.Point(75, 158);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(170, 20);
            this.txtGiaBan.TabIndex = 17;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại Gạo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Giá Bán";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BackColor = System.Drawing.Color.White;
            this.txtGiaNhap.Location = new System.Drawing.Point(75, 132);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(170, 20);
            this.txtGiaNhap.TabIndex = 16;
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Trọng Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giá Nhập";
            // 
            // txtTrongLuong
            // 
            this.txtTrongLuong.BackColor = System.Drawing.Color.White;
            this.txtTrongLuong.Location = new System.Drawing.Point(75, 106);
            this.txtTrongLuong.Name = "txtTrongLuong";
            this.txtTrongLuong.Size = new System.Drawing.Size(170, 20);
            this.txtTrongLuong.TabIndex = 15;
            this.txtTrongLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrongLuong_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtNoiDungTimKiem);
            this.groupBox2.Controls.Add(this.cbbTieuChiTimKiem);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(719, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 85);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nội Dung";
            // 
            // txtNoiDungTimKiem
            // 
            this.txtNoiDungTimKiem.Location = new System.Drawing.Point(65, 49);
            this.txtNoiDungTimKiem.Name = "txtNoiDungTimKiem";
            this.txtNoiDungTimKiem.Size = new System.Drawing.Size(180, 20);
            this.txtNoiDungTimKiem.TabIndex = 2;
            this.txtNoiDungTimKiem.TextChanged += new System.EventHandler(this.txtNoiDungTimKiem_TextChanged);
            // 
            // cbbTieuChiTimKiem
            // 
            this.cbbTieuChiTimKiem.BackColor = System.Drawing.Color.White;
            this.cbbTieuChiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTieuChiTimKiem.FormattingEnabled = true;
            this.cbbTieuChiTimKiem.Items.AddRange(new object[] {
            "Mã Gạo",
            "Tên Gạo",
            "Loại Gạo",
            "Giá Nhập",
            "Giá Bán",
            "Xuất Xứ"});
            this.cbbTieuChiTimKiem.Location = new System.Drawing.Point(65, 22);
            this.cbbTieuChiTimKiem.Name = "cbbTieuChiTimKiem";
            this.cbbTieuChiTimKiem.Size = new System.Drawing.Size(180, 21);
            this.cbbTieuChiTimKiem.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tiêu Chí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(276, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ THÔNG TIN GẠO";
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
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
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
            this.btExit.TabIndex = 21;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmQuanLyTTGao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyTTGao";
            this.Text = "Quản Lý Thông Tin Gạo";
            this.Load += new System.EventHandler(this.frmQuanLyKho_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmQuanLyKho_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmQuanLyKho_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmQuanLyKho_MouseUp);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewQLTTG)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrongLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenGao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaGao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNoiDungTimKiem;
        private System.Windows.Forms.ComboBox cbbTieuChiTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataViewQLTTG;
        private System.Windows.Forms.Button btHuyBo;
        private System.Windows.Forms.Button btDongY_Them;
        private System.Windows.Forms.Button btDongY_Sua;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENGAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIGAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRONGLUONGGAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn XUATXU;
        private System.Windows.Forms.ComboBox cbbLoaiGao;

    }
}