using System;

namespace customColorsAndSounds{
public class Ram : Vehicle{  // Gas powered truck
    public double FuelCapacity { get; set; }
    public override void Drive(){
        Console.WriteLine($"The {MainColor} Ram blazes by you. Look at that thing go!");
    }
    public void RefuelTank () { Console.WriteLine("Refueling the car.");
    }
}    
}