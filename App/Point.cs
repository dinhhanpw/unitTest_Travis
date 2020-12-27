using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    class Point
    {
        public float X { get; set; }
        public float Y { get; set; }

        public double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(this.X - point.X, 2) + Math.Pow(this.Y - point.Y, 2));
        }
    }
}
