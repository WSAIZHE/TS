using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.EF.DAL;

namespace Test.MVC.Web.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentInfo dal = new StudentInfo();
            List<Student> result = dal.GetstudentInfo();
            return View(result);
        }

        public ActionResult Create()
        {
            StudentInfo dal = new StudentInfo();
            ViewBag.ClassName= dal.GetClasses().Select(role=> new SelectListItem() { Text=role.ClassName,Value=role.ClassId.ToString()}).ToList();
            return View();
        }

        public ActionResult CreateStudent(Student stu)
        {
            StudentInfo dal = new StudentInfo();
            if (dal.AddStudet(stu)>0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        public ActionResult Edit(int id)
        {
            StudentInfo dal = new StudentInfo();
            Student student= dal.GetStudentID(id);
            ViewBag.ClassName= dal.GetClasses().Select(role=> new SelectListItem() { Text=role.ClassName,Value=role.ClassId.ToString()}).ToList();
            return View(student);
        }

        public ActionResult EditStudent(Student stu)
        {
            StudentInfo dal = new StudentInfo();
            if( dal.EditStudent(stu)>0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Edit");
            }            
        }

        public ActionResult Delete(int id)
        {
            StudentInfo dal = new StudentInfo();
            if (dal.DelStudent(id)>0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}