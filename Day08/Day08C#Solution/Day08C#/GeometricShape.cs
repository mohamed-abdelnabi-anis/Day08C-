using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_
{
    public abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        
        public abstract double CalculateArea();

        public abstract double Perimeter { get; }
    }

    public class Triangle : GeometricShape
    {
        public Triangle(double baseLength, double height)
        {
            Dimension1 = baseLength;
            Dimension2 = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }
               
        public override double Perimeter
        {
            get
            {
                double hypotenuse = Math.Sqrt(Math.Pow(Dimension1, 2) + Math.Pow(Dimension2, 2));
                return Dimension1 + Dimension2 + hypotenuse;
            }
        }
    }

    
    public class Rectangle1 : GeometricShape
    {
        public Rectangle1(double length, double width)
        {
            Dimension1 = length;
            Dimension2 = width;
        }

        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get { return 2 * (Dimension1 + Dimension2); }
        }
    }

}

