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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void câcChứcNăngQuảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
           
        }

        private void hÓAĐƠNNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
