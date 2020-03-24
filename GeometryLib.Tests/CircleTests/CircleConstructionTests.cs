using System;
using Xunit;

namespace GeometryLib.Tests.CircleTests
{
    public class CircleConstructionTests
    {
        [Fact]
        public void AttemptToConstructWithNegativeRadiusThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0 - double.Epsilon));
            Assert.Throws<ArgumentException>(() => new Circle(double.MinValue));
        }

        [Fact]
        public void ConstructionWithNonNegativeRadiusCompletedSuccessfully()
        {
            Assert.StrictEqual(0, new Circle(0).Radius);
            Assert.StrictEqual(double.MaxValue, new Circle(double.MaxValue).Radius);
        }
    }
}