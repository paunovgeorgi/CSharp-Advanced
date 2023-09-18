int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = matrixSize[0];
int cols = matrixSize[1];
int[,] matrix = new int[rows, cols];
int sum = 0;

for (int row = 0; row < rows; row++)
{
    int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        sum += (matrix[row, col] = data[col]);
    }
}

Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);
