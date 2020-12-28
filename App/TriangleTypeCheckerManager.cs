using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    partial class TriangleTypeCheckerManager
    {
        private static readonly BaseTriangleTypeChecker checker;
        static TriangleTypeCheckerManager()
        {
            BaseTriangleTypeChecker none = new NoneTypeChecker();
            BaseTriangleTypeChecker equilateral = new EquilateralTriangleChecker();
            BaseTriangleTypeChecker isosceles = new IsoscelesTriangleChecker();
            BaseTriangleTypeChecker right = new RightTriangleChecker();
            BaseTriangleTypeChecker normal = new NormalTriangleChecker();

            checker = none;
            none.NextChecker = equilateral;
            equilateral.NextChecker = isosceles;
            isosceles.NextChecker = right;
            right.NextChecker = normal;
        }

        public static BaseTriangleTypeChecker GetChecker() => checker;
    }
}
