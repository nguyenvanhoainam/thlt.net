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
    public partial class hoadonnhap : Form
    {
        HDnhap nhacc = new HDnhap();
        public hoadonnhap()
        {
            InitializeComponent();
            dataGridView1.DataSource = nhacc.GetAll();
            LoadComboBoxData();
        }
        private void LoadComboBoxData()
        {
            // Lấy dữ liệu mã nhà cung cấp và đổ vào ComboBox mancc
            DataTable dtNhaCungCap = nhacc.GetNhaCungCap();
            mancc.DataSource = dtNhaCungCap;
            mancc.DisplayMember = "manhacc";
            mancc.ValueMember = "manhacc";
            mancc.SelectedIndex = -1; // Đặt giá trị mặc định là trống

            // Lấy dữ liệu mã nhân viên và đổ vào ComboBox mnv
            DataTable dtNhanVien = nhacc.GetNhanVien();
            mnv.DataSource = dtNhanVien;
            mnv.DisplayMember = "manv";
            mnv.ValueMember = "manv";
            mnv.SelectedIndex = -1; // Đặt giá trị mặc định là trống

            DataTable dtNguyenLieu = nhacc.GetNguyenLieu();
            manl.DataSource = dtNguyenLieu;
            manl.DisplayMember = "manguyenlieu";
            manl.ValueMember = "manguyenlieu";
            manl.SelectedIndex = -1;
        }

        private void them_Click(object sender, EventArgs e)
        {
            string mahd = hdnhap.Text;
            string macc = mancc.Text;
            DateTime time = dateTimePicker1.Value;
            string nl = manl.Text;
            string gnhap = gianhap.Text;
            string slg = sl.Text;
           
            string nv = mnv.Text;

            // Validate input before creating new Docgia
            if (string.IsNullOrEmpty(mahd) || string.IsNullOrEmpty(macc) 
                || string.IsNullOrEmpty(nl)
                || string.IsNullOrEmpty(gnhap) ||
                string.IsNullOrEmpty(slg) || string.IsNullOrEmpty(nv))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the method to create a new Docgia
            nhacc.Create(mahd,macc,time ,nl , gnhap ,slg, nv);

            // Refresh the DataGridView after the addition
            dataGridView1.DataSource = nhacc.GetAll();

            // Optionally, clear the textboxes after adding
            hdnhap.Clear();
            mancc.SelectedIndex=-1;
            dateTimePicker1.Value = DateTime.Now;
            manl.SelectedIndex = -1; ;
            gianhap.Clear();
            sl.Clear();
            mnv.SelectedIndex = -1;

        }

        private void sua_Click(object sender, EventArgs e)
        {
            string mahd = hdnhap.Text;
            string macc = mancc.Text;
            DateTime time = dateTimePicker1.Value;
            string nl = manl.Text;
            string gnhap = gianhap.Text;
            string slg = sl.Text;

            string nv = mnv.Text;

            // Validate input before creating new Docgia
            if (string.IsNullOrEmpty(mahd) || string.IsNullOrEmpty(macc)
                || string.IsNullOrEmpty(nl)
                || string.IsNullOrEmpty(gnhap) ||
                string.IsNullOrEmpty(slg) || string.IsNullOrEmpty(nv))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the method to update the supplier's information
            nhacc.Update(mahd, macc, time, nl, gnhap, slg, nv);

            // Refresh the DataGridView after the update
            dataGridView1.DataSource = nhacc.GetAll();

            // Optionally, clear the textboxes after updating
            hdnhap.Clear();
            mancc.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            manl.SelectedIndex = -1;
            gianhap.Clear();
            sl.Clear();
            mnv.SelectedIndex = -1;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string mahd = hdnhap.Text;

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
                nhacc.Delete(mahd);

                // Refresh the DataGridView after the deletion
                dataGridView1.DataSource = nhacc.GetAll();

                // Clear the textboxes after deleting
                hdnhap.Clear();
                mancc.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Now;
                manl.SelectedIndex = -1;
                gianhap.Clear();
                sl.Clear();
                mnv.SelectedIndex = -1;
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            timkiemhdnhap tk = new timkiemhdnhap();
            tk.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ dòng chọn vào các TextBox
                hdnhap.Text = row.Cells[0].Value.ToString();
                mancc.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                manl.Text = row.Cells[3].Value.ToString();
                gianhap.Text = row.Cells[4].Value.ToString();
                sl.Text = row.Cells[5].Value.ToString();
                mnv.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
