using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Entities.Entity
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductCode{ get; set; }
        public string ProductLabel { get; set; }
        public string ProductDescription { get; set; }
        public bool? ProductActive { get; set; }
        public int ProductStock { get; set; }
        public float ProductPrice { get; set; }
        public int? ProductStockBuffer { get; set; }
        public Category ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }
    }
}
