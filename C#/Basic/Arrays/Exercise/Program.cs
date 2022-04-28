namespace CompanyUsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] companyNameEmployeeId = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            while (companyNameEmployeeId[0] != "End")
            {
                string company = companyNameEmployeeId[0];
                string employeeId = companyNameEmployeeId[2];

                if (!companyUsers.ContainsKey(company))
                {
                    companyUsers.Add(company, new List<string>() { employeeId});
                }
                else if (!companyUsers[company].Contains(employeeId))
                {
                    companyUsers[company].Add(employeeId);
                }

                companyNameEmployeeId = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
            }

            courseNameRegisteredStudents = courseNameRegisteredStudents
     .OrderByDescending(x => x.Value.Count())
     .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in companyUsers.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");

                foreach (var item2 in item.Value)
                {

                    Console.WriteLine($"-- {item2}");
                }
            }
        }
    }
}