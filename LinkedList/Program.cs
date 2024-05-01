var list  = new CSharpModule.LinkedList.List<int>();

list.Append(1);
list.Append(2);
list.Append(3);

list.TryInsert(0, 9);
list.TryInsert(4, 11);
list.TryInsert(2, 12);

list.Print();

Console.WriteLine(list.Count);

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}

list[6] = 15;

list.Print();

var stringList = new CSharpModule.LinkedList.List<string>();

stringList.Append("Hello");

stringList.Print();




