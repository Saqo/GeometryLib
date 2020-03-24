using System;
using System.Collections.Generic;
using System.Linq;
using GeometryLib.Utils;
using static GeometryLib.Resources.Resources;

namespace GeometryLib
{
    public class Triangle : IFigure
    {
        private readonly Lazy<bool> _isRightAngled;

        public bool IsRightAngled => _isRightAngled.Value;
        public double A { get; }
        public double B { get; }
        public double C { get; }

        double IFigure.GetArea()
        {
            var halfPerimeter = (A + B + C) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
        }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException(TriangleSideLengthMustBeGreaterThanZero);
            A = a;
            B = b;
            C = c;
            _isRightAngled = new Lazy<bool>(CheckIsRightAngled);
        }

        private bool CheckIsRightAngled()
        {
            var sortedSet = new SortedSet<double> {A, B, C};
            return sortedSet.Count >= 2 && IsCompliantWithPythagoreanTheorem(sortedSet);
        }

        private bool IsCompliantWithPythagoreanTheorem(SortedSet<double> sortedSet) =>
            LegsSquaresSum(sortedSet) == HypotenuseSquare(sortedSet.Max);


        private Func<SortedSet<double>, double> LegsSquaresSum =>
            set => GetLegsSquaresSum(set).Round(3);

        private Func<double, double> HypotenuseSquare =>
            hypotenuse => Math.Pow(hypotenuse, 2).Round(3);

        private double GetLegsSquaresSum(SortedSet<double> sortedSet) =>
            sortedSet.Count == 2
                ? Math.Pow(sortedSet.Min, 2) * 2
                : Math.Pow(sortedSet.Take(2).First(), 2) + Math.Pow(sortedSet.Take(2).Last(), 2);
    }
}