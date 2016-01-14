using CollegeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeProject.Controllers
{
    public class CoursesController : Controller
    {
        public ActionResult Index()
        {
            Data _dummyData = new Data();
            ViewModelDemo vmDemo = new ViewModelDemo();
            vmDemo.allCourses = _dummyData.GetAllCourse();
            return View(vmDemo);
        }
    }
}