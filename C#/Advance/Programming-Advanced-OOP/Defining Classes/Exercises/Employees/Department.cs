namespace ClassesEmployee
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Department
    {
        public List<Employee> employees = new List<Employee>();

        public void AddMember(Employee member)
        {
            employees.Add(member);
        }

        public Employee GetOldest()
        {
            Employee employee = new Employee();
            int oldAge = 0;

           // employees.Find(x => x.Age .);

            foreach (var item in employees)
            {
                if (item.Age > oldAge)
                {
                    oldAge = item.Age;
                }
            }

            return employee = employees.Find(x => x.Age == oldAge);
        }

        public void Sort()
        {
            var sorted = employees.FindAll(x => x.Age > 30)
                                    .OrderBy(x => x.Name);

            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}