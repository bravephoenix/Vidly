using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public IList<Movie> GetMovies()
        {
            IList<Movie> movies = new List<Movie>
            {
                new Movie(){ Id=1, Name="Incredible Hulk" },
                new Movie(){ Id=2, Name="Iron Man" }
            };
            return movies;
        }
    }
}