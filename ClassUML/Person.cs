using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Person
    {
        //properties
        public string Name { get; set; }
        public string Address { get; set; }

        //constructor
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        //methods
        public override string ToString()
        {
            return $"Person: Name: {Name} | Address: {Address}";
        }
    }
}
