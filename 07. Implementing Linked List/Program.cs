namespace Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList linkedlist = new CustomList();

            linkedlist.AddLast(16);
            linkedlist.AddLast(20);
            linkedlist.AddLast(24);
            linkedlist.AddLast(28);


            linkedlist.ForEach(x =>
            {
                Console.WriteLine($"Testing foreach -> {x.Value}");
            });

            linkedlist.RemoveFirst();
            linkedlist.RemoveLast();

            Node node = linkedlist.Head;

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}