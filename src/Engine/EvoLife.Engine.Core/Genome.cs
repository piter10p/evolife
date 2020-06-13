namespace EvoLife.Engine.Core
{
    /// <summary>
    /// Representation of Cell Genome
    /// </summary>
    public class Genome
    {
        /// <summary>
        /// Type of cell
        /// </summary>
        public CellType CellType { get; }
        
        /// <summary>
        /// Speed of cell.
        /// The faster the cell is, the less efficient in energy consumption it is.
        /// </summary>
        public float Speed { get; }
        
        /// <summary>
        /// Energy Efficiency of cell.
        /// The more cell is efficient in energy conversion, the more massive it is.
        /// </summary>
        public float EnergyEfficiency { get; }
    }
}