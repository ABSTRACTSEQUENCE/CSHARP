using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandBox
{
    class Car
    {
        public string brand { get; }
        public double price { get; }
        public double power { get; }

        public Car(string brand, double price, double power)
        {
            this.brand = brand; this.price = price; this.power = power;
        }
    }
}
