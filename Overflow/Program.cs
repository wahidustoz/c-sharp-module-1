// compile time error
// runtime time error



unchecked
{
    long son2 = int.MaxValue + 1;
    Console.WriteLine(son2);
}

// 0111 1111 1111 1111 1111 1111 1111 1111
var son = int.MaxValue;  // 2,147,483,647
// son = son + 1;
checked 
{
    son = son + 1;
}
Console.WriteLine(son);

// +, -, *, /, ++, --

// 1000 0000 0000 0000 0000 0000 0000 0000
// var minSon = int.MinValue; // -2,147,483,648
// Console.WriteLine(minSon);