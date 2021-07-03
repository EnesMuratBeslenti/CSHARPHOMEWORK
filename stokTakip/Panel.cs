using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stokTakip
{
    public partial class Panel : Form
    {

        public Panel()
        {
            InitializeComponent();
        }
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunlerPanel up = new UrunlerPanel();
            up.MdiParent = this;
            up.Show();
            up.Dock = DockStyle.Fill;
        }
        private void Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokPanel sp = new StokPanel();
            sp.MdiParent = this;
            sp.Show();
            sp.Dock = DockStyle.Fill;
        }
    }
}
