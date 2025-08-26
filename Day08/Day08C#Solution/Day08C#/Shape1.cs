using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_
{
    public class Shape1 : IComparable<Shape1>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shape1(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public int CompareTo(Shape1 other)
        {
            if (other == null) return 1;
            return Area.CompareTo(other.Area);
        }

        public override string ToString()
        {
            return $"{Name} with Area = {Area:F2}";
        }
    }
}