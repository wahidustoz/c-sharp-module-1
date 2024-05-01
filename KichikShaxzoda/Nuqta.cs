namespace CSharpModule.KichikShaxzoda;

public struct Nuqta
{
    public int X { get; set; }
    public int Y { get; set; }

    public Nuqta() : this(0, 0) { }

    public Nuqta(int x, int y) => (X, Y) = (x, y);

    public readonly double DistanceTo(Nuqta boshqa)
    {
        var a = X - boshqa.X;
        var b = Y - boshqa.Y;

        var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        return c;
    }

    public static Nuqta Parse(string str)
    {
        var nuqtalar = str.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);
        
        return new Nuqta(nuqtalar.First(), nuqtalar.Last());
    }
}
