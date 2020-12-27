using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    class Triangle
    {
        public Point APoint { get; set; }
        public Point BPoint { get; set; }
        public Point CPoint { get; set; }

        public double Perimeter()
        {
            Double ab = APoint.Distance(BPoint);
            Double ac = APoint.Distance(CPoint);
            Double bc = APoint.Distance(CPoint);

            return ab + ac + bc;
        }

        public TriangleType GetTriangleType()
        {
            return TriangleType.NONE;
        }
    }
}
