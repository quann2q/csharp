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
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        Boolean flag = false;
        int x, y;

        private void frmQuanLyTaiKhoan_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmQuanLyTaiKhoan_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmQuanLyTaiKhoan_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chức năng Quản Lý Tài Khoản?", "THOÁT CHỨC NĂNG", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                frmQLCHG frm = new frmQLCHG();
                frm.ShowDialog();
            }
        }


        public class KetNoiSQL
        {
            static public SqlConnection conn = SQLDatabase.GetDBConnection();
            static public SqlDataAdapter da;
            static public DataSet ds;

            static public void LoadDLQLTK(DataGridView dataview)
            {
                try
                {
                    
                    conn.Open();
                    //string sqlQLTK = "SELECT MATAIKHOAN, MATKHAU, HOTEN, NAMSINH, SODIENTHOAI, GIOITINH, DIACHI, LOAITAIKHOAN FROM TAIKHOAN";
                    string sqlQLTK = "SELECT * FROM TAIKHOAN";
                    SqlCommand command = new SqlCommand(sqlQLTK, conn);
                    command.CommandType = CommandType.Text;
                    da = new SqlDataAdapter(command);
                    ds = new DataSet();
                    da.Fill(ds, "TAIKHOAN");
                    dataview.DataSource = ds.Tables[0];
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            KetNoiSQL.LoadDLQLTK(dataViewQLTK);
            cbbTimKiemTK.Text = "Tài Khoản";
        }

        private void btThemTK_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan_ThemTK frm = new frmQuanLyTaiKhoan_ThemTK();
            frm.ShowDialog();
            KetNoiSQL.LoadDLQLTK(dataViewQLTK);
        }

        private void btSuaTK_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan_SuaTK frm = new frmQuanLyTaiKhoan_SuaTK();
            
            try
            {
                int CurentIndex = dataViewQLTK.CurrentCell.RowIndex;
                string TaiKhoan = Convert.ToString(dataViewQLTK.Rows[CurentIndex].Cells[1].Value.ToString());
                string MatKhau = Convert.ToString(dataViewQLTK.Rows[CurentIndex].Cells[2].Value.ToString());
                string HoTen = Convert.ToString(dataViewQLTK.Rows[CurentIndex].Cells[3].Value.ToString());
                string NamSinh = Convert.ToString(dataViewQLTK.Rows[CurentIndex].Cells[4].Value.ToString());
                string SoDienThoai = Convert.ToString(dataViewQLTK.Rows[CurentIndex].Cells[5].Value.ToString());
                string GioiTinh = Convert.ToString(dataViewQLTK.Rows[CurentIndex].Cells[6].Value.ToString());
                string DiaChi = Convert.ToString(dataViewQLTK.Rows[CurentIndex].Cells[7].Value.ToString());
                string LoaiTK = Convert.ToString(dataViewQLTK.Rows[CurentIndex].Cells[8].Value.ToString());
                string QuyenHan = Convert.ToString(dataViewQLTK.Rows[CurentIndex].Cells[9].Value.ToString());
                string[] dt0 = NamSinh.Split(new char[] { ' ' });
                string dt1 = dt0[0];

                frm.txtTaiKhoan.Text = TaiKhoan;
                frm.txtMatKhau.Text = MatKhau;
                frm.txtHoTen.Text = HoTen;
                frm.dtNamSinh.Text = dt1;
                frm.txtSoDienThoai.Text = SoDienThoai;
                frm.txtDiaChi.Text = DiaChi;
                frm.cbbLoaiTK.Text = LoaiTK;
                if (GioiTinh == "Nam")
                {
                    frm.rbNam.Checked = true;
                    frm.rbNu.Checked = false;
                }
                else
                {
                    frm.rbNu.Checked = true;
                    frm.rbNam.Checked = false;
                }

                foreach (char QH in QuyenHan)
                {
                    switch (QH)
                    {
                        case '1':
                            frm.cbQLTK.Checked = true;
                            break;
                        case '2':
                            frm.cbQLKH.Checked = true;
                            break;
                        case '3':
                            frm.cbQLTTG.Checked = true;
                            break;
                        case '4':
                            frm.cbQLBG.Checked = true;
                            break;
                        case '5':
                            frm.cbBCTK.Checked = true;
                            break;
                        default:
                            frm.cbQLTK.Checked = false;
                            frm.cbQLKH.Checked = false;
                            frm.cbQLTTG.Checked = false;
                            frm.cbQLBG.Checked = false;
                            frm.cbBCTK.Checked = false;
                            break;
                    }
                }



                frm.ShowDialog();
                KetNoiSQL.LoadDLQLTK(dataViewQLTK);
            }
            catch
            {
                MessageBox.Show("Không có Tài Khoản nào được chọn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btXoaTK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();
            try
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa Tài Khoản đã chọn?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int dem = 0;
                    foreach (DataGridViewRow row in dataViewQLTK.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if ((bool)row.Cells[0].Value == true)
                            {
                                dem++;
                                string MaTaiKhoan = row.Cells[1].Value.ToString();
                                string sqldelete_QLTK = "DELETE FROM TAIKHOAN WHERE MATAIKHOAN = @TaiKhoan";
                                SqlCommand command1 = new SqlCommand(sqldelete_QLTK, conn);
                                command1.Parameters.AddWithValue("@TaiKhoan", MaTaiKhoan);
                                command1.ExecuteNonQuery();
                            }
                        }
                    }
                    
                    if (dem == 0) MessageBox.Show("Bạn chưa chọn Tài Khoản để xóa!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        string strThongBao = "Xóa " + dem + " Tài Khoản thành công!";
                        MessageBox.Show(strThongBao, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    KetNoiSQL.LoadDLQLTK(dataViewQLTK);
                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công\nBạn không thể xóa tài khoản của nhân viên đã có giao dịch", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtTimKiemTK_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = SQLDatabase.GetDBConnection();
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                string str = string.Empty;
                if (cbbTimKiemTK.Text == "Tài Khoản") str = "SELECT * FROM TAIKHOAN WHERE MATAIKHOAN LIKE N'" + "%" + txtTimKiemTK.Text + "%'";
                if (cbbTimKiemTK.Text == "Mật Khẩu") str = "SELECT * FROM TAIKHOAN WHERE MATKHAU LIKE N'" + "%" + txtTimKiemTK.Text + "%'";
                if (cbbTimKiemTK.Text == "Họ Tên") str = "SELECT * FROM TAIKHOAN WHERE HOTEN LIKE N'" + "%" + txtTimKiemTK.Text + "%'";
                if (cbbTimKiemTK.Text == "Năm Sinh") str = "SELECT * FROM TAIKHOAN WHERE NAMSINH LIKE N'" + "%" + txtTimKiemTK.Text + "%'";
                if (cbbTimKiemTK.Text == "Số Điện Thoại") str = "SELECT * FROM TAIKHOAN WHERE SODIENTHOAI LIKE N'" + "%" + txtTimKiemTK.Text + "%'";
                if (cbbTimKiemTK.Text == "Giới Tính") str = "SELECT * FROM TAIKHOAN WHERE GIOITINH LIKE N'" + "%" + txtTimKiemTK.Text + "%'";
                if (cbbTimKiemTK.Text == "Địa Chỉ") str = "SELECT * FROM TAIKHOAN WHERE DIACHI LIKE N'" + "%" + txtTimKiemTK.Text + "%'";
                if (cbbTimKiemTK.Text == "Loại Tài Khoản") str = "SELECT * FROM TAIKHOAN WHERE LOAITAIKHOAN LIKE N'" + "%" + txtTimKiemTK.Text + "%'";
                //da = new SqlDataAdapter("SELECT * FROM DANHBA WHERE EMAIL LIKE N'" + "%" + tbTimKiem.Text + "%'", connect);
                da = new SqlDataAdapter(str, connect);
                dt = new DataTable();
                da.Fill(dt);
                dataViewQLTK.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
        }

        



    }
}
