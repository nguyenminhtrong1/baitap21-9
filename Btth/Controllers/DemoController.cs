using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Btth.Models;

namespace Btth.Controllers
{
    public class DemoController : Controller
    {
        kethua gpt = new kethua();
        // GET: Demo
        public ActionResult Nghiemphuongtrinh()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Nghiemphuongtrinh(string gta, string gtb)
        {
            double soA = Convert.ToDouble(gta);
            double soB = Convert.ToDouble(gtb);
            double x = gpt.GiaiPhuongTrinh(soA, soB);
            ViewBag.Giatrix = x; 
            return View();
        }
    }
}