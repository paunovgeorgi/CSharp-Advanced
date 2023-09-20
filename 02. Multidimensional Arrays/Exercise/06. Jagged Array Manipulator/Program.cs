int rows = int.Parse(Console.ReadLine());
int[][] jaggedArray = new int[rows][];

for (int row = 0; row < jaggedArray.Length; row++)
{
    jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}

for (int row = 0; row < jaggedArray.Length - 1; row++)
{
    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
    {
        for (int i = 0; i < jaggedArray[row].Length; i++)
        {
            jaggedArray[row][i] *= 2;
            jaggedArray[row + 1][i] *= 2;
        }
    }
    else
    {
        for (int i = 0; i < jaggedArray[row].Length; i++)
        {
            jaggedArray[row][i] /= 2;
        }

        for (int i = 0; i < jaggedArray[row + 1].Length; i++)
        {
            jaggedArray[row + 1][i] /= 2;
        }
    }
}

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = tokens[0];
    int row = int.Parse(tokens[1]);
    int col = int.Parse(tokens[2]);
    int value = int.Parse(tokens[3]);
    switch (command)
    {
        case "Add":
            if ((row >= 0 && row < jaggedArray.Length) && (col >= 0 && col < jaggedArray[row].Length))
            {
                jaggedArray[row][col] += value;
            }
            break;
        case "Subtract":
            if ((row >= 0 && row < jaggedArray.Length) && (col >= 0 && col < jaggedArray[row].Length))
            {
                jaggedArray[row][col] -= value;
            }
            break;

    }
}

foreach (int[] array in jaggedArray)
{
    Console.WriteLine(string.Join(" ", array));
}