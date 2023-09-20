using System.Numerics;

int size = int.Parse(Console.ReadLine());

char[,] board = new char[size, size];
string data;
int knightsRemoved = 0;

if (size <= 2)
{
    Console.WriteLine(0);
    return;
}
for (int row = 0; row < size; row++)
{
    data = Console.ReadLine();
    for (int col = 0; col < size; col++)
    {
        board[row, col] = data[col];
    }
}

while (true)
{

    int countMostAttacks = 0;
    int rowMostAttacks = 0;
    int colMostAttacks = 0;

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            if (board[row, col] == 'K')
            {
                int attackedKnights = CountAttackedKnights(row, col, size, board);

                if (attackedKnights > countMostAttacks)
                {
                    countMostAttacks = attackedKnights;
                    rowMostAttacks = row;
                    colMostAttacks = col;
                }
            }
        }
    }

    if (countMostAttacks == 0)
    {
        break;
    }
    else
    {
        board[rowMostAttacks, colMostAttacks] = 'O';
        knightsRemoved++;
    }
}

Console.WriteLine(knightsRemoved);
static int CountAttackedKnights(int row, int col, int size, char[,] matrix)
{
    int attackedKnights = 0;

    // Left-Up
    if (IsCellValid(row - 1, col - 2, size))
    {
        if (matrix[row -1, col - 2] == 'K')
        {
            attackedKnights++;
        }
    }
    // Left-Down 
    if (IsCellValid(row + 1, col - 2, size))
    {
        if (matrix[row + 1, col - 2] == 'K')
        {
            attackedKnights++;
        }
    }
    // Up-Left
    if (IsCellValid(row - 2, col - 1, size))
    {
        if (matrix[row - 2, col - 1] == 'K')
        {
            attackedKnights++;
        }
    }
    // Up-Right
    if (IsCellValid(row - 2, col + 1, size))
    {
        if (matrix[row - 2, col + 1] == 'K')
        {
            attackedKnights++;
        }
    }
    // Right-Up
    if (IsCellValid(row - 1, col + 2, size))
    {
        if (matrix[row - 1, col + 2] == 'K')
        {
            attackedKnights++;
        }
    }
    // Right-Down
    if (IsCellValid(row + 1, col + 2, size))
    {
        if (matrix[row + 1, col + 2] == 'K')
        {
            attackedKnights++;
        }
    }
    // Down-Left
    if (IsCellValid(row + 2, col - 1, size))
    {
        if (matrix[row + 2, col - 1] == 'K')
        {
            attackedKnights++;
        }
    }
    // Down-Right
    if (IsCellValid(row + 2, col + 1, size))
    {
        if (matrix[row + 2, col + 1] == 'K')
        {
            attackedKnights++;
        }
    }

    return attackedKnights;
}

static bool IsCellValid(int row, int col, int size)
{
    return
        row >= 0
        && row < size
        && col >= 0
        && col < size;
}