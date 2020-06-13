using System.Diagnostics.CodeAnalysis;

namespace EvoLife.Engine.Core
{
    [SuppressMessage("ReSharper", "IdentifierTypo")]
    public enum CellType
    {
        /// <summary>
        /// Light-drawing cell
        /// </summary>
        Photolites,
        
        /// <summary>
        /// A cell that draws its energy from other cells
        /// </summary>
        Heterolites
    }
}