using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class People
    {
        public List<Person> Collection { get; set; } 

        public People()
        {
            Collection = new List<Person> 
            {
                new Student("Shay", "Detroit", "Mechanical Engineering", 2017, 1500),
                new Student("Eko", "Dundee", "Track", 2025, 1200),
                new Student("Yash", "New Delhi", "Psychology", 2018, 1000),
                new Staff("Brian Mundo", "Lansing", "Engineering", 75000),
                new Staff("Justin Ames", "Iowa", "Business", 56000)
            };
        }

        public void AddPerson()
        {
            Console.Write("Do you want to add a person to the list? (y/n): ");

            while (true)
            {
                string answer = Console.ReadLine().ToLower().Trim();

                if (answer == "y")
                {
                    Console.Write("Which would you like to add?" +
                        "\n1. Student" +
                        "\n2. Staff" +
                        "\nEnter 1 or 2: ");

                    int choice = Validator.Validator.GetInt(1, 2);
                    if (choice == 1)
                    {
                        Console.Write("\nWhat is the student's name? ");
                        string name = Console.ReadLine();
                        Console.Write("What is the student's address? ");
                        string address = Console.ReadLine();
                        Console.Write("What is the student's program? ");
                        string program = Console.ReadLine();
                        Console.Write("What year are they graduating? ");
                        int year = Validator.Validator.GetInt(1, 3000);
                        Console.Write("What is the fee? ");
                        double fee = Validator.Validator.GetDouble(0, 100000);

                        Collection.Add(new Student(name, address, program, year, fee));
                        Console.WriteLine("\nThank you for adding a new Student! Below is the new list:");
                        PrintList();
                        break;
                    }
                    else
                    {
                        Console.Write("\nWhat is the staff person's name? ");
                        string name = Console.ReadLine();
                        Console.Write("What is the staff person's address? ");
                        string address = Console.ReadLine();
                        Console.Write("What is the staff person's school? ");
                        string school = Console.ReadLine();
                        Console.Write("What is the staff person's pay? ");
                        double pay = Validator.Validator.GetDouble(1, 1000000);

                        Collection.Add(new Staff(name, address, school, pay));
                        Console.WriteLine("\nThank you for adding a new Staff Member! Below is the new list:");
                        PrintList();
                        break;
                    }
                }
                else if (answer == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please type y/n: ");
                }
            }
        }

        public void PrintList()
        {
            Collection.ForEach(person => Console.WriteLine($"{person.ToString()}\n"));
        }
    }
}
