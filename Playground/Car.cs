

public class Car(string brand, string model)
{
    protected string? Brand { get; init; } = brand;
    private string? Model { get; init; } = model;

    public void Print() => Console.WriteLine($"{Brand} {Model}");
}

public class Byd : Car
{
    public Byd(string model) : base("BYD", model) { }

    public void PrintByd()
        => Console.WriteLine($"{Brand}");
}