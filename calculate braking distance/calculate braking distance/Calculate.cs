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
        float s { get; set; }

        public Calculate(float k, float f, float v)
        {
            this.k = k;
            this.f = f;
            this.v = v;
            s = 0F;
        }

        public string Calculates()
        {
            s = (k / (254 * f)) * v * v;
            return $"Тормозной путь = {s} meters";
        }
    }
}
