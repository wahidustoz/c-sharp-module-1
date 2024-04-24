namespace CSharpModule.ShaxzodaSecond;

public struct Aylana
{
    public Nuqta Markaz { get; set; }
    public int Radius { get; set; }
    public Aylana(Nuqta markaz, int radius) => (Markaz, Radius) = (markaz, radius);
    public bool IsIn(Nuqta nuqta) => Markaz.DistanceTo(nuqta) <= Radius;
    public override string ToString() => $"Markaz: {Markaz}, Radius: {Radius}";
}