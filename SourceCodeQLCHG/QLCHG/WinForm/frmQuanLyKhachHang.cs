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
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
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
            if (MessageBox.Show("Bạn muốn thoát khỏi chức năng Quản Lý Khách Hàng?", "THOÁT CHỨC NĂNG", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

            static public void LoadDLQLKH(DataGridView dataview)
            {
                try
                {
                    
                    conn.Open();
                    //string sqlQLKH = "SELECT * FROM KHACHHANG WHERE MAKHACHHANG NOT LIKE 'KH0'";
                    string sqlQLKH = "SELECT * FROM KHACHHANG WHERE MAKHACHHANG <> 'KH0'";
                    SqlCommand command = new SqlCommand(sqlQLKH, conn);
                    command.CommandType = CommandType.Text;
                    da = new SqlDataAdapter(command);
                    ds = new DataSet();
                    da.Fill(ds, "KHACHHANG");
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

            KetNoiSQL.LoadDLQLKH(dataViewQLKH);
            cbbTimKiemKH.Text = "Họ Tên";
        }

        private void btThemTK_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang_ThemKH frm = new frmQuanLyKhachHang_ThemKH();
            frm.ShowDialog();
            KetNoiSQL.LoadDLQLKH(dataViewQLKH);
        }

        private void btSuaTK_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang_SuaKH frm = new frmQuanLyKhachHang_SuaKH();
            try
            {
                int CurentIndex = dataViewQLKH.CurrentCell.RowIndex;
                string MaKH = Convert.ToString(dataViewQLKH.Rows[CurentIndex].Cells[1].Value.ToString());
                string HoTen = Convert.ToString(dataViewQLKH.Rows[CurentIndex].Cells[2].Value.ToString());
                string NamSinh = Convert.ToString(dataViewQLKH.Rows[CurentIndex].Cells[3].Value.ToString());
                string GioiTinh = Convert.ToString(dataViewQLKH.Rows[CurentIndex].Cells[4].Value.ToString());
                string SoDienThoai = Convert.ToString(dataViewQLKH.Rows[CurentIndex].Cells[5].Value.ToString());
                string DiaChi = Convert.ToString(dataViewQLKH.Rows[CurentIndex].Cells[6].Value.ToString());
                string[] dt0 = NamSinh.Split(new char[] { ' ' });
                string dt1 = dt0[0];

                frm.txtMaKH.Text = MaKH;
                frm.txtHoTen.Text = HoTen;
                frm.dtNamSinh.Text = dt1;
                frm.txtDiaChi.Text = DiaChi;
                frm.txtSoDienThoai.Text = SoDienThoai;
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

                frm.ShowDialog();
                KetNoiSQL.LoadDLQLKH(dataViewQLKH);
            }
            catch
            {
                MessageBox.Show("Không có Thông Tin Khách Hàng nào được chọn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btXoaTK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();
            try
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa Thông Tin Khách Hàng đã chọn?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int dem = 0;
                    foreach (DataGridViewRow row in dataViewQLKH.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if ((bool)row.Cells[0].Value == true)
                            {
                                dem++;
                                string MaKhachHang = row.Cells[1].Value.ToString();
                                string sqldelete_QLTK = "DELETE FROM KHACHHANG WHERE MAKHACHHANG = @MaKhacHang";
                                SqlCommand command1 = new SqlCommand(sqldelete_QLTK, conn);
                                command1.Parameters.AddWithValue("@MaKhacHang", MaKhachHang);
                                command1.ExecuteNonQuery();
                            }
                        }
                    }

                    if (dem == 0) MessageBox.Show("Bạn chưa chọn Thông Tin Khách Hàng để xóa!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        string strThongBao = "Xóa " + dem + " Thông Tin Khách Hàng thành công!";
                        MessageBox.Show(strThongBao, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    KetNoiSQL.LoadDLQLKH(dataViewQLKH);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa Thông Tin Khách Hàng đã có tiền tích lũy\nVui lòng kiểm tra lại", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (cbbTimKiemKH.Text == "Mã Khách Hàng") str = "SELECT * FROM KHACHHANG WHERE MAKHACHHANG LIKE N'" + "%" + txtTimKiemKH.Text + "%' AND MAKHACHHANG NOT LIKE 'KH0'";
                if (cbbTimKiemKH.Text == "Họ Tên") str = "SELECT * FROM KHACHHANG WHERE HOTEN LIKE N'" + "%" + txtTimKiemKH.Text + "%' AND HOTEN NOT LIKE N'Khách Lẻ'";
                if (cbbTimKiemKH.Text == "Năm Sinh") str = "SELECT * FROM KHACHHANG WHERE NAMSINH LIKE N'" + "%" + txtTimKiemKH.Text + "%'";
                if (cbbTimKiemKH.Text == "Giới Tính") str = "SELECT * FROM KHACHHANG WHERE GIOITINH LIKE N'" + "%" + txtTimKiemKH.Text + "%'";
                if (cbbTimKiemKH.Text == "Số Điện Thoại") str = "SELECT * FROM KHACHHANG WHERE SODIENTHOAI LIKE N'" + "%" + txtTimKiemKH.Text + "%'";
                if (cbbTimKiemKH.Text == "Địa Chỉ") str = "SELECT * FROM KHACHHANG WHERE DIACHI LIKE N'" + "%" + txtTimKiemKH.Text + "%'";
                if (cbbTimKiemKH.Text == "Loại Khách Hàng") str = "SELECT * FROM KHACHHANG WHERE LOAIKHACHHANG LIKE N'" + "%" + txtTimKiemKH.Text + "%'";
                da = new SqlDataAdapter(str, connect);
                dt = new DataTable();
                da.Fill(dt);
                dataViewQLKH.DataSource = dt;
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
