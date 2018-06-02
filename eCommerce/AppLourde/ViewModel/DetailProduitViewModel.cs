using AppLourde.Converter;
using AppLourde.ViewModel.common;
using BusinessLayer;
using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppLourde.ViewModel
{
    public class DetailProduitViewModel : BaseViewModel
    {

        private int _productId;
        private string _productCode;
        private string _productLabel;
        private string _productDescription;
        private bool _productActive;
        private int _productStock;
        private float _productPrice;
        private int _productStockBuffer;
        private int _productCategoryId;
        //private Category _productCategory;

        private RelayCommand _updateProduit;
        private BusinessManager bll;

        public DetailProduitViewModel(Products p)
        {
            this.bll = BusinessManager.Instance;
            this._productId = p.ProductId;
            this._productCode = p.ProductCode;
            this._productLabel = p.ProductLabel;
            this._productDescription = p.ProductDescription;
            this._productActive = p.ProductActive;
            this._productStock = p.ProductStock;
            this._productPrice = p.ProductPrice;
            this._productStockBuffer = p.ProductStockBuffer;
            this._productCategoryId = p.ProductCategoryId;
        }

        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public string ProductCode
        {
            get { return _productCode; }
            set {
                _productCode = value;
                OnPropertyChanged("ProductCode");
            }
        }
        public string ProductLabel
        {
            get { return _productLabel; }
            set {
                _productLabel = value;
                OnPropertyChanged("ProductLabel");
            }
        }

        public string ProductDescription
        {
            get { return _productCode; }
            set { _productCode = value; }
        }
        public bool ProductActive
        {
            get { return _productActive; }
            set { _productActive = value; }
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

        public int ProductStockBuffer
        {
            get { return _productStockBuffer; }
            set { _productStockBuffer = value; }
        }
        public int ProductCategoryId
        {
            get { return _productCategoryId; }
            set { _productCategoryId = value; }
        }

        
        public ICommand UpdateProduit
        {
            get
            {
                if (_updateProduit == null)
                    _updateProduit = new RelayCommand(() => this.UpdateProductData());
                return _updateProduit;
            }
        }
        
        private void UpdateProductData()
        {
            bll.ModifierProduit(ConvertProduct.ConvertProductVM2Product(this));
        }
    }
}
