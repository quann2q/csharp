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
    public partial class frmQuanLyKhachHang_ThemKH : Form
    {
        public frmQuanLyKhachHang_ThemKH()
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

            if (txtMaKH.Text == "" || txtHoTen.Text == "") lbThongBao.Text = "Vui lòng điền đầy đủ thông tin ở mục (*)";
            else if (date1.CompareTo(date2) >= 0) lbThongBao.Text = "Ngày sinh không được lớn hơn ngày hiện tại";
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
                    string sql1 = "SELECT COUNT(MAKHACHHANG) FROM KHACHHANG WHERE KHACHHANG.MAKHACHHANG = '" + txtMaKH.Text + "'";
                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    int check = (int)command1.ExecuteScalar();

                    if (check == 0)
                    {
                        lbThongBao.Text = "";

                        string sql2 = "INSERT INTO KHACHHANG(MAKHACHHANG,HOTEN,NAMSINH,GIOITINH,SODIENTHOAI,DIACHI,LOAIKHACHHANG,TIENTICHLUY) VALUES(@MaKH,@HoTen,@NamSinh,@GioiTinh,@SDT,@DiaChi,@LoaiKH,@TienTichLuy)";
                        SqlCommand command2 = new SqlCommand(sql2, conn);
                        command2.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                        command2.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        command2.Parameters.AddWithValue("@NamSinh", NamSinh);
                        command2.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                        command2.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text);
                        command2.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        command2.Parameters.AddWithValue("@LoaiKH", "VIP 0");
                        command2.Parameters.AddWithValue("@TienTichLuy", "0");
                        command2.ExecuteNonQuery();

                        string str = "Thông tin Khách Hàng '" + txtHoTen.Text + "' vừa được lưu";
                        MessageBox.Show(str, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtMaKH.Text = "";
                        txtHoTen.Text = "";
                        txtDiaChi.Text = "";
                        txtSoDienThoai.Text = "";
                    }
                    //else
                    //{
                    //    lbThongBao.Text = "Tài Khoản đã tồn tại!";
                    //    txtMaKH.Focus();
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            ThemMaKH();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            DongY();
        }

        private void ThemMaKH()
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();
            string Sql = @"select * from KHACHHANG";

            SqlDataAdapter da = new SqlDataAdapter(Sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            string g = "";
            if (dt.Rows.Count <= 0) g = "KH0";
            else
            {
                int k;
                g = "KH";
                int max = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] strItems = dt.Rows[i][0].ToString().Split(new char[] { 'H' });
                    k = Convert.ToInt32(strItems[1]);
                    if (k > max) max = k;
                }
                g = g + (max + 1).ToString();
            }
            txtMaKH.Text = g;
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            ThemMaKH();
            rbNam.Checked = true;
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
            if (e.KeyCode == Keys.Enter) DongY();
        }

    }
}
