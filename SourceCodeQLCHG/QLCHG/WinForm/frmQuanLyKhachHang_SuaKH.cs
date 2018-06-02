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
    public partial class frmQuanLyKhachHang_SuaKH : Form
    {
        public frmQuanLyKhachHang_SuaKH()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sua()
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();

            DateTime date1 = dtNamSinh.Value;
            DateTime date2 = DateTime.Now;

            string GioiTinh = "";
            if (rbNam.Checked == true) GioiTinh = "Nam";
            if (rbNu.Checked == true) GioiTinh = "Nữ";

            string NamSinh = dtNamSinh.Value.ToString("MM/dd/yyyy");

            if (txtHoTen.Text == "") lbThongBao.Text = "Vui lòng điền đầy đủ thông tin ở mục (*)";
            else if (date1.CompareTo(date2) >= 0) lbThongBao.Text = "Ngày sinh không được lớn hơn ngày hiện tại";
            else
            {
                try
                {
                    string sql1 = "UPDATE KHACHHANG SET HOTEN = @HoTen, NAMSINH = @NamSinh, GIOITINH = @GioiTinh, SODIENTHOAI = @SDT, DIACHI = @DiaChi WHERE MAKHACHHANG = @MaKhachHang";
                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    command1.Parameters.AddWithValue("@MaKhachHang", txtMaKH.Text);
                    command1.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    command1.Parameters.AddWithValue("@NamSinh", NamSinh);
                    command1.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    command1.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text);
                    command1.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    command1.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật Thông Tin Khách Hàng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Sua();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtHoTen.Focus();
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

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Sua();
        }

    }
}
