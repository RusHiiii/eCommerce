using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Service.Data
{
    [DataContract]
    public class DataOrder
    {
        public DataOrder(int id, DateTime date, string obs)
        {
            this.OrderDate = date;
            this.OrderId = id;
            this.OrderObservation = obs;
        }
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public string OrderObservation { get; set; }
    }
}