using assignmentproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignmentproject.StudentData
{
    public class SqlStudentData : IStudentData
    {
        private StudentContext _studentContext;
        public SqlStudentData(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }
        public Student AddStudent(Student student)
        {
            //throw new NotImplementedException();
            student.Id = Guid.NewGuid();
            _studentContext.Students.Add(student);
            _studentContext.SaveChanges();
            return student;
        }

        public void DeleteStudent(Student student)
        {
            //throw new NotImplementedException();
            
            _studentContext.Students.Remove(student);
            _studentContext.SaveChanges();
            
        }

        public Student EditStudent(Student student)
        {
            //throw new NotImplementedException();
            var existingStudent = _studentContext.Students.Find(student.Id);
            if(existingStudent != null)
            {
                existingStudent.F_Name = student.F_Name;
                existingStudent.L_Name = student.L_Name;
                existingStudent.Roll_No = student.Roll_No;
                _studentContext.Students.Update(existingStudent);
                _studentContext.SaveChanges();
            }
            return student;
        }

        public Student GetStudent(Guid id)
        {

            //throw new NotImplementedException();
            var student = _studentContext.Students.Find(id);
            return student;
        }

        public List<Student> GetStudents()
        {
            //throw new NotImplementedException();
            return _studentContext.Students.ToList();

        }
    }
}
