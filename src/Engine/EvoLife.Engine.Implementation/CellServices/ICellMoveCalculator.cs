using EvoLife.Engine.Core;

namespace EvoLife.Engine.Implementation.CellServices
{
    public interface ICellMoveCalculator
    {
        Position CalculateCellPosition(ICell cell);
    }
}