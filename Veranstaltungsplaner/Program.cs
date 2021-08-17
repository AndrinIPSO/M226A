using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veranstaltungsplaner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanziierung
            Saalplan sPlan = new Saalplan();

            //über Saalplan zu Veranstaltung
            sPlan.Veranstaltung.Name = "C# Party";

            //Spielstätte
            sPlan.Spielstätte.Name = "U01";
            sPlan.Spielstätte.Anschrift = "TelliStreet 4";

            //PLätze adden
            for (int i = 0; i < 20; i++)
            {
                if(i<10)
                sPlan.Plätze.Add(new Platz(1,i+1));
                    else
                        sPlan.Plätze.Add(new Platz(2, (i - 10) + 1));

            }

            //Plätze auslesen
            foreach (Platz platz in sPlan.Plätze)
            {
                Console.WriteLine("Nummer: {0} Reihe: {1}", platz.Nummer, platz.Reihe);
            }

            //Saalplan zu Veranstaltungsplan
            Veranstaltungsplan Veranstaltungsplan1 = new Veranstaltungsplan();
            Veranstaltungsplan1.Saapläne.Add(sPlan);
            Console.ReadKey();
        }
    }
}
