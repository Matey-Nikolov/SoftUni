using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Zoo
{
    public class Snake : Reptile
    {
        public string NameSnake { get; set; }

        public Snake(string name) : base(name)
        {
            NameSnake = name;
        }

        public override string ToString()
        {
            return $"Snake's name: {NameSnake}";
        }
    }
}