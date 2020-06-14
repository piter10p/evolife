using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EvoLife.Engine.Core;

namespace EvoLife.Engine.Implementation
{
    public class EvoLifeEngine : IEvoLifeEngine
    {
        private readonly List<Cell> _cells;

        public uint Time { get; private set; } = 0;

        public EvoLifeEngine(List<Cell> cells)
        {
            _cells = cells ?? throw new ArgumentNullException(nameof(cells));
        }

        public IEnumerable<ICell> Update()
        {
            MoveCells();
            Time++;
            
            return _cells;
        }

        private void MoveCells()
        {
            foreach (var cell in _cells)
            {
                cell.Move();
            }
        }
    }
}