public class Point(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public static int BittaSon { get; set; }

    public void Add(int a, int b) => BittaSon = a + b;
}