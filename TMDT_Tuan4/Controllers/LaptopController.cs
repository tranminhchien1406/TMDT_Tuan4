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
        public ActionResult getScreenResolution()
        {
            var ListScreenResolution = db.laptops.GroupBy(l => l.ScreenResolution).Select(l => l.Key);
            return PartialView(ListScreenResolution);
        }
        public ActionResult getTypeName()
        {
            var ListTypeName = db.laptops.GroupBy(l => l.TypeName).Select(l => l.Key);
            return PartialView(ListTypeName);
        }
        public ActionResult getMemory()
        {
            var ListMemory = db.laptops.GroupBy(l => l.Memory).Select(l => l.Key);
            return PartialView(ListMemory);
        }
        public ActionResult getGPU()
        {
            var ListGPU = db.laptops.GroupBy(l => l.Gpu).Select(l => l.Key);
            return PartialView(ListGPU);
        }
        public ActionResult getOS()
        {
            var ListOS = db.laptops.GroupBy(l => l.OpSys).Select(l => l.Key);
            return PartialView(ListOS);
        }
        public ActionResult getInches()
        {
            var ListInches = db.laptops.GroupBy(l => l.Inches).Select(l => l.Key);
            return PartialView(ListInches);
        }
        public ActionResult getSpeed()
        {
            var ListSpeed = db.laptops.GroupBy(l => l.Speed).Select(l => l.Key);
            return PartialView(ListSpeed);
        }
        public ActionResult getWeight()
        {
            var ListWeight = db.laptops.GroupBy(l => l.Weight).Select(l => l.Key);
            return PartialView(ListWeight);
        }
        public ActionResult getPriceLow()
        {
            var ListPriceLow = db.laptops.GroupBy(l => l.Price_euros).Select(l => l.Key);
            return PartialView(ListPriceLow);
        }
        public ActionResult getPriceHigh()
        {
            var ListPriceHigh = db.laptops.GroupBy(l => l.Price_euros).Select(l => l.Key);
            return PartialView(ListPriceHigh);
        }
        public ActionResult getRam()
        {
            var ListRam = db.laptops.GroupBy(l => l.Ram).Select(l => l.Key);
            return PartialView(ListRam);
        }
    }
}