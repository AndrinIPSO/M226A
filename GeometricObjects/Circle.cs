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

        //Prop
        public double XCoordinate { get; set; }


        //Propfull
        private double _YCoordinate;

        public double YCoordinate
        {
            get { return _YCoordinate; }
            set { _YCoordinate = value; }
        }

        private int _Radius;

        public int Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }


    }
}
