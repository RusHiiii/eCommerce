using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Entities.Entity
{
    public class OrderProduct
    {
        public Order OrderProductOrderEntity { get; set; }
        public int OrderProductOrderEntityId { get; set; }
        public Products OrderProductProductsEntity { get; set; }
        public int OrderProductProductsEntityId { get; set; }
        public int OrderProductQuantity { get; set; }
        
    }
}
