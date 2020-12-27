﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    class RightTriangleChecker : BaseTriangleTypeChecker
    {
        protected override bool Process(double edge1, double edge2, double edge3)
        {
            return edge1 * edge1 == edge2 * edge2 + edge3 * edge3;
        }
    }
}
