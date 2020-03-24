using System;

namespace GeometryLib.Utils
{
    public static class DoubleExtensions
    {
        public static double Round(this double value, uint precision) =>
            Math.Round(Math.Pow(10, precision) * value, 0, MidpointRounding.ToZero);
    }
}