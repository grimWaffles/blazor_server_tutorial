using BlazorServerTutorial.Data.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerTutorial.Pages
{
    public class StudentBase :ComponentBase
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }
        [Inject]
        public IDbContextFactory<AppDbContext> db_factory { get; set; }
        [Inject]
        public IStudentService studentService { get; set; }

        protected Data.Models.Student student { get; set; }
        protected string IdString { get; set; }
        protected string DepartmentIdString { get; set; }
        protected IEnumerable<Data.Models.Student> studentList { get; set; }

        private bool ToUpdate { get; set; }

        protected override void OnInitialized()
        {
            student = new Data.Models.Student();
            LoadStudentData();


            base.OnInitialized();
        }

        protected void SaveStudent()
        {
            student.DepartmentId = Convert.ToInt32(DepartmentIdString);
            student.updated_at = DateTime.Now;

            if (ToUpdate)
            {
                studentService.PatchStudent(db_factory.CreateDbContext(), student);
            }
            else
            {
                student.created_at = DateTime.Now;
                studentService.PostStudent(db_factory.CreateDbContext(), student);
            }

            ToUpdate = false;
            ClearData();
            LoadStudentData();
        }

        protected void LoadTextFields(int id)
        {
            var s = studentList.Where(d => d.Id == id).ToList()[0];

            student.StudentName = s.StudentName;
            student.Major = s.Major;
            student.DepartmentId = s.DepartmentId;
            student.updated_at = DateTime.Now;
            DepartmentIdString = s.DepartmentId.ToString();

            ToUpdate = true;
        }

        protected void DeleteStudent(int id)
        {
            var s = studentList.Where(d => d.Id == id).ToList()[0];

            studentService.DeleteStudent(db_factory.CreateDbContext(),s);

            studentList = null;
            ClearData();
            LoadStudentData();
        }

        protected void ClearData()
        {
            DepartmentIdString = "";
            student = new Data.Models.Student();
        }

        protected void OnDepartmentIdChange(ChangeEventArgs args)
        {
            string searchText = args.Value.ToString();

            if (searchText.Equals(""))
            {
                ClearData();
                LoadStudentData();
            }
            else
            {
                try
                {
                    studentList = studentList.Where(c => c.DepartmentId == Convert.ToInt32(searchText));
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.StackTrace.ToString());
                }
            }
        }

        private IEnumerable<Data.Models.Student> LoadStudentData()
        {
            using (var db = db_factory.CreateDbContext())
            {
                return studentList = studentService.GetStudents(db);
            }
        }

    }
}
