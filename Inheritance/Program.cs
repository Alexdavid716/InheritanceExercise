using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

         
            
            
                
                Bird myBird = new Bird();

                
                myBird.Name = "Sparrow";
                myBird.Age = 3;
                myBird.WingSpan = 10.5;
                myBird.CanFly = true;
                myBird.NestLocation = "Tree";

               
                Console.WriteLine("Bird Details:");
                Console.WriteLine($"Name: {myBird.Name}");
                Console.WriteLine($"Age: {myBird.Age} years old");
                Console.WriteLine($"Wing Span: {myBird.WingSpan} inches");
                Console.WriteLine($"Can Fly: {(myBird.CanFly ? "Yes" : "No")}");
                Console.WriteLine($"Nest Location: {myBird.NestLocation}");
                myBird.MakeSound();
                Console.WriteLine();

                
                Reptile myReptile = new Reptile();

                
                myReptile.Name = "Snake";
                myReptile.Age = 5;
                myReptile.IsColdBlooded = true;
                myReptile.ScaleType = "Scales";
                myReptile.LaysEggs = true;

               
                Console.WriteLine("Reptile Details:");
                Console.WriteLine($"Name: {myReptile.Name}");
                Console.WriteLine($"Age: {myReptile.Age} years old");
                Console.WriteLine($"Is Cold-Blooded: {(myReptile.IsColdBlooded ? "Yes" : "No")}");
                Console.WriteLine($"Scale Type: {myReptile.ScaleType}");
                Console.WriteLine($"Lays Eggs: {(myReptile.LaysEggs ? "Yes" : "No")}");
                myReptile.MakeSound();
            }
        }
    }
    

