using AppWeb.Models;
using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWeb.Converter
{
    public class ConvertProduct
    {
        public static Products ConvertProductModel2Product(ProduitModels m, Products pr)
        {
            Products p = new Products();
            p.ProductId = m.ProductId;
            p.ProductCode = m.ProductCode;
            p.ProductLabel = m.ProductLabel;
            p.ProductDescription = m.ProductDescription;
            p.ProductActive = pr.ProductActive;
            p.ProductStock = m.ProductStock;
            p.ProductPrice = m.ProductPrice;
            p.ProductStockBuffer = pr.ProductStockBuffer;
            p.ProductCategoryId = pr.ProductCategoryId;
            return p;
        }

        public static Products ConvertProductModel2ProductNotFull(ProduitModels m)
        {
            Products p = new Products();
            p.ProductId = m.ProductId;
            p.ProductCode = m.ProductCode;
            p.ProductLabel = m.ProductLabel;
            p.ProductDescription = m.ProductDescription;
            p.ProductStock = m.ProductStock;
            p.ProductPrice = m.ProductPrice;
            p.ProductCategoryId = m.ProductCategorieId;
            return p;
        }
    }
}
