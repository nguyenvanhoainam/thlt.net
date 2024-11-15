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
    public partial class Form1 : Form
    {
        Nhacc nhacc = new Nhacc();
        public Form1()
        {

            InitializeComponent();
            dataGridView1.DataSource = nhacc.GetAllNhacc();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ma = txtmanhacc.Text;
            string ten = txttennhacc.Text;      
            string diachi = txtdcnhacc.Text;
            string dienthoai = txtsdt.Text;

            // Validate input before creating new Docgia
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten)  ||
                string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(dienthoai))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the method to create a new Docgia
           nhacc.CreateNhaCungCap(ma, ten, dienthoai, diachi);

            // Refresh the DataGridView after the addition
            dataGridView1.DataSource = nhacc.GetAllNhacc();

            // Optionally, clear the textboxes after adding
            txtmanhacc.Clear();
            txttennhacc.Clear();
            txtdcnhacc.Clear();
            txtsdt.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ dòng chọn vào các TextBox
                txtmanhacc.Text = row.Cells["MaNhaCC"].Value.ToString();
                txttennhacc.Text = row.Cells["TenNhaCC"].Value.ToString();
                txttennl.Text = row.Cells["tennguyenlieu"].Value.ToString();
                txtdcnhacc.Text = row.Cells["DiaChi"].Value.ToString();
                txtsdt.Text = row.Cells["SDT"].Value.ToString();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ma = txtmanhacc.Text;
            string ten = txttennhacc.Text;
            string diachi = txtdcnhacc.Text;
            string dienthoai = txtsdt.Text;

            // Validate input before updating the supplier's information
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) ||
                string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(dienthoai))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the method to update the supplier's information
            nhacc.UpdateNhaCungCap(ma, ten, dienthoai, diachi);

            // Refresh the DataGridView after the update
            dataGridView1.DataSource = nhacc.GetAllNhacc();

            // Optionally, clear the textboxes after updating
            txtmanhacc.Clear();
            txttennhacc.Clear();
            txtdcnhacc.Clear();
            txtsdt.Clear();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ma = txtmanhacc.Text;

            // Validate input before deleting the supplier
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng nhập mã nguyên liệu để xóa.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ask for confirmation before deletion
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên liệu này?", "Xác nhận xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                // Call the method to delete the supplier
                nhacc.DeleteNhaCungCap(ma);

                // Refresh the DataGridView after the deletion
                dataGridView1.DataSource = nhacc.GetAllNhacc();

                // Clear the textboxes after deleting
                
                txtmanhacc.Clear();
                txttennhacc.Clear();
                txtdcnhacc.Clear();
                txtsdt.Clear();
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            FrmTimkiemNhacc tk = new FrmTimkiemNhacc();
            tk.Show();
        }
    }
}
