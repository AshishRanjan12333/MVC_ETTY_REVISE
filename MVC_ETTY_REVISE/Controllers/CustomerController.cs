using Microsoft.AspNetCore.Mvc;
using MVC_ETTY_REVISE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ETTY_REVISE.Controllers
{
    public class CustomerController : Controller
    {
        private  ApplicationDBContext DBContext;
        public CustomerController(ApplicationDBContext dbContext) 
        {

            DBContext = dbContext;
        }

        public IActionResult Index()
        {
            var data = DBContext.GetLocations.ToList();
            return RedirectToAction("Index");
        }

        //public IActionResult CustomerList(int id)
        //{
        //    var data = DBContext.GetCustomers.Where(e => e.location.Id == id).ToList();
        //    return RedirectToAction("Index");

        //}
    }
}
