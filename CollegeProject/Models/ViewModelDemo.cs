using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CollegeProject.Models
{
    public class ViewModelDemo
    {
        public int ID { get; set; }
        public List<Employee> allEmployees { get; set; }
        public List<Course> allCourses { get; set; }
        public List<Department> allDepartments { get; set; }
    }

    public class Employee
    {
        [Key] 
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public int DepCode { get; set; }
        public List<Course> Courses { get; set; }
    }

    public class Department
    {
        [Key] [Display(Name = "Department Code")]
         public int DepCode { get; set; }
        [Display(Name = "Department Name")]
        public string DepName { get; set; }
    }

    public class Course
    {
        [Key]
        public int CourseCode { get; set; }
        public string CourseName { get; set; }
    }

    public class ThisDbContext : DbContext
    {
        public DbSet<ViewModelDemo> VM { get; set; }
    }
}