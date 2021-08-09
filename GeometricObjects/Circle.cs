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
        //Eigenschaften > Auf public um Sie zu Kapseln
        private double XCoordinate;
        private double YCoordinate;
        private int Radius;

        //Get
        public double getX()
        {
            return XCoordinate;
        }

        public double getY()
        {
            return YCoordinate;
        }

        public double getRad()
        {
            return Radius;
        }

        //set
        public void setX(double position)
        {
            XCoordinate = position;
        }

        public void setY(double position)
        {
            YCoordinate = position;
        }

        public void setRad(int rad)
        {
            Radius = rad;
        }
    }
}
