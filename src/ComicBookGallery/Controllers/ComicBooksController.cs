using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }


            return Content("Hello from the comic book controller");
            

            
        }

    }
}

using System.Web.Mvc;

namespace Treehouse.Controllers
{
    public class VideoGamesController : Controller
    {
        public ActionResult Detail()
        {
            return "Welcome to the Video Game Detail page!";
        }
        return Content("Hello from the comic book controller");
    }
}