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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        readonly VeriTabani VT = new VeriTabani();
        private void button_girisYap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_kullaniciAdi.Text) || String.IsNullOrEmpty(textBox_sifre.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre alanı boş!");
            }
            else
            {
                if (VT.HesapTablosu.Where(kullanıcıGiris => kullanıcıGiris.k_adi == textBox_kullaniciAdi.Text && kullanıcıGiris.sifre == textBox_sifre.Text).ToList().Count > 0)
                {
                    textBox_kullaniciAdi.Text = "";
                    textBox_sifre.Text = "";
                    Panel p = new Panel();
                    this.Hide();
                    p.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }
            }
        }
    }
}
