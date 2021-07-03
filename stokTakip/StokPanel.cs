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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace stokTakip
{
    public partial class StokPanel : Form
    {
        public StokPanel()
        {
            InitializeComponent();
        }
        readonly VeriTabani VT = new VeriTabani();
        private void Listele()
        {
            if (VT.StokTablosu.ToList().Count > 0)
            {
                for (int i = 0; i < VT.StokTablosu.ToList().Count; i++)
                {
                    ListViewItem deger = new ListViewItem();
                    deger.Text = VT.StokTablosu.ToList()[i].stokID.ToString();
                    deger.SubItems.Add(VT.StokTablosu.ToList()[i].UrunKodu.ToString());
                    deger.SubItems.Add(VT.StokTablosu.ToList()[i].urunAdi.ToString());
                    deger.SubItems.Add(VT.StokTablosu.ToList()[i].tarih.ToString());
                    deger.SubItems.Add(VT.StokTablosu.ToList()[i].adet.ToString());
                    deger.SubItems.Add(VT.StokTablosu.ToList()[i].urunDurum.ToString());
                    listView1.Items.Add(deger);
                }
                label_urunSayisi_deger.Text = VT.StokTablosu.ToList().Count().ToString();
                var miktar = VT.StokTablosu.Sum(i => i.adet);
                label_adetSayisi_deger.Text = miktar.ToString();
            }
        }
        private void UrunAdiGuncelle()
        {
            string seciliUrun = this.comboBox_urunKodu.GetItemText(this.comboBox_urunKodu.SelectedItem);
            var urunAdiAl = VT.UrunlerTablosu.Where(x => x.urunKodu == seciliUrun).FirstOrDefault();
            textBox_urunAdi.Text = urunAdiAl.urunAdi;
        }
        private void StokPanel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokTakip_urunKodu.Urunler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunlerTableAdapter.Fill(this.stokTakip_urunKodu.Urunler);
            Listele();
            comboBox_urunKodu.SelectedIndex = 0;
            UrunAdiGuncelle();
        }
        private void button_ekle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox_urunKodu.Text))
            {
                comboBox_urunKodu.Focus();
            }
            else if (String.IsNullOrEmpty(textBox_urunAdi.Text))
            {
                textBox_urunAdi.Focus();
            }
            else if (String.IsNullOrEmpty(textBox_adet.Text))
            {
                textBox_adet.Focus();
            }
            else if (String.IsNullOrEmpty(comboBox_durum.Text))
            {
                comboBox_durum.Focus();
            }
            else
            {
                var ekle = new Stok();
                ekle.UrunKodu = this.comboBox_urunKodu.GetItemText(this.comboBox_urunKodu.SelectedItem);
                ekle.urunAdi = textBox_urunAdi.Text;
                ekle.adet = Convert.ToDouble(textBox_adet.Text);
                ekle.tarih = dateTimePicker_tarih.Value;
                ekle.urunDurum = Convert.ToBoolean(comboBox_durum.SelectedIndex);
                VT.StokTablosu.Add(ekle);
                VT.SaveChanges();
                textBox_urunAdi.Clear();
                comboBox_urunKodu.SelectedIndex = -1;
                textBox_adet.Text = "";
                comboBox_durum.SelectedIndex = -1;
                listView1.Items.Clear();
                Listele();
            }
        }
        private void StokPanel_MdiChildActivate(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Listele();
        }
        private void button_sil_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_silinecekID.Text))
            {
                MessageBox.Show("Silinecek ID'yi giriniz!");
            }
            else
            {
                string seciliUrun = textBox_silinecekID.Text;
                if (!VT.StokTablosu.Any(o => o.stokID.ToString() == seciliUrun))
                {
                    MessageBox.Show("Kayıt veritabanında bulunamadı!");
                }
                else
                {
                    Stok s = VT.StokTablosu.First(x => x.stokID.ToString() == seciliUrun);
                    VT.StokTablosu.Remove(s);
                    VT.SaveChanges();
                    listView1.Items.Clear();
                    Listele();
                }
            }
        }
        private void comboBox_urunKodu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UrunAdiGuncelle();
        }
        private void StokPanel_FormClosing(object sender, FormClosingEventArgs e)
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

        private void textBox_adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox_urunKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void button_yenile_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Listele();
            UrunAdiGuncelle();
        }


        struct listviewVerileri
        {
            public int id;
            public string urunKodu;
            public string UrunAdı;
            public string Tarih;
            public string urunDurum;
            public string Adet;
        }
        List<listviewVerileri> veriler = new List<listviewVerileri>();
        private void button_pdf_Click(object sender, EventArgs e)
        {
            var listView1 = new ListView();
            DataTable table = new DataTable();
            foreach (ListViewItem item in listView1.Items)
            {
                table.Columns.Add(item.ToString());
                foreach (var it in item.SubItems)
                    table.Rows.Add(it.ToString());
            }
            /*
            listviewVerileri veri = new listviewVerileri();
            veri.id = Convert.ToInt32(listView1.Items[0].Text);
            veri.urunKodu = listView1.Items[1].Text;
            veri.UrunAdı = listView1.Items[2].Text;
            veri.Tarih = listView1.Items[3].Text;
            veri.urunDurum = listView1.Items[4].Text;
            veri.Adet = listView1.Items[5].Text;
            veriler.Add(veri);
            Console.WriteLine(listView1.Items[0].Text);
            PdfPTable pdfTable = new PdfPTable(listView1.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            */
        }
      
        void ListeVerileriniBas(List<listviewVerileri> liste)
        {

                Console.WriteLine(listView1.Items[1].Text);
            
        }
    }
}
