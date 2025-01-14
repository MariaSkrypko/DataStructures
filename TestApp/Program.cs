// Файл: TestApp/Program.cs
using System;
using Library;

class Program
{
    static void Main()
    {
       
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine("Dequeue: " + queue.Dequeue()); 
        Console.WriteLine("Peek: " + queue.Peek()); 
        Console.WriteLine("Contains 2: " + queue.Contains(2)); 

     
        Stack stack = new Stack();
        stack.Push(10);
        stack.Push(20);
        Console.WriteLine("Pop: " + stack.Pop()); 
        Console.WriteLine("Peek: " + stack.Peek()); 

 
        BinaryTree bst = new BinaryTree();
        bst.Add(50);
        bst.Add(30);
        bst.Add(70);
        bst.Add(20);
        bst.Add(40);
        bst.Add(60);
        bst.Add(80);
        Console.WriteLine("Contains 40: " + bst.Contains(40)); 
        Console.WriteLine("Contains 100: " + bst.Contains(100)); 
    }
}
