int[][] jaggedArray = new int[int.Parse(Console.ReadLine())][];
for (int row = 0; row < jaggedArray.Length; row++)
{
    jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}

string input = string.Empty;

while ((input = Console.ReadLine()) != "END")
{
    string[] tokens = input.Split();
    string command = tokens[0];
    switch (command)
    {
        case "Add":
            int row = int.Parse(tokens[1]);
            int col = int.Parse(tokens[2]);
            int value = int.Parse(tokens[3]);
            if ((row >= 0 && row < jaggedArray.Length) && (col >= 0 && col < jaggedArray[row].Length))
            {
                jaggedArray[row][col] += value;
            }
            else
            {
                Console.WriteLine("Invalid coordinates");
            }
            break;
        case "Subtract":
            row = int.Parse(tokens[1]);
            col = int.Parse(tokens[2]);
            value = int.Parse(tokens[3]);
            if ((row >= 0 && row < jaggedArray.Length) && (col >= 0 && col < jaggedArray[row].Length))
            {
            jaggedArray[row][col] -= value;
            }
            else
            {
                Console.WriteLine("Invalid coordinates");
            }
            break;
    }
}

foreach (int[] array in jaggedArray)
{
    Console.WriteLine(string.Join(" ", array));
}