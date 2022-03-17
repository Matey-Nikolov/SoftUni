using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Linq;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            var context = new SoftUniContext();


            //Problem 3
            //var result = FindEmployeesWithJobTitle(context);
            //Console.WriteLine(result);

            //Problem 4
            //var result = FindProjectWithId(context);
            //Console.WriteLine(result);

            //Problem 5
            //CreateNewProject(context);

            //Problem 6
            //var result = UpdateFirstEmployee(context);
            //Console.WriteLine(result);

            //Problem 7
            //var result = DeleteFirstProject(context);
            //Console.WriteLine(result);

            //Problem 8
            var result = UpdateAddresses(context);
            Console.WriteLine(result);
        }

        //Problem 03
        public static string FindEmployeesWithJobTitle(SoftUniContext context)
        {
            var employees = context.Employees
            .Where(e => e.JobTitle == "Design Engineer")
            .Select(x => x.FirstName)
            .ToList();
            return string.Join(Environment.NewLine, employees);
        }

        //Problem 04
        public static string FindProjectWithId(SoftUniContext context)
        {
            var project = context.Projects.Find(2);
            return project.Name;
        }
        
        //Problem 05
        public static void CreateNewProject(SoftUniContext context)
        {
            var project = new Project()
            {
                Name = "Our Newest Project",
                StartDate = new DateTime(2021, 1, 1),
            };
            context.Projects.Add(project);
            context.SaveChanges();
        }

        //Problem 06
        public static string UpdateFirstEmployee(SoftUniContext context)
        {
            Employee employee = context.Employees.FirstOrDefault();
            if (employee != null)
            {
                employee.FirstName = "Alex";
                context.SaveChanges();
                return employee.FirstName;
            }
            return "";
        }

        //Problem 07
        public static string DeleteFirstProject(SoftUniContext context)
        {
            Project project = context.Projects.FirstOrDefault();

            var entitiesWithProject = context.EmployeesProjects
            .Where(x => x.ProjectId == project.ProjectId).ToList();

            context.EmployeesProjects.RemoveRange(entitiesWithProject);
            context.Projects.Remove(project);
            context.SaveChanges();

            return project.Name;
        }


        //Problem 08
        /* 
             SELECT TOP(1000) AddressID, AddressText, TownID
             FROM SoftUni.dbo.Addresses
             WHERE AddressText LIKE '%Drive%'
             UPDATE Addresses
             SET TownID = 2
             WHERE AddressText LIKE '%Drive%'
        */
        public static string UpdateAddresses(SoftUniContext context)
        {
            var addresses = context.Addresses
                .Where(x => x.AddressText.EndsWith("Drive"))
                .Select(e => e.TownId == 2)
                .ToList();

            return addresses.Count().ToString();
        }
    }
}