using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Restaurant.Dal;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class PiesController : Controller
    {
        private RestaurantContext db = new RestaurantContext();

        // GET: Pies
        public ActionResult Index(string Search)
        {
            var piesItems = from p in db.Pies
                       select p;
            if (!String.IsNullOrEmpty(Search))
            {
                piesItems = piesItems.Where(s => s.Name.Contains(Search));
            }
                return View(piesItems);
        }

        // GET: Pies/Details/
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pie pie = db.Pies.Find(id);
            if (pie == null)
            {
                return HttpNotFound();
            }
            return View(pie);
        }
    }
}
