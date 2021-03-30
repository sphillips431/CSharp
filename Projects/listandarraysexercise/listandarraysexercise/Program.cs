using System;
using System.Collections.Generic;

namespace listandarraysexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a friends name: ");
                string name = Console.ReadLine();
                
                if (name == "")
                {
                    break;
                }

                else
                {
                    friends.Add(name);
                }

            }

            if (friends.Count == 0)
            {
                Console.WriteLine("No one likes you");
            }

            else if (friends.Count == 1)
            {
                Console.WriteLine("only " + friends[0] + " liked your post");
            }

            else if (friends.Count == 2)
            {
                Console.WriteLine("only " + friends[0] + " and " + friends[1] + " liked your post");
            }

            else
            {
                Console.WriteLine(friends[0] + " and " + friends[1] + "and a bunch of other people liked your post");
            }

            Console.WriteLine("Enter your name");
            string username = Console.ReadLine();
            var namearray = new char[username.Length];
            username.CopyTo(0, namearray, 0, username.Length);
            foreach (var n in namearray)
            {
                Console.WriteLine(n);
            }
            Array.Reverse(namearray);
            Console.WriteLine(namearray);

            var input = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if(input.Contains(number) == false)
                {
                    input.Add(number);
                }

                else
                {
                    Console.WriteLine("You've already entered that number");
                }

                if(input.Count == 5)
                {
                    input.Sort();
                    foreach (var num in input)
                        Console.WriteLine(num);
                    break;
                }
            }
        }
    }
}
