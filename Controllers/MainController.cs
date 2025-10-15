using Microsoft.AspNetCore.Mvc;
using IPT2Assignment2.Models;

namespace IPT2Assignment2.Controllers
{
    public class MainController : Controller
    {
        public IActionResult LoadLogin()
        {
            return View("~/Views/Main/login.cshtml");
        }
        public IActionResult LoadHome()
        {
            return View("~/Views/Main/Home.cshtml");
        }
        public IActionResult LoadDashboard()
        {
            return View("~/Views/Main/dashboard.cshtml");
        }
        public IActionResult LoadAbout()
        {
            return View("~/Views/Main/about.cshtml");
        }
        public IActionResult LoadContact()
        {
            return View("~/Views/Main/contact.cshtml");
        }
        public IActionResult LoadDiv3()
        {
            return View("~/Views/Main/div3.cshtml");
        }
        public IActionResult LoadGallery()
        {
            return View("~/Views/Main/gallery.cshtml");
        }
        public IActionResult LoadGamba()
        {
            return View("~/Views/Main/gamba.cshtml");
        }
        public IActionResult LoadPyramid()
        {
            return View("~/Views/Main/pyramid.cshtml");
        }
        public IActionResult LoadTheEnd()
        {
            return View("~/Views/Main/end.cshtml");
        }
        public IActionResult LoadEndDashboard()
        {
            return View("~/Views/Main/enddashboard.cshtml");
        }


        public IActionResult login(login mod)
        {
            Random rand = new Random();
            double chance = 0.5;
            double randnum = rand.NextDouble();

            if (mod.username == "admin" && mod.password == "123")
            {
                return View("~/Views/Main/Home.cshtml");
            }
            else
            {
                if (randnum <= chance)
                {
                    ViewBag.msg = "try 'admin' and '123'";
                }
                else
                {
                    ViewBag.msg = "Wrong username or password";       
                }
                return View("~/Views/Main/login.cshtml");
            } 
        }

        public IActionResult Div3(div3 mod)
        {
            if (mod.num == 0)
            {
                ViewBag.msg = "You either put a text or 0 bro wot di hik >:l";
            }
            else
            {
                if (mod.num % 3 == 0)
                {
                    ViewBag.msg = mod.num + " is divisible by 3";
                }
                else
                {
                    ViewBag.msg = mod.num + " is not divisible by 3";
                }
            }
            return View("~/Views/Main/div3.cshtml");
        }

        public IActionResult gamba()
        {
            Random rand = new Random();
            double win = 0.1;
            double randnum = rand.NextDouble();
            if (randnum <= win)
            {
                int num1 = rand.Next(1, 9);
            
                ViewBag.num1 = num1;
                ViewBag.num2 = num1;
                ViewBag.num3 = num1;
                ViewBag.msg = "Congrats you won! :D";
            }
            else
            {
                int num1 = rand.Next(1, 9);
                int num2 = rand.Next(1, 9);
                int num3 = rand.Next(1, 9);
                while (num1 == num2 && num2 == num3)
                {
                   num2 = rand.Next(1, 9);
                   num3 = rand.Next(1, 9);
                }

                ViewBag.num1 = num1;
                ViewBag.num2 = num2;
                ViewBag.num3 = num3;
                ViewBag.msg = "You lost! D:";
            }

            return View("~/Views/Main/gamba.cshtml");
        }

        public IActionResult pyramid(pyramid mod)
        {
            if (mod.rows < 1 || mod.rows > 200)
            {
                ViewBag.msg = "Please enter a number between 1 and 200.";
                return View("~/Views/Main/pyramid.cshtml");
            }
            string pyramid = "";
            for (int i = 1; i <= mod.rows; i++)
            {
                pyramid += new string('*', i) + "<br/>";
            }
            ViewBag.msg = "Here is your pyramid: ";
            ViewBag.pyramid = pyramid;
            return View("~/Views/Main/pyramid.cshtml");
        }
    }
}
