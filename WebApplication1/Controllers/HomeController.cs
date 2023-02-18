using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult TaskFirst()
        {
            return View();
        }

        public IActionResult TaskSecond()
        {
            return View();
        }

        public IActionResult TaskThird()
        {
            return View();
        }

        public IActionResult TaskFour()
        {
            return View();
        }


        private int _counter = 0;
        [HttpPost]
        public IActionResult TaskFirst(string FirstCatet, string SecondCatet)
        {
           ViewBag.H = Math.Sqrt(Math.Pow(Convert.ToInt32(FirstCatet), 2) +Math.Pow(Convert.ToInt32(SecondCatet), 2));
            return View();
        }

        [HttpPost]
        public IActionResult TaskSecond(string firstQuestion, string
secondQuestion, string thirdQuestion)
        {
            if (firstQuestion == null || secondQuestion == null || thirdQuestion == null)
            {
                return RedirectToAction("Index");
            }
            if (firstQuestion == "1")
            {
                _counter++;
            }
            if (secondQuestion == "5")
            {
               _counter++;
            }
            if (thirdQuestion == "9")
            {
               _counter++;
            }
            ViewBag.Result = Convert.ToInt32(_counter);
            return View();
        }

        [HttpPost]
        public IActionResult TaskThird(string First, string Second)
        {
            ViewBag.one = Second;
            ViewBag.two = First;
            return View();
        }

        [HttpPost]
        public IActionResult TaskFour(string Firstpr, string Secondpr)
        {
            int k = 0;
            foreach (char c in Firstpr)
            {
                if(Convert.ToString(c) == "н" || Convert.ToString(c) == "Н")
                {
                    k++;

                }
            }
            foreach (char c in Secondpr)
            {
                if (Convert.ToString(c) == "н" || Convert.ToString(c) == "Н")
                {
                    k++;

                }
            }
            ViewBag.kol = k;
            return View();
        }

        public IActionResult TaskFive()
        {
            string x = "";
            int n = 0;
            int sred = 0;
            int y = 0;
            Random r = new Random();

            for (int j = 0; j < 9; j++)
            {
                n = r.Next(10, 30);
                if (n % 2 == 0)
                {
                    sred = sred + n;
                    y++;
                }
                x = x + n + " ";
            }
            ViewBag.t1 = x;
            ViewBag.sr1 = sred/y;

            x = "";
            sred = 0;
            y = 0;
            for (int j = 0; j < 9; j++)
            {
                n = r.Next(10, 30);
                if (n % 2 == 0)
                {
                    sred = sred + n;
                    y++;
                }
                x = x + n + " ";
            }
            ViewBag.t2 = x;
            ViewBag.sr2 = sred / y;

            x = "";
            sred = 0;
            y = 0;
            for (int j = 0; j < 9; j++)
            {
                n = r.Next(10, 30);
                if (n % 2 == 0)
                {
                    sred = sred + n;
                    y++;
                }
                x = x + n + " ";
            }
            ViewBag.t3 = x;
            ViewBag.sr3 = sred / y;

            x = "";
            sred = 0;
            y = 0;
            for (int j = 0; j < 9; j++)
            {
                n = r.Next(10, 30);
                if (n % 2 == 0)
                {
                    sred = sred + n;
                    y++;
                }
                x = x + n + " ";
            }
            ViewBag.t4 = x;
            ViewBag.sr4 = sred / y;

            x = "";
            sred = 0;
            y = 0;
            for (int j = 0; j < 9; j++)
            {
                n = r.Next(10, 30);
                if (n % 2 == 0)
                {
                    sred = sred + n;
                    y++;
                }
                x = x + n + " ";
            }
            ViewBag.t5 = x;
            ViewBag.sr5 = sred / y;

            x = "";
            sred = 0;
            y = 0;
            for (int j = 0; j < 9; j++)
            {
                n = r.Next(10, 30);
                if (n % 2 == 0)
                {
                    sred = sred + n;
                    y++;
                }
                x = x + n + " ";
            }
            ViewBag.t6 = x;
            ViewBag.sr6 = sred / y;

            x = "";
            sred = 0;
            y = 0;
            for (int j = 0; j < 9; j++)
            {
                n = r.Next(10, 30);
                if (n % 2 == 0)
                {
                    sred = sred + n;
                    y++;
                }
                x = x + n + " ";
            }
            ViewBag.t7 = x;
            ViewBag.sr7 = sred / y;

            x = "";
            sred = 0;
            y = 0;
            for (int j = 0; j < 9; j++)
            {
                n = r.Next(10, 30);
                if (n % 2 == 0)
                {
                    sred = sred + n;
                    y++;
                }
                x = x + n + " ";
            }
            ViewBag.t8 = x;
            ViewBag.sr8 = sred / y;

            x = "";
            sred = 0;
            y = 0;
            for (int j = 0; j < 9; j++)
            {
                n = r.Next(10, 30);
                if (n % 2 == 0)
                {
                    sred = sred + n;
                    y++;
                }
                x = x + n + " ";
            }
            ViewBag.t9 = x;
            ViewBag.sr9 = sred / y;
            return View();
        }
    }
}
