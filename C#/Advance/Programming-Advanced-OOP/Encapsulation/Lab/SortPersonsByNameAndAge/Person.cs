namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Person
    {
        private int age;
        private string firstName;
        private string lastName;
        private decimal salary;

        public int Age
        {
            get { return age; }
            private set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }

                age = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            private set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

                firstName = value; 
            }
        }

        public string LastName
        {
            get { return lastName; }
            private set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

                lastName = value; 
            }
        }

        public decimal Salary
        {
            get { return salary; }
            private set 
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }

                salary = value; 
            }
        }

        /*
         * Sort Persons by Name and Age
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        */

        //Salary Increase
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age > 30)
            {
                Salary += Salary * percentage / 100;
            }
            else
            {
                Salary += Salary * percentage / 200;
            }
        }

        /*
         * Sort Persons by Name and Age
        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
        */

        /*
        //Salary Increase
        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
        */
    }
}