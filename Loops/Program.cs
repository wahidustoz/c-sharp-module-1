// break, continue

for(var son = 1; ; son++)
{
    if(son % 2 == 1)
        continue;

    if(son >= 100)
        break;

    Console.Write($"{son} ");
}




// while, for, foreach, do while

// do while

void DoWhile()
{
    var javob = int.Parse(Console.ReadLine() ?? "0");
    var taxmin = 0;
    var taxminlar = 0;

    do
    {
        taxmin = int.Parse(Console.ReadLine() ?? "0");
        taxminlar++;

        if (taxmin > javob)
            Console.WriteLine($"{taxmin}>");
        else if (taxmin < javob)
            Console.WriteLine($"{taxmin}<");
    } while (javob != taxmin);

    Console.WriteLine(taxminlar);
}


// for

// 1. initialization
// 2. condition
// 3. increment/decrement

void Problem2_For()
{
    var javob = int.Parse(Console.ReadLine() ?? "0");


    for (var taxminlar = 0; ;)
    {
        var taxmin = int.Parse(Console.ReadLine() ?? "0");
        taxminlar++;

        if (taxmin > javob)
            Console.WriteLine($"{taxmin}>");
        else if (taxmin < javob)
            Console.WriteLine($"{taxmin}<");
        else
        {
            Console.WriteLine(taxminlar);
            break;
        }
    }
}

void Problem1_For()
{
    var son = int.Parse(Console.ReadLine() ?? "0");

    for (var sanoq = 1; sanoq <= son; sanoq++)
    {
        if (son % sanoq == 0)
            Console.Write($"{sanoq} ");
    }
}

// while 

void Problem2_While()
{
    var javob = int.Parse(Console.ReadLine() ?? "0");
    var taxminlar = 0;

    while (true)
    {
        var taxmin = int.Parse(Console.ReadLine() ?? "0");
        taxminlar++;

        if (taxmin > javob)
            Console.WriteLine($"{taxmin}>");
        else if (taxmin < javob)
            Console.WriteLine($"{taxmin}<");
        else
        {
            Console.WriteLine($"{taxminlar}");
            break;
        }
    }
}

void Problem1_While()
{
    var son = int.Parse(Console.ReadLine() ?? "0");
    var sanoq = 1;

    while (sanoq <= son)
    {
        if (son % sanoq == 0)
            Console.Write($"{sanoq} ");

        sanoq++;
    }
}