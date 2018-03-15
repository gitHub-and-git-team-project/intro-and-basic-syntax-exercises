using System;

namespace ProductCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            // We receive the value in miles
            double milesInput = double.Parse(Console.ReadLine());
            // We calculate the value in kilometers
            double kilometers = milesInput * 1.60934;
            //We print on the console the result
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
