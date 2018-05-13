using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HourManager.Controllers
{
    public class TimeEntryController : Controller
    {
        // GET: TimeEntry
        public ActionResult Index()
        {
            return View();
            
        }
    }
}