namespace Birthday_Celebrations
{
    using Food_Shortage;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    public class Citizen : IBirthable, IIdentifiable, IBuyer
    {
        public BigInteger Id { get; set; }

        public int Food { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public DateTime Birthdate { get; set; }

        public Citizen(BigInteger id, string name, int age, string birthdate)
        {
            Id = id;
            Name = name;
            Age = age;
            Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
            Food = 0;
        }

        public int BuyFood()
        {
            Food += 10;
            return Food;
        }
    }
}