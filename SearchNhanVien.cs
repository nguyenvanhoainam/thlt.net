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
    public partial class SearchNhanVien : Form
    {
        private DataAccessLayer dal;
        public SearchNhanVien()
        {
            InitializeComponent();
            dal = new DataAccessLayer();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string keyword = txt_timkiem.Text;
            string criteria = "";

            // Kiểm tra nút radio được chọn
            if (rd1.Checked)
            {
                criteria = "MaNV";
            }
            else if (rd2.Checked)
            {
                criteria = "TenNV";
            }
            else if (rd3.Checked)
            {
                criteria = "SDT";
            }

            dataGridView1.DataSource = dal.TimKiemNhanVien(keyword, criteria);

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
