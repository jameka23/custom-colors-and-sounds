using System;

namespace customColorsAndSounds
{
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips past you. Wheeeeeeeeeeew, doggy!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero carefully turns {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero gently rolls to a stop!");
        }
        public void ChargeBattery()
        {
            Console.WriteLine("Zero, going to the charge tower.");
        }
    }

}