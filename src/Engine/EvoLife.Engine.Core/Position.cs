using System;

namespace EvoLife.Engine.Core
{
    /// <summary>
    /// Representation of position in two dimensional space
    /// </summary>
    public class Position
    {
        public Position(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float X { get; }
        public float Y { get; }
        
        public Position Add(Position position)
            => new Position(X + position.X, Y + position.Y);
        
        public Position Subtract(Position position)
            => new Position(X - position.X, Y - position.Y);
        
        public Position Multiply(Position position)
            => new Position(X * position.X, Y * position.Y);

        public Position Divide(Position position)
        {
            if(position.X == 0 || position.Y == 0)
                throw new InvalidOperationException("Can not divide by 0.");
            
            return new Position(X / position.X, Y / position.Y);
        }
    }
}