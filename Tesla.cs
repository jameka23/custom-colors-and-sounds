using System;
namespace customColorsAndSounds
{
    public class Tesla : Vehicle
    {

        public double BatteryKWh { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla looks great with it's high speed! Lordy Lordy Michael Jordy.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla gently rolls to a stop!");
        }
        public void ChargeBattery()
        {
            Console.WriteLine("Tesla going to the charging tower");
        }
    }

}