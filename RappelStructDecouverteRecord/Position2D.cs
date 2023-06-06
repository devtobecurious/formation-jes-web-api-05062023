namespace RappelStructDecouverteRecord
{
    public class Position2DC
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public struct Position2DS
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public record Position2DR(int X, int Y);

    public record Position2DRR
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Hello() { }
    }
}
