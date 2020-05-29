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
    public partial class Arsa : UserControl
    {
        public Model.Arsa Veri { get; private set; }

        public Arsa()
        {
            Veri = new Model.Arsa();
            InitializeComponent();
        }

        private void textBoxMetrekare_TextChanged(object sender, EventArgs e)
        {
            Veri.Metrekare = Int32.Parse(textBoxMetrekare.Text);
        }
    }
}
