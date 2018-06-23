using AppWeb.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    public class HomeController : Controller
    {
        private BusinessManager bll = BusinessManager.Instance;
        public ActionResult Index()
        {
            HomeModels data = new HomeModels(bll.GetAllProduit(), bll.GetFiveOrder());
            return View("Index", data);
        }
        

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}