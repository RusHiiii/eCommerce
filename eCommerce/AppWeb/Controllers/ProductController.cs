using AppWeb.Converter;
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
        public ActionResult Create(ProduitModels p)
        {
            try
            {
                    Products toCreate = ConvertProduct.ConvertProductModel2ProductNotFull(p);
                    bll.AjouterProduit(toCreate);
                
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(ProduitModels p)
        {
            try
            {
                Products product = bll.GetProduct(p.ProductId);
                if (ModelState.IsValid)
                {
                    Products toUpdate = ConvertProduct.ConvertProductModel2Product(p, product);
                    bll.ModifierProduit(toUpdate);
                }
                return RedirectToAction("Index");
            }catch(Exception e)
            {
                return RedirectToAction("Index");
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
