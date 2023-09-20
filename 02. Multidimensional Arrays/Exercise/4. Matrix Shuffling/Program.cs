using System.Drawing;
int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];

string[,] matrix = new string[rows,cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = data[col];
    }
}

string input = String.Empty;

while ((input = Console.ReadLine()) != "END")
{
    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (tokens[0] != "swap" || tokens.Length != 5)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    int row1 = int.Parse(tokens[1]);
    int col1 = int.Parse(tokens[2]);
    int row2 = int.Parse(tokens[3]);
    int col2 = int.Parse(tokens[4]);
    if (row1 < 0 || row1 >= matrix.GetLength(0)
                 || row2 < 0 || row2 >= matrix.GetLength(0)
                 || col1 < 0 || col1 >= matrix.GetLength(1)
                 || col2 < 0 || col2 >= matrix.GetLength(1))
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    string current = matrix[row1, col1];
    matrix[row1, col1] = matrix[row2, col2];
    matrix[row2, col2] = current;
    PrintMatrix(matrix);
}

void PrintMatrix(string[,] strings)
{
    for (int row = 0; row < strings.GetLength(0); row++)
    {
        for (int col = 0; col < strings.GetLength(1); col++)
        {
            Console.Write(strings[row, col] + " ");
        }

        Console.WriteLine();
    }
}