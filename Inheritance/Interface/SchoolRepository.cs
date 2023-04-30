using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Interface
{
    public interface ISchoolRepository
    {
        void AddStudent(Student s);
        List<Student> GetStudents();
    }
    public class SchoolRepository : ISchoolRepository
    {
        private List<Student> students = new List<Student>();
        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
