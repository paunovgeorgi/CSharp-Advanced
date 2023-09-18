int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size,size];

for (int row = 0; row < size; row++)
{
    int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = data[col];
    }
}

int primaryDiagonalSum = 0;
int secondaryDiagonalSum = 0;

for (int row = 0; row < size; row++)
{
    primaryDiagonalSum += matrix[row, row];
    secondaryDiagonalSum += matrix[size - row - 1, row];
}

int difference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
Console.WriteLine(difference);