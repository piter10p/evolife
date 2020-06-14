using EvoLife.Engine.Core;

namespace EvoLife.Engine.Implementation.CellServices
{
    public interface ICellFactory
    {
        ICell Create(Position position, Genome genome);
    }
}