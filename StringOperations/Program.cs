// is string literal mutable or immutable?
// is string variable mutable or immutable?

var name = "Wahid Ustoz";
name = "Wahid ustoz";
var son = 15;
son = 16;

Console.WriteLine(name);
Console.WriteLine(son);

Console.WriteLine(name[0]);
Console.WriteLine(name[1]);


var greet = "Hello" + " " + name;   // string concatenation
Console.WriteLine(greet);

greet += "!";
Console.WriteLine(greet);

// string interpolation
var greet2 = $"Hello {name}";
Console.WriteLine(greet2);

// fomatting

var butunSon = 25;
Console.WriteLine($"Butun son: {butunSon,-10:C3}!");

// composite formatting
var ajoyib = 3.14;
// var tekst = string.Format("bu {0, 10:C3} tekst", ajoyib);
Console.WriteLine("bu {0, 10:C3} tekst", ajoyib);


// length
// string manipulation methods (ToUpper(), ToLower, Split, Replace, Substring)
// Comparison: string.Equials, Compare, CompareTo, StringComparison(.IgnoreCase)
// StringBuilder class
// Regex: Match, Replace, Split