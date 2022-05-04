using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication46.Models;

namespace WebApplication46.Controllers
{
    public class EraseController : Controller
    {
        Applicationdbcontext dbcontext = new Applicationdbcontext();
        // GET: Erase
        public ActionResult Index()
        {
            List<Employee> employees = dbcontext.Employees.ToList();
            return View(employees);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.cataegory = dbcontext.categories.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Title, decimal Price, int Quantity, string descr, int cataegoryid)
        {
            var tag = dbcontext.categories.SingleOrDefault(e => e.id == cataegoryid);
            Employee employee = new Employee()
            {
                Title = Title,
                Price = Price,
                Quantity = Quantity,
                descr = descr,
                category = tag

            };
            dbcontext.Employees.Add(employee);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}