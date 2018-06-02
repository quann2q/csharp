using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCHG
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public static string TenTaiKhoan = "";

        private void DangNhap()
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "") lbThongBao.Text = "Tài Khoản hoặc Mật Khẩu chưa được nhập";
            else
            {
                try
                {
                    SqlConnection conn = SQLDatabase.GetDBConnection();
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM TAIKHOAN WHERE TAIKHOAN.MATAIKHOAN = @TAIKHOAN AND TAIKHOAN.MATKHAU = @MATKHAU";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.Add(new SqlParameter("@TAIKHOAN", txtTaiKhoan.Text));
                    command.Parameters.Add(new SqlParameter("@MATKHAU", txtMatKhau.Text));
                    int x = (int)command.ExecuteScalar();
                    if (x > 0)
                    {
                        MessageBox.Show("Đăng Nhập thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TenTaiKhoan = txtTaiKhoan.Text;
                        this.Hide();
                        frmQLCHG frm = new frmQLCHG();
                        frm.ShowDialog();
                        //Application.Exit();
                    }
                    else
                    {
                        lbThongBao.Text = "Tài Khoản hoặc Mật Khẩu không đúng";
                        txtTaiKhoan.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtTaiKhoan.Focus();
            cbHienMatKhau.Checked = false;
            lbThongBao.Text = "";
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked) txtMatKhau.UseSystemPasswordChar = false;
            else txtMatKhau.UseSystemPasswordChar = true;
        }

        Boolean flag;
        int x, y;

        private void frmDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmDangNhap_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmDangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) DangNhap();
        }

    }
}
