using Our_Birds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Our_Birds.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.PageTitle = "Birds of our planet";
            model.FirstArticleTitle = "Birds of Slovakia";
            model.SecondArticleTitle = "Birds of the World";
            model.ThirdArticleTitle = "Almost extinct birds";
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Pages()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}