int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[,] matrix = new int[dimensions[0], dimensions[1]];
int[,] output = new int[3, 3];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = data[col];
    }
}

int sum = 0;

for (int row = 0; row < matrix.GetLength(0) - 2; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
    {
        int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] +
                         matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] +
                         matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
        if (currentSum > sum)
        {
            sum = currentSum;
            output[0, 0] = matrix[row, col];
            output[0, 1] = matrix[row, col +1];
            output[0, 2] = matrix[row, col +2];
            output[1, 0] = matrix[row + 1, col];
            output[1, 1] = matrix[row + 1, col + 1];
            output[1, 2] = matrix[row + 1, col + 2];
            output[2, 0] = matrix[row + 2, col];
            output[2, 1] = matrix[row + 2, col + 1];
            output[2, 2] = matrix[row + 2, col + 2];
        }
    }
}

Console.WriteLine($"Sum = {sum}");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(output[i, j] + " ");
    }
    Console.WriteLine();
}