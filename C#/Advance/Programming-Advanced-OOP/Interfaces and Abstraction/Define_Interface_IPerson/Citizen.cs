namespace PersonInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public string Id { get; set; }

        public string Birthdate { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            Id = id;
            Birthdate = birthdate;
            Name = name;
            Age = age;
        }
    }
}