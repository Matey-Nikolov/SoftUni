using System;
using System.Collections.Generic;
using System.Text;

namespace Explicit_Interfaces
{
    public class Citizen : IPerson, IResident
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public int Age { get; set; }

        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }
        string IPerson.GetName()
        {
            return "Mr/Ms/Mrs";
        }

        string IResident.GetName()
        {
            return Name;
        }
    }
}
