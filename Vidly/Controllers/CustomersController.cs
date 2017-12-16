using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Vidly.Models;


namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();
            if (customers.Count == 0)
                return View("NoCustomers");

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var custObj = _context.Customers.SingleOrDefault(m => m.Id == id);
            if (custObj == null)
                return HttpNotFound();

            return View(custObj);
        }
    }
}