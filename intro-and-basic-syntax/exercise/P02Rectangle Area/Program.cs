using System;

namespace Problem_2_RectangleArea
{
    class Program
    {
        static void Main()
        {
            // We receive the 2D rectangle properties
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            // We calculate the rectangle 2D area
            double rectangleArea = width * height;

            // We write on the console the result, rounded to the second decimal number
            Console.WriteLine($"{rectangleArea:f2}");
        }
    }
}
