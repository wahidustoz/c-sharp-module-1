// kasr son tiplari
// float - 4 - 6 digits         - System.Single  
// double - 8 - 15~17 digits
// decimal - 16 - 28~29 digits

// float kasrSon = 3.333333333333333333333333f;
// Console.WriteLine($"Float: {kasrSon:f10}");

// double doubleSon = 3.33333333333333333333333333333333;
// Console.WriteLine($"Double: {doubleSon:f33}");

// decimal decimalSon = 3.33333333333333333333333333333333m;
// Console.WriteLine($"Decimal: {decimalSon:f33}");

// float son = .3f + .3f + .3f + .1f;
// double son2 = (.3 + .3 + .3 + .1);
// decimal son3 = .3m + .3m + .3m + .1m;
// Console.WriteLine(son == son2);
// Console.WriteLine($"{son:f33}");
// Console.WriteLine($"{son2:f33}");
// Console.WriteLine($"{son3:f33}");

// Console.Write("Kasr son kiriting: ");
// var karsSonString = Console.ReadLine();
// var parsedKasrSon = double.Parse(karsSonString!);
// Console.WriteLine($"Float: {parsedKasrSon:f10}");


// MATH

using System.Numerics;

Console.WriteLine(Math.PI);
Console.WriteLine(Math.E);
Console.WriteLine(Math.Tau);

Console.WriteLine(BigInteger.Parse("1231231231231231233123123123123123123123") + BigInteger.Parse("1231231231231231233123123123123123123123"));