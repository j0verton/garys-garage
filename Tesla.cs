using System;

namespace garys_garage
{
    public class Tesla : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; } = 100;

        public double CurrentChargePercentage { get; set; } = 40;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
            Console.WriteLine($"Your Tesla is now charged to {BatteryKWh}kWh");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past. mmmmmmMMMMMMmmmmm!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla stops, making no sound at all, as if it never moved.");
        }
    }
}