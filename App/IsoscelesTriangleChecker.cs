using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    class IsoscelesTriangleChecker : BaseTriangleTypeChecker
    {
        public IsoscelesTriangleChecker()
        {
            defaultType = TriangleType.ISOSCELES;
        }
        protected override bool Process(double edge1, double edge2, double edge3)
        {
            return edge2 == edge3 || edge1 == edge2;
        }
    }
}
