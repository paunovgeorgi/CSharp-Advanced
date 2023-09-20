int fieldSize = int.Parse(Console.ReadLine());
string[] moves = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int coalCount = 0;
char[,] matrix = new char[fieldSize, fieldSize];

for (int row = 0; row < fieldSize; row++)
{
    char[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int col = 0; col < fieldSize; col++)
    {
        matrix[row, col] = data[col];
    }
}

string command = string.Empty;
int currentRow = 0;
int currentCol = 0;
for (int row = 0; row < fieldSize; row++)
{
    for (int col = 0; col < fieldSize; col++)
    {
        if (matrix[row,col] == 's')
        {
            int miner = 0;
            currentRow = row;
            currentCol = col;
            for (int i = 0; i < moves.Length; i++)
            {
                command = moves[i];
                switch (command)
                {
                    case "left":
                        if (IsValid(currentRow, currentCol - 1, fieldSize))
                        {
                            miner = matrix[currentRow, currentCol - 1];
                            currentCol = currentCol - 1;
                            switch (miner)
                            {
                                case 'e':
                                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                                    return;
                                case 'c':
                                    matrix[currentRow, currentCol] = '*';
                                    coalCount++;
                                    break;                               
                            }
                        }
                        break;
                    case "right":
                        if (IsValid(currentRow, currentCol + 1, fieldSize))
                        {
                            miner = matrix[currentRow, currentCol + 1];
                            currentCol = currentCol + 1;
                            switch (miner)
                            {
                                case 'e':
                                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                                    return;
                                case 'c':
                                    matrix[currentRow, currentCol] = '*';
                                    coalCount++;
                                    break;
                            }
                        }
                        break;
                    case "up":
                        if (IsValid(currentRow - 1, currentCol, fieldSize))
                        {
                            miner = matrix[currentRow - 1, currentCol];
                            currentRow = currentRow - 1;
                            switch (miner)
                            {
                                case 'e':
                                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                                    return;
                                case 'c':
                                    matrix[currentRow, currentCol] = '*';
                                    coalCount++;
                                    break;
                            }
                        }
                        break;
                    case "down":
                        if (IsValid(currentRow + 1, currentCol, fieldSize))
                        {
                            miner = matrix[currentRow + 1, currentCol];
                            currentRow = currentRow + 1;
                            switch (miner)
                            {
                                case 'e':
                                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                                    return;
                                    break;
                                case 'c':
                                    matrix[currentRow, currentCol] = '*';
                                    coalCount++;
                                    break;
                            }
                        }
                        break;
                }
            }
        }
    }
}

int coalsLeft = 0;

for (int row = 0; row < fieldSize; row++)
{
    for (int col = 0; col < fieldSize; col++)
    {
        if (matrix[row,col] == 'c')
        {
            coalsLeft++;
        }
    }
}

if (coalsLeft > 0)
{
    Console.WriteLine($"{coalsLeft} coals left. ({currentRow}, {currentCol})");
}
else
{
    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
}

static bool IsValid(int row, int col, int size)
{
    return
        row >= 0
        && row < size
        && col >= 0
        && col < size;
}