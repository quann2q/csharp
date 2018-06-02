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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QLCHG
{
    public partial class frmBaoCaoThongKe : Form
    {
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }

        Boolean flag = false;
        int x, y;

        private void frmBaoCaoThongKe_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmBaoCaoThongKe_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void frmBaoCaoThongKe_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chức năng Báo Cáo Thống Kê?", "THOÁT CHỨC NĂNG", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                frmQLCHG frm = new frmQLCHG();
                frm.ShowDialog();
            }
        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            btxuatfile.Enabled = false;
            datetimebd.Hide();
            datetimekt.Hide();
            lbtu.Hide();
            lbden.Hide();
            label3.Hide();
            label4.Hide();
            txtdoanhthu.Hide();
            txtloinhuan.Hide();
            txtvip1.Hide();
            txtvip2.Hide();
            txtvip3.Hide();
            txtvip0.Hide();
            txttongkh.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            dataviewthongke.ReadOnly = true;
            txtdoanhthu.Enabled = false;
            txtloinhuan.Enabled = false;
            txttongkh.Enabled = false;
            txtvip0.Enabled = false;
            txtvip1.Enabled = false;
            txtvip2.Enabled = false;
            txtvip3.Enabled = false;

            string LoaiTaiKhoan = frmQLCHG.LoaiTK;
            if (LoaiTaiKhoan == "Nhân Viên Kho")
            {
                cbthongke.Items.Add("Báo cáo số lượng tồn");
                cbthongke.Items.Add("Báo cáo gạo sắp hết");

            }
            if (LoaiTaiKhoan == "Nhân Viên Bán Hàng")
            {
                cbthongke.Items.Add("Báo cáo khách hàng");
                cbthongke.Items.Add("Báo cáo doanh thu, lợi nhuận");
            }
            if (LoaiTaiKhoan == "Administrator")
            {
                cbthongke.Items.Add("Báo cáo khách hàng");
                cbthongke.Items.Add("Báo cáo doanh thu, lợi nhuận");
                cbthongke.Items.Add("Báo cáo số lượng tồn");
                cbthongke.Items.Add("Báo cáo gạo sắp hết");
            }

        }


        private void cbthongke_TextChanged(object sender, EventArgs e)
        {
            if (cbthongke.Text == "Báo cáo khách hàng")
            {
                datetimebd.Hide();
                datetimekt.Hide();
                lbtu.Hide();
                lbden.Hide();
            }
            if (cbthongke.Text == "Báo cáo số lượng tồn")
            {
                datetimebd.Hide();
                datetimekt.Hide();
                lbtu.Hide();
                lbden.Hide();
            }
            if (cbthongke.Text == "Báo cáo gạo sắp hết")
            {
                datetimebd.Hide();
                datetimekt.Hide();
                lbtu.Hide();
                lbden.Hide();
            }
            if (cbthongke.Text == "Báo cáo doanh thu, lợi nhuận")
            {
                datetimebd.Show();
                datetimekt.Show();
                lbtu.Show();
                lbden.Show();
            }
        }

        private void exportexcel()
        {
            DateTime dt = DateTime.Now;
            string Name = cbthongke.Text + " (" + dt.Hour + "h" + dt.Minute + "  " + dt.Day + "." + dt.Month + "." + dt.Year + ")";
            string LinkSave = System.Windows.Forms.Application.StartupPath + @"\..\Reports\";
            
            // tạo đối tượng 
            SaveFileDialog fsave = new SaveFileDialog();
            fsave.InitialDirectory = LinkSave;
            fsave.Filter = "(tất cả các tệp)|*.*|(các tệp tin)|*.xlsx";
            fsave.FileName = Name + ".xlsx";
            if (fsave.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) { }
            else
            {
                if (fsave.FileName != "")
                {
                    //khởi tạo excel
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    //Khởi tại WorkBook
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    //Khởi tạo Worksheet
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    app.Visible = false;

                    DateTime time1 = datetimebd.Value;
                    DateTime time2 = datetimekt.Value;
                    string dt1 = time1.ToString("dd/MM/yyyy");
                    string dt2 = time2.ToString("dd/MM/yyyy");

                    //Đổ dữ liệu vào sheet
                    if (cbthongke.Text == "Báo cáo khách hàng")
                    {
                        //worksheet.Range["E4", "E100"].NumberFormat("Text");
                        worksheet.Cells[1, 1] = "BÁO CÁO KHÁCH HÀNG";
                        worksheet.Cells[2, 1] = "Nhân Viên: " + frmQLCHG.Ten;
                        worksheet.Cells[3, 1] = "MãKH";
                        worksheet.Cells[3, 2] = "Họ Và Tên";
                        worksheet.Cells[3, 3] = "Năm Sinh";
                        worksheet.Cells[3, 4] = "Giới Tính";
                        worksheet.Cells[3, 5] = "Số Điện Thoại";
                        worksheet.Cells[3, 6] = "Địa Chỉ";
                        worksheet.Cells[3, 7] = "Loại KH";
                        worksheet.Cells[3, 8] = "Tiền Tích Lũy";

                        for (int i = 0; i < dataviewthongke.RowCount; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {

                                worksheet.Cells[i + 4, j + 1] = dataviewthongke.Rows[i].Cells[j].Value;
                                worksheet.Cells[i + 5, 2] = "VIP 0 = " + txtvip0.Text + "";
                                worksheet.Cells[i + 6, 2] = "VIP 1 = " + txtvip1.Text + "";
                                worksheet.Cells[i + 7, 2] = "VIP 2 = " + txtvip2.Text + "";
                                worksheet.Cells[i + 8, 2] = "VIP 3 = " + txtvip3.Text + "";
                                worksheet.Cells[i + 9, 2] = "Tổng KH = " + txttongkh.Text + "";

                                //Kẻ Bảng
                                worksheet.Range["A3", "H" + (i + 4)].Borders.LineStyle = 1;
                                worksheet.Range["A4", "H" + (i + 4)].Borders.LineStyle = 1;
                                //Định dạng các  dòng text;
                                worksheet.Range["A4", "A" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["B4", "B" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["E4", "E" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["F4", "F" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["G4", "G" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["H4", "H" + (i + 4)].HorizontalAlignment = 3;
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
                        worksheet.Range["A1"].ColumnWidth = 8.57;
                        worksheet.Range["B1"].ColumnWidth = 30;
                        worksheet.Range["C1"].ColumnWidth = 12;
                        worksheet.Range["D1"].ColumnWidth = 11.86;
                        worksheet.Range["E1"].ColumnWidth = 17.57;
                        worksheet.Range["F1"].ColumnWidth = 15;
                        worksheet.Range["G1"].ColumnWidth = 10.57;
                        worksheet.Range["H1"].ColumnWidth = 18;
                        //Định dạng font
                        worksheet.Range["A1", "H100"].Font.Name = "Times New Roman";
                        worksheet.Range["A1", "H1"].Font.Size = 20;
                        worksheet.Range["A2", "H100"].Font.Size = 14;
                        worksheet.Range["A1", "H1"].MergeCells = true;
                        worksheet.Range["A1", "H1"].Font.Bold = true;
                        worksheet.Range["A3", "H3"].Font.Bold = true;
                        //Định dạng các  dòng text:

                        int abc = dataviewthongke.RowCount + 2;
                        string def = "H" + abc;

                        worksheet.Range["A1", "H1"].HorizontalAlignment = 3;
                        worksheet.Range["A3", def].HorizontalAlignment = 3;

                    }

                    if (cbthongke.Text == "Báo cáo doanh thu, lợi nhuận")
                    {
                        worksheet.Cells[1, 1] = "BÁO CÁO DOANH THU, LỢI NHUẬN";
                        worksheet.Cells[2, 1] = "Nhân Viên: " + frmQLCHG.Ten;
                        worksheet.Cells[2, 6] = "Ngày: " + dt1 + " - " + dt2;
                        worksheet.Cells[3, 1] = "MãHĐ";
                        worksheet.Cells[3, 2] = "MãTK";
                        worksheet.Cells[3, 3] = "MãKH";
                        worksheet.Cells[3, 4] = "Ngày lập";
                        worksheet.Cells[3, 5] = "Tổng Tiền";
                        worksheet.Cells[3, 6] = "Chiết Khấu";
                        worksheet.Cells[3, 7] = "Thuế";
                        worksheet.Cells[3, 8] = "Tổng Tiền Gốc";


                        for (int i = 0; i < dataviewthongke.RowCount; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                //worksheet.Cells[i + 8, 1] = i ;
                                worksheet.Cells[i + 4, j + 1] = dataviewthongke.Rows[i].Cells[j].Value;
                                worksheet.Cells[i + 5, 1] = "";
                                worksheet.Cells[i + 6, 1] = "Tổng Doanh Thu :      " + txtdoanhthu.Text + " VND";
                                worksheet.Cells[i + 7, 1] = "Lợi Nhuận :           " + txtloinhuan.Text + " VND";

                                //Kẻ Bảng
                                worksheet.Range["A3", "H" + (i + 4)].Borders.LineStyle = 1;
                                worksheet.Range["A4", "H" + (i + 4)].Borders.LineStyle = 1;
                                //Định dạng các  dòng text;
                                worksheet.Range["A4", "A" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["B4", "B" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["E4", "E" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["F4", "F" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["G4", "G" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["H4", "H" + (i + 4)].HorizontalAlignment = 3;
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
                        worksheet.Range["A1"].ColumnWidth = 8.57;
                        worksheet.Range["B1"].ColumnWidth = 8.57;
                        worksheet.Range["C1"].ColumnWidth = 12;
                        worksheet.Range["D1"].ColumnWidth = 21.29;
                        worksheet.Range["E1"].ColumnWidth = 17.57;
                        worksheet.Range["F1"].ColumnWidth = 15;
                        worksheet.Range["G1"].ColumnWidth = 10.57;
                        worksheet.Range["H1"].ColumnWidth = 18.86;

                        //Định dạng font
                        worksheet.Range["A1", "H100"].Font.Name = "Times New Roman";
                        worksheet.Range["A1", "H1"].Font.Size = 20;
                        worksheet.Range["A2", "H100"].Font.Size = 14;
                        worksheet.Range["A1", "H1"].MergeCells = true;
                        worksheet.Range["A1", "H1"].Font.Bold = true;
                        worksheet.Range["A3", "H3"].Font.Bold = true;
                        //Định dạng các  dòng text:

                        int abc = dataviewthongke.RowCount + 3;
                        string def = "H" + abc;

                        worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
                        worksheet.Range["A3", def].HorizontalAlignment = 3;
                    }

                    if (cbthongke.Text == "Báo cáo số lượng tồn")
                    {
                        worksheet.Cells[1, 1] = "BÁO CÁO SỐ LƯỢNG TỒN";
                        worksheet.Cells[2, 1] = "Nhân Viên: " + frmQLCHG.Ten;
                        worksheet.Cells[3, 1] = "MãG";
                        worksheet.Cells[3, 2] = "TênG";
                        worksheet.Cells[3, 3] = "LoạiG";
                        worksheet.Cells[3, 4] = "TLGao";
                        worksheet.Cells[3, 5] = "Giá Nhập";
                        worksheet.Cells[3, 6] = "Giá Bán";
                        worksheet.Cells[3, 7] = "Xuất Xứ";

                        for (int i = 0; i < dataviewthongke.RowCount; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                //worksheet.Cells[i + 8, 1] = i ;
                                worksheet.Cells[i + 4, j + 1] = dataviewthongke.Rows[i].Cells[j].Value;
                                worksheet.Cells[i + 5, 1] = "";
                                //Kẻ Bảng
                                worksheet.Range["A3", "G" + (i + 4)].Borders.LineStyle = 1;
                                worksheet.Range["A4", "G" + (i + 4)].Borders.LineStyle = 1;
                                //Định dạng các  dòng text:
                                worksheet.Range["A3", "A" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["B3", "B" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["E3", "E" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["F3", "F" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["G3", "G" + (i + 4)].HorizontalAlignment = 3;
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
                        worksheet.Range["A3", "G3"].Font.Bold = true;
                        //Định dạng các  dòng text:
                        int abc = dataviewthongke.RowCount + 3;
                        string def = "G" + abc;

                        worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
                        worksheet.Range["A3", def].HorizontalAlignment = 3;
                    }
                    if (cbthongke.Text == "Báo cáo gạo sắp hết")
                    {
                        worksheet.Cells[1, 1] = "BÁO CÁO SỐ GẠO SẮP HẾT";
                        worksheet.Cells[2, 1] = "Nhân Viên: " + frmQLCHG.Ten;
                        worksheet.Cells[3, 1] = "MãG";
                        worksheet.Cells[3, 2] = "TênG";
                        worksheet.Cells[3, 3] = "LoạiG";
                        worksheet.Cells[3, 4] = "TLGạo";
                        worksheet.Cells[3, 5] = "Giá Nhập";
                        worksheet.Cells[3, 6] = "Giá Bán";
                        worksheet.Cells[3, 7] = "Xuất Xứ";

                        for (int i = 0; i < dataviewthongke.RowCount; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                //worksheet.Cells[i + 8, 1] = i ;
                                worksheet.Cells[i + 4, j + 1] = dataviewthongke.Rows[i].Cells[j].Value;
                                worksheet.Cells[i + 5, 1] = "";
                                //Kẻ Bảng
                                worksheet.Range["A3", "G" + (i + 4)].Borders.LineStyle = 1;
                                worksheet.Range["A4", "G" + (i + 4)].Borders.LineStyle = 1;
                                //Định dạng các  dòng text:
                                worksheet.Range["A3", "A" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["B3", "B" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["E3", "E" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["F3", "F" + (i + 4)].HorizontalAlignment = 3;
                                worksheet.Range["G3", "G" + (i + 4)].HorizontalAlignment = 3;
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
                        worksheet.Range["A3", "G3"].Font.Bold = true;
                        //Định dạng các  dòng text:
                        int abc = dataviewthongke.RowCount + 3;
                        string def = "G" + abc;

                        worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
                        worksheet.Range["A3", def].HorizontalAlignment = 3;
                    }
                    worksheet.SaveAs(fsave.FileName);
                    String Message = "Xuất " + cbthongke.Text + " thành công";
                    MessageBox.Show(Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private object Worksheets(string p)
        {
            throw new NotImplementedException();
        }

        private void btxuatfile_Click(object sender, EventArgs e)
        {
            exportexcel();
        }

        private void btthongke_Click(object sender, EventArgs e)
        {
            btxuatfile.Enabled = true;
            if (cbthongke.Text == "")
                MessageBox.Show("Vui lòng chọn cách thức", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                
                if (cbthongke.Text == "Báo cáo khách hàng")
                {
                    datetimebd.Hide();
                    datetimekt.Hide();
                    lbden.Hide();
                    lbtu.Hide();
                    label3.Hide();
                    label4.Hide();
                    txtdoanhthu.Hide();
                    txtloinhuan.Hide();
                    txtvip1.Show();
                    txtvip2.Show();
                    txtvip3.Show();
                    txtvip0.Show();
                    txttongkh.Show();
                    label5.Show();
                    label9.Show();
                    label6.Show();
                    label7.Show();
                    label8.Show();


                    SqlConnection conn = SQLDatabase.GetDBConnection();
                    conn.Open();
                    SqlDataAdapter da;
                    DataSet ds;
                    da = new SqlDataAdapter("SELECT * FROM KHACHHANG WHERE MAKHACHHANG <> 'KH0'", conn);
                    ds = new DataSet();
                    da.Fill(ds, "KHACHHANG");
                    //(dataviewthongke.Columns["MAKHACHHANG"] as DataGridViewComboBoxColumn).DisplayMember = "Mã Khách Hàng";

                    dataviewthongke.DataSource = ds.Tables[0];
                    dataviewthongke.Columns[0].HeaderText = "Mã Khách Hàng";
                    dataviewthongke.Columns[1].HeaderText = "Họ Và Tên";
                    dataviewthongke.Columns[2].HeaderText = "Năm Sinh";
                    dataviewthongke.Columns[3].HeaderText = "Giới Tính";
                    dataviewthongke.Columns[4].HeaderText = "Số Điện Thoại";
                    dataviewthongke.Columns[5].HeaderText = "Địa Chỉ";
                    dataviewthongke.Columns[6].HeaderText = "Loại Khách Hàng";
                    dataviewthongke.Columns[7].HeaderText = "Tiền Tích Lũy";
                    {
                        string lkh = "VIP 1";
                        string kh = ("SELECT COUNT(*) FROM KHACHHANG WHERE LOAIKHACHHANG = '" + lkh + "' ");
                        SqlCommand cam = new SqlCommand(kh, conn);
                        string khv = Convert.ToString(cam.ExecuteScalar());
                        txtvip1.Text = khv;
                    }

                    {
                        string lkh1 = "VIP 2";
                        string kh1 = ("SELECT COUNT(*) FROM KHACHHANG WHERE LOAIKHACHHANG = '" + lkh1 + "' ");
                        SqlCommand cam1 = new SqlCommand(kh1, conn);
                        string khv1 = Convert.ToString(cam1.ExecuteScalar());
                        txtvip2.Text = khv1;
                    }

                    {
                        string lkh2 = "VIP 3";
                        string kh2 = ("SELECT COUNT(*) FROM KHACHHANG WHERE LOAIKHACHHANG = '" + lkh2 + "' ");
                        SqlCommand cam2 = new SqlCommand(kh2, conn);
                        string khv2 = Convert.ToString(cam2.ExecuteScalar());
                        txtvip3.Text = khv2;
                    }
                    {
                        string lkh3 = "VIP 0";
                        string kh3 = ("SELECT COUNT(*) FROM KHACHHANG WHERE LOAIKHACHHANG = '" + lkh3 + "' ");
                        SqlCommand cam3 = new SqlCommand(kh3, conn);
                        string khv3 = Convert.ToString(cam3.ExecuteScalar());
                        txtvip0.Text = khv3;
                    }

                    {
                        string kh4 = ("SELECT COUNT(LOAIKHACHHANG) FROM KHACHHANG   ");
                        SqlCommand cam4 = new SqlCommand(kh4, conn);
                        string khv4 = Convert.ToString(cam4.ExecuteScalar());
                        txttongkh.Text = khv4;
                    }
                    dataviewthongke.AutoResizeColumns();
                    dataviewthongke.AutoResizeRows(); 
                    conn.Close();
                    
                }

                if (cbthongke.Text == "Báo cáo số lượng tồn")
                {
                    datetimebd.Hide();
                    datetimekt.Hide();
                    lbden.Hide();
                    lbtu.Hide();
                    label3.Hide();
                    label4.Hide();
                    txtdoanhthu.Hide();
                    txtloinhuan.Hide();
                    txtvip1.Hide();
                    txtvip2.Hide();
                    txtvip3.Hide();
                    txtvip0.Hide();
                    txttongkh.Hide();
                    label9.Hide();
                    label8.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();


                    SqlConnection conn = SQLDatabase.GetDBConnection();
                    conn.Open();
                    SqlDataAdapter da;
                    DataSet ds;
                    da = new SqlDataAdapter("SELECT * FROM GAO", conn);
                    ds = new DataSet();
                    da.Fill(ds, "GAO");
                    dataviewthongke.DataSource = ds.Tables[0];
                    dataviewthongke.Columns[0].HeaderText = "Mã Gạo";
                    dataviewthongke.Columns[1].HeaderText = "Tên Gạo";
                    dataviewthongke.Columns[2].HeaderText = "Loại Gạo";
                    dataviewthongke.Columns[3].HeaderText = "Trọng Lượng";
                    dataviewthongke.Columns[4].HeaderText = "Giá Nhập";
                    dataviewthongke.Columns[5].HeaderText = "Giá Bán";
                    dataviewthongke.Columns[6].HeaderText = "Xuất Xứ";
                    dataviewthongke.AutoResizeColumns();
                    dataviewthongke.AutoResizeRows();
                    conn.Close();
                }

                if (cbthongke.Text == "Báo cáo doanh thu, lợi nhuận")
                {
                    datetimebd.Show();
                    datetimekt.Show();
                    lbden.Show();
                    lbtu.Show();
                    label3.Show();
                    label4.Show();
                    txtdoanhthu.Show();
                    txtloinhuan.Show();
                    txtvip1.Hide();
                    txtvip2.Hide();
                    txtvip3.Hide();
                    txtvip0.Hide();
                    txttongkh.Hide();
                    label9.Hide();
                    label8.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    SqlConnection conn = SQLDatabase.GetDBConnection();
                    conn.Open();
                    decimal loinhuan = 0;
                    decimal tongtien = 0;
                    decimal chietkhau = 0;
                    decimal thue = 0;
                    decimal tiennhapgoc = 0;
                    DateTime time1 = datetimekt.Value;
                    DateTime time3 = time1.AddDays(+1);

                    string dt2 = time3.ToString("MM/dd/yyyy");
                    SqlDataAdapter da;
                    DataSet ds;
                    da = new SqlDataAdapter("SELECT * FROM HOADON WHERE NGAYLAP BETWEEN  '" + datetimebd.Value.ToString("MM/dd/yyy") + "' and '" + dt2 + "'; ", conn);
                    ds = new DataSet();
                    da.Fill(ds, "HOADON");
                    dataviewthongke.DataSource = ds.Tables[0];
                    dataviewthongke.Columns[0].HeaderText = "Mã Hóa Đơn";
                    dataviewthongke.Columns[1].HeaderText = "Mã Tài Khoản";
                    dataviewthongke.Columns[2].HeaderText = "Mã Khách Hàng";
                    dataviewthongke.Columns[3].HeaderText = "Ngày Lập";
                    dataviewthongke.Columns[4].HeaderText = "Tổng Tiền";
                    dataviewthongke.Columns[5].HeaderText = "Chiết Khấu";
                    dataviewthongke.Columns[6].HeaderText = "Thuế";
                    dataviewthongke.Columns[7].HeaderText = "Tổng Tiền Gốc";
                    string sqlsv = ("SELECT SUM(TONGTIEN) FROM HOADON WHERE NGAYLAP BETWEEN  '" + datetimebd.Value.ToString("MM/dd/yyyy") + "' and   '" + dt2 + "' ; ");
                    SqlCommand cam = new SqlCommand(sqlsv, conn);

                    string sqlsv1 = ("SELECT SUM(CHIETKHAU) FROM HOADON WHERE NGAYLAP BETWEEN '" + datetimebd.Value.ToString("MM/dd/yyyy") + "' and  '" + dt2 + "' ; ");
                    SqlCommand cam1 = new SqlCommand(sqlsv1, conn);

                    string sqlsv2 = ("SELECT SUM(THUE) FROM HOADON WHERE NGAYLAP BETWEEN '" + datetimebd.Value.ToString("MM/dd/yyyy") + "' and  '" + dt2 + "' ; ");
                    SqlCommand cam2 = new SqlCommand(sqlsv2, conn);

                    string sqlsv3 = ("SELECT SUM(TONGTIENGOC) FROM HOADON WHERE NGAYLAP BETWEEN '" + datetimebd.Value.ToString("MM/dd/yyyy") + "' and '" + dt2 + "' ");
                    SqlCommand cam3 = new SqlCommand(sqlsv3, conn);
                    if (cam3.ExecuteScalar() != DBNull.Value && cam.ExecuteScalar() != DBNull.Value && cam2.ExecuteScalar() != DBNull.Value && cam1.ExecuteScalar() != DBNull.Value)
                    {
                        tiennhapgoc = Convert.ToDecimal(cam3.ExecuteScalar());
                        tongtien = Convert.ToDecimal(cam.ExecuteScalar());
                        thue = Convert.ToDecimal(cam2.ExecuteScalar());
                        chietkhau = Convert.ToDecimal(cam1.ExecuteScalar());
                    }
                    loinhuan = tongtien - tiennhapgoc - thue;
                     string loinhuana = Convert.ToString(loinhuan);
                     string tongtiena = Convert.ToString(tongtien);
                    // txtloinhuan.Text = loinhuana;
                    txtloinhuan.Text = string.Format("{0:0,0}", loinhuan);
                    // txtdoanhthu.Text = tongtiena;
                    txtdoanhthu.Text = string.Format("{0:0,0}", tongtien);

                    dataviewthongke.AutoResizeColumns();
                    dataviewthongke.AutoResizeRows();
                    conn.Close();
                }
                if (cbthongke.Text == "Báo cáo gạo sắp hết")
                {
                    datetimebd.Hide();
                    datetimekt.Hide();
                    lbtu.Hide();
                    lbden.Hide();
                    label3.Hide();
                    label4.Hide();
                    txtdoanhthu.Hide();
                    txtloinhuan.Hide();
                    txtvip1.Hide();
                    txtvip2.Hide();
                    txtvip3.Hide();
                    txtvip0.Hide();
                    txttongkh.Hide();
                    label9.Hide();
                    label8.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    SqlConnection conn = SQLDatabase.GetDBConnection();
                    conn.Open();
                    SqlDataAdapter da;
                    DataSet ds;
                    da = new SqlDataAdapter("SELECT * FROM GAO WHERE TRONGLUONGGAO < 400", conn);
                    ds = new DataSet();
                    da.Fill(ds, "GAO");
                    dataviewthongke.DataSource = ds.Tables[0];
                    dataviewthongke.DataSource = ds.Tables[0];
                    dataviewthongke.Columns[0].HeaderText = "Mã Gạo";
                    dataviewthongke.Columns[1].HeaderText = "Tên Gạo";
                    dataviewthongke.Columns[2].HeaderText = "Loại Gạo";
                    dataviewthongke.Columns[3].HeaderText = "Trọng Lượng";
                    dataviewthongke.Columns[4].HeaderText = "Giá Nhập";
                    dataviewthongke.Columns[5].HeaderText = "Giá Bán";
                    dataviewthongke.Columns[6].HeaderText = "Xuất Xứ";
                    dataviewthongke.AutoResizeColumns();
                    dataviewthongke.AutoResizeRows();
                }
            }

        }
    }
}
       

      
   