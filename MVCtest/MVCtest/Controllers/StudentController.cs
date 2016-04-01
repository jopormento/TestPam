using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCtest.Models;

namespace MVCtest.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            //List<Student> objStudentDetails = new List<Student>();

            //var studentModel1 = new Models.Student();
            //studentModel1.StudentId = 1;
            //studentModel1.StudentName = "James Oliver";
            //studentModel1.Age = 23;

            //objStudentDetails.Add(studentModel1);

            //var studentModel2 = new Models.Student();
            //studentModel2.StudentId = 2;
            //studentModel2.StudentName = "James";
            //studentModel2.Age = 24;

            //objStudentDetails.Add(studentModel2);

            //var studentModel3 = new Models.Student();
            //studentModel3.StudentId = 3;
            //studentModel3.StudentName = "Oliver";
            //studentModel3.Age = 25;

            //objStudentDetails.Add(studentModel3);

            var studentList = new List<Student>{ 
                            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                            new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                            new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                            new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 } 
                        };

            return View(studentList);
        }
    }
}
