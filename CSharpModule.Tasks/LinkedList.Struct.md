#### Linked List yaratish

LinkedList bu ma'lumotlarni ketma-ket joylashtiradigan o'ziga hos data strukturasi. `int` tipidagi ma'lumotlarni saqlaydigan LinkedList ni struct orqali yozing.

```csharp
public struct Node
{
    private int? Data;
    private Node? Next;

    public Node(int? data, Node? next) => 
        (Data, Next) = (data, next);
}
```

Yuqorida list ichidagi bitta elementni ifodalovchi Node structurasi

```csharp
public struct List
{
    private Node? Head;

    public readonly int First { get; }
    public readonly int Last { get; }

    public void Append(int data) { }    // oxiriga element qo'shadi
    public void Prepend(int data) { }   // boshiga element qo'shadi
    public void DeleteFirst() { }       // birinchi elementni o'chiradi
    public void DeleteLast() { }        // oxirgi elementni o'chiradi
    public bool TryDelete(int data) { } // ma'lumotni o'chiradi muvaffaqiyatli bo'lsa true qaytaradi
    public void Print() { }             // recursive usulda boshidan oxirgacha chop etadi
}
```

Yuqoridagi method va property'larni implement qilish kerak.


Sinab ko'rish uchun:
```cs
List list = new List();
list.Append(1);
list.Append(2);
list.Append(3);
list.Prepend(0);

Console.WriteLine("Initial List:");
list.Print(); // Output: 0 1 2 3
Console.WriteLine();

list.DeleteFirst();
list.DeleteLast();
list.TryDelete(2);

Console.WriteLine("List after deletions:");
list.Print(); // Output: 1
```