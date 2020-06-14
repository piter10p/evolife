using System;
using EvoLife.Engine.Core;

namespace EvoLife.Engine.Implementation.CellServices
{
    public class CellDivider : ICellDivider
    {
        private readonly ICellFactory _cellFactory;

        public CellDivider(ICellFactory cellFactory)
        {
            _cellFactory = cellFactory ?? throw new ArgumentNullException(nameof(cellFactory));
        }

        public ICell DivideCell(ICell cell)
        {
            if (cell == null) throw new ArgumentNullException(nameof(cell));
            
            var position = cell.Position;
            var genome = cell.Genome;

            return _cellFactory.Create(position, genome);
        }
    }
}