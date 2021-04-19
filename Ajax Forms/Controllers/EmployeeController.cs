using Ajax_Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax_Forms.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeEntities db = new EmployeeEntities();
        // GET: Employee
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(employee e)
        {
            if(ModelState.IsValid == true)
            {
                db.employees.Add(e);
                int em = db.SaveChanges();
                if(em > 0)
                {
                    return Json("Inserted", JsonRequestBehavior.AllowGet);
                } 
                else
                {
                    return Json("Not inserted");
                }
            }
            return View();
        }
    }
}