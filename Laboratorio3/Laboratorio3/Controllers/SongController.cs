using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace Laboratorio3.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            //var movies = GetListOfMovies();
            var song = GetFavoriteSong();
            ViewBag.MainTitle = "My favorite song";
            return View(song);
        }

        private List<SongModel> GetFavoriteSong()
        {
            List<SongModel> song = new List<SongModel>();
            song.Add(new SongModel
            {
                Name = "A Sky Full of Stars",
                Autor = "Coldplay",
                Genre = "pop-rock",
                Album = "Ghost Stories",
                ReleasedDate = new DateTime(2010, 05, 2)
            });
            return song;
        }
    }
}
