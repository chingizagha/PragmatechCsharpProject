using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp
{
    class PizzaSize
    {
        public string Kicik { get; set; } = "Kicik";
        public string Orta { get; set; } = "Orta";

        public string Boyuk { get; set; } = "Boyuk";

        public string Maxi { get; set; } = "Maxi";


        public double KicikIndex { get; private set; } = 1.0f;
        public double OrtaIndex { get; private set; } = 1.25f;
        public double BoyukIndex { get; private set; } = 1.75f;
        public double MaxIndex { get; private set; } = 2.0f;
    }
}
