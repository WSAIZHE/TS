using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.EF.DAL;

namespace Test.MVC.Web.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class
        public ActionResult Index1()
        {
            ClassInfo dal = new ClassInfo();
            List<Class> result=dal.GetClassInfo();
            return View(result);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            ClassInfo dal = new ClassInfo();
            Class match = dal.GetClassByID(id);
            return View(match);
        }

        public ActionResult Edit(int id)
        {
            ClassInfo dal = new ClassInfo();
            Class match = dal.GetClassByID(id);
            return View(match);
        }
        public ActionResult EditClass(Class cla)
        {
            ClassInfo dal = new ClassInfo();
            if (dal.EditClass(cla) > 0)
            {
                return RedirectToAction("Index1");
            }
            else
            {
                return RedirectToAction("EditClassId");
            }
        }
        public ActionResult CreateClass(Class cla)
        {
            ClassInfo dal = new ClassInfo();
            if (dal.AddClass(cla)>0)
            {
                return RedirectToAction("Index1");
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        public ActionResult DelClass(int id)
        {
            ClassInfo dal = new ClassInfo();
            if (dal.DelClass(id)>0)
            {
                return RedirectToAction("Index1");
            }
            else
            {
                return RedirectToAction("Delete");
            }
        }


    }
}