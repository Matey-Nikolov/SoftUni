﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Gorilla : Mammal
    {
        public string Name { get; set; }
        public Gorilla(string name) : base(name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Gorilla's name: {Name}";
        }
    }
}
