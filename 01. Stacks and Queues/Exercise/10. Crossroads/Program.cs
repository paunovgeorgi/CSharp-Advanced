int greenlight = int.Parse(Console.ReadLine());
int greenLightReset = greenlight;
int freeWindow = int.Parse(Console.ReadLine());
int carsPassed = 0;
string input = string.Empty;
Queue<string> cars = new Queue<string>();
while ((input = Console.ReadLine()) != "END")
{
    greenlight = greenLightReset;
    if (input != "green")
    {
        cars.Enqueue(input);
    }
    else if (input == "green")
    {
        while (greenlight > 0 && cars.Any())
        {
            if (greenlight >= cars.Peek().Length)
            {
               greenlight -= cars.Dequeue().Length;
               carsPassed++;
            }
            else
            {
                string currentCar = cars.Peek();
                if (currentCar.Length <= greenlight + freeWindow)
                {
                    cars.Dequeue();
                    carsPassed++;
                    greenlight = 0;
                }
                else
                {
                    int index = greenlight + freeWindow;
                    char currentLetter = currentCar[index];
                    Console.WriteLine($"A crash happened!");
                    Console.WriteLine($"{currentCar} was hit at {currentLetter}.");
                    return;
                }
            }
        }
    }
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{carsPassed} total cars passed the crossroads.");