using System;

namespace garys_garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"Your Tesla is now charged to {BatteryKWh}kWh");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. RRrrrrrummbbble!");
        }
    }
}