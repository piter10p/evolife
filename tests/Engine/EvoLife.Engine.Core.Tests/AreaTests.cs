using FluentAssertions;
using Xunit;

namespace EvoLife.Engine.Core.Tests
{
    public class AreaTests
    {
        [Theory]
        [InlineData(0, true)]
        [InlineData(4.99f, true)]
        [InlineData(5, true)]
        [InlineData(5.1, false)]
        [InlineData(6, false)]
        public void Contains(float distance, bool expected)
        {
            var area = new Area(new Position(0, 0), 5);
            var point = new Position(distance, 0);

            var actual = area.Contains(point);
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(9.99f, true)]
        [InlineData(10, true)]
        [InlineData(10.1, false)]
        [InlineData(11, false)]
        public void Collide(float distance, bool expected)
        {
            var area1 = new Area(new Position(0, 0), 5);
            var area2 = new Area(new Position(0, distance), 5);

            var actual = area1.Collide(area2);
            actual.Should().Be(expected);
        }
    }
}