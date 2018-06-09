using Modele.Entities.Entity;
using Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWeb.Models
{
    public class ProduitListModel
    {
        private List<ProduitModels> products;

        public ProduitListModel(List<Products> list)
        {
            products = new List<ProduitModels>();
            foreach (Products prod in list)
            {
                products.Add(new ProduitModels(prod));
            }

        }

        public List<ProduitModels> Products
        {
            get { return products; }
            set { products = value; }
        }


    }
}