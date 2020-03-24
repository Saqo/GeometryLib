
namespace GeometryLib
{
    public static class AreaCalculator
    {
        public static double CalculateAreaOf< T>(ref T figure) where T : IFigure => figure.GetArea();
    }
}