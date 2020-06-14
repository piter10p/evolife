using System;

namespace EvoLife.Engine.Implementation.Extensions
{
    public static class RandomExtensions
    {
        public static float NextFloatRange(this Random random, float min, float max)
        {
            if (random == null) throw new ArgumentNullException(nameof(random));
            return (float)random.NextDouble() * (max - min) + min;
        }
    }
}