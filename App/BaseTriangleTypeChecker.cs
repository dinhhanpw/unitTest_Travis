using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    abstract partial class BaseTriangleTypeChecker
    {
        protected TriangleType defaultType;
        public BaseTriangleTypeChecker NextChecker { get; set; }
        protected void SortThreeEdge(ref double edge1, ref double edge2, ref double edge3)
        {
            double max, mid, min;

            if (edge1 > edge2)
            {
                mid = edge1;
                min = edge2;
            }
            else
            {
                mid = edge2;
                min = edge1;
            }

            if (edge3 > mid)
            {
                max = edge3;
            }
            else
            {
                max = mid;

                if (edge3 > min)
                {
                    mid = edge3;
                }
                else
                {
                    mid = min;
                    min = edge3;
                }
            }

            edge1 = max;
            edge2 = mid;
            edge3 = min;
        }
        protected abstract bool Process(double edge1, double edge2, double edge3);

        public virtual TriangleType Check(double edge1, double edge2, double edge3)
        {
            //SortThreeEdge(ref edge1, ref edge2, ref edge3);

            if (Process(edge1, edge2, edge3))
                return defaultType;

            return NextChecker.Check(edge1, edge2, edge3);
        }

    }
}
