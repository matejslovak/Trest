using System;
using System.Collections.Generic;
using System.Text;

namespace Trest
{
    class Storage
    {
        private readonly List<Battery> batteries;

        public Storage()
        {
            batteries = new List<Battery>
            {
                new Battery("pencil battery 2", "AA+", 200, 0),
                new Battery("pencil battery 3", "AAA+", 100, 91),
                new Battery("pencil battery 1", "A+", 300, 11),
                new Battery("car battery", "small", 0, 0),
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

        public void Recharge(string name, int amount)
        {
            Battery battery = FindBatteryBy(name);
            if (battery != null)
            {
                battery.Charge(amount);
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