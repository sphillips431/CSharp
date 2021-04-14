using System;
using System.Collections.Generic;
using CSharpFundamentals.Math;
using System.Text;
using System.IO;

namespace CSharpFundamentals
{
        class Program
    {
        static void Main(string[] args)
        {
            /* var sentence = "this is going to be a really really really really really long text.";
             var summary = StringUtility.SummerizeText(sentence, 25);
             Console.WriteLine(summary);

             var builder = new StringBuilder();

             builder.Append('-', 10);
             builder.AppendLine();
             builder.Append("Header");
             builder.AppendLine();
             builder.Append('-', 10);

             builder.Replace('-', '+');

             builder.Remove(0, 10);
             Console.WriteLine(builder);
            */

            // Console.WriteLine(StringExercises.ConsecutiveCheck());

            // Console.WriteLine(StringExercises.DuplicateCheck());

            //StringExercises.TimeCheck();

            var path = @"C:\Users\Sean and Kayla\Desktop\Sean_Work\Udemy\CSharp\file.txt";

            var allWords = File.ReadAllText(path);
            var words = allWords.Split(' ');

            var count = 0;
            foreach (var word in words)
            {
                Console.WriteLine(word);
                count++;
            }
            Console.WriteLine(count);
        }

        

    }
}
