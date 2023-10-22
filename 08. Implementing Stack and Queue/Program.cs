namespace Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new();

            list.Add(100);

            CustomStack stack = new();

            stack.Push(16);
            stack.Push(32);
            stack.Push(48);

            stack.ForEach(item => Console.Write($"{item} "));
        }
    }
}