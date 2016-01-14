using CollegeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeProject.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            Data _dummyData = new Data();
            ViewModelDemo vmDemo = new ViewModelDemo();
            vmDemo.allEmployees = _dummyData.GetAllEmployee();
            return View(vmDemo);
        }

        public ActionResult Position()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}