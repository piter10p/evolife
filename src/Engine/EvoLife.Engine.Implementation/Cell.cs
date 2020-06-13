using System;
using EvoLife.Engine.Core;

namespace EvoLife.Engine.Implementation
{
    public class Cell : ICell
    {
        public Cell(Position position, Genome genome)
        {
            Position = position ?? throw new ArgumentNullException(nameof(position));
            Genome = genome ?? throw new ArgumentNullException(nameof(genome));
        }

        public Position Position { get; }
        public Genome Genome { get; }
    }
}