namespace CSharpModule.ShaxzodaSecond;


public struct Nuqta
{
    public int x { get; set; }
    public int y { get; set; }

    public Nuqta() : this(0, 0) { }
    public Nuqta(int x, int y) => (this.x, this.y) = (x, y);

    public readonly double DistanceTo(Nuqta nuqta) => Math.Sqrt(Math.Pow(x - nuqta.x, 2) + Math.Pow(y - nuqta.y, 2));

    public override string ToString() => $"Nuqta koordinatalari: {x}, {y}";

    public static implicit operator (int, int)(Nuqta nuqta) => (nuqta.x, nuqta.y);

    public static implicit operator Nuqta((int, int) nuqta) => new Nuqta(nuqta.Item1, nuqta.Item2);


  
    
}

}
