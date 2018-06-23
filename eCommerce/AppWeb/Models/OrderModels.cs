using Modele.Entities.Entity;
using Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWeb.Models
{
    public class OrderModels
    {

        public OrderModels(Order p)
        {
            this.OrderClientEntityId = p.OrderClientEntityId;
            this.OrderDate = p.OrderDate;
            this.OrderId = p.OrderId;
            this.OrderObservation = p.OrderObservation;
            this.OrderStatusEntityId = p.OrderStatusEntityId;
        }

        public OrderModels() { }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderObservation { get; set; }
        public int OrderStatusEntityId { get; set; }
        public int OrderClientEntityId { get; set; }
    }
}