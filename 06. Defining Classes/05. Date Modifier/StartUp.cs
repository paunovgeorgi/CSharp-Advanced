﻿namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

           int difference = DateModifier.GetDifference(startDate, endDate);
            Console.WriteLine(difference);
        }
    }
}