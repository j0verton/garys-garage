using System;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Red"
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Silver"
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "White"
            };

            Ram myTruck = new Ram()
            {
                MainColor = "Grey"
            };

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            modelS.Drive();
            modelS.Stop();
            mx410.Drive();
            mx410.Stop();
            mx410.Turn("left");
            myTruck.Drive();
            myTruck.Turn("right");
        }
    }
}
