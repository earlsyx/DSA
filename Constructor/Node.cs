using System;
using System.Security.Cryptography.X509Certificates;

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


    public LinkedList Push(int value)
    {
        Node newNode = new Node(value);

        if(this.Head != Head)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            this.Tail.Next = newNode; 
            this.Tail = newNode;
        }
        this.Length++;
        return this;
    }

    public LinkedList Pop()
    {
        if (this.Head == null)
        {
            return null;
        }

        var temp = this.Head;
        var pre = this.Head;

        while (temp.Next != null)
        {
            pre = temp;
            temp = temp.Next;
        }
        this.Tail = pre;
        this.Tail.Next = null;
        this.Length--;
        if (this.Length == 0)
        {
            this.Head = null;
            this.Tail = null;
        }

        return this;
    }

    public LinkedList Unshift(int value)
    {
        Node newNode = new Node(value);
        if (this.Head != Head)
        {
            this.Head = newNode;
            this.Tail = newNode;
        }
        else
        {
            newNode.Next = this.Head;
            this.Head = newNode;
        }
        this.Length++;
        return this;

    }

    public LinkedList Shift()
    {
        if (this.Head == null)
        {
            return null;
        }
        else
        {
            var temp = this.Head;
            this.Head = this.Head.Next;
            temp.Next = null;
            this.Length--;
        }
        if (this.Length == 0)
        {
            this.Tail = null;
        }

        return this; 
    }

    //Next would be =unshift
} 



