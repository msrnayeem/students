using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAssignment.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var db = new studentsEntities();
            var students = db.Student_Tables.ToList();

            ViewBag.StudentData = students;

            return View();
        }
    }
}