
void Baxo()
{
    var baxo = int.Parse(Console.ReadLine() ?? "0");

    if(baxo >= 90)
        Console.WriteLine("A");
    else if(baxo >= 80)
        Console.WriteLine("B");
    else if(baxo >= 70)
        Console.WriteLine("C");
    else if(baxo >= 60)
        Console.WriteLine("D");
    else
        Console.WriteLine("F");
}
void NotogriIfScope()
{
    var son = int.Parse(Console.ReadLine() ?? "0");

    if(son % 2 == 0)
        Console.WriteLine("Even");
        Console.WriteLine("Juft");
}
void Juftmi()
{
    var son = int.Parse(Console.ReadLine() ?? "0");

    // readibility - o'qish uchun osonmi
    if(son % 2 == 0)
        Console.WriteLine("Even");
    else 
        Console.WriteLine("Odd");
}
void Musbatmi()
{
    var son = int.Parse(Console.ReadLine() ?? "0");

    if (son > 0) // true yoki false beradiga ifoda
    { // if scope
        Console.WriteLine("Musbat son");
    }
    else
    {
        Console.WriteLine("Manfiy son");
    }

    Console.WriteLine("Tugadi :)");
}
