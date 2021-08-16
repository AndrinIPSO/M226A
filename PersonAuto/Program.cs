using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Max = new Person("Max", "Mustermann");

            Max.GeburtsDatum = new DateTime(2000,8,16);
            Max.Alter = 21;

            Max.Hauptwohnsitz.Ort = "Zurzach";
            Max.Hauptwohnsitz.Postleitzahl = "8965";
            Max.Hauptwohnsitz.Strasse = "Strassestrass";
            Max.Hauptwohnsitz.Hausnummer = "12b";
            Max.Hauptwohnsitz.Land = "Spreitebach";

            Max.Autos.Add(new Auto("Tesla", "AG 69"));
            Max.Autos.Add(new Auto("GucciCar", "AG 420"));

            Console.WriteLine("---Person---");
            Console.WriteLine("Name: {0}", Max.Nachname);
            Console.WriteLine("VorName: {0}",Max.Vorname);
            Console.WriteLine("Geburi: {0}",Max.GeburtsDatum.ToShortDateString());

            Console.WriteLine();
            Console.WriteLine("---Wohnsitz---");
            Console.WriteLine("Ort: {0}", Max.Hauptwohnsitz.Ort);
            Console.WriteLine("PLZ: {0}", Max.Hauptwohnsitz.Postleitzahl);
            Console.WriteLine("Strasse: {0} {1}", Max.Hauptwohnsitz.Strasse, Max.Hauptwohnsitz.Hausnummer);
            Console.WriteLine("Land: {0}", Max.Hauptwohnsitz.Land);

            Console.WriteLine();
            Console.WriteLine("---Autos({0})---",Max.Autos.Count);
            foreach (Auto auto in Max.Autos)
            {
                Console.WriteLine("Marke: {0}",auto.Marke);
                Console.WriteLine("Kennzeichen: {0}",auto.Kennzeichen);
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
