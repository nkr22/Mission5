using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission5.Controllers
{
    public class HomeController : Controller
    {

        private MovieContext M5Context { get; set; }

        //Constructor
        public HomeController( MovieContext someName)
        {
            M5Context = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = M5Context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(FormResponse fr)
        {

            if (ModelState.IsValid)
            {
                M5Context.Add(fr);
                M5Context.SaveChanges();
                return View("Confirmation", fr);
            }
            else
            {

                ViewBag.Categories = M5Context.Categories.ToList();
                return View(fr);
            }


        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var submissions = M5Context.Responses.Include(x => x.Category).OrderBy(x => x.Title).ToList();
            return View(submissions);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = M5Context.Categories.ToList();
            var submission = M5Context.Responses.Single(x => x.MovieId == movieid);
            return View("MovieForm", submission);
        }

        [HttpPost]
        public IActionResult Edit(FormResponse fr)
        {
            M5Context.Update(fr);
            M5Context.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var submission=M5Context.Responses.Single(x => x.MovieId == movieid);

            return View(submission);

        }

        [HttpPost]
        public IActionResult Delete(FormResponse fr)
        {
            M5Context.Responses.Remove(fr);
            M5Context.SaveChanges();

            return RedirectToAction("MovieList");
            
        }
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
