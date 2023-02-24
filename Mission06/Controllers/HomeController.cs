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
            if (ModelState.IsValid)
            {
                daContext.Add(ar);
                daContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {

                ViewBag.Categories = daContext.Categories.ToList();
                return View(ar);
            }

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

        [HttpGet]
        public IActionResult Edit (int applicationid)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            var application = daContext.Responses.Single(x => x.ApplicationId == applicationid);

            return View("Movies", application);
        }

        [HttpPost]
        public IActionResult Edit (ApplicationResponse blah)
        {
            daContext.Update(blah);
            daContext.SaveChanges();

            return RedirectToAction("Waitlist");
        }

        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application = daContext.Responses.Single(x => x.ApplicationId == applicationid);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            daContext.Responses.Remove(ar);
            daContext.SaveChanges();

            return RedirectToAction("Waitlist");
        }

    }
}
