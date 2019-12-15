using MVCCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        MovieGenreDbContext db = new MovieGenreDbContext();
        public ActionResult Index()
        {
          
            
                var w = db.Movies ;

                return View(w);
            
         
        }
        public ActionResult Add()
        {

           
            ViewBag.GenreId = new SelectList(db.Genres , "GenreId","From");

            return View();


        }
        [HttpPost]
        public ActionResult Add(Movie m)
        {


            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "From");
            db.Movies.Add(m);
            db.SaveChanges();
            return RedirectToAction("Index");

        


        }
        public ActionResult Edit(int ? id)
        {

            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "From");
            var w = db.Movies.Find(id);

            return View(w );


        }
        [HttpPost]
        public ActionResult Edit(Movie m)
        {


            db.Entry(m).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int ? id )
        {
            var w = db.Movies.Find(id);

            return View(w );
        }
        [HttpPost]
        public ActionResult Delete(Movie m)
        {

            var w = db.Movies.Find(m.MovieId);
            db.Entry(w).State = EntityState.Deleted ;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}