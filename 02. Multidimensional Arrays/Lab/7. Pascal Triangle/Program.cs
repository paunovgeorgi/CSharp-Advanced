int n = int.Parse(Console.ReadLine());
long[][] jagged = new long[n][];
jagged[0] = new long[1] { 1 };

for (int row = 1; row < n; row++)
{
    jagged[row] = new long[row + 1];

    for (int col = 0; col < jagged[row].Length; col++)
    {
        if (jagged[row - 1].Length > col)
        {
            jagged[row][col] += jagged[row - 1][col];
        }
        if (col > 0)
        {
            jagged[row][col] += jagged[row - 1][col - 1];
        }
    }
}

foreach (long[] array in jagged)
{
    Console.WriteLine(string.Join(" ", array));
}
