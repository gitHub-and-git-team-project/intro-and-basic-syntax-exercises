using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data for our product
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());
         

            //calculations
            var totalCalories = (double)energy * volume / 100;
            var totalSugar = (double)volume * sugar / 100;

            //output data
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{totalCalories}kcal, {totalSugar}g sugars");
        }
    }
}
