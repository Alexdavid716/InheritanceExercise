using System;

public class Reptile : Animal
{
   

    
    public bool IsColdBlooded { get; set; }

    
    public string ScaleType { get; set; }

    
    public bool LaysEggs { get; set; }

    
    public void Hibernate()
    {
        Console.WriteLine($"{Name} is hibernating.");
    }

   
    public override void MakeSound()
    {
        Console.WriteLine("Hiss hiss!");
    }
}