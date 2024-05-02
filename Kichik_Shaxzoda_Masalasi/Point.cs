namespace Kichik_Shaxzoda_Masalasi;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point() : this(0, 0) {}
    public Point(int x, int y) => (X, Y) = (x, y);

    public readonly double DistanceTo(Point point)
    {
        var a = X - point.X;
        var b = Y - point.Y;

        var c = Math.Sqrt((a * a) + (b * b));

        return c;
    }
}