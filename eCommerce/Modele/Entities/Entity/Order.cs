using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Entities.Entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderObservation { get; set; }
        public Status OrderStatusEntity { get; set; }
        public int OrderStatusEntityId { get; set; }
        public Client OrderClientEntity { get; set; }
        public int OrderClientEntityId { get; set; }
    }
}
