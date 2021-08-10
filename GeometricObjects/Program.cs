using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle C1 = new Circle();
                Circle C2 = new Circle(12, 13, 10);
                Circle C3 = new Circle(1);
                C1.Move(10, 12, 1);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
            //Console.WriteLine($"Fläche = {C1.getArea()}");
            //Console.WriteLine("Umfang = {0}", C1.getCircumference());

            try
            {
                Debug.Assert(Mathematik.Addition(1, 2) == 3);
                

                
                Mathematik.Addition(1, 2);
                Mathematik.Subtraktion(2, 1);
                Mathematik.Multiplikation(3, 4);
                Mathematik.Division(10, 2);
                Mathematik.Modulo(10, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");

            }
            Console.ReadLine();


        }
    }
}
