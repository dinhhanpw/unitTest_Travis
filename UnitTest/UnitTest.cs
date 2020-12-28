using App;
using NUnit.Framework;
using System;

namespace UnitTest
{
    public class Tests
    {
        private static object[] triangleTypeCases =
        {
            new object[] {new Point(0,0), new Point(0,1), new Point(0,0), TriangleType.NONE},
            new object[] {new Point(0,0), new Point(0,0), new Point(0,0), TriangleType.NONE},
            new object[] {new Point(0,0), new Point(0,1), new Point(0,2), TriangleType.NONE},
            new object[] {new Point(2,0), new Point(4,0), new Point(0,6), TriangleType.NORMAL},
            new object[] {new Point(0,0), new Point(0,3), new Point(4,0), TriangleType.RIGHT},
            new object[] {new Point(2,0), new Point(3,2*Math.Sqrt(2)), new Point(4,0), TriangleType.ISOSCELES},
            new object[] {new Point(2,0), new Point(3,Math.Sqrt(3)), new Point(4,0), TriangleType.EQUILATERAL},
        };

        private static object[] perimeterCase =
        {
            new object[] {new Point(2,0), new Point(4,0), new Point(0,6), 2 + 2*Math.Sqrt(10) + 2*Math.Sqrt(13)},
        };

        [TestCaseSource(nameof(triangleTypeCases))]
        public void TestGetTriangleType(Point a, Point b, Point c, TriangleType expectedType)
        {
            Triangle triangle = new Triangle(a, b, c);

            Assert.That(triangle.GetTriangleType(), Is.EqualTo(expectedType));
        }

        [TestCaseSource(nameof(perimeterCase))]
        public void TestGetPerimeter(Point a, Point b, Point c, double expectedOutput)
        {
            Triangle triangle = new Triangle(a, b, c);

            Assert.That(triangle.Perimeter(), Is.EqualTo(expectedOutput));
        }
    }
}