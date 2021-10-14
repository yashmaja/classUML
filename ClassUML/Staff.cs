using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Staff : Person
    {
        //properties
        private string School { get; set; }
        private double Pay { get; set; }

        //constructor
        public Staff(string name, string address, string school, double pay):base(name, address)
        {
            Name = name;
            Address = address;
            School = school;
            Pay = pay;
        }

        //methods
        public override string ToString()
        {
            return $"{base.ToString()} | School: {School} | Pay: {Pay}";
        }
    }
}
