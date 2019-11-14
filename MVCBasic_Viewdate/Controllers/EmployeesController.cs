using MVCBasic_Viewdate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic_Viewdate.Controllers
{
    public class EmployeesController : Controller
    {
        private HRContext db = new HRContext();
        // GET: Employees
        public ActionResult Index()
        {
            var employees = db.Employees.ToList();
            return View(employees);
        }
        public ActionResult EmployeeList()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 10001, Name = "David", Phone = "0933-154228", Email ="david@gmail.com" },
                new Employee { Id = 10002, Name = "D2", Phone = "0933-154228", Email ="david@gmail.com" },
                new Employee { Id = 10003, Name = "D3", Phone = "0933-154228", Email ="david@gmail.com" },
                new Employee { Id = 10004, Name = "D4", Phone = "0933-154228", Email ="david@gmail.com" },
                new Employee { Id = 10005, Name = "D5", Phone = "0933-154228", Email ="david@gmail.com" }
            };

            return View(employees);
        }
    }
}