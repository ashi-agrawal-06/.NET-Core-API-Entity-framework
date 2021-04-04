using assignmentproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignmentproject.StudentData
{
    public class MockStudentData : IStudentData
    {
        private List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id = Guid.NewGuid(),
                Roll_No = 1,
                F_Name = "Ashi",
                L_Name = "Agrawal"
            },
            new Student()
            {
                Id = Guid.NewGuid(),
                Roll_No =2,
                F_Name = "Amity",
                L_Name= "University"
            }
        };
        public Student AddStudent(Student student)
        {
            //throw new NotImplementedException();
            student.Id = Guid.NewGuid();
            students.Add(student);
            return student;
        }

        public void DeleteStudent(Student student)
        {
            //throw new NotImplementedException();
            students.Remove(student);
        }

        public Student EditStudent(Student student)
        {
            //throw new NotImplementedException();
            var existingStudent = GetStudent(student.Id);
            existingStudent.F_Name = student.F_Name;
            return existingStudent;

        }

        public Student GetStudent(Guid id)
        {
            //throw new NotImplementedException();
            return students.SingleOrDefault(x => x.Id == id);
        }

        public List<Student> GetStudents()
        {
            //throw new NotImplementedException();
            return students;

        }
    }
}
