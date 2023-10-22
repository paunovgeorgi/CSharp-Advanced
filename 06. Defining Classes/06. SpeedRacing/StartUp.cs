using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing;

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split();

            string model = data[0];
            double fuelAmount = double.Parse(data[1]);
            double fuelConsumption = double.Parse(data[2]);

            Car car = new Car(model, fuelAmount, fuelConsumption);
            cars.Add(car);
        }

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] carData = input.Split();
            string model = carData[1];
            double distance = double.Parse(carData[2]);

            Car currentCar = cars.FirstOrDefault(car => car.Model == model);
            currentCar.Drive(distance);
        }


        foreach (Car car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TraveledDistance}");
        }
    }
}