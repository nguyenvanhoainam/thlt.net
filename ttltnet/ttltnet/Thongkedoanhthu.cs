using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
