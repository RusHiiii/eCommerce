using AppWeb.Models;
using BusinessLayer;
using Modele.Entities.Entity;
using Service;
using Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    public class ProductController : Controller
    {
        private BusinessManager bll = BusinessManager.Instance;

        // GET: Product
        public ActionResult Index()
        {
            //List products
            
            ProduitListModel products = new ProduitListModel(bll.GetAllProduit());
            return View("Index", products);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            ProduitModels product = new ProduitModels(bll.GetProduct(id));
            return View("Details", product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            bll.SupprimerProduit(id);
            return RedirectToAction("Index");
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
