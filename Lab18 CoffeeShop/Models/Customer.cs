using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18_CoffeeShop.Models
{
    public class Customer
    {
        [RegularExpression(@"[^a-z\s][a-z]{1,30}")]
        public string FirstName { get; set; }
        [RegularExpression(@"[^a-z\s][a-z]{1,30}")]
        public string LastName { get; set; }  //add regular expressions to verify inputs
       // [RegularExpression(@"^[A-Za-z0-9]{5,30}[@][a-zA-Z0-9]{5,10}[.][A-Za-z0-9]{2,3}")]
        public string Email { get; set; }       // add a page for after 
        //[RegularExpression(@"\d{3}-\d{3}-\d{4}")]
        public int PhoneNumber { get; set; }
        public string Password { get; set; }

        public Customer(string firstName, string lastName, string email, int phoneNumber, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }

        public Customer() { }
    }
}
