using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCoreTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var std = new Student()
                {
                    FirstName = "Arley"
                };

                context.Students.Add(std);
                context.SaveChanges();

                var studentWithGrade = context.Students.Where(s => s.FirstName == "Arley").ToList();
                Console.WriteLine(studentWithGrade.FirstOrDefault().FirstName);
            }
        }
    }
}
