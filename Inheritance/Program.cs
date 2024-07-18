using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            
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
            var eagle = new Bird()
            {
                Name = "Bald Eagle",
                Age = 5,
                Species = "Haliaeetus leucocephalus",
                Weight = 6.3, // in kg
                WingSpan = 2.3, // in meters
                CanFly = true,
                FeatherColor = "Brown with white head",
                BeakType = "Hooked"
            };


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile snake = new Reptile
            {
                Name = "King Cobra",
                Age = 3,
                Species = "Ophiophagus hannah",
                Weight = 6.0, // in kg
                Length = 3.7, // in meters
                IsVenomous = true,
                Habitat = "Forests and plains",
                ScaleType = "Smooth"
            };
            
            Console.WriteLine("Eagle Details: ");
            Console.WriteLine(eagle.DisplayBirdDetails());
            
            Console.WriteLine("King Cobra Details: ");
            Console.WriteLine(snake.DisplayReptileDetails());

        }
    }
}
