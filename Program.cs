using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write celsius: ");

            int celsius = Convert.ToInt32(Console.ReadLine());
            int fahrenheit = celsius * 9 / 5 + 32;

            Console.WriteLine("{0} °C: {1} °F", celsius, fahrenheit);
            Console.ReadLine();
        }
    }
}
