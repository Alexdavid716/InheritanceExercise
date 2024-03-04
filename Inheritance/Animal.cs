using System;

public class Animal
{
 

    
    public string Name { get; set; }

   
    public int Age { get; set; }

   
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }

  
    public void Sleep()
    {
        Console.WriteLine("Zzzz...");
    }
}