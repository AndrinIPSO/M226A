using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    /// <summary>
    /// Mathematik
    /// </summary>
    public static class Mathematik
    {
        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="a">Wert1</param>
        /// <param name="b">Wert2</param>
        /// <returns>resulatat</returns>
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtraktion
        /// </summary>
        /// <param name="a">Wert 1</param>
        /// <param name="b">Wert 2</param>
        /// <returns>result</returns>
        public static int Subtraktion(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplikation
        /// </summary>
        /// <param name="a">Wert 1</param>
        /// <param name="b">Wert 2</param>
        /// <returns>result</returns>
        public static int Multiplikation(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Division
        /// </summary>
        /// <param name="a">wert1</param>
        /// <param name="b">wert2</param>
        /// <returns>result</returns>
        public static int Division(int a, int b)
        {
            if (a % b > 0)
                throw new Exception("Rückgabe kein Integer");
            else
                return a / b;
        }

        /// <summary>
        /// Modulo
        /// </summary>
        /// <param name="a">Wert 1</param>
        /// <param name="b">Wert 2</param>
        /// <returns>rest</returns>
        public static int Modulo(int a, int b)
        {
            return a % b;
        }
    }
}
