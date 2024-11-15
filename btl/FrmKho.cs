using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl
{
    public partial class FrmKho : Form
    {
        public FrmKho()

        {
            Kho Kho = new Kho();
            InitializeComponent();
            LoadComboBoxData();
            dataGridView1.DataSource = Kho.Tinhsoluong();
           
        }
        private void LoadComboBoxData()
        {
            // Tạo đối tượng Kho để kết nối cơ sở dữ liệu
            Kho kho = new Kho();

            // Lấy dữ liệu từ cơ sở dữ liệu (tên nguyên liệu)
            DataTable dt = kho.GetAllKho(); // Hoặc có thể thay thế bằng kho.TimKiemkho("") nếu cần tìm kiếm tất cả

            // Xóa hết các item hiện có trong ComboBox trước khi thêm mới
            cbotennguyenlieu.Items.Clear();

            // Duyệt qua từng dòng trong DataTable và thêm vào ComboBox
            foreach (DataRow row in dt.Rows)
            {
                // Lấy giá trị từ cột tennguyenlieu
                string tenNguyenLieu = row["manguyenlieu"].ToString();

                // Thêm giá trị vào ComboBox
                cbotennguyenlieu.Items.Add(tenNguyenLieu);
            }
        }
       

        private void btntk_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ ComboBox làm từ khóa tìm kiếm
            string keyword = cbotennguyenlieu.Text;

            // Kiểm tra nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword))
            {
                // Tạo đối tượng Kho để gọi hàm tìm kiếm
                Kho kho = new Kho();

                // Sử dụng hàm TimKiemkho trong lớp Kho với từ khóa
                dataGridView1.DataSource = kho.TimKiemkho(keyword);
            }
            else
            {
                // Nếu từ khóa trống, hiển thị tất cả dữ liệu
                Kho kho = new Kho();
                dataGridView1.DataSource = kho.GetAllKho();
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ dòng chọn vào các TextBox
                cbotennguyenlieu.Text = row.Cells["manguyenlieu"].Value.ToString();

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Kho kho = new Kho(); // Tạo một instance của lớp Kho
                kho.updatekho(); // Gọi phương thức updatekho thông qua instance
                MessageBox.Show("Cập nhật kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
