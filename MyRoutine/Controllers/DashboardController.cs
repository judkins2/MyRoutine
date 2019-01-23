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
        List<Routine> _routines = new List<Routine>();

        public DashboardController()
        {
            _context = new ApplicationDbContext();
            _routines = _context.Routines.ToList();

        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Dashboard
        public ActionResult Index()
        {
            return View(_routines);
        }

        public ActionResult Toggle(int Id)
        {
            List<Routine> routines = new List<Routine>();
            Routine routine = new Routine();

            routine = _context.Routines.FirstOrDefault(x => x.Id == Id);

            if (!routine.Complete)
            {
                routine.Complete = true;
                 routine.CompleteDate = DateTime.Now;
                _context.SaveChanges();
            }
            else
            {
                //_context.Routines.FirstOrDefault(x => x.Id == Id).Complete = false;
                ////_context.Routines.FirstOrDefault(x => x.Id == Id).TimeStamp = DateTime.Now;
                //_context.SaveChanges();
            }
            // _context.RoutineItems.Add( new RoutineItem { RoutineID=})


            routines = _context.Routines.ToList();
            return RedirectToAction("index", routines);

        }

        public ActionResult Finalize()
        {
            List<Routine> routines = new List<Routine>();

            routines = _context.Routines.ToList();
            
            foreach (var item in routines)
            {
                item.FinalizedDate = DateTime.Now;
                RoutineItem ri = new RoutineItem();
                ri.Complete = item.Complete;
                ri.RoutineID = item.Id;
                ri.CompleteDate = DateTime.Now.Date;
                item.Complete = false;
                _context.RoutineItems.Add(ri);
                _context.SaveChanges();
            }


            return View("Index", routines);
        }
    }
}