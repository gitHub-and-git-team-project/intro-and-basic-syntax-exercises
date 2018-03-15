

//This code is tested in Judge by Ivan Kirilov and works correctly. The result in Judge is 100/100.
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
