using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EvoLife.Engine.Core
{
    /// <summary>
    /// EvoLife engine
    /// </summary>
    public interface IEvoLifeEngine
    {
        uint Time { get; }
        
        IEnumerable<ICell> Update();
    }
}