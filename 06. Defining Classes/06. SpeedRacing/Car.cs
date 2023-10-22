using System;

namespace SpeedRacing;

public class Car
{
    public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKm = fuelConsumptionPerKm;
        TraveledDistance = 0;
    }

    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKm { get; set; }
    public double TraveledDistance { get; set; }

    public void Drive(double distance)
    {
        if (FuelAmount >= distance * FuelConsumptionPerKm)
        {
            TraveledDistance += distance;
            FuelAmount -= distance * FuelConsumptionPerKm;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}   