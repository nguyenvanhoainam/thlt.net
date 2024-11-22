using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace ttltnet
{
    public partial class Thongkedoanhthu : Form
    {
        Thongke nhacc = new Thongke();
        public Thongkedoanhthu()
        {
            InitializeComponent();
            
        }
        
        private void btntinh_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerFrom.Value.Date;
            DateTime endDate = dateTimePickerTo.Value.Date;

            // Kiểm tra nếu người dùng chưa chọn đầy đủ ngày bắt đầu và ngày kết thúc
            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi phương thức tính toán doanh thu và chi phí trong khoảng thời gian đã chọn
            DataTable dt = nhacc.DoanhThu(startDate, endDate);

            // Đặt DataSource của DataGridView là DataTable nhận được
            dataGridView1.DataSource = dt;

            // Thông báo cho người dùng
            MessageBox.Show("Cập nhật doanh thu và chi phí thành công!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo ứng dụng Excel
                Application excelApp = new Application();
                Workbook workbook = excelApp.Workbooks.Add();
                Worksheet worksheet = (Worksheet)workbook.Sheets[1];

                // Xuất tiêu đề cột
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }

                // Xuất dữ liệu hàng
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }

                // Định dạng bảng
                worksheet.Columns.AutoFit();

                // Lưu file Excel
                string filePath = @"F:\thongke.xlsx";
                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show($"Xuất dữ liệu thành công! File được lưu tại: {filePath}", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }
    }
}
