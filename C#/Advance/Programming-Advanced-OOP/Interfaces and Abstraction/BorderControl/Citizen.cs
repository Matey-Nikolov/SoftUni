using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BorderControl
{
    public class Citizen: IIdentifiable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public BigInteger Id { get; set; }
        public Citizen(string name, int age, BigInteger id)
        { 
            Name = name;
            Age = age;
            Id = id;
        }
    }
}