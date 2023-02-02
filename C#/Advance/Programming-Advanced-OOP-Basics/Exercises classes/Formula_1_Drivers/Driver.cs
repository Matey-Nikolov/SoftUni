namespace Formula_1_Drivers
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float TotalTime { get; set; }
        public float Speed { get; set; }

        public Driver(string name, int age, float totalTime, float speed)
        {
            Name = name;
            Age = age;
            TotalTime = totalTime;
            Speed = speed;
        }
    }
}