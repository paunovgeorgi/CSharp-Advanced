using System.Diagnostics;

string input;
Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

while ((input = Console.ReadLine()) != "Revision")
{
    string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string shop = tokens[0];
    string product = tokens[1];
    double price = double.Parse(tokens[2]);
    if (!shops.ContainsKey(shop))
    {
        shops.Add(shop, new Dictionary<string, double>());
    }
    shops[shop].Add(product, price);
}

foreach (var shop in shops.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{shop.Key}->");
    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
} 