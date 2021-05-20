using BlazorServerTutorial.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerTutorial.Data.Services
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetStudents(AppDbContext db);
        public Student GetStudent(AppDbContext db, int id);
        public void PatchStudent(AppDbContext db, Student student);
        public void PostStudent(AppDbContext db, Student student);
        public void DeleteStudent(AppDbContext db, Student student);
    }
}
