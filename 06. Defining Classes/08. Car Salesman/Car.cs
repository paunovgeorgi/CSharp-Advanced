
using System.Text;

namespace CarSalesman;

    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine($"{Model}:");
            sb.AppendLine($"  {Engine.ToString()}");
            if (Weight != 0)
            {
                sb.AppendLine($"  Weight: {Weight}");
            }
            else
            {
                sb.AppendLine($"  Weight: n/a");
            }

            if (Color != null)
            {
                sb.AppendLine($"  Color: {Color}");
            }
            else
            {
                sb.AppendLine($"  Color: n/a");
            }

        return sb.ToString().TrimEnd();
        }
    }

