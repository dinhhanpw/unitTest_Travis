using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    partial class NormalTriangleChecker : BaseTriangleTypeChecker
    {
        public NormalTriangleChecker()
        {
            defaultType = TriangleType.NORMAL;
        }

        protected override bool Process(double edge1, double egde2, double edge3)
        {
            return true;
        }

        public override TriangleType Check(double edge1, double edge2, double edge3)
        {
            return defaultType;
        }
    }
}
