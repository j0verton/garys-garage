using System;

namespace garys_garage
{
    public class Boat : Vehicle, IGas
    {
        public double FuelCapacity { get; set; } = 22;
        public double CurrentTankPercentage { get; set; } = 50;
        public void RefuelTank()
        {
            {
                CurrentTankPercentage = 100;
                Console.WriteLine($"Your Boat is all gassed up, {FuelCapacity} gal");
            }
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Boat kicks up wake!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Boat slowly turns {direction}");
        }
    }

}