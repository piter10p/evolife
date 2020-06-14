using System;

namespace EvoLife.Engine.Core.Tests.Extensions
{
    public static class RandomExtensions
    {
        public static double NextDoubleRange(this Random random, double min, double max)
        {
            if (random == null) throw new ArgumentNullException(nameof(random));
            return random.NextDouble() * (max - min) + min;
        }
        
        public static float NextFloatRange(this Random random, float min, float max)
        {
            if (random == null) throw new ArgumentNullException(nameof(random));
            return (float)random.NextDouble() * (max - min) + min;
        }
    }
}