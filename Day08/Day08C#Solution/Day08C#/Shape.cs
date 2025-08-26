using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_
{
    abstract class Shape
    {
        public abstract double GetArea();
        public void Display()
        {
            Console.WriteLine("shape");
        }
    }

        class Rectangle : Shape
        {
            private double Dim1;
            private double Dim2;

            public Rectangle(double dim1, double dim2)
            {
                Dim1 = dim1;
                Dim2 = dim2;
            }

            public override double GetArea()
            {
                return Dim1 * Dim2;
            }
        }

            class Circle : Shape
            {
                private double radius;

                public Circle(double r)
                {
                    radius = r;
                }

                public override double GetArea()
                {
                    return Math.PI * radius * radius;
                }
            }


        }
    

    
