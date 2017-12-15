using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            if (customers.Count == 0)
                return View("NoCustomers");

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var custObj = GetCustomers().SingleOrDefault(m => m.Id == id);
            if (custObj == null)
                return HttpNotFound();

            return View(custObj);
        }

        public IList<Customer> GetCustomers()
        {
            IList<Customer> customers = new List<Customer>
            {
                new Customer(){ Id=1, Name="Sandeep" },
                new Customer(){ Id=2, Name="Rohit"}
            };
            return customers;
        }
    }
}