using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab18_CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab18_CoffeeShop.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult AddCustomer()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DisplayCustomer(Customer newCustomer)
        {
            if (ModelState.IsValid)
            {
                return View(newCustomer);
            }
            else
            {
                return View("AddCustomer");
            }
        }
    }
}