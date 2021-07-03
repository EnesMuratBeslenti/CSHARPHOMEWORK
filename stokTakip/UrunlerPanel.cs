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
    public partial class UrunlerPanel : Form
    {
        readonly VeriTabani VT = new VeriTabani();
        public UrunlerPanel()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            for (int i = 0; i < VT.UrunlerTablosu.ToList().Count; i++)
            {
                ListViewItem deger = new ListViewItem();
                deger.Text = VT.UrunlerTablosu.ToList()[i].urunID.ToString();
                deger.SubItems.Add(VT.UrunlerTablosu.ToList()[i].urunKodu.ToString());
                deger.SubItems.Add(VT.UrunlerTablosu.ToList()[i].urunAdi.ToString());
                deger.SubItems.Add(VT.UrunlerTablosu.ToList()[i].urunDurum.ToString());
                listView1.Items.Add(deger);
            }
        }
        private void button_ekle_Click(object sender, EventArgs e)
        {
            var ekle = new Urunler();
            if (String.IsNullOrEmpty(textBox_urunKodu.Text))
            {
                textBox_urunKodu.Focus();
            }
            else if (String.IsNullOrEmpty(textBox_urunAdi.Text))
            {
                textBox_urunAdi.Focus();
            }
            else if (comboBox_durum.SelectedIndex == -1)
            {
                comboBox_durum.Focus();
            }
            else
            {
                ekle.urunKodu = textBox_urunKodu.Text;
                ekle.urunAdi = textBox_urunAdi.Text;
                ekle.urunDurum = Convert.ToBoolean(comboBox_durum.SelectedIndex);
                VT.UrunlerTablosu.Add(ekle);
                VT.SaveChanges();
                textBox_urunAdi.Clear();
                textBox_urunKodu.Clear();
                comboBox_durum.SelectedIndex = -1;
                listView1.Items.Clear();
                Listele();
            }
        }
        private void button_sil_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_silinecekID.Text))
            {
                textBox_silinecekID.Focus();
            }
            else if (!VT.UrunlerTablosu.Any(o => o.urunID.ToString() == textBox_silinecekID.Text))
            {
                MessageBox.Show("Kayıt veritabanında bulunamadı!");
            }
            else
            {
                Urunler u = VT.UrunlerTablosu.First(x => x.urunID.ToString() == textBox_silinecekID.Text);
                VT.UrunlerTablosu.Remove(u);
                VT.SaveChanges();
                listView1.Items.Clear();
                Listele();
            }
        }
        private void UrunlerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox_silinecekID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_urunKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void button_yenile_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Listele();
        }
    }
}
