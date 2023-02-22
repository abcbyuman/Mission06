using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Controllers
{
    public class HomeController : Controller
    {

        private DateApplicationContext daContext { get; set; }

        //Constructor
        public HomeController(DateApplicationContext someName)
        {
            daContext = someName;
        }


        [HttpGet]

        public IActionResult Movies ()
        {
            ViewBag.Categories = daContext.Categories.ToList();

            return View();
        }

        [HttpPost]

        public IActionResult Movies(ApplicationResponse ar)
        {
            daContext.Add(ar);
            daContext.SaveChanges();
            return View("Confirmation", ar);
        }

        [HttpGet]
        public IActionResult Waitlist()
        {
            
            var applications = daContext.Responses
                .Include(x => x.Category)
                //.Where(blah => blah.Rating == 3)
                .OrderBy(x => x.Title)
                .ToList();

            return View(applications);
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

    }
}
