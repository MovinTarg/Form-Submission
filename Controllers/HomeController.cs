using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using form_submission.Models;

namespace form_submission.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Success()
        {
            return View("Success");
        }
        [HttpPost]
        [Route("/register")]
        public IActionResult Quotes(string first_name, string last_name, int age, string email, string password)
        {
            User NewUser = new User
            {
                First_name = first_name,
                Last_name = last_name,
                Age = age,
                Email = email,
                Password = password
            };
            TryValidateModel(NewUser);
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            } else {
                ViewBag.errors = ModelState.Values;
                return View("Register");
            }
        }
    }
}
