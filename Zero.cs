using System;

namespace garys_garage
{
    public class Zero : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; } = 14;
        public double CurrentChargePercentage { get; set; } = 40;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
            Console.WriteLine($"Your Zero is now charged to {BatteryKWh}kWh");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips past. YEOWWWWWW!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turns {direction}");
        }
    }
}