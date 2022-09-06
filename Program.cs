namespace MinStack
{
    class Program
    {
        static void Main()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            minStack.GetMin();
            minStack.Pop();
            minStack.Top();
            minStack.GetMin();
        }
    }
}
