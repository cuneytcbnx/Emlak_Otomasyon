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
    public partial class Kiralik : UserControl
    {
        public Model.Kiralik Veri { get; set; }

        public Kiralik()
        {
            Veri = new Model.Kiralik();
            InitializeComponent();
        }

        private void textBoxUcret_TextChanged(object sender, EventArgs e)
        {
            Veri.AylikUcret = Decimal.Parse(textBoxUcret.Text);
        }

        private void textBoxSure_TextChanged(object sender, EventArgs e)
        {
            Veri.KacAylikKiralanacak = Int32.Parse(textBoxSure.Text);
        }
    }
}
