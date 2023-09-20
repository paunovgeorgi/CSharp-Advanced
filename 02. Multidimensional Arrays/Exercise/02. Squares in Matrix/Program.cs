int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];
char[,] matrix = new char[rows, cols];
int squareCount = 0;

for (int row = 0; row < rows; row++)
{
    char[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
    }
}

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        if (IsEqual(matrix, row, col))
        {
            squareCount++;
        }
    }
}

Console.WriteLine(squareCount);

bool IsEqual(char[,] chars, int row, int col)
{
    return chars[row, col] == chars[row, col + 1] && chars[row, col] == chars[row + 1, col] &&
           chars[row, col] == chars[row + 1, col + 1];
}
