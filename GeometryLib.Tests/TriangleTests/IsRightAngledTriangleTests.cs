using System;
using Xunit;

namespace GeometryLib.Tests.TriangleTests
{
    public class IsRightAngledTriangleTests
    {
        [Theory]
        [InlineData(0.5, 1.2, 1.3)]
        [InlineData(5, 12, 13)]
        public void IsRightAngled(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.True(triangle.IsRightAngled);
        }

        [Fact]
        public void IsIsoscelesRightAngledTriangle()
        {
            var triangle = new Triangle(1, 1, Math.Sqrt(2));
            Assert.True(triangle.IsRightAngled);
        }


        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(6, 24, 25)]
        [InlineData(0.4, 0.5, 0.6)]
        [InlineData(0.51, 0.12, 0.13)]
        public void IsNotRightAngled(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.False(triangle.IsRightAngled);
        }
    }
}