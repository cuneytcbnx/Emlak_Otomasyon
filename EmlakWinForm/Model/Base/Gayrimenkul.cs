using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakWinForm.Model.Base
{
    public abstract class Gayrimenkul
    {
        public string GayrimenkulTuru 
        {
            get { return this.GetType().Name; }
        }

        public decimal Ucret
        {
            get
            {
                if (SatisTuru == null)
                    return 0;
                return SatisTuru.Ucret;
            }
        }

        public int Metrekare { get; set; }

        public Emlakci Emlakci { get; set; }

        public SatisTuru SatisTuru { get; set; }
    }
}
