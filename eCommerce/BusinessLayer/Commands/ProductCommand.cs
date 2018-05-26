using Modele;
using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class ProduitCommand
    {
        private readonly Context _contexte;
        
        public ProduitCommand(Context contexte)
        {
            _contexte = contexte;
        }
        
        public int Ajouter(Products p)
        {
            _contexte.Products.Add(p);
            return _contexte.SaveChanges();
        }
        
        public void Modifier(Products p)
        {
            Products upPrd = _contexte.Products.Where(prd => prd.ProductId == p.ProductId).FirstOrDefault();
            if (upPrd != null)
            {
                upPrd.ProductLabel = p.ProductLabel;
                upPrd.ProductCategoryId = p.ProductCategoryId;
            }
            _contexte.SaveChanges();
        }

        public void Supprimer(int produitID)
        {
            Products delPrd = _contexte.Products.Where(prd => prd.ProductId == produitID).FirstOrDefault();
            if (delPrd != null)
            {
                _contexte.Products.Remove(delPrd);
            }
            _contexte.SaveChanges();
        }
    }
}
