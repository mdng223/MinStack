using System.Collections.Generic;
using System.Linq;
using System;

namespace MinStack
{
    public class MinStack
    {
        public MinStack() => Stack = new Stack<int>();

        public Stack<int> Stack { get; set; }

        public void GetMin()
        {
            if (Stack.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Console.WriteLine($"Minimum element in the stack is {Stack.Min()}");
            }
        }

        public void Pop() => Stack.Pop();

        public void Push(int val) => Stack.Push(val);
        
        public void Top()
        {
            if (Stack.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Console.WriteLine($"Top element in the stack is {Stack.LastOrDefault()}");
            }
        }
    }
}
