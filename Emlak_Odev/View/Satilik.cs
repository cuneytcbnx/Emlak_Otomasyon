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
    public partial class Satilik : UserControl
    {
        public Model.Satilik Veri { get; set; }

        public Satilik()
        {
            Veri = new Model.Satilik();
            InitializeComponent();
        }

        private void textBoxUcret_TextChanged(object sender, EventArgs e)
        {
            Veri.Ucret = Decimal.Parse(textBoxUcret.Text);
        }
    }
}
