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
    public partial class Daire : UserControl
    {
        public Model.Daire Veri { get; set; }

        public Daire()
        {
            Veri = new Model.Daire();
            InitializeComponent();
        }

        private void textBoxMetrekare_TextChanged(object sender, EventArgs e)
        {
            Veri.Metrekare = Int32.Parse(textBoxMetrekare.Text);
        }

        private void textBoxSalonAdeti_TextChanged(object sender, EventArgs e)
        {
            Veri.SalonAdeti = Int32.Parse(textBoxSalonAdeti.Text);
        }

        private void textBoxOdaAdeti_TextChanged(object sender, EventArgs e)
        {
            Veri.OdaAdeti = Int32.Parse(textBoxOdaAdeti.Text);
        }

        private void textBoxBalkonAdeti_TextChanged(object sender, EventArgs e)
        {
            Veri.BalkonAdeti = Int32.Parse(textBoxBalkonAdeti.Text);
        }

        private void checkBoxTuvaletVarmi_CheckedChanged(object sender, EventArgs e)
        {
            Veri.TuvaletVarMi = checkBoxTuvaletVarmi.Checked;
        }

        private void checkBoxBanyoVarMi_CheckedChanged(object sender, EventArgs e)
        {
            Veri.BanyoVarMi = checkBoxBanyoVarMi.Checked;
        }
    }
}
