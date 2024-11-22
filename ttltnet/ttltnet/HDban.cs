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
    public partial class HDban : Form
    {
        HDBH HD = new HDBH();

        public HDban()
        {
            InitializeComponent();
            dataGridView1.DataSource = HD.GetAll();
            LoadComboBoxData();
        }
        private void LoadComboBoxData()
        {
            // Lấy dữ liệu mã nhà cung cấp và đổ vào ComboBox mancc
            DataTable MonAn = HD.Getmamon();
            cb_mamon.DataSource = MonAn;
            cb_mamon.DisplayMember = "mamon";
            cb_mamon.ValueMember = "mamon";
            cb_mamon.SelectedIndex = -1; // Đặt giá trị mặc định là trống

            // Lấy dữ liệu mã nhân viên và đổ vào ComboBox mnv
            DataTable NhanVien = HD.GetNhanVien();
            cb_manv.DataSource = NhanVien;
            cb_manv.DisplayMember = "manv";
            cb_manv.ValueMember = "manv";
            cb_manv.SelectedIndex = -1; // Đặt giá trị mặc định là trống

            DataTable Nguyenlieu = HD.Getmanguyenlieu();
            cb_manl.DataSource = Nguyenlieu;
            cb_manl.DisplayMember = "manguyenlieu";
            cb_manl.ValueMember = "manguyenlieu";
            cb_manl.SelectedIndex = -1; // Đặt giá trị mặc định là trống

        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            if (i >= 0)
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dataGridView1.Rows[i];
                txt_mahd.Text = r.Cells[0].Value.ToString();
                txt_hoten.Text = r.Cells[1].Value.ToString();
                txt_sdt.Text = r.Cells[2].Value.ToString();
                txt_diachi.Text = r.Cells[3].Value.ToString();
                dt_ngay.Text = r.Cells[4].Value.ToString();
                cb_mamon.Text = r.Cells[5].Value.ToString();
                txt_soluong.Text = r.Cells[6].Value.ToString();
                cb_manv.Text = r.Cells[8].Value.ToString();
                cb_manl.Text = r.Cells[9].Value.ToString();
                txt_slnl.Text = r.Cells[10].Value.ToString();


            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string maHD = txt_mahd.Text;
            string hotenKH = txt_hoten.Text;
            string sdt = txt_sdt.Text;
            string diachi = txt_diachi.Text;
            DateTime ngay = dt_ngay.Value;
            string mmon = cb_mamon.Text;
            string solg = txt_soluong.Text;
            string nv = cb_manv.Text;
            string mnl = cb_manl.Text;
            string slnl = txt_slnl.Text;
            if (string.IsNullOrEmpty(maHD) || string.IsNullOrEmpty(hotenKH)
                 || string.IsNullOrEmpty(sdt)
                 || string.IsNullOrEmpty(diachi) ||
                 string.IsNullOrEmpty(mmon) || string.IsNullOrEmpty(solg) || string.IsNullOrEmpty(nv) || string.IsNullOrEmpty(mnl) || string.IsNullOrEmpty(slnl))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HD.Update(maHD, hotenKH, sdt, diachi, ngay, mmon, solg, nv, mnl, slnl);
            dataGridView1.DataSource = HD.GetAll();

            // Optionally, clear the textboxes after adding
            txt_mahd.Clear();
            txt_hoten.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
            dt_ngay.Value = DateTime.Now;
            cb_mamon.SelectedIndex = -1;
            txt_soluong.Clear();
            cb_manv.SelectedIndex = -1;
            cb_manl.SelectedIndex = -1;
            txt_slnl.Clear();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string mahd = txt_mahd.Text;

            // Validate input before deleting the supplier
            if (string.IsNullOrEmpty(mahd))
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp để xóa.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ask for confirmation before deletion
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                // Call the method to delete the supplier
                HD.Delete(mahd);

                // Refresh the DataGridView after the deletion
                dataGridView1.DataSource = HD.GetAll();

                // Clear the textboxes after deleting
                txt_mahd.Clear();
                txt_hoten.Clear();
                txt_sdt.Clear();
                txt_diachi.Clear();
                dt_ngay.Value = DateTime.Now;
                cb_mamon.SelectedIndex = -1;
                txt_soluong.Clear();
                cb_manv.SelectedIndex = -1;
                cb_manl.SelectedIndex = -1;
                txt_slnl.Clear();
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            string maHD = txt_mahd.Text;
            string hotenKH = txt_hoten.Text;
            string sdt = txt_sdt.Text;
            string diachi = txt_diachi.Text;
            DateTime ngay = dt_ngay.Value;
            string mmon = cb_mamon.Text;
            string solg = txt_soluong.Text;
            string nv = cb_manv.Text;
            string mnl = cb_manl.Text;
            string slnl = txt_slnl.Text;

            // Validate input before creating new Docgia
            if (string.IsNullOrEmpty(maHD) || string.IsNullOrEmpty(hotenKH)
                || string.IsNullOrEmpty(sdt)
                || string.IsNullOrEmpty(diachi) ||
                string.IsNullOrEmpty(mmon) || string.IsNullOrEmpty(solg) || string.IsNullOrEmpty(nv) || string.IsNullOrEmpty(mnl) || string.IsNullOrEmpty(slnl))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HD.Create(maHD, hotenKH, sdt, diachi, ngay, mmon, solg, nv, mnl, slnl);
            dataGridView1.DataSource = HD.GetAll();

            // Optionally, clear the textboxes after adding
            txt_mahd.Clear();
            txt_hoten.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
            dt_ngay.Value = DateTime.Now;
            cb_mamon.SelectedIndex = -1;
            txt_soluong.Clear();
            cb_manv.SelectedIndex = -1;
            cb_manl.SelectedIndex = -1;
            txt_slnl.Clear();
        }

        private void HDban_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
