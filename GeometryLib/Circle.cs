using System;
using static GeometryLib.Resources.Resources;


namespace GeometryLib
{
    public struct Circle : IFigure
    {
        public double Radius { get; }

        double IFigure.GetArea() => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentException(RadiusCantBeNegative);
            Radius = radius;
        }
    }
}