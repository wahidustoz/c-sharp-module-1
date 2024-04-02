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

// Format()  	returns a formatted string
var testString = string.Format("Hello {0}", 123123);
Console.WriteLine("Hello {0:C}", 123123);

// Split()	splits the string into substring
var originalString = "olma anor nok";
var mevalar = originalString.Split(' ');
Console.WriteLine(mevalar[0]);
Console.WriteLine(mevalar[1]);
Console.WriteLine(mevalar[2]);

// var input = Console.ReadLine();
// var inputlar = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// Console.WriteLine(inputlar.Length);
// Console.WriteLine(int.Parse(inputlar[0]) + int.Parse(inputlar[1]));

// var sum = Console.ReadLine()?
//     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
//     .Select(int.Parse)
//     .Aggregate((x, y) => x + y);

// Console.WriteLine(sum);


// Substring()	returns substring of a string

var longString = "This is a very long string";
// longString = longString.Substring(5);
// Console.WriteLine(longString);
Console.WriteLine(longString.Substring(5));
Console.WriteLine(longString.Substring(5, 10));


// Replace()	replaces the specified old character with the specified new character
Console.WriteLine(longString.Replace('i', 'I'));
Console.WriteLine(longString.Replace("is", "IS"));
Console.WriteLine(longString.Replace("Is", "IS", StringComparison.CurrentCultureIgnoreCase));

// Contains()	checks whether the string contains a substring
Console.WriteLine(longString.Contains('i'));
Console.WriteLine(longString.Contains('I'));
Console.WriteLine(longString.Contains('I', StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine(longString.Contains("very"));
Console.WriteLine(longString.Contains("VERY"));
Console.WriteLine(longString.Contains("VERY", StringComparison.CurrentCultureIgnoreCase));

// Join()	joins the given strings using the specified separator
Console.WriteLine(string.Join(", ", [123, "hello", 'a', 3.14]));

// Trim()	removes any leading and trailing whitespaces
var stringWithSpaces = "  hello world     \n";
Console.WriteLine(stringWithSpaces);
Console.WriteLine(stringWithSpaces.Trim());
Console.WriteLine(stringWithSpaces.TrimEnd());
Console.WriteLine(stringWithSpaces.TrimStart());

// EndsWith()	checks if the string ends with the given string
Console.WriteLine(longString.EndsWith("string"));
Console.WriteLine(longString.EndsWith("STRING"));
Console.WriteLine(longString.EndsWith("STRING", StringComparison.CurrentCultureIgnoreCase));


// StartsWith()	checks if the string starts with the given string
Console.WriteLine("StartsWith()");
Console.WriteLine(longString.StartsWith("This"));
Console.WriteLine(longString.StartsWith("this"));
Console.WriteLine(longString.StartsWith("this", StringComparison.CurrentCultureIgnoreCase));


// IndexOf()	returns the position of the specified character in the string
Console.WriteLine("IndexOf()");
Console.WriteLine(longString.IndexOf('i'));
Console.WriteLine(longString.IndexOf("very"));
Console.WriteLine(longString.IndexOf("VERY"));
Console.WriteLine(longString.IndexOf("VERY", StringComparison.CurrentCultureIgnoreCase));

// Remove()  	returns characters from a string
Console.WriteLine("Remove()");
Console.WriteLine(longString.Remove(10));
Console.WriteLine(longString.Remove(10, 5));

// ToUpper()    	converts the string to uppercase
Console.WriteLine("ToUpper()");
Console.WriteLine(longString.ToUpper());

// ToLower()  	converts the string to lowercase
Console.WriteLine("ToLower()");
Console.WriteLine(longString.ToLower());


// PadLeft()	returns string padded with spaces or with a specified Unicode character on the left
Console.WriteLine("PadLeft()");
Console.WriteLine("Hello".PadLeft(10));
Console.WriteLine("Hello".PadLeft(10, '+'));

// PadRight()    returns string padded with spaces or with a specified Unicode character on the right
Console.WriteLine("PadRight()");
Console.WriteLine("Hello".PadRight(10));
Console.WriteLine("Hello".PadRight(10, '+'));

// Compare()  	compares string objects
Console.WriteLine(string.Compare("A", "B"));
Console.WriteLine(string.Compare("B", "AB"));
Console.WriteLine(string.Compare("B", "B"));
Console.WriteLine("A".CompareTo("B"));

// Equals()
Console.WriteLine(string.Equals("Hello", "hello"));
Console.WriteLine(string.Equals("Hello", "hello", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Hello".Equals("hello", StringComparison.CurrentCultureIgnoreCase));

// StringBuilder class
// Regex: Match, Replace, Split