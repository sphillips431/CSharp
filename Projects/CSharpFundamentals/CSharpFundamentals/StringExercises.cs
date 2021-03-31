using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class StringExercises
    {
        public static string ConsecutiveCheck()
        {

                Console.WriteLine("Enter 5 numbers separated by -:");
                var input = Console.ReadLine();
                var numbers = new List<int>();

                bool consecutive = true;

                foreach (var number in input.Split('-')) 
                    numbers.Add(Convert.ToInt32(number));

                if (numbers[0] < numbers[1])
                {
                    for (var i = 2; i < numbers.Count; i++)
                    {
                        if (numbers[i-1] > numbers[i])
                            consecutive = false;
                    }
                }

                else
                {
                    for (var i = 2; i < numbers.Count; i++)
                    {
                        if (numbers[i-1] < numbers[i])
                            consecutive = false;
                    }
                }

            if (consecutive == true)
                return "Consecutive";
            else
                return "Not Consecutive";

        }

        public static string DuplicateCheck()
        {
            Console.WriteLine("Enter a few numbers separated by -:");
            var input = Console.ReadLine();

            var numbers = new List<int>();

            bool duplicate = false;

            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));
            var uniques = new List<int>();

            if (string.IsNullOrWhiteSpace(input))
                return "Why didn't you enter anything";
            else
            {
                foreach (var number in numbers)
                    if (!uniques.Contains(number))
                        uniques.Add(number);
                    else
                    {
                        duplicate = true;
                        break;
                    }

                        
            }

            if (duplicate == true)
                return "There are duplicates";
            else
                return "No duplicates here";

        }

        public static void TimeCheck()
        {
            Console.WriteLine("Enter a valid time in 24 hour format");
            var input = Console.ReadLine();
            var components = input.Split(':');

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Why didn't you enter anything");
                return;
            }

            if (components.Length !=2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }

    }
}
