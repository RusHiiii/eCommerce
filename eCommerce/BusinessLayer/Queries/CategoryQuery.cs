using Modele;
using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class CategoryQuery
    {
        private readonly Context _contexte;

        public CategoryQuery(Context contexte)
        {
            _contexte = contexte;
        }

        public IQueryable<Category> GetAll()
        {
            return _contexte.Categories;
        }

        public IQueryable<Category> GetByID(int id)
        {
            return _contexte.Categories.Where(p => p.CategoryId == id);
        }
    }
}
