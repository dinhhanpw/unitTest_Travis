using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    partial class NoneTypeChecker : BaseTriangleTypeChecker
    {
        public NoneTypeChecker()
        {
            defaultType = TriangleType.NONE;
        }
        protected override bool Process(double edge1, double edge2, double edge3)
        {
            return edge2 + edge3 <= edge1;
        }

        public override TriangleType Check(double edge1, double edge2, double edge3)
        {
            SortThreeEdge(ref edge1, ref edge2, ref edge3);

            if (Process(edge1, edge2, edge3))
                return defaultType;

            return NextChecker.Check(edge1, edge2, edge3);
        }
    }
}
