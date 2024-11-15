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
    public partial class timkiemhdnhap : Form
    {
        HDnhap nhacc = new HDnhap();
        public timkiemhdnhap()
        {
            InitializeComponent();
            LoadComboBoxData();
        }
        private void LoadComboBoxData()
        {
            // Lấy dữ liệu mã nhà cung cấp và đổ vào ComboBox mancc
            DataTable dtNhaCungCap = nhacc.GetMaHD();
            txtma.DataSource = dtNhaCungCap;
            txtma.DisplayMember = "mahdnhap";
            txtma.ValueMember = "mahdnhap";
            txtma.SelectedIndex = -1; 
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string keyword = txtma.Text;

            // Kiểm tra nếu ô tìm kiếm trống
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable result;

            
                result = nhacc.TimKiemTheoMa(keyword);
            

            // Hiển thị kết quả tìm kiếm vào DataGridView
            dataGridView1.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
