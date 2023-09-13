string input = Console.ReadLine();
Stack<char> brackets = new();
foreach (char c in input)
{
    switch (c)
    {
        case '(':
        case '[':
        case '{':
            brackets.Push(c);
            break;
        case ')':
            if (brackets.Count == 0 || brackets.Pop() != '(')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
        case ']':
            if (brackets.Count == 0 || brackets.Pop() != '[')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
        case '}':
            if (brackets.Count == 0 || brackets.Pop() != '{')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
    }
}

if (brackets.Count == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}


//if (input.Length % 2 == 0)
//{
//string firstPart = input.Substring(0, input.Length/2);
//string secondPart = input.Remove(0, input.Length / 2);
//secondPart = secondPart.Replace(')', '(').Replace(']', '[' ).Replace('}', '{');
//string reversed = string.Concat(secondPart.Reverse());
//if (firstPart == reversed)
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}
//}
//else
//{
//    Console.WriteLine("NO");
//}