using CollegeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeProject.Controllers
{
    

    public class DepartmentsController : Controller
    {
        private ThisDbContext db = new ThisDbContext();

        // GET: Departments
        public ActionResult Index()
        {
            Data _dummyData = new Data();
            ViewModelDemo vmDemo = new ViewModelDemo();
            vmDemo.allDepartments = _dummyData.GetAllDepartment();

            return View(vmDemo);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,DepName,DepCode")] ViewModelDemo vm)
        {

            if (ModelState.IsValid)
            {
                db.VM.Add(vm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vm);
        }
    }
}