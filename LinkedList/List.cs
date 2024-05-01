namespace CSharpModule.LinkedList;

// indexer

public class List<T>
{
    class Node(T data)
    {
        public T Data { get; init; } = data;
        public Node? Next;
    }

    public T this[int index]
    {
        get
        {
            if(index < 0 || index >= Count)
                throw new IndexOutOfRangeException();
            
            return GetAtIndexRecursive(head, index);
        }

        set 
        {
            if(index < 0 || index > Count)
                throw new IndexOutOfRangeException();
            
            TryInsertRecursive(ref head, index, value);
        }
    }

    private Node? head = null;

    public void Append(T data) 
        => AppendRecursive(ref head, data);

    public int Count => CountRecursive(head, 0);

    public bool TryInsert(int index, T data)
        => index >= 0 && index <= Count && TryInsertRecursive(ref head, index, data);

    public void Print()
    {
        PrintRecursive(head);
        Console.WriteLine();
    }

    private void AppendRecursive(ref Node? current, T data)
    {
        if(current is null)
            current = new Node(data);
        else
            AppendRecursive(ref current.Next, data);
    }

    private void PrintRecursive(Node? current)
    {
        if(current is not null)
        {
            Console.Write($"{current.Data} ");
            PrintRecursive(current.Next);
        }
    }

    private int CountRecursive(Node? current, int count)
    {
        if(current is null) return count;

        return CountRecursive(current.Next, count + 1);
    }

    private bool TryInsertRecursive(ref Node? current, int index, T data)
    {
        if(current is null && index > 0)
            throw new InvalidOperationException("Index out of range");

        if(index is 0)
        {
            var temp = head;
            head = new Node(data);
            head.Next = temp;

            return true;
        }

        if(index is 1)
        {
            var temp = current?.Next;
            var node = new Node(data);
            current!.Next = node;
            node.Next = temp;
            return true;
        }

        return TryInsertRecursive(ref current!.Next, index - 1, data);
    }

    private T GetAtIndexRecursive(Node? current, int index)
    {
        if(index is 0)
            return current!.Data;
        
        return GetAtIndexRecursive(current!.Next, --index);
    }
}