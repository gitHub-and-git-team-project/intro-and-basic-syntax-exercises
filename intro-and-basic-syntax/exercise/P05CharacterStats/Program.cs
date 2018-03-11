using System;

namespace Problem05_CharacterStats
{
    class Program
    {
        static void Main()
        {
            // We recieve from the Console the name of the game character -> a string
            string player = Console.ReadLine();

            /* In the next four lines, we recieve
             * current health, maximum health,
             * current energy and maximum energy -> as integer*/
            int currHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            // We print the characters name
            Console.WriteLine($"Name: {name}");

            /* We calculate and display the information about the characters
             * health and energy */
            Console.WriteLine($"Health: |{new string('|', currHealth)}{new string('.', maxHealth - currHealth)}|");
            Console.WriteLine($"Energy: |{new string('|', currEnergy)}{new string('.', maxEnergy - currEnergy)}|");

        }
    }
}