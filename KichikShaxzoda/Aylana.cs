namespace CSharpModule.KichikShaxzoda;

public struct Aylana
{
    public Nuqta Markaz { get; set; }
    public int Radius { get; set; }

    public Aylana() : this(new Nuqta(), 0) { }

    public Aylana(Nuqta markaz, int radius)
        => (Markaz, Radius) = (markaz, radius);

    public readonly bool IsIn(Nuqta nuqta) 
        => Markaz.DistanceTo(nuqta) < Radius;
}