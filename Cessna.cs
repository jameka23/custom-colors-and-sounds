using System;
namespace customColorsAndSounds{
public class Cessna : Vehicle{  // Propellor light aircraft
    public double FuelCapacity { get; set; }
    public override void Drive () {
        Console.WriteLine($"Hot damn, look at that {MainColor} Cessna go!");
    }
    public void RefuelTank () { 
        Console.WriteLine("Refueling aircraft"); }
    }    
}