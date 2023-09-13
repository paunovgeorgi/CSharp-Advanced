using System.Text;
string input = Console.ReadLine();
Stack<int> openBrackets = new Stack<int>();
var sb = new StringBuilder();
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        openBrackets.Push(i);
    }

    if (input[i] == ')')
    {
        int index = openBrackets.Pop();
        sb.AppendLine(input.Substring(index, ((i + 1) - index)));
    }
}
Console.WriteLine(sb);