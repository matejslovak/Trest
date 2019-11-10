using System;
using System.Collections.Generic;
using System.Text;

namespace Trest
{
    class storage
    {
        private readonly List<Battery> batteries;

        public storage()
        {
            batteries = new List<Battery>
            {
                new Battery("pencil battery", "AA+", 200, 90),
                new Battery("pencil battery", "AAA+", 100, 22),
                new Battery("pencil battery", "A+", 300, 11),
                new Battery("car battery ", "small", 500, 0),
                new Battery("truck battery", "big", 1000, 57),
            };
        }

        public void Update()
        {
            foreach (var battery in batteries)
            {
                battery.Update();
            }
        }

        public void recharge(string name, int amount)
        {
            Battery battery = FindBatteryBy(name);
            if (battery != null)
            {
                battery.Eat(amount);
            }
        }

        private Battery FindBatteryBy(string name)
        {
            foreach (var battery in batteries)
            {
                if (battery.Name.ToLower() == name.ToLower())
                {
                    return battery;
                }
            }

            return null;
        }
    }
}