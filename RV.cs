using System;

namespace garys_garage
{
    public class RV : Vehicle, IGas
    {
        public double FuelCapacity { get; set; } = 22;
        public double CurrentTankPercentage { get; set; } = 50;
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
            Console.WriteLine($"Your RV is all gassed up, {FuelCapacity} gal");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} RV drives past. RRrrrrrummbbble!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} RV slowly turns {direction} like a lumbering elephant");
        }
    }

}