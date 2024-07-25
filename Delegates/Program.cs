// using System.Globalization;
// using System.Numerics;

// int Add(int a, int b)
// {
//     return a + b;
// }

// double AddDouble(double a, double b)
// {
//     return a + b;
// }

// double Root(int x) => Math.Sqrt(x);
// double RootFloat(float x) => Math.Sqrt(x);

// Func<int> qoshish = Add;
// Func<double> qoshishDouble = AddDouble;


// Func<double, int> ildiz = Root;
// Func<double, float> ildizFloat = RootFloat;

// Console.WriteLine(Add(1, 2));

using Delegates;

string getNumberAsString(int x)
{
    return x.ToString();
}

int[] sonlar = [1, 2, 3, 4];

var sonlarString = sonlar.Select(getNumberAsString);

    var x = Console.ReadLine()?
        .Split()
        // .Select(int.Parse);
        .Songa(int.Parse);


// bool Juftmi(int x) => x % 2 == 0;
// var juftlar = sonlar.Filter(Juftmi);
var juftlar = sonlar.Filter(x => x % 2 == 0);
















// var square = (int x) => {
//     return x * x;
// };

// // function signature nima?
// int add(int a, int b) 
// {
//     Console.WriteLine("Qo'shish chaqirildi");
//     return a + b;
// }

// int multiply(int a, int b) 
// {
//     Console.WriteLine("Ko'paytirish chaqirildi");
//     return a * b;
// }

// Qoshish qoshish = add;
// qoshish += multiply;

// qoshish = (x, y) => {
//     return x * x + y + y;
// };

// Console.WriteLine(qoshish?.Invoke(1, 2));
// Console.WriteLine(square(4));

// delegate int Qoshish(int a, int b);
























// // 5 ni saqlash uchun bizga int tipi kerak
// // "Hello world" ni saqlash uchun string tipi kerak
// // 4.3 ni saqlash uchun float/double kerak

// int x = 5;
// string salom = "Hello world";
// double sum = 4.3;


// int add(int a, int b)
// {
//     return a + b;
// }

// var qoshish = add;

// Console.WriteLine(qoshish(1, 2));

// // Student classiga reference'ni saqlash uchun Student tipidagi o'zgaruvchi kerak
// Student anvar = new Student("Anvar", 22);
// Student bekzod = anvar;
// public record Student(string Name, int Age);