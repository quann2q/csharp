using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHG
{
    public partial class frmQuanLyTTGao : Form
    {
        public frmQuanLyTTGao()
        {
            InitializeComponent();
        }

        Boolean flag = false;
        int x, y;

        private void frmQuanLyKho_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmQuanLyKho_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmQuanLyKho_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chức năng Quản Lý Thông Tin Gạo?", "THOÁT CHỨC NĂNG", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                frmQLCHG frm = new frmQLCHG();
                frm.ShowDialog();
            }
        }

        private void frmQuanLyKho_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            cbbTieuChiTimKiem.Text = "Tên Gạo";
            KetNoiSQL.LoadDLQLTTGao(dataViewQLTTG);
            Disable_TTGao();
        }

        private class KetNoiSQL
        {
            static public SqlConnection conn = SQLDatabase.GetDBConnection();
            static public SqlDataAdapter da;
            static public DataSet ds;

            static public void LoadDLQLTTGao(DataGridView dataview)
            {
                conn.Open();
                try
                {
                    
                    string sqlQLTTGao = "SELECT * FROM GAO";
                    SqlCommand command = new SqlCommand(sqlQLTTGao, conn);
                    command.CommandType = CommandType.Text;
                    da = new SqlDataAdapter(command);
                    ds = new DataSet();
                    da.Fill(ds, "GAO");
                    dataview.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("Không lấy được dữ liệu gạo...\nVui lòng thử lại!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void txtNoiDungTimKiem_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = SQLDatabase.GetDBConnection();
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                string str = string.Empty;
                if (cbbTieuChiTimKiem.Text == "Mã Gạo") str = "SELECT * FROM GAO WHERE MAGAO LIKE N'" + "%" + txtNoiDungTimKiem.Text + "%'";
                if (cbbTieuChiTimKiem.Text == "Tên Gạo") str = "SELECT * FROM GAO WHERE TENGAO LIKE N'" + "%" + txtNoiDungTimKiem.Text + "%'";
                if (cbbTieuChiTimKiem.Text == "Loại Gạo") str = "SELECT * FROM GAO WHERE LOAIGAO LIKE N'" + "%" + txtNoiDungTimKiem.Text + "%'";
                if (cbbTieuChiTimKiem.Text == "Giá Nhập") str = "SELECT * FROM GAO WHERE GIANHAP LIKE N'" + "%" + txtNoiDungTimKiem.Text + "%'";
                if (cbbTieuChiTimKiem.Text == "Giá Bán") str = "SELECT * FROM GAO WHERE GIABAN LIKE N'" + "%" + txtNoiDungTimKiem.Text + "%'";
                if (cbbTieuChiTimKiem.Text == "Xuất Xứ") str = "SELECT * FROM GAO WHERE XUATXU LIKE N'" + "%" + txtNoiDungTimKiem.Text + "%'";
                da = new SqlDataAdapter(str, connect);
                dt = new DataTable();
                da.Fill(dt);
                dataViewQLTTG.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Không thể tìm thấy nội dung tìm kiếm\nVui lòng kiểm tra lại!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void Displays()
        {
            Disable_TTGao();
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();

            try
            {
                int CurentIndex = dataViewQLTTG.CurrentCell.RowIndex;
                string MaGao = Convert.ToString(dataViewQLTTG.Rows[CurentIndex].Cells[1].Value.ToString());
                string TenGao = Convert.ToString(dataViewQLTTG.Rows[CurentIndex].Cells[2].Value.ToString());
                string LoaiGao = Convert.ToString(dataViewQLTTG.Rows[CurentIndex].Cells[3].Value.ToString());
                string TrongLuong = Convert.ToString(dataViewQLTTG.Rows[CurentIndex].Cells[4].Value.ToString());
                string GiaNhap = Convert.ToString(dataViewQLTTG.Rows[CurentIndex].Cells[5].Value.ToString());
                string GiaBan = Convert.ToString(dataViewQLTTG.Rows[CurentIndex].Cells[6].Value.ToString());
                string XuatXu = Convert.ToString(dataViewQLTTG.Rows[CurentIndex].Cells[7].Value.ToString());

                txtMaGao.Text = MaGao;
                txtTenGao.Text = TenGao;
                cbbLoaiGao.Text = LoaiGao;
                txtTrongLuong.Text = TrongLuong;
                txtGiaNhap.Text = GiaNhap;
                txtGiaBan.Text = GiaBan;
                txtXuatXu.Text = XuatXu;

            }
            catch
            {
                MessageBox.Show("Không thể lấy được thông tin gạo\nVui lòng thử lại!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }


        private void Enable_TTGao()
        {
            txtMaGao.Enabled = true;
            txtTenGao.Enabled = true;
            cbbLoaiGao.Enabled = true;
            txtTrongLuong.Enabled = true;
            txtGiaNhap.Enabled = true;
            txtGiaBan.Enabled = true;
            txtXuatXu.Enabled = true;
        }

        private void Disable_TTGao()
        {
            txtMaGao.Enabled = false;
            txtTenGao.Enabled = false;
            cbbLoaiGao.Enabled = false;
            txtTrongLuong.Enabled = false;
            txtGiaNhap.Enabled = false;
            txtGiaBan.Enabled = false;
            txtXuatXu.Enabled = false;
        }

        private void EmptyTTGao()
        {
            txtMaGao.Text = "";
            txtTenGao.Text = "";
            cbbLoaiGao.Text = "";
            txtTrongLuong.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtXuatXu.Text = "";
        }

        private void ThemMaGao()
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();
            string Sql = @"select * from GAO";

            SqlDataAdapter da = new SqlDataAdapter(Sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            string g = "";
            int k = 0;
            if (dt.Rows.Count <= 0) g = "MG1";
            else
            {
                g = "MG";
                int max = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] numbers = Regex.Split(dt.Rows[i][0].ToString(), @"\D+");
                    k = Convert.ToInt32(numbers[1]);
                    if (k > max) max = k;
                }
                g = g + (max + 1).ToString();
            }
            txtMaGao.Text = g;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Enable_TTGao();
            btDongY_Them.Visible = true;
            btHuyBo.Visible = true;
            btDongY_Sua.Visible = false;
            EmptyTTGao();
            txtTenGao.Focus();
            ThemMaGao();
        }

        private void dataViewQLTTG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Displays();
            Disable_TTGao();
            btDongY_Sua.Visible = false;
            btDongY_Them.Visible = false;
            btHuyBo.Visible = false;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btDongY_Sua.Visible = true;
            btDongY_Them.Visible = false;
            btHuyBo.Visible = true;
            Enable_TTGao();
            txtMaGao.Enabled = false;
            txtTenGao.Focus();
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            btDongY_Sua.Visible = false;
            btDongY_Them.Visible = false;
            btHuyBo.Visible = false;
            EmptyTTGao();
            Disable_TTGao();
        }

        private void btDongY_Sua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();
            if(txtMaGao.Text == "")
            {
                MessageBox.Show("Cập nhật Thông Tin Gạo không thành công\nVui lòng kiểm tra lại Mã Gạo", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTenGao.Text == "" || cbbLoaiGao.Text == "" || txtTrongLuong.Text == "" || txtGiaNhap.Text == "" || txtGiaBan.Text == "" || txtXuatXu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Double TrongLuong = Double.Parse(txtTrongLuong.Text);
                    string sql1 = "UPDATE GAO SET TENGAO = @TenGao, LOAIGAO = @LoaiGao, TRONGLUONGGAO = @TrongLuongGao, GIANHAP = @GiaNhap, GIABAN = @GiaBan, XUATXU = @XuatXu WHERE MAGAO = @MaGao";
                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    command1.Parameters.AddWithValue("@MaGao", txtMaGao.Text);
                    command1.Parameters.AddWithValue("@TenGao", txtTenGao.Text);
                    command1.Parameters.AddWithValue("@LoaiGao", cbbLoaiGao.Text);
                    command1.Parameters.AddWithValue("@TrongLuongGao", TrongLuong);
                    command1.Parameters.AddWithValue("@GiaNhap", txtGiaNhap.Text);
                    command1.Parameters.AddWithValue("@GiaBan", txtGiaBan.Text);
                    command1.Parameters.AddWithValue("@XuatXu", txtXuatXu.Text);
                    command1.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật Thông Tin Gạo thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KetNoiSQL.LoadDLQLTTGao(dataViewQLTTG);
                }
                catch
                {
                    MessageBox.Show("Cập nhật Thông Tin Gạo không thành công..\nVui lòng kiểm tra lại.", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            
        }

        private int CheckExistence(string Column, string Ex)
        {
            int check = 0;
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();
            try
            {
                string sql1 = "SELECT COUNT(" + Column + ") FROM GAO WHERE " + Column + " = @Str";
                SqlCommand command1 = new SqlCommand(sql1, conn);
                command1.Parameters.AddWithValue("@Str", Ex);
                check = (int)command1.ExecuteScalar();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return check;
        }

        private void ThemMoiGao()
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();

            if(txtMaGao.Text == "")
            {
                MessageBox.Show("Thêm mới Thông Tin Gạo không thành công\nVui lòng nhập thông tin Mã Gạo", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int check = CheckExistence("MAGAO", txtMaGao.Text);

                    //Nhập mới;
                    if (check == 0)
                    {
                        if (txtTenGao.Text == "" || cbbLoaiGao.Text == "" || txtTrongLuong.Text == "" || txtGiaNhap.Text == "" || txtGiaBan.Text == "" || txtXuatXu.Text == "")
                        {
                            MessageBox.Show("Thêm mới Thông Tin Gạo không thành công\nVui lòng nhập đầy đủ thông tin", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string sql2 = "INSERT INTO GAO(MAGAO,TENGAO,LOAIGAO,TRONGLUONGGAO,GIANHAP,GIABAN,XUATXU) VALUES(@MaGao,@TenGao,@LoaiGao,@TrongLuongGao,@GiaNhap,@GiaBan,@XuatXu)";
                            SqlCommand command2 = new SqlCommand(sql2, conn);
                            command2.Parameters.AddWithValue("@MaGao", txtMaGao.Text);
                            command2.Parameters.AddWithValue("@TenGao", txtTenGao.Text);
                            command2.Parameters.AddWithValue("@LoaiGao", cbbLoaiGao.Text);
                            command2.Parameters.AddWithValue("@TrongLuongGao", txtTrongLuong.Text);
                            command2.Parameters.AddWithValue("@GiaNhap", txtGiaNhap.Text);
                            command2.Parameters.AddWithValue("@GiaBan", txtGiaBan.Text);
                            command2.Parameters.AddWithValue("@XuatXu", txtXuatXu.Text);
                            command2.ExecuteNonQuery();
                            MessageBox.Show("Thêm Thông Tin Gạo mới thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KetNoiSQL.LoadDLQLTTGao(dataViewQLTTG);
                        }
                    }
                    //Cập nhật;
                    else
                    {
                        Double tempTrongLuong = 0;
                        string TenGao = "";
                        string sql3 = "SELECT * FROM GAO WHERE GAO.MAGAO = '" + txtMaGao.Text + "'";
                        SqlCommand command3 = new SqlCommand(sql3, conn);
                        SqlDataReader reader = command3.ExecuteReader();
                        while (reader.Read())
                        {
                            TenGao = reader.GetString(1);
                            tempTrongLuong = reader.GetDouble(3);
                        }

                        reader.Close();

                        Double temp = Double.Parse(txtTrongLuong.Text);

                        Double TrongLuong = (tempTrongLuong + temp);

                        //txtXuatXu.Text = TrongLuong;

                        string sql4 = "UPDATE GAO SET TRONGLUONGGAO = @TrongLuongGao WHERE MAGAO = @MaGao";
                        SqlCommand command4 = new SqlCommand(sql4, conn);
                        command4.Parameters.AddWithValue("@MaGao", txtMaGao.Text);
                        command4.Parameters.AddWithValue("@TrongLuongGao", TrongLuong);
                        command4.ExecuteNonQuery();
                        string str = "Gạo '" + TenGao + "' vừa được nhập thêm '" + txtTrongLuong.Text + "' KG";
                        MessageBox.Show(str, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KetNoiSQL.LoadDLQLTTGao(dataViewQLTTG);
                    }
                }
                catch
                {
                    MessageBox.Show("Không thành công\nVui lòng kiểm tra lại", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
                
            }
        }

        private void btDongY_Them_Click(object sender, EventArgs e)
        {
            ThemMoiGao();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            EmptyTTGao();
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();
            try
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa Thông Tin Gạo đã chọn?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int dem = 0;
                    foreach (DataGridViewRow row in dataViewQLTTG.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if ((bool)row.Cells[0].Value == true)
                            {
                                dem++;
                                string MaGao = row.Cells[1].Value.ToString();
                                string sqldelete_QLTTG = "DELETE FROM GAO WHERE MAGAO = @MaGao";
                                SqlCommand command1 = new SqlCommand(sqldelete_QLTTG, conn);
                                command1.Parameters.AddWithValue("@MaGao", MaGao);
                                command1.ExecuteNonQuery();
                            }
                        }
                    }
                    if (dem == 0) MessageBox.Show("Bạn chưa chọn Thông Tin Gạo để xóa!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        string strThongBao = "Xóa " + dem + " Thông Tin Gạo thành công!";
                        MessageBox.Show(strThongBao, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    KetNoiSQL.LoadDLQLTTGao(dataViewQLTTG);
                }
            }
            catch
            {
                MessageBox.Show("Xóa Thông Tin Gạo không thành công\nVui lòng kiểm tra lại", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtMaGao_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();

            try
            {
                if (CheckExistence("MAGAO", txtMaGao.Text) > 0)
                {
                    string sql = "SELECT * FROM GAO WHERE GAO.MAGAO = '" + txtMaGao.Text + "'";
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtTenGao.Text = reader.GetString(1);
                        cbbLoaiGao.Text = reader.GetString(2);
                        txtGiaNhap.Text = reader.GetInt32(4).ToString();
                        txtGiaBan.Text = reader.GetInt32(5).ToString();
                        txtXuatXu.Text = reader.GetString(6);
                    }

                    reader.Close();

                    txtMaGao.Enabled = true;
                    txtTrongLuong.Enabled = true;
                    txtTenGao.Enabled = false;
                    cbbLoaiGao.Enabled = false;
                    txtGiaNhap.Enabled = false;
                    txtGiaBan.Enabled = false;
                    txtXuatXu.Enabled = false;
                }
                else
                {
                    Enable_TTGao();
                    txtTenGao.Text = "";
                    cbbLoaiGao.Text = "";
                    txtTrongLuong.Text = "";
                    txtGiaNhap.Text = "";
                    txtGiaBan.Text = "";
                    txtXuatXu.Text = "";
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void txtTrongLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 44 || e.KeyChar == 8)) e.Handled = true;
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)) e.Handled = true;
        }






    }
}
