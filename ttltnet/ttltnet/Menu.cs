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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cácChứcNăngQuảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMonAn f = new FormMonAn();
            f.Show();
        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien f = new FormNhanVien();
            f.Show();
        }

        private void nHÀCUNGCẤPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap f = new NhaCungCap();
            f.Show();
        }

        private void hÓAĐƠNNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hoadonnhap f = new hoadonnhap();
            f.Show();
        }

        private void hÓAĐƠNBÁNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HDban f = new HDban();
            f.Show();
        }

        private void tÌMKIẾMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tÌMKIẾMMÓNĂNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMonAn f = new SearchMonAn();
            f.Show();
        }

        private void tÌMKIẾMNHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchNhanVien f = new SearchNhanVien();
            f.Show();
        }

        private void tÌMKIẾMNHÀCUNGCẤPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimkiemNhacc f = new FrmTimkiemNhacc();
            f.Show();
        }

        private void tÌMKIẾMHÓAĐƠNNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timkiemhdnhap f = new timkiemhdnhap();
            f.Show();
        }

        private void tÌMKIẾMHÓAĐƠNBÁNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timhdban f = new timhdban();
            f.Show();
        }

        private void tHỐNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongkedoanhthu f = new Thongkedoanhthu();
            f.Show();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kHOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKho f = new FrmKho();
            f.Show();
        }
    }
}
