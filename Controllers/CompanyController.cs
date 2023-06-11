using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Featuresplan()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Employee()
        {
            var employee1 = new Employee()
            {
                Name = "Saurav",
                Year = "20 May 2020",
                Uid = "Saurav07"

            };
            var employee2 = new Employee()
            {
                Name = "Sarkar",
                Year = "21 May 2020",
                Uid = "Sarkar00"
            };
            var employee3 = new Employee()
            {
                Name = "Saurav Sarkar",
                Year = "01 May 2020",
                Uid = "Sauravsarkar"
            };
            Employee[] eds = new Employee[] { employee1, employee2, employee3 };

            return View(eds);
        }

        public ActionResult Signin()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }
    }
}