using System.Text;
int n = int.Parse(Console.ReadLine());
string sb = string.Empty;
Stack<string> stack = new();
string lastString = String.Empty;

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split();
    int command = int.Parse(tokens[0]);
    switch (command)
    {
        case 1:
            string toAppend = tokens[1];
            sb +=toAppend;
            stack.Push(sb);
            break;
        case 2:
            int index = int.Parse(tokens[1]);
            sb = sb.Remove(sb.Length - index, index);
            stack.Push(sb);
            break;
        case 3:
            index = int.Parse(tokens[1]);
            Console.WriteLine(sb[index - 1]);
            break;
        case 4:
           stack.Pop();
           if (!stack.Any())
           {
               stack.Push("");
           }
           sb = stack.Peek();
            break;
    }
}