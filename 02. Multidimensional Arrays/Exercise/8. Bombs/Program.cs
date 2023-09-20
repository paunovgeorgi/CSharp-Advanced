int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];

for(int row = 0; row < size; row++)
{
    int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = data[col];
    }
}

int[] coordinates = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

for (int i = 0; i < coordinates.Length; i += 2)
{
    int bombRow = coordinates[i];
    int bombCol = coordinates[i + 1];
matrix = BombDetonation(size, bombRow, bombCol, matrix);
}

int aliveCells = 0;
int sum = 0;

foreach (int num in matrix)
{
    if (num > 0)
    {
        aliveCells++;
        sum += num;
    }
}

Console.WriteLine($"Alive cells: {aliveCells}");
Console.WriteLine($"Sum: {sum}");
PrintMatrix(size, matrix);

void PrintMatrix(int i, int[,] ints)
{
    for (int row = 0; row < i; row++)
    {
        for (int col = 0; col < i; col++)
        {
            Console.Write(ints[row, col] + " ");
        }

        Console.WriteLine();
    }
}
static int[,] BombDetonation(int size1, int firstBombRow1, int firstBombCol1, int[,] matrix1)
{
    for (int row = 0; row < size1; row++)
    {
        for (int col = 0; col < size1; col++)
        {
            if (row == firstBombRow1 && col == firstBombCol1)
            {
                int damage = matrix1[row, col];
                if (damage > 0)
                {
                    matrix1 = Explosion(damage, row, col, size1, matrix1);
                    matrix1[row, col] = 0;
                }
            }
        }
    }

    return matrix1;
}

static int[,] Explosion(int damage, int row, int col, int size, int[,] matrix)
{
    if (IsValid(row - 1, col - 1, size, matrix))
    {
        matrix[row - 1, col - 1] -= damage;
    }

    if (IsValid(row - 1, col, size, matrix))
    {
        matrix[row - 1, col] -= damage;
    }

    if (IsValid(row - 1, col + 1, size, matrix))
    {
        matrix[row - 1, col + 1] -= damage;
    }

    if (IsValid(row, col - 1, size, matrix))
    {
        matrix[row, col - 1] -= damage;
    }

    if (IsValid(row, col + 1, size, matrix))
    {
        matrix[row, col + 1] -= damage;
    }

    if (IsValid(row + 1, col + 1, size, matrix))
    {
        matrix[row + 1, col + 1] -= damage;
    }

    if (IsValid(row + 1, col, size, matrix))
    {
        matrix[row + 1, col] -= damage;
    }

    if (IsValid(row + 1, col - 1, size, matrix))
    {
        matrix[row + 1, col - 1] -= damage;
    }

    return matrix;
}

static bool IsValid(int row, int col, int size, int[,] matrix)
{
    return
        row >= 0
        && row < size
        && col >= 0
        && col < size
        && matrix[row, col] > 0;
}
