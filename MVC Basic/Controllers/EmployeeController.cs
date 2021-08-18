using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Basic.Models;

namespace MVC_Basic.Controllers
{
    public class EmployeeController : Controller
    {
        /*public string Profile(int id ) 
        {
            string profile =string.Empty;
            if (id == 1)
            {
                profile = "Employee 1 profile";

            }
            else if (id == 1)
            {
                profile = "Employee 2 profile";

            }
            else {
                profile = "No record found";
            }
            return  profile; 
        }*/
        public ActionResult Index() 
        {
            var data = GetEmployee();
            return View(data);
        }
        private Employee GetEmployee() 
        {
            return new Employee()
            {
                Id = 1,
                Name = "Anchal ",
                Address = "Palasia Indore"
            };
        }


   
    }
}