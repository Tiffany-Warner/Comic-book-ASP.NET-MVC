using Comic_Book.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comic_Book.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            //Using object initializer syntax
            //Could also just name each property... comicBook.SeriesTitle = "The Amazing Spider-Man";
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Dan Slott", Role="Script"},
                    new Artist() {Name = "Humberto Ramos", Role="Pencils"},
                    new Artist() {Name = "Victor Olazaba", Role="Inks"},
                    new Artist() {Name = "Edgar Delgado", Role="Colors"},
                    new Artist() {Name = "Chris Eliopoulos", Role="Letters"}
                }
            };
            return View(comicBook);
        }
    }
}