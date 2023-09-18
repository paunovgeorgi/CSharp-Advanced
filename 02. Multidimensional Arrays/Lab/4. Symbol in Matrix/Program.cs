int size = int.Parse(Console.ReadLine());
char[,] matrix = new char[size, size];

for (int row = 0; row < size; row++)
{
    string data = Console.ReadLine();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = data[col];
    }
}

char symbol = char.Parse(Console.ReadLine());
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (matrix[i, j] == symbol)
        {
            Console.WriteLine($"({i}, {j})");
            return;
        }
    }
}
Console.WriteLine($"{symbol} does not occur in the matrix");