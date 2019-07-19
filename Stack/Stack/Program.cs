using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> a = new MyStack<int>();
            a.Push(5);
            a.Push(6);
            a.Push(7);
            a.Print();
            Console.WriteLine(a.Pop());
            a.Print();
           
        }
    }
}