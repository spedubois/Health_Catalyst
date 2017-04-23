using people.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace people.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PeopleContext db = new PeopleContext();
            return View(db.People.ToList());
        }

        public ActionResult create(People people)
        {
            PeopleContext db = new PeopleContext();
            db.People.Add(people);
            return View();
        }

        [HttpPost]
        public ActionResult create(People model, HttpPostedFileBase image1)
        {
            PeopleContext db = new PeopleContext();
            if(image1 != null)
            {
                model.photo = new byte[image1.ContentLength];
                image1.InputStream.Read(model.photo, 0, image1.ContentLength);
            }
            db.People.Add(model);
            db.SaveChanges();
            return View(model);
        }

        public ActionResult List()
        {
            PeopleContext db = new PeopleContext();
            return View();
        }

        public ActionResult _List(String id)
        {
            PeopleContext db = new PeopleContext();
            List<People> peopleList = new List<People>();
            peopleList = db.People.Where(s => s.first == id || s.last == id).ToList();
            return PartialView(peopleList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}