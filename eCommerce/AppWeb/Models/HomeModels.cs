using Modele.Entities.Entity;
using Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWeb.Models
{
    public class HomeModels
    {
        private List<ProduitModels> products;
        private List<OrderModels> orders;

        public HomeModels(List<Products> list, List<Order> listO)
        {
            products = new List<ProduitModels>();
            foreach (Products prod in list)
            {
                products.Add(new ProduitModels(prod));
            }

            orders = new List<OrderModels>();
            foreach (Order ord in listO)
            {
                orders.Add(new OrderModels(ord));
            }

        }

        public List<ProduitModels> Products
        {
            get { return products; }
            set { products = value; }
        }

        public List<OrderModels> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
    }
}