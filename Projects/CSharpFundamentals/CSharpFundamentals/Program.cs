using System;
using System.Collections.Generic;
using CSharpFundamentals.Math;
using System.Text;

namespace CSharpFundamentals
{
        class Program
    {
        static void Main(string[] args)
        {
            var sentence = "this is going to be a really really really really really long text.";
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

            // Console.WriteLine(StringExercises.ConsecutiveCheck());

            // Console.WriteLine(StringExercises.DuplicateCheck());
            StringExercises.TimeCheck();

        }

        

    }
}
