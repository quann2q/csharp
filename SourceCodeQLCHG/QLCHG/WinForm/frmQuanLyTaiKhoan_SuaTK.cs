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
    public partial class frmQuanLyTaiKhoan_SuaTK : Form
    {
        public frmQuanLyTaiKhoan_SuaTK()
        {
            InitializeComponent();
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

            string QuyenHan = "";
            if (cbQLTK.Checked) QuyenHan = QuyenHan + "1";
            if (cbQLKH.Checked) QuyenHan = QuyenHan + "2";
            if (cbQLTTG.Checked) QuyenHan = QuyenHan + "3";
            if (cbQLBG.Checked) QuyenHan = QuyenHan + "4";
            if (cbBCTK.Checked) QuyenHan = QuyenHan + "5";

            string NamSinh = dtNamSinh.Value.ToString("MM/dd/yyyy");

            if (txtMatKhau.Text == "" || txtHoTen.Text == "") lbThongBao.Text = "Vui lòng điền đầy đủ thông tin ở mục (*)";
            else if (txtMatKhau.TextLength < 5)
            {
                lbThongBao.Text = "Mật Khẩu quá ngắn";
                txtMatKhau.Focus();
            }
            else if (date1.CompareTo(date2) >= 0) lbThongBao.Text = "Ngày sinh không được lớn hơn ngày hiện tại";
            else
            {
                try
                {
                    string sql1 = "UPDATE TAIKHOAN SET MATKHAU = @MatKhau, HOTEN = @HoTen, NAMSINH = @NamSinh, SODIENTHOAI = @SDT, GIOITINH = @GioiTinh, DIACHI = @DiaChi, LOAITAIKHOAN = @LoaiTK, QUYENHAN = @QuyenHan WHERE MATAIKHOAN = @MaTaiKhoan";
                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    command1.Parameters.AddWithValue("@MaTaiKhoan", txtTaiKhoan.Text);
                    command1.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                    command1.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    command1.Parameters.AddWithValue("@NamSinh", NamSinh);
                    command1.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text);
                    command1.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    command1.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    command1.Parameters.AddWithValue("@LoaiTK", cbbLoaiTK.Text);
                    command1.Parameters.AddWithValue("@QuyenHan", QuyenHan);
                    command1.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật Tài Khoản thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btDongY_Click(object sender, EventArgs e)
        {
            Sua();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked) txtMatKhau.UseSystemPasswordChar = false;
            else txtMatKhau.UseSystemPasswordChar = true;
        }

        Boolean flag;
        int x, y;

        private void frmSuaTK_QLTK_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmSuaTK_QLTK_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmSuaTK_QLTK_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8)) e.Handled = true;
        }

        private void frmQLTK_SuaTK_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Sua();
        }
    }
}
