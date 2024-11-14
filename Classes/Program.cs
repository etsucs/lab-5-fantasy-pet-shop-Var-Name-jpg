using System;

namespace Classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Set a discount percent for the sale (made this on haloween so dragon is 25% off
            int percDiscount = 25;

            // Creating the filler creatures
            FantasyPet dragon = new FantasyPet("Deez", "Dragon", 530, 49999.89m, "Fire Breath");
            FantasyPet imp = new FantasyPet("Schmebulock", "Imp", 32, 29.89m, "Scorpion Sting");
            FantasyPet gargoyle = new FantasyPet("Grunk", "Gargoyle", 602, 199999.89m, "Stone Blast");

            FantasyPet cyclops = new FantasyPet("Victoria", "Cyclops", 167, 499999.89m, "Lazer Vision"); // Saving this one to use the AddPet method

            // Put all the pets into the pet store
            List<FantasyPet> pets = new List<FantasyPet> { dragon, imp, gargoyle };

            // Create a PetStore obj using the list
            PetShop DaveAndSons = new PetShop(pets);

            // Use the AddPet method
            DaveAndSons.AddPet(cyclops);

            // List all the pets
            DaveAndSons.ListPets();

            // Tell the user about the dragon having a discounted price
            Console.WriteLine($"There is a Haloween sale for out store! The dragons are on sale for 25% off!\n{dragon.Name} is actually: ${Math.Round( dragon.DiscountPrice(percDiscount), 2) }");

            // Have one of the pets perform magic
            gargoyle.PerformMagic();
        }
    }
}