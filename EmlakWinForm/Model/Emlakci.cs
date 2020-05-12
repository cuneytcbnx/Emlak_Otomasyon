using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakWinForm.Model
{
    public class Emlakci
    {
        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Telefon { get; set; }

        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }
    }
}
