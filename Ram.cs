using System;

namespace garys_garage
{
    public class Ram : Vehicle, IGas// Gas powered truck
    {
        public double FuelCapacity { get; set; } = 22;
        public double CurrentTankPercentage { get; set; } = 50;
        public void RefuelTank()
        {
            {
                CurrentTankPercentage = 100;
                Console.WriteLine($"Your Ram is all gassed up, {FuelCapacity} gal");
            }
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. RRrrrrrummbbble!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram slowly turns {direction} like a lumbering elephant");
        }
    }
}