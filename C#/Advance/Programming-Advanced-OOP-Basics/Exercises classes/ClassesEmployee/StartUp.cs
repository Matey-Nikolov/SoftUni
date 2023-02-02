namespace ClassesEmployee
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            /*
             * Task 1
            Employee employee1 = new Employee();
            employee1.Name = "Dan";
            employee1.Age = 20;

            Employee employee2 = new Employee();
            employee2.Name = "Joey";
            employee2.Age = 18;

            Employee employee3 = new Employee();
            employee3.Name = "Tommy";
            employee3.Age = 43;
            */

            // Task 3
            /*
            Department department = new Department();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Employee employee = new Employee();

                string[] nameAge = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                employee.Name = nameAge[0];
                employee.Age = int.Parse(nameAge[1]);

                department.AddMember(employee);
            }

            var emp = department.GetOldest();

            Console.WriteLine($"{emp.Name} {emp.Age}");
            */

            // Task 4
            Department department = new Department();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Employee employee = new Employee();

                string[] nameAge = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                employee.Name = nameAge[0];
                employee.Age = int.Parse(nameAge[1]);

                department.AddMember(employee);
            }

            department.Sort();
        }
    }
}