using Xunit;

namespace GeometryLib.Tests.AreaCalculatorTests
{
    public class TriangleAreaCalculationTests
    {
        [Fact]
        public void IsValidCalculation()
        {
            var triangle = new Triangle(5, 12, 13);
            Assert.StrictEqual(30, AreaCalculator.CalculateAreaOf(ref triangle));
            triangle = new Triangle(0.5, 1.2, 1.3);
            Assert.StrictEqual(0.3, AreaCalculator.CalculateAreaOf(ref triangle));
        }
    }
}