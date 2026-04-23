using DragonBallZMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DragonBallZMVC.Controllers
{
    public class HomeController : Controller
    {
        private DragonBallContext db = new DragonBallContext();
        public ActionResult Index()
        {

            ViewBag.Guerreros = db.Guerreros.ToList();
            ViewBag.Tecnicas = db.Tecnicas.Include("Guerrero").ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Increibles Guerreros de Dragon Ball Z";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacto";

            return View();
        }
    }
}