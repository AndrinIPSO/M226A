using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle();
            Circle C2 = new Circle(12, 13, 10);
            C1.Radius = Convert.ToInt32(Console.Read());
            Console.WriteLine($"Fläche = {C1.getArea()}");
            Console.WriteLine("Umfang = {0}", C1.getCircumference());
            Console.ReadLine();
        }
    }
}
