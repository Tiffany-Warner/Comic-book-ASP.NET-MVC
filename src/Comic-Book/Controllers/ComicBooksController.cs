using Comic_Book.Data;
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
        private ComicBookRepository _comicBookRepository = null;

        //Constructor
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        //? means the type is nullable
        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            // Because int is a nullable type now, we have to either cast
            // the id as an int like so: (int) id or we have to call the 
            // nullable type's value: id.Value. Either method works. 
            var comicBook = _comicBookRepository.GetComicBook(id.Value);
            return View(comicBook);
        }
    }
}