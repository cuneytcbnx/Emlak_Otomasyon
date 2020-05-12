using EmlakWinForm.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakWinForm.Model
{
    public class Konut : Gayrimenkul
    {
        public int SalonAdeti { get; set; }

        public int OdaAdeti { get; set; }

        public int BalkonAdeti { get; set; }

        public int KatAdeti { get; set; }
    }
}
