using System.Collections;
string[] inputElements = Console.ReadLine().Split();
Stack<string>  stack = new Stack<string>(inputElements.Reverse());
while (stack.Count > 1)
{
    int firstNum = int.Parse(stack.Pop());
    string currentOperator = stack.Pop();
    int secondNum = int.Parse(stack.Pop());

    if (currentOperator == "+")
    {
        stack.Push((firstNum + secondNum).ToString());
    }
    else
    {
        stack.Push((firstNum - secondNum).ToString());
    }
}
Console.WriteLine(stack.Pop());