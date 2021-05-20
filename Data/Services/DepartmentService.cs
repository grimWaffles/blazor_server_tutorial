using BlazorServerTutorial.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerTutorial.Data.Services
{
    public class DepartmentService : IDepartmentService
    {
        public void DeleteDepartment(AppDbContext db, int deptId)
        {
            var dept = db.Departments.Find(deptId);

            db.Departments.Remove(dept);
            db.SaveChanges();
        }

        public Department GetDepartment(AppDbContext db, int id)
        {
            return db.Departments.Find(id);
        }

        public IEnumerable<Department> GetDepartments(AppDbContext db)
        {
            return db.Departments.ToList();
        }

        public void UpdateDepartment(AppDbContext db, Department department)
        {
            var dept = db.Departments.Find(department.Id);

            dept.Code = department.Code;
            dept.DepartmentName = department.DepartmentName;
            dept.School = department.School;
            dept.updated_at = DateTime.Now;

            db.SaveChanges();

            //DOES NOT WORK*******
        }

        public void PostDepartment(AppDbContext db, Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
        }
    }
}
