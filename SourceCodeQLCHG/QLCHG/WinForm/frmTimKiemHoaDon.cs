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
    public partial class frmTimKiemHoaDon : Form
    {
        public frmTimKiemHoaDon()
        {
            InitializeComponent();
        }

        Boolean flag = false;
        int x, y;

        private void frmTimKiemHoaDon_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmTimKiemHoaDon_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmTimKiemHoaDon_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void LoadHD()
        {
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();

            SqlDataAdapter da;

            DataSet ds;
            da = new SqlDataAdapter("SELECT MAHOADON,MATAIKHOAN,HOADON.MAKHACHHANG,KHACHHANG.HOTEN,NGAYLAP,CHIETKHAU,THUE,TONGTIEN FROM HOADON, KHACHHANG WHERE KHACHHANG.MAKHACHHANG = HOADON.MAKHACHHANG", conn);
            ds = new DataSet();
            da.Fill(ds, "HOADON");
            dataviewtkhd.DataSource = ds.Tables[0];
            dataviewtkhd.Columns[0].HeaderText = "MãHĐ";
            dataviewtkhd.Columns[1].HeaderText = "Tài Khoản";
            dataviewtkhd.Columns[2].HeaderText = "MãKH";
            dataviewtkhd.Columns[3].HeaderText = "Tên Khách Hàng";
            dataviewtkhd.Columns[4].HeaderText = "Ngày Lập";
            dataviewtkhd.Columns[5].HeaderText = "Chiết Khấu";
            dataviewtkhd.Columns[6].HeaderText = "Thuế"; 
            dataviewtkhd.Columns[7].HeaderText = "Tổng Tiền";
            dataviewtkhd.Columns[1].Visible = false;

            dataviewtkhd.Columns[0].Width = 80;
            dataviewtkhd.Columns[2].Width = 80;
            dataviewtkhd.Columns[3].Width = 200;
            dataviewtkhd.Columns[4].Width = 150;
            dataviewtkhd.Columns[5].Width = 150;
            dataviewtkhd.Columns[6].Width = 150;
            dataviewtkhd.Columns[5].DefaultCellStyle.Format = "N0";
            dataviewtkhd.Columns[6].DefaultCellStyle.Format = "N0";
            dataviewtkhd.Columns[7].DefaultCellStyle.Format = "N0";
            
            
            conn.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }


        private int rowIndex = 0;

        private void dataviewtkhd_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt;
            string MaTK = "";
            string MaHD = "";
            rowIndex = e.RowIndex;
            DataGridViewRow row = dataviewtkhd.Rows[e.RowIndex];
            MaHD = row.Cells["MAHOADON"].Value.ToString();
            MaTK = row.Cells["MATAIKHOAN"].Value.ToString();
            SqlConnection conn = SQLDatabase.GetDBConnection();
            conn.Open();
            string Sql1 = "Select CTHOADON.MAGAO,TENGAO,XUATXU,TRONGLUONGMUA,DONGIA,THANHTIEN From CTHOADON,GAO Where MAHOADON=@MaHD and CTHOADON.MAGAO=GAO.MAGAO";
            SqlCommand cmd1 = new SqlCommand(Sql1, conn);


            cmd1.Parameters.AddWithValue("@MaHD", MaHD);
            da = new SqlDataAdapter(cmd1);
            dt = new DataTable();

            da.Fill(dt);
            dtgvCTHD.DataSource = dt;
            dtgvCTHD.Columns[4].DefaultCellStyle.Format = "N0";
            dtgvCTHD.Columns[5].DefaultCellStyle.Format = "N0";

            string SqlKH = "Select HOTEN,SODIENTHOAI From KHACHHANG,HOADON Where MAHOADON=@MaHD and HOADON.MAKHACHHANG=KHACHHANG.MAKHACHHANG";
            SqlCommand cmd = new SqlCommand(SqlKH, conn);
            cmd.Parameters.AddWithValue("@MaHD", MaHD);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = row.Cells["MAHOADON"].Value.ToString();
                //txtMKH.Text = row.Cells["MAKHACHHANG"].Value.ToString();
                txtKH.Text = reader["HOTEN"].ToString();
                txtSDT.Text = reader["SODIENTHOAI"].ToString();
                
            }
            reader.Close();
            string SqlNV = "Select HOTEN From TAIKHOAN Where MATAIKHOAN=@MaTK";
            SqlCommand cmd2 = new SqlCommand(SqlNV, conn);
            cmd2.Parameters.AddWithValue("@MaTK", MaTK);
            string ht = Convert.ToString(cmd2.ExecuteScalar());
            txtNV.Text = ht;
            string Thue = "";
            string CK = "";
            string TongT = "";
            
            Thue = row.Cells["THUE"].Value.ToString();
            CK = row.Cells["CHIETKHAU"].Value.ToString();
            TongT = row.Cells["TONGTIEN"].Value.ToString();
            decimal thue = Convert.ToDecimal(Thue);
            decimal ck = Convert.ToDecimal(CK);
            decimal tienTT = Convert.ToDecimal(TongT);
            decimal ThanhToan = tienTT + ck - thue;
            txtVAT.Text = string.Format("{0:0,0}", thue);
            txtCK.Text =  string.Format("{0:0,0}", ck);
            txtTong.Text = string.Format("{0:0,0}", ThanhToan);
            txtTT.Text = string.Format("{0:0,0}", tienTT);
            
            
        }

        private void btInHD_Click(object sender, EventArgs e)
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
            worksheet.Cells[3, 2] = "Mã Hóa Đơn: " + textBox1.Text;
            worksheet.Cells[3, 6] = dt.ToString();
            worksheet.Cells[4, 2] = "Khách Hàng: " + txtKH.Text;
            worksheet.Cells[5, 2] = "Số Điện Thoại: " + txtSDT.Text;
            worksheet.Cells[7, 1] = "STT";
            worksheet.Cells[7, 2] = "Mã Gạo";
            worksheet.Cells[7, 3] = "Tên Gạo";
            worksheet.Cells[7, 4] = "Xuất Xứ";
            worksheet.Cells[7, 5] = "Trọng Lượng";
            worksheet.Cells[7, 6] = "Đơn Giá";
            worksheet.Cells[7, 7] = "Thành Tiền";

            for (int i = 0; i < dtgvCTHD.RowCount; i++)
            {
                worksheet.Cells[i + 8, 1] = i+1;
                for (int j = 0; j < 6; j++)
                {
                    worksheet.Cells[i + 8, j + 2] = dtgvCTHD.Rows[i].Cells[j].Value;

                    worksheet.Cells[i + 9, 1] = "";
                    worksheet.Cells[i + 10, 1] = "Tổng Tiền:   " + txtTong.Text + " VND";
                    worksheet.Cells[i + 11, 1] = "Chiết Khấu:   " + txtCK.Text + " VND";
                    worksheet.Cells[i + 12, 1] = "Thuế VAT:   " + txtVAT.Text + " VND";
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
            worksheet.Range["C1"].ColumnWidth = 20;
            worksheet.Range["D1"].ColumnWidth = 15;
            worksheet.Range["E1"].ColumnWidth = 13;
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

        private void frmTimKiemHoaDon_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            LoadHD();
            cbbTimKiemHD.Text = "Mã Hóa Đơn";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiemHD_TextChanged(object sender, EventArgs e)
        {

            SqlConnection connect = SQLDatabase.GetDBConnection();
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                string str = string.Empty;
                if (cbbTimKiemHD.Text == "Mã Hóa Đơn") str = "SELECT MAHOADON,MATAIKHOAN,HOADON.MAKHACHHANG,KHACHHANG.HOTEN,NGAYLAP,CHIETKHAU,THUE,TONGTIEN FROM HOADON, KHACHHANG WHERE KHACHHANG.MAKHACHHANG = HOADON.MAKHACHHANG AND MAHOADON LIKE N'" + "%" + txtTimKiemHD.Text + "%'";
                if (cbbTimKiemHD.Text == "Mã Khách Hàng") str = "SELECT MAHOADON,MATAIKHOAN,HOADON.MAKHACHHANG,KHACHHANG.HOTEN,NGAYLAP,CHIETKHAU,THUE,TONGTIEN FROM HOADON, KHACHHANG WHERE KHACHHANG.MAKHACHHANG = HOADON.MAKHACHHANG AND HOADON.MAKHACHHANG LIKE N'" + "%" + txtTimKiemHD.Text + "%'";
                if (cbbTimKiemHD.Text == "Tên Khách Hàng") str = "SELECT MAHOADON,MATAIKHOAN,HOADON.MAKHACHHANG,KHACHHANG.HOTEN,NGAYLAP,CHIETKHAU,THUE,TONGTIEN FROM HOADON, KHACHHANG WHERE KHACHHANG.MAKHACHHANG = HOADON.MAKHACHHANG AND KHACHHANG.HOTEN LIKE N'" + "%" + txtTimKiemHD.Text + "%'";
                if (cbbTimKiemHD.Text == "Ngày Lập") str = "SELECT MAHOADON,MATAIKHOAN,HOADON.MAKHACHHANG,KHACHHANG.HOTEN,NGAYLAP,CHIETKHAU,THUE,TONGTIEN FROM HOADON, KHACHHANG WHERE KHACHHANG.MAKHACHHANG = HOADON.MAKHACHHANG AND NGAYLAP LIKE N'" + "%" + txtTimKiemHD.Text + "%'";
                
              
                da = new SqlDataAdapter(str, connect);
                dt = new DataTable();
                da.Fill(dt);
                dataviewtkhd.DataSource = dt;
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

