using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakWinForm.View
{
    public partial class Emlakci : UserControl
    {
        public Model.Emlakci Veri { get; set; }

        public Emlakci()
        {
            Veri = new Model.Emlakci();
            InitializeComponent();
        }

        private void textBoxAdi_TextChanged(object sender, EventArgs e)
        {
            Veri.Adi = textBoxAdi.Text;
        }

        private void textBoxSoyadi_TextChanged(object sender, EventArgs e)
        {
            Veri.Soyadi = textBoxSoyadi.Text;
        }

        private void textBoxTelefon_TextChanged(object sender, EventArgs e)
        {
            Veri.Telefon = textBoxTelefon.Text;
        }

        public void Temizle()
        {
            Veri = new Model.Emlakci();
            textBoxAdi.Clear();
            textBoxSoyadi.Clear();
            textBoxTelefon.Clear();
        }
    }
}
