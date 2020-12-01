using System;

namespace garys_garage
{
    public interface IElectric
    {
        public double CurrentChargePercentage { get; set; }
        double BatteryKWh { get; set; }
        public void ChargeBattery();

    }

}