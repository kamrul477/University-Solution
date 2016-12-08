using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer.UniversitySolution;
using Domain.UniversitySolution;

namespace WebApi.UniversitySolution.Controllers
{
    public class HomeController : Controller
    {
        UniversityContext _context  = new UniversityContext();

        public ActionResult Index()
        {
            University university = new University {UnivesityName = "Dhaka University"};
            _context.Universities.Add(university);
            _context.SaveChanges();
            ViewBag.Title = _context.Universities.FirstOrDefault().UnivesityName;

            return View();
        }
    }
}
