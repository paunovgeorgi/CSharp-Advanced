
using System.Text;

namespace CarSalesman;
public class Engine
    {
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;

        }

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{Model}:");
            sb.AppendLine($"    Power: {Power}");
            if (Displacement != 0)
            {
                sb.AppendLine($"    Displacement: {Displacement}");
            }
            else
            {
                sb.AppendLine($"    Displacement: n/a");
            }

            if (Efficiency != null)
            {
                sb.AppendLine($"    Efficiency: {Efficiency}");
            }
            else
            {
                sb.AppendLine($"    Efficiency: n/a");
            }

            return sb.ToString().TrimEnd();
        }
    }