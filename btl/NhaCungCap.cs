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
    public partial class NhaCungCap : Form
    {
        Nhacc nhacc = new Nhacc();
        public NhaCungCap()
        {
            InitializeComponent();
            dataGridView1.DataSource = nhacc.GetAllNhacc();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnthem_Click(object sender, EventArgs e)
        {  
            string manl = txtmanguyenlieu.Text;
            string ma = txtmanhacc.Text;
            string ten = txttennhacc.Text;
            string tennl= txttennl.Text;
            string diachi = txtdcnhacc.Text;
            string dienthoai = txtsdt.Text;

           
            if (string.IsNullOrEmpty(manl) || string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(tennl) || string.IsNullOrEmpty(ten) ||
                string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(dienthoai))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            nhacc.CreateNhaCungCap(manl,ma, ten,tennl, dienthoai, diachi);

            
            dataGridView1.DataSource = nhacc.GetAllNhacc();

            txtmanguyenlieu.Clear();
            txtmanhacc.Clear();
            txttennhacc.Clear();
            txttennl.Clear();
            txtdcnhacc.Clear();
            txtsdt.Clear();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string manl = txtmanguyenlieu.Text;
            string ma = txtmanhacc.Text;
            string ten = txttennhacc.Text;
            string tennl = txttennl.Text;
            string diachi = txtdcnhacc.Text;
            string dienthoai = txtsdt.Text;


            if (string.IsNullOrEmpty(manl) || string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(tennl) ||
                string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(dienthoai))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            nhacc.UpdateNhaCungCap(manl, ma, ten,tennl, dienthoai, diachi);

            
            dataGridView1.DataSource = nhacc.GetAllNhacc();

            txtmanguyenlieu.Clear();
            txtmanhacc.Clear();
            txttennhacc.Clear();
            txttennl.Clear();
            txtdcnhacc.Clear();
            txtsdt.Clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ma = txtmanguyenlieu.Text;

           
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp để xóa.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                
                nhacc.DeleteNhaCungCap(ma);
                
                dataGridView1.DataSource = nhacc.GetAllNhacc();
                txtmanguyenlieu.Clear();
                txtmanhacc.Clear();
                txttennhacc.Clear();
                txttennl.Clear();
                txtdcnhacc.Clear();
                txtsdt.Clear();
            }

        }

        private void btntk_Click(object sender, EventArgs e)
        {
            FrmTimkiemNhacc tk = new FrmTimkiemNhacc();
            tk.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ dòng chọn vào các TextBox
                txtmanguyenlieu.Text = row.Cells["manguyenlieu"].Value.ToString();
                txtmanhacc.Text = row.Cells["manhacc"].Value.ToString();
                txttennhacc.Text = row.Cells["TenNhaCC"].Value.ToString();
                txttennl.Text = row.Cells["tennguyenlieu"].Value.ToString();
                txtdcnhacc.Text = row.Cells["DiaChi"].Value.ToString();
                txtsdt.Text = row.Cells["SDT"].Value.ToString();
            }
        }
    }
}
