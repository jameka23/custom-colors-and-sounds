using System;

namespace customColorsAndSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.BatteryKWh = 300;
            fxs.MainColor = "Yellow";
            fxs.MaximumOccupancy = "2";

            Tesla modelS = new Tesla();
            modelS.MaximumOccupancy = "5";
            modelS.MainColor = "Midnight Blue";
            modelS.BatteryKWh = 250;

            Cessna mx410 = new Cessna();
            mx410.MainColor = "Red";
            mx410.MaximumOccupancy = "2";
            mx410.FuelCapacity = 31;
            

            Ram ram1500 = new Ram();
            ram1500.FuelCapacity = 30;
            ram1500.MainColor = "Black";
            ram1500.MaximumOccupancy = "4";

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            ram1500.Drive();


        }
    }
}
