namespace Birthday_Celebrations
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    public class Citizen : IBirthable, IIdentifiable
    {
        public BigInteger Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public DateTime Birthdate { get; set; }

        public Citizen(BigInteger id, string name, int age, string birthdate)
        {
            Id = id;
            Name = name;
            Age = age;
            Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
        }
    }
}