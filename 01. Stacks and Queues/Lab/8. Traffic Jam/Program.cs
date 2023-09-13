int n = int.Parse(Console.ReadLine());
string input;
Queue<string> cars = new Queue<string>();
int counter = 0;
while ((input = Console.ReadLine()) != "end")
{
    if (input != "green")
    {
        cars.Enqueue(input);
    }
    else
    {
        if (n > cars.Count)
        {
            n = cars.Count;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{cars.Dequeue()} passed!");
            counter++;
        }
    }
}
Console.WriteLine($"{counter} cars passed the crossroads.");