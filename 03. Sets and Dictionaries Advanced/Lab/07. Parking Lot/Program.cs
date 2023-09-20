string input;
HashSet<string> cars = new HashSet<string>();
while ((input = Console.ReadLine()) != "END")
{
    string[] tokens = input.Split(", ");
    string command = tokens[0];
    string car = tokens[1];

    if (command == "IN")
    {
        cars.Add(car);
    }
    else
    {
        cars.Remove(car);
    }
}

if (cars.Any())
{
foreach (var car in cars)
{
    Console.WriteLine(car);
}
}

else
{
    Console.WriteLine("Parking Lot is Empty");
}