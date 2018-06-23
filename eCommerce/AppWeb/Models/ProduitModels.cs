using Modele.Entities.Entity;
using Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWeb.Models
{
    public class ProduitModels
    {
        private int _productId;
        private string _productCode;
        private string _productLabel;
        private string _productDescription;
        private int _productStock;
        private float _productPrice;
        private int _productCategorieId;

        public ProduitModels(Products p)
        {
            this._productId = p.ProductId;
            this._productCode = p.ProductCode;
            this._productLabel = p.ProductLabel;
            this._productDescription = p.ProductDescription;
            this._productStock = p.ProductStock;
            this._productPrice = p.ProductPrice;
            this._productCategorieId = p.ProductCategoryId;
        }

        public ProduitModels() { }

        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public string ProductCode
        {
            get { return _productCode; }
            set {_productCode = value; }
        }
        public string ProductLabel
        {
            get { return _productLabel; }
            set {_productLabel = value; }
        }

        public string ProductDescription
        {
            get { return _productDescription; }
            set { _productDescription = value; }
        }

        public int ProductStock
        {
            get { return _productStock; }
            set { _productStock = value; }
        }
        public float ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }

        public int ProductCategorieId
        {
            get { return _productCategorieId; }
            set { _productCategorieId = value; }
        }

    }
}