namespace EvoLife.Engine.Core
{
    public interface ICell
    {
        Position Position { get; }
        Genome Genome { get; }

        void Move();
    }
}