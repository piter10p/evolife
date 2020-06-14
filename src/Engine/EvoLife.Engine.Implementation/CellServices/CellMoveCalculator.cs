using System;
using EvoLife.Engine.Core;
using EvoLife.Engine.Implementation.Extensions;

namespace EvoLife.Engine.Implementation.CellServices
{
    public class CellMoveCalculator : ICellMoveCalculator
    {
        private readonly Random _random = new Random();
        
        public Position CalculateCellPosition(ICell cell)
        {
            if (cell == null) throw new ArgumentNullException(nameof(cell));

            var distance = cell.Genome.Speed;
            var angle = _random.NextFloatRange(0, MathF.PI);

            var x = distance * MathF.Cos(angle) + cell.Position.X;
            var y = distance * MathF.Sin(angle) + cell.Position.Y;
            
            return new Position(x, y);
        }
    }
}