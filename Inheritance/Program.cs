using Inheritance.Implemented;
using Inheritance.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rectangle = new Rectangle();
            //rectangle.SetHight(20);
            //rectangle.SetWidth(20);

            //Console.WriteLine(rectangle.GetArea());


            //dependency injection 
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ISchoolRepository, SchoolRepository>()
                .BuildServiceProvider();

            var repository = serviceProvider.GetService<ISchoolRepository>();

            var student = new Student(1, "Popescu Ion");

            repository.AddStudent(student);

            var students = repository.GetStudents();

            foreach(var s in students)
            {
                Console.WriteLine(s.Name); 
            }
        }
    }
}
