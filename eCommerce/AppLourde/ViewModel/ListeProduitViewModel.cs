using AppLourde.Converter;
using AppLourde.ViewModel.common;
using BusinessLayer;
using Modele;
using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppLourde.ViewModel
{
    public class ListeProduitViewModel : BaseViewModel
    {

        private ObservableCollection<DetailProduitViewModel> _produits = null;
        private DetailProduitViewModel _selectedProduit;
        private String _productFilter;
        private BusinessManager bll;
        private RelayCommand _suppProduit;

        public ListeProduitViewModel()
        {
            bll = BusinessManager.Instance;
            _produits = new ObservableCollection<DetailProduitViewModel>();
            foreach (Products p in bll.GetAllProduit())
            {
                _produits.Add(new DetailProduitViewModel(p));
            }

            if (_produits != null && _produits.Count > 0)
                _selectedProduit = _produits.ElementAt(0);
        }
        public String FilterProduct
        {
            get { return _productFilter; }
            set {
                _productFilter = value;
                _produits.Clear();
                foreach (Products p in bll.filterProduct(_productFilter))
                {
                    _produits.Add(new DetailProduitViewModel(p));
                }
                OnPropertyChanged("Produits");
            }
        }


        public ObservableCollection<DetailProduitViewModel> Produits
        {
            get {
                return _produits;
            }
            set
            {
                _produits = value;
                OnPropertyChanged("Produits");
            }
        }

        public DetailProduitViewModel SelectedProduit
        {
            get
            {
                return _selectedProduit;
            }
            set
            {
                _selectedProduit = value;
                OnPropertyChanged("SelectedProduit");
            }
        }

        public ICommand SuppProduit
        {
            get
            {
                if (_suppProduit == null)
                    _suppProduit = new RelayCommand(() => this.SuppProductData());
                return _suppProduit;
            }
        }

        private void SuppProductData()
        {
            bll.SupprimerProduit(ConvertProduct.ConvertProductVM2Product(_selectedProduit).ProductId);
            _produits.Remove(_selectedProduit);
            OnPropertyChanged("Produits");
        }

    }
}
