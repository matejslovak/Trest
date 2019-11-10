using System;
using System.Collections.Generic;
using System.Text;

namespace Trest
{
    class Battery
    {
        public Battery(string name, string type, int lifespan, int recharge)
        {
            Name = name;
            Type = type;
            Lifespan = lifespan;
            Recharge = recharge;
        }

        public string Name { get; }
        public string Type { get; }
        public int Lifespan { get; set; }
        public int Recharge { get; set; }

        public void Update()
        {
            if (Lifespan <= 0) return;
            Recharge--;
            if (Recharge <= 0)
            {
                Lifespan--;
                if (Lifespan > 0)
                {
                    Console.WriteLine($"{Name} The battery discharges.");
                }
                else
                {
                    Console.WriteLine($"{Name} The battery is out.");
                    Lifespan = 0;
                }

                Recharge = 0;
            }
        }

        public void Eat(int amount)
        {
            Recharge += amount;
        }
    }
}