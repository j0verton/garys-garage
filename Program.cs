using System;
using System.Collections.Generic;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zero fxs = new Zero()
            // {
            //     MainColor = "Red"
            // };
            // Tesla modelS = new Tesla()
            // {
            //     MainColor = "Silver"
            // };
            // Cessna mx410 = new Cessna()
            // {
            //     MainColor = "White"
            // };

            // Ram myTruck = new Ram()
            // {
            //     MainColor = "Grey"
            // };

            // fxs.Drive();
            // fxs.Turn("right");
            // fxs.Stop();
            // modelS.Drive();
            // modelS.Stop();
            // mx410.Drive();
            // mx410.Stop();
            // mx410.Turn("left");
            // myTruck.Drive();
            // myTruck.Turn("right");

            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}
