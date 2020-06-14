using EvoLife.Engine.Core;
using EvoLife.Engine.Implementation.CellServices;
using FluentAssertions;
using Xunit;

namespace EvoLife.Engine.Implementation.Tests.CellServices
{
    public class CellMoveCalculatorTests
    {
        [Theory]
        [InlineData(0.5, 1, true)]
        [InlineData(0.5, 0.6, true)]
        [InlineData(0.5, 0.5, true)]
        [InlineData(0.5, 0.4, false)]
        [InlineData(0.5, 0.1, false)]
        public void Calculate_ShouldReturnExpectedPosition(float speed, float expectedRadius, bool expected)
        {
            //Arrange
            var position = new Position(0, 0);
            var cellExpectedArea = new Area(position, expectedRadius);
            
            var cell = new Cell(position,
                new Genome(CellType.Photolites, speed, 0),
                new CellMoveCalculator());
            
            //Act
            cell.Move();
            
            //Assert
            cellExpectedArea.Contains(cell.Position).Should().Be(expected);
        }
    }
}