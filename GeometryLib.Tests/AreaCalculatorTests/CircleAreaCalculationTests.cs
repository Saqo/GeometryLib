using System;
using Xunit;
using static GeometryLib.AreaCalculator;

namespace GeometryLib.Tests.AreaCalculatorTests
{
    public class CircleAreaTests
    {
        [Fact]
        public void IsValidCalculation()
        {
            var circle = new Circle(1);
            Assert.StrictEqual(Math.PI, CalculateAreaOf(ref circle));
            circle = new Circle(10);
            Assert.StrictEqual(Math.PI * 100, CalculateAreaOf(ref circle));
        }
    }
}