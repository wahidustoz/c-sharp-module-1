namespace Kichik_Shaxzoda_Masalasi;
public struct Circle
{
    public Point Center { get; set; }
    public int Radius { get; set; }

    public Circle() : this(new Point(), 0) { }
    public Circle(Point center, int radius) => (Center, Radius) = (center, radius);

    public readonly bool IsWithinCircle(Point point) => Center.DistanceTo(point) < Radius;
}