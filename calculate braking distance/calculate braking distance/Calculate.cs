using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_braking_distance
{
    internal class Calculate
    {
        float k { get; set; }
        float f { get; set; }
        float v { get; set; }
        public float s { get; set; }
        public float number;
        public float Speed;


        public Calculate(float k, float f, float v)
        {
            this.k = k;
            this.f = f;
            this.v = v;
            s = 0F;
        }
        public Calculate()
        {
        }

        

        public void GetResult()
        {
                Console.WriteLine("Enter num (1 - icy; \n2 - snowy; \n3 - wet; \n4 - dry \n0 - Exit): ");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        number = 0.1F;
                        break;
                    case 2:
                        number = 0.2F;
                        break;
                    case 3:
                        number = 0.4F;
                        break;
                    case 4:
                        number = 0.7F;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

                Console.WriteLine("Enter speed (1 - 500): ");
                float.TryParse(Console.ReadLine(), out var speed);
                if (speed < 1 && speed > 500)
                {
                    Console.WriteLine("Error enter speed");
                    Environment.Exit(0);
                }
                Speed = speed;
        }
        public string Calculates()
        {
            s = (k / (254 * f)) * v * v;
            return $"Тормозной путь = {s} meters";
        }
    }
}
