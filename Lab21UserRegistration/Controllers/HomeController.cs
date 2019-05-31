using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21UserRegistration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(); 
        }

        public ActionResult Welcome(string username, string email, string password, string confirmPassword, 
            string phoneNumber, string city, string country)
        {
            ViewBag.UserName = username;
            ViewBag.Email = email;
            ViewBag.Password = password;
            ViewBag.ConfirmPassword = confirmPassword;
            ViewBag.PhoneNumber = phoneNumber;
            ViewBag.City = city;
            ViewBag.Country = country;

            return View(); 
        }
        public ActionResult Registration()
        {
            return View();
        }
    }
}