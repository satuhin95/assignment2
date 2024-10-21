using Assignmenton2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignmenton2.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>
    {
        new Student
        {
            StudentId = 1,
            Name = "Ariful Islam",
            Course = new Course
            {
                CourseId = 1,
                CourseName = "Math",
                Teacher = new Teacher
                {
                    TeacherId = 1,
                    Name = "Hasan"
                }
            }
        },
        new Student
        {
            StudentId = 2,
            Name = "Abdullah al mamun",
            Course = new Course
            {
                CourseId = 2,
                CourseName = "Science",
                Teacher = new Teacher
                {
                    TeacherId = 2,
                    Name = "Roni"
                }
            }
        }
    };
        // GET: Student
        public ActionResult Index()
        {
           

            return View(students);
        }
    }
}