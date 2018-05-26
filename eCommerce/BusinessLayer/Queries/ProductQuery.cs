using Modele;
using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class ProduitQuery
    {
        private readonly Context _contexte;

        public ProduitQuery(Context contexte)
        {
            _contexte = contexte;
        }

        public IQueryable<Products> GetAll()
        {
            return _contexte.Products;
        }
        
        public IQueryable<Products> GetByID(int id)
        {
            return _contexte.Products.Where(p => p.ProductId == id);
        }
    }
}
