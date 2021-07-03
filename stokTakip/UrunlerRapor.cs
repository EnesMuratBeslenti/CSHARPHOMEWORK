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
    public partial class UrunlerRapor : Form
    {
        public UrunlerRapor()
        {
            InitializeComponent();
        }

        private void UrunlerRapor_Load(object sender, EventArgs e)
        {
            try
            {
                axAcroPDF1.LoadFile(arayüz.DosyaYoluGetir() + @"" + pdfYol + ".pdf");
                axAcroPDF1.src = arayüz.DosyaYoluGetir() + @"" + pdfYol + ".pdf";
                axAcroPDF1.printAll();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
    }
}
