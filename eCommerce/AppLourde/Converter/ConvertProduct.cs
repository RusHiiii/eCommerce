using AppLourde.ViewModel;
using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLourde.Converter
{
    public class ConvertProduct
    {
        public static Products ConvertProductVM2Product(DetailProduitViewModel dPMV)
        {
            Products p = new Products();
            p.ProductId = dPMV.ProductId;
            p.ProductCode = dPMV.ProductCode;
            p.ProductLabel = dPMV.ProductLabel;
            p.ProductDescription = dPMV.ProductDescription;
            p.ProductActive = dPMV.ProductActive;
            p.ProductStock = dPMV.ProductStock;
            p.ProductPrice = dPMV.ProductPrice;
            p.ProductStockBuffer = dPMV.ProductStockBuffer;
            p.ProductCategoryId = dPMV.ProductCategoryId;
            return p;
        }

        public static DetailProduitViewModel ConvertProduct2ProductVM(Products p)
        {
            DetailProduitViewModel dPMV = new DetailProduitViewModel(p);
            return dPMV;
        }
    }
}
