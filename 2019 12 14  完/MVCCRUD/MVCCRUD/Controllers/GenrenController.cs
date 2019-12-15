using MVCCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD.Controllers
{
    public class GenrenController : Controller
    {
        // GET: Genren
        MovieGenreDbContext db = new MovieGenreDbContext() { };
        public ActionResult Index()
        {
            var DB = new MovieGenreDbContext();
            {
                var w = DB.Genres;

                return View(w);
            }
          
        }
        public ActionResult Add()
        {
           

                return View();
       

        }
        [HttpPost]
        public ActionResult Add(Genre g)
        {
            db.Genres.Add(g);
            db.SaveChanges();
            return RedirectToAction("Index");


        }
        public ActionResult Edit(int? id)
        {

            var w = db.Genres.Find(id);
            return View(w);

        }
        [HttpPost]
        public ActionResult Edit(Genre g)
        {

            db.Entry(g).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int? id)
        {

            var w = db.Genres.Find(id);
            return View(w);

        }
        [HttpPost ]
        public ActionResult Delete(int id)
        {
            var g = db.Genres.Find(id);
            db.Entry(g).State = EntityState.Deleted ;
            db.SaveChanges();
            return RedirectToAction("Index");

        }



    }
}