using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDT_Tuan4.Models;
namespace TMDT_Tuan4.Controllers
{
    public class LaptopController : Controller
    {
        TMDT5Entities db = new TMDT5Entities();
        // GET: Laptop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getCompany()
        {
            var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
            return PartialView(ListCompany);
        }
        public ActionResult getCPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }
    }
}