using System;
using Xunit;

namespace GeometryLib.Tests.TriangleTests
{
    public class TriangleConstructionTests
    {
        [Fact]
        public void AttemptToConstructWithNegativeSideLengthThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 1, 1));
        }

        [Fact]
        public void AttemptToConstructWithZeroSideLengthThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 1, 1));
        }

        [Fact]
        public void ConstructionWithSideLengthGreaterThanZeroCompletedSuccessfully()
        {
            Assert.NotNull(new Triangle(1, 1, 1));
        }
    }
}