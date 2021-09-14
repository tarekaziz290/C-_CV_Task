using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace first.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Bio()

        {
            ViewBag.Intro = "MD Tarek Aziz";
            ViewBag.Address = "Ashara,Chandina,Cumilla";
            ViewBag.Contact = "Email: azizt0127@gmail.com| Contact: +8801609439416";
            return View(); 
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Project()
        {
            ViewBag.Addition = "Additional Skills: ";
            ViewBag.Skills = "Language Bangla, English, Hindi (Speaking only) ,Photo Editing Adobe Photoshop,Graphics Design";
            return View();
        }

        public ActionResult Reference()
        {
            ViewBag.Rname = "Tanvir Ahmed";
            ViewBag.Details = "Lecturer,Department of Computer Science, FST, AIUB ,Email – tanvir.ahmed @aiub.edu";
            return View();
        }
    }
}