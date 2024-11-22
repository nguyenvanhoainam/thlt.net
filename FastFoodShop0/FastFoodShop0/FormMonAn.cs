using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodShop0
{
    public partial class FormMonAn : Form
    {
        private DataAccessLayer dal;
        public FormMonAn()
        {
            InitializeComponent();
            dal = new DataAccessLayer();
            LoadMonAn();
        }
        private void LoadMonAn()
        {
            dataGridView1.DataSource = dal.GetAllMonAn();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            dal.ThemMonAn(txt_mamon.Text, txt_tenmon.Text, txt_gia.Text, pictureBox1.Image != null ? ImageToByteArray(pictureBox1.Image) : null);
            LoadMonAn();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            dal.SuaMonAn(txt_mamon.Text, txt_tenmon.Text, txt_gia.Text, pictureBox1.Image != null ? ImageToByteArray(pictureBox1.Image) : null);
            LoadMonAn();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string mamon = txt_mamon.Text;
            dal.XoaMonAn(mamon);
            LoadMonAn();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Chọn ảnh món ăn"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            SearchMonAn f = new SearchMonAn();
            f.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            if (i >= 0)
            {
                DataGridViewRow r = new DataGridViewRow();
                r = dataGridView1.Rows[i];
                txt_mamon.Text = r.Cells[0].Value.ToString();
                txt_tenmon.Text = r.Cells[1].Value.ToString();
                txt_gia.Text = r.Cells[2].Value.ToString();
                if (r.Cells[3].Value != DBNull.Value) // Kiểm tra nếu ảnh không null
                {
                    byte[] imageBytes = (byte[])r.Cells[3].Value; // Lấy dữ liệu nhị phân từ SQL
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms); // Hiển thị ảnh trong PictureBox
                    }
                }
                else
                {
                    MessageBox.Show("Ảnh sản phẩm đang được cải tiến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
