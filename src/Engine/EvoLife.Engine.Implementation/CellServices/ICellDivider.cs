using EvoLife.Engine.Core;

namespace EvoLife.Engine.Implementation.CellServices
{
    public interface ICellDivider
    {
        ICell DivideCell(ICell cell);
    }
}