using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication16.Models;

namespace WebApplication16.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        portfolioEntities db = new portfolioEntities();
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(datta o)
        {
            db.dattas.Add(o);
            db.SaveChanges();
            ModelState.Clear();
            return View();
        }
    }
}