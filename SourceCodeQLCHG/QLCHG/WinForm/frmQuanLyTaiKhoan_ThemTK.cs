using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHG
{
    public partial class frmQuanLyTaiKhoan_ThemTK : Form
    {
        public frmQuanLyTaiKhoan_ThemTK()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DongY()
        {
            DateTime date1 = dtNamSinh.Value;
            DateTime date2 = DateTime.Now;

            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || txtHoTen.Text == "") lbThongBao.Text = "Vui lòng điền đầy đủ thông tin ở mục (*)";
            else if (txtMatKhau.TextLength < 5)
            {
                lbThongBao.Text = "Mật Khẩu quá ngắn";
                txtMatKhau.Focus();
            }
            else if (date1.CompareTo(date2) >= 0) lbThongBao.Text = "Ngày sinh không được lớn hơn ngày hiện tại";
            else
            {
                string NamSinh = dtNamSinh.Value.ToString("MM/dd/yyyy");
                string GioiTinh = "";
                if (rbNam.Checked == true) GioiTinh = "Nam";
                if (rbNu.Checked == true) GioiTinh = "Nữ";

                string QuyenHan = "";
                if (cbQLTK.Checked) QuyenHan = QuyenHan + "1";
                if (cbQLKH.Checked) QuyenHan = QuyenHan + "2";
                if (cbQLTTG.Checked) QuyenHan = QuyenHan + "3";
                if (cbQLBG.Checked) QuyenHan = QuyenHan + "4";
                if (cbBCTK.Checked) QuyenHan = QuyenHan + "5";

                SqlConnection conn = SQLDatabase.GetDBConnection();
                conn.Open();
                try
                {
                    string sql1 = "SELECT COUNT(MATAIKHOAN) FROM TAIKHOAN WHERE TAIKHOAN.MATAIKHOAN = @TAIKHOAN";
                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    command1.Parameters.AddWithValue("@TAIKHOAN", txtTaiKhoan.Text);
                    int check = (int)command1.ExecuteScalar();

                    if (check == 0)
                    {
                        lbThongBao.Text = "";

                        string sql2 = "INSERT INTO TAIKHOAN(MATAIKHOAN,MATKHAU,HOTEN,NAMSINH,SODIENTHOAI,GIOITINH,DIACHI,LOAITAIKHOAN,QUYENHAN) VALUES(@TaiKhoan,@MatKhau,@HoTen,@NamSinh,@SDT,@GioiTinh,@DiaChi,@LoaiTK,@QuyenHan)";
                        SqlCommand command2 = new SqlCommand(sql2, conn);
                        command2.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);
                        command2.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                        command2.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        command2.Parameters.AddWithValue("@NamSinh", NamSinh);
                        command2.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text);
                        command2.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                        command2.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        command2.Parameters.AddWithValue("@LoaiTK", cbbLoaiTK.Text);
                        command2.Parameters.AddWithValue("@QuyenHan", QuyenHan);
                        command2.ExecuteNonQuery();

                        string str = "Thêm Tài Khoản '" + txtTaiKhoan.Text + "' thành công";
                        MessageBox.Show(str, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtTaiKhoan.Text = "";
                        txtMatKhau.Text = "";
                        txtHoTen.Text = "";
                        txtDiaChi.Text = "";
                        txtSoDienThoai.Text = "";
                        txtTaiKhoan.Focus();
                    }
                    else
                    {
                        lbThongBao.Text = "Tài Khoản đã tồn tại!";
                        txtTaiKhoan.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            DongY();
            cbQLTK.Checked = false;
            cbQLKH.Checked = false;
            cbQLTTG.Checked = false;
            cbQLBG.Checked = false;
            cbBCTK.Checked = false;
        }

        

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            rbNam.Checked = true;
            cbbLoaiTK.Text = "Nhân Viên Bán Hàng";
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked) txtMatKhau.UseSystemPasswordChar = false;
            else txtMatKhau.UseSystemPasswordChar = true;
        }

        Boolean flag;
        int x, y;

        private void frmDangKy_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmDangKy_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmDangKy_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8)) e.Handled = true;
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) DongY();
        }

    }
}

