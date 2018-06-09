using BusinessLayer.Commands;
using BusinessLayer.Queries;
using Modele;
using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    public class BusinessManager
    {
        private readonly Context contexte;
        private static BusinessManager _businessManager = null;
        
        private BusinessManager()
        {
            contexte = new Context();
        }

        public static BusinessManager Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BusinessManager();
                return _businessManager;
            }
        }

        public List<Products> GetAllProduit()
        {
            ProduitQuery pq = new ProduitQuery(contexte);
            return pq.GetAll().ToList();
        }

        public List<Products> filterProduct(string filter)
        {
            ProduitQuery pq = new ProduitQuery(contexte);
            return pq.filterProducts(filter).ToList();
        }

        public List<Order> GetOrder()
        {
            OrderQuery pc = new OrderQuery(contexte);
            return pc.getAllOrder();
        }

        public Products GetProduct(int id)
        {
            ProduitQuery pc = new ProduitQuery(contexte);
            return pc.GetByID(id).Single();
        }

        public int AjouterProduit(Products p)
        {
            ProduitCommand pc = new ProduitCommand(contexte);
            return pc.Ajouter(p);
        }

        public int StockProduit(String code)
        {
            ProduitQuery pc = new ProduitQuery(contexte);
            return pc.Stockproduit(code);
        }

        public void ModifierProduit(Products p)
        {
            ProduitCommand pc = new ProduitCommand(contexte);
            pc.Modifier(p);
        }

        public void SupprimerProduit(int produitID)
        {
            ProduitCommand pc = new ProduitCommand(contexte);
            pc.Supprimer(produitID);
        }
        
        public List<Category> GetAllCategorie()
        {
            CategoryQuery pq = new CategoryQuery(contexte);
            return pq.GetAll().ToList();
        }
    }
}
