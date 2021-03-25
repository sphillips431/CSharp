using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisibleByThree = 0;

            for (int i = 0; i <=100; i++)
            {
                if (i%3 == 0)
                {
                    divisibleByThree++;
                }
            }

            Console.WriteLine(divisibleByThree);

            int sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number to multiply or ok to quit: ");
                string input = Console.ReadLine();
                
                if (input.ToLower() == "ok")
                {
                    break;
                }

                else
                {
                    sum = sum + (Convert.ToInt32(input));
                }
            }

            Console.WriteLine(sum);

            Console.WriteLine("Enter a number to calculate the factorial");
            int initialNumber = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= initialNumber; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);

            Random random = new Random();
            int secretNumber = random.Next(1, 10);

            Console.WriteLine("The secret number is " + secretNumber);

            int attempts = 0;
            while (true)
            {
                Console.WriteLine("Guess the secret number between 1 and 10");
                int inputGuess = Convert.ToInt32(Console.ReadLine());

                if (inputGuess == secretNumber)
                {
                    Console.WriteLine("Congrats, you guessed right!");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, try again");
                    attempts++;
                }

                if (attempts > 4)
                {
                    break;
                }
            }
        }
    }
}
