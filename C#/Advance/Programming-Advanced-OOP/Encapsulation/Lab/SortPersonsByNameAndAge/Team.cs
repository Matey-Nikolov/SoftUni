﻿namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return firstTeam.AsReadOnly(); }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return reserveTeam.AsReadOnly(); }
        }

        public Team(string name)
        {
            name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }

        //First and Reserve Team
        public override string ToString()
        {
            return $"First team has {firstTeam.Count} players. \n" +
                   $"Reserve team has {reserveTeam.Count} players.";
        }
    }
}