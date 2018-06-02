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
using System.Text.RegularExpressions;

namespace QLCHG
{
    public partial class frmQuanLyBanGao : Form
    {
        public frmQuanLyBanGao()
        {
            InitializeComponent();
        }

        Boolean flag = false;
        int x, y;

        private void frmQuanLyBanGao_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmQuanLyBanGao_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmQuanLyBanGao_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chức năng Quản Lý Bán Gạo?", "THOÁT CHỨC NĂNG", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                frmQLCHG frm = new frmQLCHG();
                frm.ShowDialog();
            }
        }

        private void frmQuanLyBanGao_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            LoadGao();
            LoadKH();
            ThemMHD();
            txtNV.Text = frmQLCHG.Ten;
        }

        private void LoadGao()
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            try
            {

                conn.Open();
                string Sql = @"select [MAGAO],
                                   [TENGAO],
                                   [LOAIGAO],
                                   [TRONGLUONGGAO],
                                   [GIANHAP],
                                   [GIABAN] ,
                                   [XUATXU] 
                               from GAO";
                SqlDataAdapter da = new SqlDataAdapter(Sql, conn);
                DataTable dtG = new DataTable();
                da.Fill(dtG);
                cbbTenGao.DataSource = dtG;
                cbbTenGao.DisplayMember = "TENGAO";
                cbbTenGao.ValueMember = "MAGAO";

                cbbTenGao.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbTenGao.AutoCompleteSource = AutoCompleteSource.ListItems;

                cbbTenGao_SelectedIndexChanged(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.ToString());

            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadKH()
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            try
            {

                conn.Open();
                string Sql = @"select [MAKHACHHANG],
                                   [HOTEN],
                                   [NAMSINH],
                                   [GIOITINH],
                                   [SODIENTHOAI],
                                   [DIACHI] ,
                                   [LOAIKHACHHANG] 
                               from KHACHHANG";

                SqlDataAdapter da = new SqlDataAdapter(Sql, conn);
                DataTable dtKH = new DataTable();
                da.Fill(dtKH);
                cbbTKH.DataSource = dtKH;
                cbbTKH.DisplayMember = "HOTEN";
                cbbTKH.ValueMember = "MAKHACHHANG";

                cbbSDT.DataSource = dtKH;
                cbbSDT.DisplayMember = "SODIENTHOAI";
                cbbSDT.ValueMember = "MAKHACHHANG";
                cbbSDT.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbSDT.AutoCompleteSource = AutoCompleteSource.ListItems;

                cbbTKH.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbTKH.AutoCompleteSource = AutoCompleteSource.ListItems;

                cbbTKH_SelectedIndexChanged(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.ToString());

            }
            finally
            {
                conn.Close();
            }

        }

        private void cbbTenGao_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbTenGao.SelectedValue == null)
                return;

            string MAGAO = cbbTenGao.SelectedValue.ToString();
            SqlConnection conn = SQLDatabase.GetDBConnection();
            try
            {

                conn.Open();
                string Sql = @"select [MAGAO],
                                   [TENGAO],
                                   [LOAIGAO],
                                   [TRONGLUONGGAO],
                                   [GIANHAP],
                                   [GIABAN] ,
                                   [XUATXU] 
                               from GAO
                               where MAGAO=@MAGAO";
                SqlCommand cmd = new SqlCommand(Sql, conn);
                cmd.Parameters.AddWithValue("@MAGAO", MAGAO);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtGiaBan.Text = reader["GIABAN"].ToString();
                    txtXuatXu.Text = reader["XUATXU"].ToString();
                    txtTLTon.Text = reader["TRONGLUONGGAO"].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.ToString());

            }
            finally
            {
                conn.Close();
            }
        }

        private void cbbTKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTKH.SelectedValue == null)
                return;

            string MAKHACHHANG = cbbTKH.SelectedValue.ToString();
            SqlConnection conn = SQLDatabase.GetDBConnection();
            try
            {

                conn.Open();
                string Sql = @"select [MAKHACHHANG],
                                   [HOTEN],
                                   [NAMSINH],
                                   [GIOITINH],
                                   [SODIENTHOAI],
                                   [DIACHI] ,
                                   [LOAIKHACHHANG],
                                   [TIENTICHLUY] 
                               from KHACHHANG
                               where MAKHACHHANG=@MAKHACHHANG";
                SqlCommand cmd = new SqlCommand(Sql, conn);
                cmd.Parameters.AddWithValue("@MAKHACHHANG", MAKHACHHANG);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMKH.Text = reader["MAKHACHHANG"].ToString();
                    txtLKH.Text = reader["LOAIKHACHHANG"].ToString();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.ToString());

            }
            finally
            {
                conn.Close();
            }
        }

        private void ThemMHD()
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();
            string Sql = @"select * from HOADON";

            SqlDataAdapter da = new SqlDataAdapter(Sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            string g = "";
            if (dt.Rows.Count <= 0)
            {
                g = "HD1";
            }
            else
            {

                int k;
                g = "HD";
                int max = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] strItems = dt.Rows[i][0].ToString().Split(new char[] { 'D' });
                    k = Convert.ToInt32(strItems[1]);
                    if (k > max) max = k;
                }
                g = g + (max + 1).ToString();
            }
            txtMHD.Text = g;
        }

        private void TinhThanhTien()
        {
            decimal trongluong = 0;
            decimal giaban = 0;
            decimal thanhtien = 0;
            try
            {
                decimal.TryParse(txtTrongLuong.Text, out trongluong);
                decimal.TryParse(txtGiaBan.Text, out giaban);
                thanhtien = trongluong * giaban;
                txtThanhTien.Text = string.Format("{0:0,0}", thanhtien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.ToString());
            }
        }

        private Decimal getTrongLuong()
        {
            Decimal r = 0;
            string data = txtTrongLuong.Text.ToString();
            if (data != "")
                try
                {
                    r = Decimal.Parse(data.ToString());
                }
                catch { }

            return r;
        }

        private bool KiemTraTrongLuong()
        {
            Decimal TrongLuongTon = Decimal.Parse(txtTLTon.Text);
            Decimal TL = this.getTrongLuong();
            if (TL > TrongLuongTon)
            {
                return true;
            }
            return false;
        }

        private void txtTrongLuong_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraTrongLuong())
            {
                MessageBox.Show("Trọng Lượng Mua không được vượt quá Trọng Lượng Tồn của gạo\nVui lòng kiểm tra lại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtTrongLuong.Focus();
            }
            else
            {
                KtCK_VAT();
                TinhThanhTien();
            }
            
        }

        private void txtLKH_TextChanged(object sender, EventArgs e)
        {
            KtCK_VAT();

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtVAT_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void txtTrongLuong_Click(object sender, EventArgs e)
        {
            txtTrongLuong.SelectAll();
        }


        #region===========Hàm Thêm cộng dồn=================================================

        

        private void btThem_Click(object sender, EventArgs e) //them cong don
        {
            KtMaKH();
            try
            {
                
                decimal trongluong = 0;
                decimal.TryParse(txtTrongLuong.Text, out trongluong);
                decimal ton = 0;
                decimal.TryParse(txtTLTon.Text, out ton);
                if (trongluong <= 0)
                {
                    MessageBox.Show("Trọng lượng mua không đúng\nVui lòng kiểm tra lại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTrongLuong.Focus();
                }
                else if (ton < trongluong)
                {
                    MessageBox.Show("Trọng Lượng Mua không được vượt quá Trọng Lượng Tồn của gạo\nVui lòng kiểm tra lại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtTrongLuong.Focus();
                }
                else
                {
                    int RowIndex = KtTonTaiThem(cbbTenGao.Text);

                    decimal giaban = 0;
                    decimal.TryParse(txtGiaBan.Text, out giaban);

                    decimal ThanhTien = decimal.Parse(txtThanhTien.Text.Replace(",", "").Replace(".", ""));

                    string magao = cbbTenGao.SelectedValue.ToString();
                    string tengao = cbbTenGao.Text;
                    string xuatxu = txtXuatXu.Text;

                    if (RowIndex == -1)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dtgvCTHD);
                        row.Cells[0].Value = dtgvCTHD.Rows.Count + 1;
                        row.Cells[1].Value = magao;
                        row.Cells[2].Value = tengao;
                        row.Cells[3].Value = xuatxu;
                        row.Cells[4].Value = trongluong;
                        row.Cells[5].Value = giaban;
                        row.Cells[6].Value = ThanhTien;
                        dtgvCTHD.Rows.Add(row);
                        TinhTongTien();
                    }
                    else
                    {
                        if (MessageBox.Show("Gạo " + cbbTenGao.Text + " đã tồn tại. Bạn có muốn thêm " + txtTrongLuong.Text + " KG không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            foreach (DataGridViewRow row in dtgvCTHD.Rows)
                            {
                                string MG = row.Cells["MaGao"].Value.ToString();
                                if (magao == MG)
                                {
                                    decimal trongluongcu = decimal.Parse(row.Cells["TrongLuong"].Value.ToString());
                                    decimal trongluongmoi = trongluong + trongluongcu;
                                    if (trongluongmoi > ton)
                                    {
                                        MessageBox.Show("Trọng Lượng Mua không được vượt quá Trọng Lượng Tồn của gạo\nVui lòng kiểm tra lại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    }
                                    else
                                    { 
                                        row.Cells["TrongLuong"].Value = trongluongmoi;
                                        row.Cells["ThanhTien"].Value = (trongluong + trongluongcu) * giaban;
                                        TinhTongTien();
                                    }
                                }
                            }
                    }
                }
                KtCK_VAT();
            }
            catch
            {
                MessageBox.Show("Tên gạo không đúng\nVui lòng kiểm tra lại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbTenGao.Focus();
            } 
        }

        private void KtMaKH()
        {
            int TKH = 0;
            SqlConnection conn = SQLDatabase.GetDBConnection();
              conn.Open();
            string Sql = "select count (*) from KHACHHANG where HOTEN=@HoTen and SODIENTHOAI=@SDT";
            SqlCommand cmd = new SqlCommand(Sql, conn);
            cmd.Parameters.AddWithValue("@HoTen",cbbTKH.Text);
            cmd.Parameters.AddWithValue("@SDT",cbbSDT.Text);
            TKH = Convert.ToInt32(cmd.ExecuteScalar());
            if(TKH==0)
            {   
                txtMKH.Text = "KH0";
                cbbSDT.Text = "";
            }
           
        }
             
         private int KtTonTaiThem(string strtengao) //them cong don
         {
             int index = 0;
             foreach(DataGridViewRow row in dtgvCTHD.Rows)
             {
                 string tengao = row.Cells["TENGAO"].Value.ToString();
                 if(strtengao==tengao)
                 {
                   // MessageBox.Show(strtengao + "Đã Tồn Tại  ");
                     return index;
                 }
             }
             return -1;
         }

        #endregion


     

        private bool KtTonTaiSua(string strtengao)
        {
            for (int i = 0; i < dtgvCTHD.Rows.Count; i++)
            {
                if (i == rowIndex) continue;
                string tengao = dtgvCTHD["TENGAO", i].Value.ToString();
                if (strtengao == tengao)
                {
                    MessageBox.Show(strtengao + "Đã Tồn Tại  ");
                    return true;
                }
            }
            return false;
        }

        private int rowIndex = 0;

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dtgvCTHD.Rows.Count < 1) MessageBox.Show("Hóa đơn rỗng không thể xóa\nVui lòng kiểm tra lại hóa đơn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dtgvCTHD.Rows.RemoveAt(rowIndex);
                }
                TinhTongTien();
            }
        }

        private void SuaDoi()
        {
            if (dtgvCTHD.RowCount == 0) MessageBox.Show("Không có loại gạo nào trong hóa đơn\nVui lòng kiểm tra lại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn sửa đổi?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string magao = cbbTenGao.SelectedValue.ToString();
                    string tengao = cbbTenGao.Text;

                    if (KtTonTaiSua(tengao) == true)
                        return;

                    string xuatxu = txtXuatXu.Text;
                    int trongluong = 0;
                    int.TryParse(txtTrongLuong.Text, out trongluong);
                    int giaban = 0;
                    int.TryParse(txtGiaBan.Text, out giaban);
                    decimal ThanhTien = decimal.Parse(txtThanhTien.Text);
                    int ton = 0;
                    int.TryParse(txtTLTon.Text, out ton);

                    if (trongluong <= 0 || ton < trongluong)
                    {
                        MessageBox.Show("Trọng lượng mua không đúng\nVui lòng kiểm tra lại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTrongLuong.Focus();
                    }
                    else
                    {
                        DataGridViewRow row = dtgvCTHD.Rows[rowIndex];
                        row.Cells[1].Value = magao;
                        row.Cells[2].Value = tengao;
                        row.Cells[3].Value = xuatxu;
                        row.Cells[4].Value = trongluong;
                        row.Cells[5].Value = giaban;
                        row.Cells[6].Value = ThanhTien;
                        TinhTongTien();
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SuaDoi();
        }

        private void TinhTongTien()
        {
            decimal sum = 0;
            decimal CK = 0;
            decimal VAT = 0;
            decimal.TryParse(txtCK.Text, out CK);
            decimal.TryParse(txtVAT.Text, out VAT);
            decimal TienCK = 0;
            decimal TienVAT = 0;
            decimal TT = 0;
            
            for (int i = 0; i < dtgvCTHD.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dtgvCTHD["ThanhTien", i].Value);
            }
            txtTongTien.Text = string.Format("{0:0,0}", sum);
            TienCK = (sum / 100) * CK;
            TienVAT = (sum / 100) * VAT;
            TT = sum - TienCK + TienVAT;
            txtTienCK.Text = string.Format("{0:0,0}", TienCK);
            txtTienVAT.Text = string.Format("{0:0,0}", TienVAT);
            txtTT.Text = string.Format("{0:0,0}", TT);
        }

        private void dtgvCTHD_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            btXoa.Enabled = true;
            DataGridViewRow row = dtgvCTHD.Rows[e.RowIndex];
            cbbTenGao.Text = row.Cells["TenGao"].Value.ToString();
            txtTrongLuong.Text = row.Cells["TrongLuong"].Value.ToString();
            txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
        }

        private void KtCK_VAT()
        {
            decimal v0 = 0;
            decimal v1 = 5;
            decimal v2 = 10;
            decimal v3 = 15;
            decimal TLM = 0;
            
            //if(txtLKH.Text=="VIP 0")         
            if(txtLKH.Text=="VIP 1")    txtCK.Text = v1.ToString();
            else if(txtLKH.Text=="VIP 2")    txtCK.Text = v2.ToString();
            else if (txtLKH.Text == "VIP 3") txtCK.Text = v3.ToString();
            else txtCK.Text = v0.ToString();

            for (int i = 0; i < dtgvCTHD.Rows.Count; i++)
            {
                TLM += Convert.ToDecimal(dtgvCTHD["TrongLuong", i].Value);
            }
            if (TLM < 50)
            {
                txtVAT.Text = v0.ToString();
            }
            else if (TLM < 500)
            {
                txtVAT.Text = v1.ToString();
            }
            else if (TLM < 1000)
            {
                txtVAT.Text = v2.ToString();
            }
            else txtVAT.Text = v3.ToString();
        }

        private void txtCK_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void txtTrongLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 44 || e.KeyChar == 46 || e.KeyChar == 8)) e.Handled = true;
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            LoadGao();
            LoadKH();
            ThemMHD();
            dtgvCTHD.Rows.Clear();
            dtgvCTHD.Enabled = true;
            TinhTongTien();
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            cbbTKH.Enabled = true;
            cbbSDT.Enabled = true;
            txtTrongLuong.Text = "";
        }

        private void btInHD_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            try
            {
                conn.Open();
                if (dtgvCTHD.Rows.Count < 1) MessageBox.Show("Hóa đơn rỗng không thể in\nVui lòng thêm gạo vào hóa đơn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {

                    string sql = "SELECT COUNT(*) FROM HOADON WHERE HOADON.MAHOADON = '" + txtMHD.Text.Trim() + "'";
                    SqlCommand command = new SqlCommand(sql, conn);
                    int x = (int)command.ExecuteScalar();
                    if (x == 0)
                    {
                        MessageBox.Show("Hóa đơn đang được in\nVui lòng đợi giây lát", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string Sql1 = "INSERT INTO HOADON(MAHOADON,MATAIKHOAN,MAKHACHHANG,NGAYLAP,TONGTIEN,CHIETKHAU,THUE,TONGTIENGOC) VALUES(@MaHD,@MaTK,@MaKH,@NgaLap,@TongTien,@ChietKhau,@Thue,@TongTG)";
                        SqlCommand cmd1 = new SqlCommand(Sql1, conn);
                        //thêm gtri bảng hóa đơn
                        decimal TongTien = decimal.Parse(txtTT.Text.Replace(".", "").Replace(",", ""));
                        decimal ChietKhau = decimal.Parse(txtTienCK.Text.Replace(".", "").Replace(",", ""));
                        decimal Thue = decimal.Parse(txtTienVAT.Text.Replace(".", "").Replace(",", ""));
                        cmd1.Parameters.AddWithValue("@MaHD", txtMHD.Text.Trim());
                        cmd1.Parameters.AddWithValue("@MaTK", frmQLCHG.MaTk.Trim());
                        cmd1.Parameters.AddWithValue("@MaKH", txtMKH.Text.Trim());
                        cmd1.Parameters.AddWithValue("@NgaLap", dtpNgayLap.Value);
                        cmd1.Parameters.AddWithValue("@TongTien", TongTien.ToString());
                        cmd1.Parameters.AddWithValue("@ChietKhau", ChietKhau.ToString());
                        cmd1.Parameters.AddWithValue("@Thue", Thue.ToString());
                        cmd1.Parameters.AddWithValue("@TongTG", GiaGoc());
                        cmd1.ExecuteNonQuery();

                        string sql2 = "INSERT INTO CTHOADON(MAHOADON,MAGAO,TRONGLUONGMUA,DONGIA,THANHTIEN) VALUES(@MaHD,@MaG,@TLM,@DonGia,@ThanhTien)";

                        //thêm giá trị bảng cthd
                        for (int i = 0; i < dtgvCTHD.Rows.Count; i++)
                        {
                            SqlCommand cmd2 = new SqlCommand(sql2, conn);

                            DataGridViewRow row = dtgvCTHD.Rows[i];

                            cmd2.Parameters.AddWithValue("@MaHD", txtMHD.Text.Trim());
                            cmd2.Parameters.AddWithValue("@MaG", row.Cells["MaGao"].Value);
                            cmd2.Parameters.AddWithValue("@TLM", row.Cells["TrongLuong"].Value);
                            cmd2.Parameters.AddWithValue("@DonGia", row.Cells["Giaban"].Value);
                            cmd2.Parameters.AddWithValue("@ThanhTien", row.Cells["ThanhTien"].Value);
                            cmd2.ExecuteNonQuery();
                        }
                        UpdateTon();
                        if (txtMKH.Text != "KH0")
                        {
                            UpdateVip();
                        }
                        HoaDon();

                        btThem.Enabled = false;
                        btSua.Enabled = false;
                        btXoa.Enabled = false;
                        cbbTKH.Enabled = false;
                        cbbSDT.Enabled = false;
                        dtgvCTHD.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn đang được in\nVui lòng đợi giây lát", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HoaDon();
                        btThem.Enabled = false;
                        btSua.Enabled = false;
                        btXoa.Enabled = false;
                        cbbTKH.Enabled = false;
                        cbbSDT.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.ToString());

            }
            finally
            {
                conn.Close();
            }
        }

        private void UpdateTon()
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            try
            {
                conn.Open();
                string MaGao = "";
                for (int i = 0; i < dtgvCTHD.Rows.Count; i++)
                {
                    MaGao = Convert.ToString(dtgvCTHD["MaGao", i].Value);
                    Double TrongLuongCu = 0;

                    string sql1 = "SELECT * FROM GAO WHERE GAO.MAGAO = '" + MaGao + "'";
                    SqlCommand command1 = new SqlCommand(sql1, conn);
                    SqlDataReader reader = command1.ExecuteReader();
                    while (reader.Read())
                    {
                        TrongLuongCu = reader.GetDouble(3);
                    }
                    reader.Close();
                    
                    Double TrongLuongMua = 0;
                    Double ton = 0;
                    TrongLuongMua = Convert.ToDouble(dtgvCTHD["TrongLuong", i].Value);
                    ton = TrongLuongCu - TrongLuongMua;
                    string sql = "UPDATE GAO SET TRONGLUONGGAO = @TrongLuongGao WHERE MAGAO = @MaGao";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@TrongLuongGao", ton);
                    command.Parameters.AddWithValue("@MaGao", MaGao);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.ToString());

            }
            finally
            {
                conn.Close();
            }

        }

        private void UpdateVip()
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            try
            {
                conn.Open();
                string MaKH = "";
                decimal TienCu = 0;
                decimal TienMoi = 0;
                decimal TienMua = 0;
                decimal.TryParse(txtTT.Text.Replace("," , "").Replace("." , ""), out TienMua);
                MaKH = Convert.ToString(txtMKH.Text);
                string Vip="";

                string Sql1 = "Select TIENTICHLUY From KHACHHANG Where MAKHACHHANG=@MaKH";
                SqlCommand cmd1 = new SqlCommand(Sql1, conn);

                cmd1.Parameters.AddWithValue("@MaKH", MaKH);
                TienCu = Convert.ToDecimal(cmd1.ExecuteScalar());
                TienMoi = TienCu + TienMua;
                if(TienMoi >= 1000000 )
                {
                    Vip = "VIP 1";
                    if (TienMoi >= 5000000)
                    {
                        Vip = "VIP 2";
                        if (TienMoi >= 10000000)
                        {
                            Vip = "VIP 3";
                        }
                    }
                }
                else Vip = "VIP 0";


                string Sql2 = "UPDATE KHACHHANG SET TIENTICHLUY = @TienTL, LOAIKHACHHANG=@LKH WHERE MAKHACHHANG = @MaKH";
                SqlCommand cmd2 = new SqlCommand(Sql2, conn);
                cmd2.Parameters.AddWithValue("@MaKH", MaKH);
                cmd2.Parameters.AddWithValue("@TienTL", TienMoi);
                cmd2.Parameters.AddWithValue("@LKH", Vip);
                cmd2.ExecuteNonQuery();
                
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.ToString());

            }
            finally
            {
                conn.Close();
            }
        }

        private void HoaDon()
        {
            //khởi tạo excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Khởi tại WorkBook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Khởi tạo Worksheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;

            DateTime dt = DateTime.Now;

            //Đổ dữ liệu vào sheet
            worksheet.Cells[1, 1] = "HÓA ĐƠN BÁN GẠO";
            worksheet.Cells[2, 2] = "Nhân Viên Bán Hàng: " + txtNV.Text;
            worksheet.Cells[3, 2] = "Mã Hóa Đơn: " + txtMHD.Text;
            worksheet.Cells[3, 6] = dt.ToString();
            worksheet.Cells[4, 2] = "Khách Hàng: " + cbbTKH.Text;
            worksheet.Cells[5, 2] = "Số Điện Thoại: " + cbbSDT.Text;
            worksheet.Cells[7, 1] = "STT";
            worksheet.Cells[7, 2] = "Mã Gạo";
            worksheet.Cells[7, 3] = "Tên Gạo";
            worksheet.Cells[7, 4] = "Xuất Xứ";
            worksheet.Cells[7, 5] = "Trọng Lượng";
            worksheet.Cells[7, 6] = "Đơn Giá";
            worksheet.Cells[7, 7] = "Thành Tiền";

            for(int i = 0; i < dtgvCTHD.RowCount; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    //worksheet.Cells[i + 8, 1] = i ;
                    worksheet.Cells[i + 8, j + 1] = dtgvCTHD.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 9, 1] = "";
                    worksheet.Cells[i + 10, 1] = "Tổng Tiền:               " + txtTongTien.Text + " VND";
                    worksheet.Cells[i + 11, 1] = "Chiết Khấu (" + txtCK.Text + "%):     " + txtTienCK.Text + " VND";
                    worksheet.Cells[i + 12, 1] = "Thuế VAT (" + txtVAT.Text + "%):      " + txtTienVAT.Text +" VND";
                    worksheet.Cells[i + 13, 1] = "Tổng Thanh Toán:   " + txtTT.Text + " VND";
                    worksheet.Cells[i + 14, 4] = "";
                    worksheet.Cells[i + 15, 4] = "";
                    
                    //Kẻ Bảng
                    worksheet.Range["A7", "G" + (i + 8)].Borders.LineStyle = 1;
                    //Định dạng các  dòng text:
                    worksheet.Range["A7", "A" + (i + 8)].HorizontalAlignment = 3;
                    worksheet.Range["B7", "B" + (i + 8)].HorizontalAlignment = 3;
                    worksheet.Range["E7", "E" + (i + 8)].HorizontalAlignment = 3;
                    worksheet.Range["F7", "F" + (i + 8)].HorizontalAlignment = 3;
                    worksheet.Range["G7", "G" + (i + 8)].HorizontalAlignment = 3;
                }
            }
            //Định dạng trang:
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;
            //Định dạng cột
            worksheet.Range["A1"].ColumnWidth = 5.55;
            worksheet.Range["B1"].ColumnWidth = 10;
            worksheet.Range["C1"].ColumnWidth = 22;
            worksheet.Range["D1"].ColumnWidth = 15;
            worksheet.Range["E1"].ColumnWidth = 16;
            worksheet.Range["F1"].ColumnWidth = 13.35;
            worksheet.Range["G1"].ColumnWidth = 15;
            //Định dạng font
            worksheet.Range["A1", "G100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "G1"].Font.Size = 20;
            worksheet.Range["A2", "G100"].Font.Size = 14;
            worksheet.Range["A1", "G1"].MergeCells = true;
            worksheet.Range["A1", "G1"].Font.Bold = true;
            worksheet.Range["A1", "G7"].Font.Bold = true;
            //Định dạng các  dòng text:
            worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
            worksheet.Range["A6", "G7"].HorizontalAlignment = 3;
        }
        private decimal GiaGoc()
        {   
            decimal Gia = 0;
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();
            foreach (DataGridViewRow row in dtgvCTHD.Rows)
            {   decimal GiaN;
                string KL=row.Cells["TrongLuong"].Value.ToString();
                decimal KLM = Convert.ToDecimal(KL);
                string tengao = row.Cells["MAGAO"].Value.ToString();
                string Sql2 = "SELECT GIANHAP FROM GAO WHERE MAGAO=@MAG ";
                SqlCommand cmd2 = new SqlCommand(Sql2, conn);
                cmd2.Parameters.AddWithValue("@MAG", tengao);
                GiaN=Convert.ToDecimal(cmd2.ExecuteScalar());
                Gia = Gia + GiaN * KLM;
            }
            return Gia;
        }

        private void btTimHoaDon_Click(object sender, EventArgs e)
        {
            frmTimKiemHoaDon frm = new frmTimKiemHoaDon();
            frm.ShowDialog();
        }


       

       

    }
}
