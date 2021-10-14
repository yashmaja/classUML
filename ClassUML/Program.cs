using System;
using System.Collections.Generic;

namespace ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Class UML Program!");

            People groupA = new People();
            groupA.PrintList();

            bool repeat = true;

            while (repeat)
            {
                groupA.AddPerson();
                repeat = Validator.Validator.Repeat("Would you like to add another person? ");
            }
        }
    }
}
