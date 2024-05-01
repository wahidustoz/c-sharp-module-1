// NullPattern();
// DeclarationPattern();
// ConstantPattern();
// RelationalPattern();
// LogicalPattern();
// PropertyPattern();
ListPattern();

// list pattern
void ListPattern()
{
    var sonlar = new int[] { 1, 2, 3 };
    if(sonlar is [0, 1, 2])
        Console.WriteLine("True");
    else if(sonlar is [1, 2, var x] && x == 5)
        Console.WriteLine("Ichida 5 bor.");
}

// property pattern
void PropertyPattern()
{
    var today = new DateTime(2024, 2, new Random().Next(25, 29));

    if(today is { Day: 28 })
        Console.WriteLine("HAppy Birthday!");

    var paymentDate = DateTime.Now;

    if(paymentDate is { Month: > 6 })
        Console.WriteLine("Late");

    var input = Console.ReadLine();

    if(input is { Length: > 0 })
        Console.WriteLine("Input is not empty");
}


// logical pattern
void LogicalPattern()
{
    var son = new Random().Next(0, 10);
    var text = son switch
    {
        0 => "Zero",
        1 or 3 or 5 or 7 or 9 => "Odd",
        >= 2 and <= 8 => "2 dan 8 gacha",
        _ => "Not matched"
    };
    Console.WriteLine(text);
}

// relational pattern
void RelationalPattern()
{
    var baxo = new Random().Next(0, 110);
    // EGrade? grade = null;
    // if(baxo is >= 90 and <= 100)
    //     grade = EGrade.A;
    // else if (baxo is >= 80)
    //     grade = EGrade.B;

    EGrade? grade = baxo switch
    {
        > 100 => null,
        >= 90 and <= 100 => EGrade.A,
        >= 80 => EGrade.B,
        >= 70 => EGrade.C,
        >= 60 => EGrade.D,
        _ => EGrade.F
    };

    Console.WriteLine($"Baxo: {baxo}, Grade: {grade}");

}

// constant pattern
void ConstantPattern()
{
    var son = new Random().Next(0, 3);

    // if(son is 0)
    //     Console.WriteLine("Zero");
    // else if (son is 1)
    //     Console.WriteLine("One");
    // else if (son is 2)
    //     Console.WriteLine("Two");
    // else if (son is 3)
    //     Console.WriteLine("Three");
    // else 
    //     Console.WriteLine("Not matched");

    var text = son switch
    {
        0 => "Zero",
        1 => "One",
        2 => "Two",
        3 => "Three",
        _ => "Not matched"
    };
    Console.WriteLine(text);
}

// declaration pattern
void DeclarationPattern()
{
    var obj = GetObject();

    // if(obj is char c)
    //     Console.WriteLine($"Char is returned {c}");
    // else if (obj is string s)
    //     Console.WriteLine($"String is returned {s}");
    // else if (obj is int i)
    //     Console.WriteLine($"Int is returned {i}");
    // else if (obj is decimal d)
    //     Console.WriteLine($"Decimal is returned {d}");

    var text = obj switch
    {
        char c => $"Char is returned {c}",
        string s => $"String is returned {s}",
        int i => $"Int is returned {i}",
        decimal d => $"Decimal is returned {d}",
        _ => "Not matched"
    };
    Console.WriteLine(text);

    object GetObject()
    {
        return new Random().Next(1, 5) switch 
        {
            1 => '1',
            2 => "two",
            3 => 3,
            4 => 4.0m,
        };
    }
}

// null pattern
void NullPattern()
{
    var son = GetIntOrDefault(Console.ReadLine());

    // if(son is null) // null pattern
    //     Console.WriteLine("Son olishda xatolik yuz berdi");
    // else 
    //     Console.WriteLine($"Son = {son}");

    if(son is not null) // null pattern
        Console.WriteLine($"Son = {son}");
    else 
        Console.WriteLine("Son olishda xatolik yuz berdi");


    int? GetIntOrDefault(string? text)
    {
        if(int.TryParse(text, out var value))
            return value;
        
        return null;
    }
}


