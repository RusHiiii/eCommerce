using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Entities.Entity;

namespace BusinessLayer.Queries
{
    class OrderQuery
    {

        private readonly Context _contexte;

        public OrderQuery(Context contexte)
        {
            _contexte = contexte;
        }
        
        internal List<Order> getAllOrder()
        {
            return _contexte.Orders.ToList();
        }
        internal List<Order> getFiveOrder()
        {
            return _contexte.Orders.Take(5).ToList();

        }
    }
}
