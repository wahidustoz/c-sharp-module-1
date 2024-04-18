using System.Numerics;
// "Hello" - string literal
// 123 - integer literal
// 'a' - character literal
// 3.14 - float literal
BigInteger kattaSon = 123;
Console.WriteLine(kattaSon);

BigInteger kattaSon2 = BigInteger.Parse("20442342342342342342342342342342342346744073709551615");
Console.WriteLine(kattaSon2);

var kattaSon3 = new BigInteger(123);

Console.WriteLine(kattaSon3.IsEven);
Console.WriteLine(kattaSon3.IsOne);
Console.WriteLine(kattaSon3.IsZero);
Console.WriteLine(kattaSon3.IsPowerOfTwo);
Console.WriteLine(BigInteger.Add(kattaSon3, kattaSon3));
Console.WriteLine(BigInteger.Pow(kattaSon2, 1000));

int a = int.MaxValue;
a += 1;
Console.WriteLine(a);