using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
        class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            Console.WriteLine("lenth: " + numbers.Length);

            int index = Array.IndexOf(numbers, 9);

            Console.WriteLine("index of 9: " + index);

            Array.Clear(numbers, 0, 2);

            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
