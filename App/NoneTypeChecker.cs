﻿using System;
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
            return edge2 + edge3 > edge1;
        }
    }
}
