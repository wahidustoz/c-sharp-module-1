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
var carModel = "Byd Song L";
Console.WriteLine("String = {0}, Length = {1}", carModel, carModel.Length);

for(int i = 0; i < carModel.Length; i ++)
    Console.WriteLine(carModel[i]);

// escape charcter & verbatim string

// \ - escape character maxsus belgilarni yozish uchun ishlatiladi.
var specialString = "U judayam \"zor\" bola";   
Console.WriteLine(specialString);
Console.WriteLine("olma\nanor\nnok");
Console.WriteLine("olma\tanor\tnok");
Console.WriteLine("olma\tanor\tnok");
Console.WriteLine("olma\banor");
Console.WriteLine("olma\rnok");
Console.WriteLine("\\olma\\");

// verbatim string 
// verbatim - biror so'zni o'zgarishsiz o'shanday ko'chirib aytish yoki yozish

Console.WriteLine("C:\\Windows\\System32\\calc.exe");
Console.WriteLine(@"C:\Windows\System32\calc.exe");
Console.WriteLine(@"Bugun \n maxsus belgisini o'rgandik!");














// string manipulation methods (ToUpper(), ToLower, Split, Replace, Substring)
// Comparison: string.Equials, Compare, CompareTo, StringComparison(.IgnoreCase)
// StringBuilder class
// Regex: Match, Replace, Split