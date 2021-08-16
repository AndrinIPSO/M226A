using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAuto
{
    public class Auto
    {
        public string Marke { get; set; }
        public string Kennzeichen { get; set; }

        public Auto(string Marke, string Kennzeichen)
        {
            this.Marke = Marke;
            this.Kennzeichen = Kennzeichen;
        }


    }
}
