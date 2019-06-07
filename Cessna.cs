using System;
namespace customColorsAndSounds
{
    public class Cessna : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"Hot damn, look at that {MainColor} Cessna go!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna carefully turns {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna gently rolls to a stop!");
        }
        public void RefuelTank()
        {
            Console.WriteLine("Refueling aircraft");
        }
    }
}