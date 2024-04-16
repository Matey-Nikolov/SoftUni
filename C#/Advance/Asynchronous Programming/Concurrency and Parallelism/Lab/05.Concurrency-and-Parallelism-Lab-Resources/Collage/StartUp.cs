using Collage.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace Collage
{
    class StartUp
    {
        static void Main()
        {
            CollageDBContext context = new CollageDBContext();

            AverageGrade(context);
            InstructorsOffices(context);
        }

        static void AverageGrade(CollageDBContext context)
        {
            var students = context.Person
                .Where(x => x.Discriminator == "Student")
                .Select(x => new
                {
                    FullName = x.FirstName + " " + x.LastName,
                    grades = x.StudentGrade
                    .Where(g => g.Grade != null)
                    .Select(g => g.Grade)
                })
                .ToList();

            Parallel.ForEach(students, student => {

                if (student.grades.Count() > 0)
                {
                    Console.WriteLine($"{student.FullName} - {student.grades.Average()}");
                }
            });
        }

        static void InstructorsOffices(CollageDBContext context)
        {
            var instructors = context.Person
                .Where(x => x.Discriminator == "Instructor")
                .Select(x => new
                {
                    FullName = x.FirstName + " " + x.LastName,
                    x.OfficeAssignment.Location
                })
                .ToList();

            Parallel.For(0, instructors.Count, i =>
            {
                Console.WriteLine($"{instructors[i].FullName} - {instructors[i].Location}");
            });
        }
    }
}