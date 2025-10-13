using System;

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

public class LinkedList
{
    public Node Head { get; set; }
    public Node Tail { get; set; }
    public int Length { get; set; }

    public LinkedList(int value)
    {
        Node newNode = new Node(value);
        Head = newNode;
        Tail = Head;
        Length = 1;
    }

    public void PrintList()
    {
        Node temp = Head;
        while (temp != null)
        {
            Console.WriteLine(temp.Value);
            temp = temp.Next;
        }
    }

    public void GetHead()
    {
        if (Head == null)
        {
            Console.WriteLine("Head: null");
        }
        else
        {
            Console.WriteLine($"Head: {Head.Value}");
        }
    }

    public void GetTail()
    {
        if (Tail == null)
        {
            Console.WriteLine("Tail: null");
        }
        else
        {
            Console.WriteLine($"Tail: {Tail.Value}");
        }
    }

    public void GetLength()
    {
        Console.WriteLine($"Length: {Length}");
    }
}


