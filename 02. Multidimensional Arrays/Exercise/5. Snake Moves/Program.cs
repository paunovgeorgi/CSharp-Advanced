int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];
char[,] matrix = new char[rows, cols];
string snake = Console.ReadLine();
int currentIndex = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    if (row % 2 == 0)
    {
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (currentIndex == snake.Length)
        {
            currentIndex = 0;
        }
            matrix[row, col] = snake[currentIndex];
            currentIndex++;
    }
    }
    else
    {
        for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
    {
        if (currentIndex == snake.Length)
        {
            currentIndex = 0;
        }
        matrix[row, col] = snake[currentIndex];
        currentIndex++;
    }
    }
}

PrintMatrix(matrix);
void PrintMatrix(char[,] strings)
{
    for (int row = 0; row < strings.GetLength(0); row++)
    {
        for (int col = 0; col < strings.GetLength(1); col++)
        {
            Console.Write(strings[row, col]);
        }

        Console.WriteLine();
    }
}