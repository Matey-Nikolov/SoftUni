﻿namespace PlayersAndMonsters
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Hero
    {
        public string Username { get; set; }
        public int Level { get; set; }
        public Hero(string username, int level)
        {
            Username = username;
            Level = level;
        }

        public override string ToString()
        {
            return $"Type: {GetType().Name} Username: {Username} Level: {Level}";
        }
    }
}
