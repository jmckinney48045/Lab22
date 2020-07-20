using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB22ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB22ASP.Controllers
{
    public class MovieController : Controller
    {
       
        public IActionResult Index()
        {
            List<Movie> movie = new List<Movie>
            {
                new Movie { Title = "Ghost", Genre = "Drama"},
                new Movie { Title = "A Star is Born", Genre = "Drama"},
                new Movie { Title = "Joker", Genre = "Drama"},
                new Movie { Title = "The Shining", Genre = "Horror"},
                new Movie { Title = "It", Genre = "Horror"},
                new Movie { Title = "Texas Chainsaw Massacre", Genre = "Horror"},
                new Movie { Title = "Elf", Genre = "Comedy"},
                new Movie { Title = "Stepbrothers", Genre = "Comedy"},
                new Movie { Title = "Dumb and Dumber", Genre = "Comedy"},
                new Movie { Title = "Mission Impossible", Genre = "Action"},
                new Movie { Title = "The Mummy", Genre = "Action"},
                new Movie { Title = "The Fifth Element", Genre = "Action"},
                new Movie { Title = "The Terminator", Genre = "Sci Fi"},
                new Movie { Title = "Planet of the Apes", Genre = "Sci Fi"},
                new Movie { Title = "12 Monkeys", Genre = "Sci Fi"},
                
            };
         
            return View(movie);
        }
    }
}