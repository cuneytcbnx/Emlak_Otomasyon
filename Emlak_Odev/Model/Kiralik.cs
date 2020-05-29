using EmlakWinForm.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakWinForm.Model
{
    public class Kiralik : SatisTuru
    {
        public override decimal Ucret
        {
            get
            {
                return AylikUcret * KacAylikKiralanacak;
            }

            set
            {

            }
        }

        public decimal AylikUcret { get; set; }

        public int KacAylikKiralanacak { get; set; }

        public override string ToString()
        {
            return "Kiralik";
        }
    }
}
