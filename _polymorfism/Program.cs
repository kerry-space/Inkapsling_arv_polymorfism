using System;
using System.Security.Cryptography;
using Inkapsling_arv_polymorfism;

namespace Inkapsling_arv_polymorfisms
{
    class Program
    {
        static void Main(string[] args)
        {

           /*  3.1
           PersonHandler personhandler = new PersonHandler();

            try
            {
                Person person = personhandler.CreatePerson(25, "kerry", "jalal", 180.5, 75.0);
                personhandler.DisplayPersonInfo(person);

                personhandler.SetAge(person, 30);
                Console.WriteLine("After updating age:");
                personhandler.DisplayPersonInfo(person);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

            }
            */

            /* 3.2
            List<UserError> userErrors = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError()
            };

            foreach (UserError item in userErrors)
            {
               
                Console.WriteLine("________________________________________________");
                Console.WriteLine(item.UEMessage());

            } 

            //egna

            List<UserError> userErrors2 = new List<UserError>
            {
                new LoginError(),
                new ConnectionError(),
                new PermissionError()
            };

             Console.WriteLine("=========================================My Own Classes======================================================");

            foreach (UserError item in userErrors2)
            {
                Console.WriteLine("________________________________________________________________________");
                Console.WriteLine(item.UEMessage());
                Console.WriteLine("________________________________________________________________________");

            } 
            */

            /* 3.3
            //13.F Om samtliga fåglar behöver det  nya attributet, bör vi lägga det i Bird-klassen

             // Create instances of different animals
            Dog dog = new Dog("Buddy", 30.5, 5, "Labrador");
            Horse horse = new Horse("Spirit", 500, 8, "Mustang");
            Hedgehog hedgehog = new Hedgehog("Sonic", 1.2, 2, 5000);
            Worm worm = new Worm("Wiggly", 0.05, 1, false);
            Bird bird = new Bird("Tweety", 0.1, 1, 0.25);
            Wolf wolf = new Wolf("Alpha", 40, 7, "Pack1");

            Pelican pelican = new Pelican("Perry", 10, 3, 2, 0.5);
            Flamingo flamingo = new Flamingo("Flora", 8, 4, 2.5, "Pink");
            Swan swan = new Swan("Sam", 12, 5, 3, "Long");

            // Använd deras egenskaper och metoder
            dog.DoSound();
            Console.WriteLine($"{dog.Name} is a {dog.Breed} and weighs {dog.Weight} kg.");

            horse.DoSound();
            Console.WriteLine($"{horse.Name} is a {horse.Breed} and weighs {horse.Weight} kg.");

            hedgehog.DoSound();
            Console.WriteLine($"{hedgehog.Name} has {hedgehog.NumberOfSpikes} spikes and weighs {hedgehog.Weight} kg.");

            worm.DoSound();
            Console.WriteLine($"{worm.Name} is poisonous: {worm.IsPoisonous} and weighs {worm.Weight} kg.");

            bird.DoSound();
            Console.WriteLine($"{bird.Name} has a wingspan of {bird.WingSpan} meters and weighs {bird.Weight} kg.");

            wolf.DoSound();
            Console.WriteLine($"{wolf.Name} is part of the {wolf.PackName} pack and weighs {wolf.Weight} kg.");

            pelican.DoSound();
            Console.WriteLine($"{pelican.Name} has a beak length of {pelican.BeakLength} meters and weighs {pelican.Weight} kg.");

            flamingo.DoSound();
            Console.WriteLine($"{flamingo.Name} is {flamingo.Color} and has a wingspan of {flamingo.WingSpan} meters.");

            swan.DoSound();
            Console.WriteLine($"{swan.Name} has a neck length of {swan.NeckLength} and weighs {swan.Weight} kg.");

            // Skapa och använd en Wolfman
            Wolfman wolfman = new Wolfman("Lupin", 80, 30, "Lone Wolf");
            wolfman.DoSound();
            wolfman.Talk();
            Console.WriteLine($"{wolfman.Name} is part of the {wolfman.PackName} pack and weighs {wolfman.Weight} kg.");
            */


            List<Animal> animals = new List<Animal>
            {
                new Bird("Tweety", 0.1, 1, 0.25),
                new Wolfman("Lupin", 80, 30, "Lone Wolf"),
                new Horse("Spirit", 500, 8, "Mustang"),
                new Hedgehog("Sonic", 1.2, 2, 5000),
                new Worm("Wiggly", 0.05, 1, false),
                new Pelican("Perry", 10, 3, 2, 0.5),
                new Flamingo("Flora", 8, 4, 2.5, "Pink"),
                new Swan("Sam", 12, 5, 3, "Long"),
                new Wolf("Alpha", 40, 7, "Pack1"),
                new Dog("Buddy", 30.5, 5, "Labrador"),
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());

                // Kontrollera om djuret också är av typen IPerson
                if (animal is IPerson person)
                {
                    Console.WriteLine("_______________________Type Iperson_______________________________");
                    person.Talk();
                    Console.WriteLine("__________________________________________________________________");

                }
               
            }


            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Buddy", 30.5, 5, "Labrador"));

            //1. Detta fungerar inte eftersom Horse inte är av typen Dog
            // dogs.Add(new Horse("Spirit", 500, 8, "Mustang"));   <--- Kommer att ge ett kompileringsfel eftersom typerna är olika och inte kompatibla

            //2. För att kunna lagra alla klasser samma lista måste listan deklareras med den gemensamma bastypen som alla dessa klasser delar, som är Animal 
           
            //16.  Vi kan inte direkt anropa GetDogInfo på Animal-objekt eftersom Animal inte har denna metod. Vi måste först type-casta till Dog.
           
            Console.WriteLine("\nCalling the new method on all dogs:");
            foreach (var animal in animals)
            {
                //här typecast vi till Dog för komma åt GetDogInfo() methoden
                if (animal is Dog dog)
                {
                     Console.WriteLine("__________________________________________________________________");
                    Console.WriteLine(dog.GetDogInfo());
                }
            }
             Console.WriteLine("__________________________________________________________________");
        }
    }


}
