using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Modele.Entities.Entity;
using BusinessLayer;
using System.ServiceModel.Web;
using Service.Data;

namespace Service
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceEcommerce" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceEcommerce.svc ou ServiceEcommerce.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceEcommerce : IServiceCommerce
    {
        public List<DataOrder> GetOrders()
        {
            BusinessManager bll = BusinessManager.Instance;
            List<Order> l = bll.GetOrder();
            List<DataOrder> lData = new List<DataOrder>();
            foreach (Order tmp in l)
            {
                lData.Add(new DataOrder(tmp.OrderId, tmp.OrderDate, tmp.OrderObservation));
            }
            return lData;
        }

        public int GetProductStock(string code)
        {
            BusinessManager bll = BusinessManager.Instance;
            return bll.StockProduit(code);
        }

        
        public List<DataProduct> GetProduits()
        {
            BusinessManager bll = BusinessManager.Instance;
            List<Products> l = bll.GetAllProduit();
            List<DataProduct> lData = new List<DataProduct>();
            foreach(Products tmp in l)
            {
                lData.Add(new DataProduct(tmp.ProductId, tmp.ProductCode, tmp.ProductLabel, tmp.ProductDescription, tmp.ProductStock, tmp.ProductPrice));
            }
            return lData;
        }
    }
}
