using CSharpModule.Structure;

// var a = new Nuqta();
// Console.WriteLine(a);

// a.X = 15;
// a.Y = 20;

// Console.WriteLine(a);



unsafe
{
    var toshmat = new Person("Toshmat Eshmat", 17);
    var eshmat = new Person("Eshmat Toshmat", 17, &toshmat); 
    // Console.WriteLine(sizeof(Person)); // 4 + 8
    // Console.WriteLine(sizeof(string));

    Console.WriteLine(toshmat);
    Console.WriteLine(eshmat);
}