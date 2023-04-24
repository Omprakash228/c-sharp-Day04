using Generics;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stk = new MyStack<int>();
            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            Console.WriteLine(stk.Count);
            stk.Pop();
            Console.WriteLine(stk.Count);
        }
    }
}