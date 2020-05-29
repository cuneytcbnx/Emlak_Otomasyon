using EmlakWinForm.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakWinForm.Model
{
    public class Satilik : SatisTuru
    {
        public override decimal Ucret { get; set; }

        public override string ToString()
        {
            return "Satilik";
        }
    }
}
