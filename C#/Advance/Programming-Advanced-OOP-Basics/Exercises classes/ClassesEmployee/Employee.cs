namespace ClassesEmployee
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Employee
    {
        private string name;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }

        
        public Employee()
        {
            Name = "No name";
            Age = 1;
        }

        public Employee(int age)
        {
            Name = "No name";
            Age = age;
        }

        public Employee(string name,int age)
        {
            Name = name;
            Age = age;
        }
    }
}