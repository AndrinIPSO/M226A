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

        //Koordinaten in Autoprop
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }

        //Radiuss mit Propfull
        private int _Radius;

        public int Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }


    }
}
