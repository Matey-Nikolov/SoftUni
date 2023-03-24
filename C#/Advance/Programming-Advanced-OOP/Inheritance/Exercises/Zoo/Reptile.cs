using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Reptile : Animal
    {
        public string NameReptile { get; set; }

        public Reptile(string name)
        {
            NameReptile = name;
        }

        public override string ToString()
        {
            return $"Reptile's name: {NameReptile}";
        }
    }
}
