using MyRoutine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MyRoutine.Controllers
{
    public class DashboardController : Controller
    {
        private ApplicationDbContext _context;
        public DashboardController()
        {
            _context = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Dashboard
        public ActionResult Index()
        {

            toggleRoutineItemViewModel tri = new toggleRoutineItemViewModel();
            using (_context)
            {
                tri.RoutineList = _context.Routines.ToList();
            }

            return View(tri);
        }
        [HttpPost]
        public ActionResult toggle(toggleRoutineItemViewModel sad)
        {
            var t = sad;
            return View();
        }
    }
}