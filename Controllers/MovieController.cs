using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21_MovieRegisteration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab21_MovieRegisteration.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View(new Movie());
        }
        public IActionResult MovieResult(Movie movie)
        {
            if(ModelState.IsValid)
            {
                return View(movie);
            }

            return View("Index", movie);
        }

        public IActionResult WatchTrailer ()
        {
            return View();
        }
        public IActionResult PlayTrailer(Movie movie)
        {
            return View(movie);
        }


    }
}
