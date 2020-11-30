using System;

namespace garys_garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
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