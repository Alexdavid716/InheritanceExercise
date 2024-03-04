
using System;

public class Bird : Animal
{
    

    
    public double WingSpan { get; set; }

   
    public bool CanFly { get; set; }

    
    public string NestLocation { get; set; }

    
    public void Fly()
    {
        Console.WriteLine($"{Name} is flying.");
    }

    
    public override void MakeSound()
    {
        Console.WriteLine("Chirp chirp!");
    }
}