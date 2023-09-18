int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];

for (int rows = 0; rows < size; rows++)
{
    int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int cols = 0; cols < size; cols++)
    {
        matrix[rows, cols] = data[cols];
    }
}

int sum = 0;
for (int row = 0; row < size; row++)
{ 
       sum += matrix[row, row]; 
}

Console.WriteLine(sum);