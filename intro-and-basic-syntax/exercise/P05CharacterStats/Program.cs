using System;

namespace Problem05_CharacterStats
{
    class Program
    {
        static void Main()
        {
            // We recieve from the Console the name of the game character -> a string
            string name = Console.ReadLine();

            /* In the next four lines, we recieve
             * current health, maximum health,
             * current energy and maximum energy -> as integer*/
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            // We print the characters name
            Console.WriteLine($"Name: {name}");

            /* We calculate and display the information about the characters
             * health and energy */
            Console.WriteLine($"Health: |{new string('|',currentHealth)}{new string('.', maximumHealth - currentHealth)}|");
            Console.WriteLine($"Energy: |{new string('|',currentEnergy)}{new string('.', maximumEnergy - currentEnergy)}|");

        }
    }
}
