using System;

namespace  DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        Person first = new Person();
        first.Name = "Glory";
        first.Age = 1878;

        Person second = new Person()
        {
            Name = "aaa",
            Age = 32
        };

        Console.WriteLine(first.Name + " " + second.Age);
    }
}