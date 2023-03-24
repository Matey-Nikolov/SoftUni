using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Zoo
{
    public class Lizard : Reptile
    {
        public string NameLizard { get; set; }
        
        public Lizard(string name) : base(name)
        { 
            NameLizard = name;
        }

        public override string ToString()
        {
            return $"Lizard's name: {NameLizard}";
        }
    }
}