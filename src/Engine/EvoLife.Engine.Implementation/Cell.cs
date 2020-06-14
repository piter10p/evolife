using System;
using EvoLife.Engine.Core;
using EvoLife.Engine.Implementation.CellServices;

namespace EvoLife.Engine.Implementation
{
    public class Cell : ICell
    {
        private readonly ICellMoveCalculator _cellMoveCalculator;

        public Cell(Position position, Genome genome, ICellMoveCalculator cellMoveCalculator)
        {
            _cellMoveCalculator = cellMoveCalculator ?? throw new ArgumentNullException(nameof(cellMoveCalculator));
            Position = position ?? throw new ArgumentNullException(nameof(position));
            Genome = genome ?? throw new ArgumentNullException(nameof(genome));
        }

        public Position Position { get; private set; }
        public Genome Genome { get; }
        
        public void Move()
        {
            Position = _cellMoveCalculator.CalculateCellPosition(this);
        }
    }
}