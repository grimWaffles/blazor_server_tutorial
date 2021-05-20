using BlazorServerTutorial.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerTutorial.Data.Services
{
    public interface IDepartmentService
    {
        public IEnumerable<Department> GetDepartments(AppDbContext db);
        public Department GetDepartment(AppDbContext db, int id);
        public void PostDepartment(AppDbContext db, Department department);
        public void UpdateDepartment(AppDbContext db, Department department);
        public void DeleteDepartment(AppDbContext db, int deptId);
    }
}
