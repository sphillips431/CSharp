using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class Person
    {
        public string firstname;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My Name is " + firstname + " " + lastName);
        }
    }
}
