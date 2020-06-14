using System;
using EvoLife.Engine.Core.Tests.Extensions;
using FluentAssertions;
using Xunit;

namespace EvoLife.Engine.Core.Tests
{
    public class PositionTests
    {
        private readonly Random _random = new Random();
        
        [Fact]
        public void Add_ShouldSucceed()
            => Operation((pos1, pos2) => pos1.Add(pos2), (x, y) => x + y);
        
        [Fact]
        public void Subtract_ShouldSucceed()
            => Operation((pos1, pos2) => pos1.Subtract(pos2), (x, y) => x - y);
        
        [Fact]
        public void Multiply_ShouldSucceed()
            => Operation((pos1, pos2) => pos1.Multiply(pos2), (x, y) => x * y);
        
        [Fact]
        public void Divide_ShouldSucceed()
            => Operation((pos1, pos2) => pos1.Divide(pos2), (x, y) => x / y);

        [Theory]
        [InlineData(0, 10)]
        [InlineData(10, 0)]
        public void Divide_ByZero_ShouldThrowInvalidOperationException(float x, float y)
        {
            var pos1 = new Position(10, 100);
            var pos2 = new Position(x, y);

            Assert.Throws<InvalidOperationException>(() => pos1.Divide(pos2));
        }

        private void Operation(Func<Position, Position, Position> resultOperation, Func<float, float, float> expectedOperation)
        {
            var pos1 = CreateRandomPosition();
            var pos2 = CreateRandomPosition();

            var expectedX = expectedOperation(pos1.X, pos2.X);
            var expectedY = expectedOperation(pos1.Y, pos2.Y);

            var result = resultOperation(pos1, pos2);
            result.X.Should().Be(expectedX);
            result.Y.Should().Be(expectedY);
        }

        private Position CreateRandomPosition()
        {
            const float minimum = 50;
            const float maximum = 100;

            var x = _random.NextFloatRange(minimum, maximum);
            var y = _random.NextFloatRange(minimum, maximum);
            
            return new Position(x, y);
        }
    }
}