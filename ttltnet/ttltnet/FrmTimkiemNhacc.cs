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
    public partial class FrmTimkiemNhacc : Form
    {
        Nhacc nhacc = new Nhacc();
        public FrmTimkiemNhacc()
        {
            InitializeComponent();
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string keyword = txttk.Text;

            // Kiểm tra nếu ô tìm kiếm trống
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable result;

            
                result = nhacc.TimKiemNhaCungCapTheoMa(keyword);
            

            // Hiển thị kết quả tìm kiếm vào DataGridView
            dataGridView1.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
