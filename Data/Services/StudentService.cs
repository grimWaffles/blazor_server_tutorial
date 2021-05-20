using BlazorServerTutorial.Data.Models;
using BlazorServerTutorial.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerTutorial.Data
{
    public class StudentService : IStudentService
    {
        public Student GetStudent(AppDbContext db, int id)
        {
            return db.Students.Find(id);
        }

        public IEnumerable<Student> GetStudents(AppDbContext db)
        {
            return db.Students.ToList();
        }

        public void PatchStudent(AppDbContext db, Student student)
        {
            Student s=db.Students.Find(student.Id);

            s.DepartmentId = student.DepartmentId;
            s.Major = student.Major;
            s.DepartmentId = student.DepartmentId;
            s.updated_at = student.updated_at;

            db.SaveChanges();

            //Does not work****
        }

        public void PostStudent(AppDbContext db, Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        public void DeleteStudent(AppDbContext db,Student student)
        {
            var s = db.Students.Find(student.Id);

            db.Students.Remove(s);
            db.SaveChanges();
        }
    }
}
