using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    /// <summary>
    /// Kreisklasse
    /// </summary>
    /// <remarks>
    /// Übung Kreisklasse vom Buch
    /// </remarks>
    public class Circle
    {
        /// <summary>
        /// X Koordinate des Kreises mit Autoprop
        /// </summary>
        public double XCoordinate { get; set; }

        /// <summary>
        /// Y Koordinate des Kreises
        /// </summary>
        public double YCoordinate { get; set; }

        /// <summary>
        /// Radius des Kreises mit Fullprop
        /// </summary>
        private int _Radius;

        public int Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }

        /// <summary>
        /// Konstruktor (ctor)
        /// </summary>
        public Circle()
        {

        }

        /// <summary>
        /// Kreis mit Radius
        /// </summary>
        /// <param name="rad">
        /// Radius
        /// </param>
        public Circle(int rad)
        {
            Radius = rad;
        }

        /// <summary>
        /// Kreis mit Koordinaten
        /// </summary>
        /// <param name="x">
        /// X Koordinate
        /// </param>
        /// <param name="y">
        /// Y Koordinate
        /// </param>
        public Circle(double x, double y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }

        /// <summary>
        /// Kreis mit Koordinate und Radius
        /// </summary>
        /// <param name="x">
        /// X Koordinate
        /// </param>
        /// <param name="y">
        /// Y Koordinate
        /// </param>
        /// <param name="rad">
        /// Radius
        /// </param>
        public Circle(double x, double y, int rad)
        {
            XCoordinate = x;
            YCoordinate = y;
            Radius = rad;
        }

        /// <summary>
        /// Fläche wird berechnet
        /// </summary>
        /// <returns>
        /// Fläche
        /// </returns>
        public double getArea()
        {
            double Area = Math.Pow(Radius, 2) * Math.PI;
            return Area;
        }

        /// <summary>
        /// Umfang berechnen
        /// </summary>
        /// <returns>
        /// Umfang
        /// </returns>
        public double getCircumference()
        {
            return Radius * 2 * Math.PI;
        }

    }
}
