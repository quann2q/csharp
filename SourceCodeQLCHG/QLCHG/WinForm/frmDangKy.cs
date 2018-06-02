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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            Application.Exit();
        }

        private void DangKy()
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || txtHoTen.Text == "") lbThongBao.Text = "Vui lòng điền đầy đủ thông tin ở mục (*)";
            else if (txtMatKhau.TextLength < 5)
            {
                lbThongBao.Text = "Mật Khẩu quá ngắn";
                txtMatKhau.Focus();
            }
            else
            {
                string NamSinh = dtNamSinh.Value.ToString("MM/dd/yyyy");
                string GioiTinh = "";
                if (rbNam.Checked == true) GioiTinh = "Nam";
                if (rbNu.Checked == true) GioiTinh = "Nữ";


                SqlConnection conn = SQLDatabase.GetDBConnection();
                conn.Open();
                try
                {
                    string sql1 = "SELECT COUNT(MATAIKHOAN) FROM TAIKHOAN WHERE TAIKHOAN.MATAIKHOAN = @MATAIKHOAN";
                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    command1.Parameters.AddWithValue("@MATAIKHOAN", txtTaiKhoan.Text);
                    int check = (int)command1.ExecuteScalar();

                    if (check == 0)
                    {
                        lbThongBao.Text = "";

                        string sql2 = "INSERT INTO TAIKHOAN(MATAIKHOAN,MATKHAU,HOTEN,NAMSINH,SODIENTHOAI,GIOITINH,DIACHI,LOAITAIKHOAN) VALUES(@MaTaiKhoan,@MatKhau,@HoTen,@NamSinh,@SDT,@GioiTinh,@DiaChi,@LoaiTK)";
                        SqlCommand command2 = new SqlCommand(sql2, conn);
                        command2.Parameters.AddWithValue("@MaTaiKhoan", txtTaiKhoan.Text);
                        command2.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                        command2.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        command2.Parameters.AddWithValue("@NamSinh", NamSinh);
                        command2.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text);
                        command2.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                        command2.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        command2.Parameters.AddWithValue("@LoaiTK", cbbLoaiTK.Text);
                        command2.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        //txtTaiKhoan.Text = "";
                        txtTaiKhoan.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            DangKy();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
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

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) DangKy();
        }

    }
}
