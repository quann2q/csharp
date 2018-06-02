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
    public partial class frmQLCHG : Form
    {
        public frmQLCHG()
        {
            InitializeComponent();
        }


        private void btQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan();
            frm.ShowDialog();
            Application.Exit();
        }

        private void btQuanLyKho_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyTTGao frm = new frmQuanLyTTGao();
            frm.ShowDialog();
            Application.Exit();
        }

        private void btQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyKhachHang frm = new frmQuanLyKhachHang();
            frm.ShowDialog();
            Application.Exit();
        }

        private void btQuanLyBanGao_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyBanGao frm = new frmQuanLyBanGao();
            frm.ShowDialog();
            Application.Exit();
        }

        private void btBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBaoCaoThongKe frm = new frmBaoCaoThongKe();
            frm.ShowDialog();
            Application.Exit();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát khỏi phần mềm?", "TẮT CHƯƠNG TRÌNH", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        Boolean flag = false;
        int x, y;

        private void frmQLCHG_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmQLCHG_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmQLCHG_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        static public DateTime dt;
        private string setTime()
        {
            string time = "";
            dt = DateTime.Now;
            if (dt.Hour < 10)
            {
                if (dt.Minute < 10)
                {
                    if (dt.Second < 10) time = "0" + dt.Hour + ":0" + dt.Minute + ":0" + dt.Second;
                    else time = "0" + dt.Hour + ":0" + dt.Minute + ":" + dt.Second;
                }
                else
                {
                    if (dt.Second < 10) time = "0" + dt.Hour + ":" + dt.Minute + ":0" + dt.Second;
                    else time = "0" + dt.Hour + ":" + dt.Minute + ":" + dt.Second;
                }
            }
            else
            {
                if (dt.Minute < 10)
                {
                    if (dt.Second < 10) time = dt.Hour + ":0" + dt.Minute + ":0" + dt.Second;
                    else time = dt.Hour + ":0" + dt.Minute + ":" + dt.Second;
                }
                else
                {
                    if (dt.Second < 10) time = dt.Hour + ":" + dt.Minute + ":0" + dt.Second;
                    else time = dt.Hour + ":" + dt.Minute + ":" + dt.Second;
                }
            }

            return time;
        }
        public static string MaTk = "";
        public static string Ten = "";
        public static string QuyenHan = "";
        public void setLabel(string TaiKhoan)
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();

            try
            {
                string sql1 = "SELECT * FROM TAIKHOAN WHERE TAIKHOAN.MATAIKHOAN = '" + TaiKhoan + "'";
                SqlCommand command1 = new SqlCommand(sql1, conn);
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    lbTenTaiKhoan.Text = "[" + reader.GetString(0) + "] " + reader.GetString(2);
                    lbLoaiTK.Text = reader.GetString(7);
                    Ten = reader.GetString(2);
                    MaTk = reader.GetString(0);
                    QuyenHan = reader.GetString(8);
                }

                reader.Close();
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

        public static string LoaiTK = "";
        

        private void btQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            setLabel(frmDangNhap.TenTaiKhoan);
            LoaiTK = lbLoaiTK.Text;

            btQuanLyTaiKhoan.Enabled = false;
            btQuanLyTTGao.Enabled = false;
            btQuanLyBanGao.Enabled = false;
            btQuanLyKhachHang.Enabled = false;
            btBaoCaoThongKe.Enabled = false;

            foreach (char QH in QuyenHan)
            {
                switch (QH)
                {
                    case '1':
                        btQuanLyTaiKhoan.Enabled = true;
                        break;
                    case '2':
                        btQuanLyKhachHang.Enabled = true;
                        break;
                    case '3':
                        btQuanLyTTGao.Enabled = true;
                        break;
                    case '4':
                        btQuanLyBanGao.Enabled = true;
                        break;
                    case '5':
                        btBaoCaoThongKe.Enabled = true;
                        break;
                    default:
                        btQuanLyTaiKhoan.Enabled = false;
                        btQuanLyTTGao.Enabled = false;
                        btQuanLyBanGao.Enabled = false;
                        btQuanLyKhachHang.Enabled = false;
                        btBaoCaoThongKe.Enabled = false;
                        break;
                }
            }



            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDongHo.Text = setTime();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn Đăng Xuất?", "ĐĂNG XUẤT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
                Application.Exit();
            }
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }




    }
}
