using Lab18_CoffeeShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lab18_CoffeeShop.Controllers
{
    public class CustomerController : Controller
    {
        public List<Customer> customerList = new List<Customer>();

        public IActionResult AddCustomer()
        {
            return View();
        }
        public IActionResult Index()
        {
            string customerJson = HttpContext.Session.GetString("CustomerListSession");
            if (customerJson != null)
            {
                List<Customer> savedCustomer = JsonConvert.DeserializeObject<List<Customer>>(customerJson);
                return View(savedCustomer); 
            }
            return View(new Customer());
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
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
        public IActionResult SaveCustomer(Customer newCustomer)
        {
            //PopulateFromSession();
            customerList.Add(newCustomer);

            HttpContext.Session.SetString("CustomerListSession",
                JsonConvert.SerializeObject(customerList));

            return RedirectToAction("Index");
        }
    }
}