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
                    Name = "Arley"
                };

                context.Students.Add(std);
                context.SaveChanges();

                var studentWithGrade = context.Students.Where(s => s.Name == "Arley").ToList();
                Console.WriteLine(studentWithGrade.FirstOrDefault().Name);
            }
        }
    }
}
