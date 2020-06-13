using System;

namespace EvoLife.Engine.Core
{
    /// <summary>
    /// Class representing an circle area on board
    /// </summary>
    public class Area
    {
        public Area(Position position, float radius)
        {
            Position = position ?? throw new ArgumentNullException(nameof(position));
            Radius = radius;
        }

        public Position Position { get; }
        public float Radius { get; }

        public bool Contains(Position point)
            => MathF.Pow(point.X - Position.X, 2) + MathF.Pow(point.Y - Position.Y, 2) <=
               MathF.Pow(Radius, 2);

        public bool Collide(Area area)
            => MathF.Pow(area.Position.X - Position.X, 2) + MathF.Pow(Position.Y - area.Position.Y, 2) <=
               MathF.Pow(Radius + area.Radius, 2);
    }
}