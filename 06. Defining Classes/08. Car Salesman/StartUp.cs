using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman;
internal class Program
    {
        static void Main(string[] args)
        {
            int numOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new();
            List<Car> cars = new();

            for (int i = 0; i < numOfEngines; i++)
            {
                string[] engineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = engineData[0];
                int power = int.Parse(engineData[1]);

                Engine currentEngine = new Engine(model, power);
                if (engineData.Length == 3)
                {
                    if (IsString(engineData[2]))
                    {
                        string efficiency = engineData[2];
                        currentEngine.Efficiency = efficiency;
                    }
                    else
                    { 
                       int displacement = int.Parse(engineData[2]);
                    currentEngine.Displacement = displacement;
                    }
                }
                else if (engineData.Length == 4)
                {
                    int displacement = int.Parse(engineData[2]);
                    string efficiency = engineData[3];
                    currentEngine.Displacement = displacement;
                    currentEngine.Efficiency = efficiency;
                }

                engines.Add(currentEngine);
            }

            int numOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCars; i++)
            {
            string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = carData[0];
            string engine = carData[1];

            Engine currentEngine = engines.FirstOrDefault(x => x.Model == engine);
            Car currentCar = new Car(model, currentEngine);
            if (carData.Length == 3)
            {
                if (IsString(carData[2]))
                {
                    string color = carData[2];
                    currentCar.Color = color;
                }
                else
                {
                int weight = int.Parse(carData[2]);
                currentCar.Weight = weight;
                }
            }

            else if (carData.Length == 4)
            {
                int weight = int.Parse(carData[2]);
                string color = carData[3];
                currentCar.Weight = weight;
                currentCar.Color = color;
            }
            cars.Add(currentCar);
        }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
        static bool IsString(string s)
        {
            if (char.IsLetter(s[0]))
            {
                return true;
            }

            return false;
        }


}
