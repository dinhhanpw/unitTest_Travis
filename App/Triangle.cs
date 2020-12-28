using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public class Triangle
    {
        public Point APoint { get; set; }
        public Point BPoint { get; set; }
        public Point CPoint { get; set; }

        public Triangle(Point a, Point b, Point c)
        {
            this.APoint = a;
            this.BPoint = b;
            this.CPoint = c;
        }

        public double Perimeter()
        {
            Double ab = APoint.Distance(BPoint);
            Double ac = APoint.Distance(CPoint);
            Double bc = APoint.Distance(CPoint);

            return ab + ac + bc;
        }

        public TriangleType GetTriangleType()
        {
            Double ab = APoint.Distance(BPoint);
            Double ac = APoint.Distance(CPoint);
            Double bc = APoint.Distance(CPoint);

            return TriangleTypeCheckerManager.GetChecker().Check(ab, ac, bc);
        }
    }
}
