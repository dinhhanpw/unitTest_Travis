using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public class Point
    {
        public Double X { get; set; }
        public Double Y { get; set; }

        public Point(Double x, Double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(this.X - point.X, 2) + Math.Pow(this.Y - point.Y, 2));
        }
    }
}
