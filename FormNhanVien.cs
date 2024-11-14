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
    public partial class FormNhanVien : Form
    {
        private DataAccessLayer dal;
        public FormNhanVien()
        {
            InitializeComponent();
            dal = new DataAccessLayer();
            LoadNhanVien();
        }
        private void LoadNhanVien()


        {
            dataGridView1.DataSource = dal.GetAllNhanVien();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            dal.ThemNhanVien(txt_manv.Text, txt_hoten.Text, txt_cv.Text, txt_sdt.Text, cb_gt.SelectedItem.ToString(), txt_dc.Text);
            LoadNhanVien();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            dal.SuaNhanVien(txt_manv.Text, txt_hoten.Text, txt_cv.Text, txt_sdt.Text, cb_gt.SelectedItem.ToString(), txt_dc.Text);
            LoadNhanVien();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string manv = txt_manv.Text;

            LoadNhanVien();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            if (i >= 0)
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dataGridView1.Rows[i];
                txt_manv.Text = r.Cells[0].Value.ToString();
                txt_hoten.Text = r.Cells[1].Value.ToString();
                txt_cv.Text = r.Cells[2].Value.ToString();
                txt_sdt.Text = r.Cells[3].Value.ToString();
                cb_gt.Text = r.Cells[4].Value.ToString();
                txt_dc.Text = r.Cells[5].Value.ToString();
            }
        }
    }
}
