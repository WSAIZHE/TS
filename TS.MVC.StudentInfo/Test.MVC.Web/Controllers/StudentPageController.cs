using HPIT.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.EF.DAL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HPIT.Survey.Portal.Filters;

namespace Test.MVC.Web.Controllers
{
    public class StudentPageController : Controller
    {
        // GET: StudentPage
        public ActionResult Index()
        {
            return View();
        }
        public DeluxeJsonResult QueryPageData(SearchModel<Student> search)
        {
            int total = 0;
            var result = StudentPageDal.Instance.GetPageData(search, out total);
            var totalPages = total % search.PageSize == 0 ? total / search.PageSize : total / search.PageSize + 1;
            return new DeluxeJsonResult(new
            {
                Data = result,
                Total = total,
                TotalPages = totalPages
            }, "yyyy-MM- dd HH: mm");
        }
    }
}