string input; 
HashSet<string> normal = new HashSet<string>();
HashSet<string> vip = new HashSet<string>();

    while ((input = Console.ReadLine()) != "PARTY")
    {
        if (input[0] >= '0' && input[0] <= '9')
    {
        vip.Add(input);
    }
    else
    {
        normal.Add(input);
    }
}

while ((input = Console.ReadLine()) != "END")
{
    if (normal.Contains(input))
        {
            normal.Remove(input);
        }
        else if (vip.Contains(input))
        {
            vip.Remove(input);
        }
}

Console.WriteLine(normal.Count + vip.Count);

   if (vip.Any())
   {
       foreach (var person in vip)
       {
           Console.WriteLine(person);
       }
   }

   if (normal.Any())
   {
       foreach (var person in normal)
       {
           Console.WriteLine(person);
       }
   }