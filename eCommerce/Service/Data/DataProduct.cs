using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Service.Data
{
    [DataContract]
    public class DataProduct
    {
        public DataProduct(int id, string code, string label, string dsc, int stock, float price){
            this.ProductId = id;
            this.ProductCode = code;
            this.ProductDescription = dsc;
            this.ProductStock = stock;
            this.ProductLabel = label;
            this.ProductPrice = price;
        }

        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string ProductCode { get; set; }
        [DataMember]
        public string ProductLabel { get; set; }
        [DataMember]
        public string ProductDescription { get; set; }
        [DataMember]
        public int ProductStock { get; set; }
        [DataMember]
        public float ProductPrice { get; set; }
    }
}