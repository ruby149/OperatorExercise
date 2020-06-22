using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string variableName = ("Hello World!");
            var varName = "Hello World";

            var a = 17;
            var b = 4;

            var quotient= a / b;
            var remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine($"What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = CalculateArea(radius);

            Console.WriteLine($"The area of a circle with radius {radius} is {areaOfCircle}");

        }
        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
