using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Student : Person
    {
        //properties
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        //consctructor
        public Student(string name, string address, string program, int year, double fee):base(name, address)
        {
            Name = name;
            Address = address;
            Program = program;
            Year = year;
            Fee = fee;
        }

        //methods
        public override string ToString()
        {
            return $"{base.ToString()} | Program: {Program} | Year: {Year} | Fee: {Fee}";
        }
    }
}
