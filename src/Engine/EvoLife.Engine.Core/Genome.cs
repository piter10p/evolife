namespace EvoLife.Engine.Core
{
    /// <summary>
    /// Representation of Cell Genome
    /// </summary>
    public class Genome
    {
        public Genome(CellType cellType, float speed, float energyEfficiency)
        {
            CellType = cellType;
            Speed = speed;
            EnergyEfficiency = energyEfficiency;
        }

        /// <summary>
        /// Type of cell
        /// </summary>
        public CellType CellType { get; }
        
        /// <summary>
        /// Speed of cell (distance travel in one tick).
        /// The faster the cell is, the less efficient in energy consumption it is.
        /// Value 0 - 1
        /// </summary>
        public float Speed { get; }
        
        /// <summary>
        /// Energy Efficiency of cell.
        /// The more cell is efficient in energy conversion, the more massive it is.
        /// Value 0 - 1
        /// </summary>
        public float EnergyEfficiency { get; }
    }
}