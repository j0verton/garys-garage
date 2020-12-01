using System;

namespace garys_garage
{
    public interface IGas
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank();
    }
}