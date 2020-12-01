using System;

namespace garys_garage
{
    public class Cessna : Vehicle, IGas
    {
        public double FuelCapacity { get; set; } = 52;
        public double CurrentTankPercentage { get; set; } = 50;
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
            Console.WriteLine($"Your Cessna is all gassed up, {FuelCapacity} gal");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you. ZoooOOOOOOooM!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after breaking for a mile down the runway.");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna dips a wing and gracefully veers {direction}");

        }
    }
}