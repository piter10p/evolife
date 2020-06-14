using System;
using EvoLife.Engine.Core;

namespace EvoLife.Engine.Implementation.CellServices
{
    public class CellFactory : ICellFactory
    {
        private readonly ICellMoveCalculator _cellMoveCalculator;

        public CellFactory(ICellMoveCalculator cellMoveCalculator)
        {
            _cellMoveCalculator = cellMoveCalculator ?? throw new ArgumentNullException(nameof(cellMoveCalculator));
        }

        public ICell Create(Position position, Genome genome)
        {
            if (position == null) throw new ArgumentNullException(nameof(position));
            if (genome == null) throw new ArgumentNullException(nameof(genome));
            
            return new Cell(position, genome, _cellMoveCalculator);
        }
    }
}