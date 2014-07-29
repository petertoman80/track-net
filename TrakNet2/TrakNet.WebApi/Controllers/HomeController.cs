using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrakNet.Data;
using TrakNet.Entities;

namespace TrakNet.WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TrackNetDbContext ctx = new TrackNetDbContext();
            IEnumerable<Timesheet> timesheets = from t in ctx.Timesheets where t.Billable != true select t;
            List<Timesheet> timesheetsList = timesheets.ToList();

            return View();
        }
    }
}
