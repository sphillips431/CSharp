using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 1 and 10: ");
            string input = Console.ReadLine();
            int inputNumber = Int32.Parse(input);

            if (inputNumber >= 1 && inputNumber <= 10)
            {
                Console.WriteLine("Valid Input");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("Enter number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine(number1 + " is the larger than " + number2);
            }
            else if (number2 > number1)
            {
                Console.WriteLine(number2 + " is the larger than " + number1);
            }
            else
            {
                Console.WriteLine(number1 + " is equal to " + number2);
            }

            Console.WriteLine("What is the speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the speed of the car?: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());



            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int speedDifference = carSpeed - speedLimit;
                int demeritPoints = speedDifference / 5;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("You've lost " + demeritPoints + " demerit points");
                }
            }
        }
    }
}
