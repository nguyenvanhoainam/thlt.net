using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodShop0
{
    public partial class SearchMonAn : Form
    {
        private DataAccessLayer dal;
        public SearchMonAn()
        {
            InitializeComponent();
            dal = new DataAccessLayer();
        }

        private void btntim_Click(object sender, EventArgs e)
        {

            string keyword = txt_timkiem.Text;
            string criteria = "";

            if (rd1.Checked)
            {
                criteria = "MaMon";
            }
            else if (rd2.Checked)
            {
                criteria = "TenMon";
            }
            else if (rd3.Checked)
            {
                criteria = "Gia";
            }

            dataGridView1.DataSource = dal.TimKiemMonAn(keyword, criteria);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
