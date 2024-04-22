namespace CSharpModule.Structure;

public struct Nuqta // immutable
{
    public int X { get; set; } 
    public int Y { get; set; } 

    public Nuqta() : this(1, 1) { }

    public Nuqta(int x, int y) => (X, Y) = (x, y);

    public readonly override string ToString() 
        => $"Nuqta koordinatalari: {X}, {Y}";
}