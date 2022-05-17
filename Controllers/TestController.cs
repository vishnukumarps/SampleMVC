using Microsoft.AspNetCore.Mvc;
using WebApplication2.Helper;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult RegisterData(Employee employee)
        {
            // insert to database

            HelperClass o = new HelperClass();
            o.FileWriterExample(employee, "test");

            return RedirectToAction("Home");
        }

        [HttpPost]
        public IActionResult Login(string userName,string password,string password2)
        {

            // get Data from db

            if(userName=="test" && password == "test")
            {
                return RedirectToAction("Home");
            }
            return RedirectToAction("ErrorPage");

        }


        public IActionResult Home()
        {
            return View();
        }

        public IActionResult ErrorPage()
        {
            return View();
        }



    }
}
