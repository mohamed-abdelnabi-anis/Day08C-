using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_
{
    interface IShapeSeries
    {
        double CurrentShapeArea { get; set; }
        void GetNextArea();
        void ResetSeries();
    }

    class SquareSeries : IShapeSeries
    {
        private int side;
        public double CurrentShapeArea { get; set; }

        public SquareSeries()
        {
            side = 0;
            CurrentShapeArea = 0;
        }

        public void GetNextArea()
        {
            side++;
            CurrentShapeArea = side * side;
        }

        public void ResetSeries()
        {
            side = 0;
            CurrentShapeArea = 0;
        }
    }

    class CircleSeries : IShapeSeries
    {
        private int radius;
        public double CurrentShapeArea { get; set; }

        public CircleSeries()
        {
            radius = 0;
            CurrentShapeArea = 0;
        }

        public void GetNextArea()
        {
            radius++;
            CurrentShapeArea = Math.PI * radius * radius;
        }

        public void ResetSeries()
        {
            radius = 0;
            CurrentShapeArea = 0;
        }
    }
}