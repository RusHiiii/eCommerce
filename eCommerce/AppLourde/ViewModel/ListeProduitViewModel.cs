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

namespace AppLourde.ViewModel
{
    public class ListeProduitViewModel : BaseViewModel
    {

        private ObservableCollection<DetailProduitViewModel> _produits = null;
        private DetailProduitViewModel _selectedProduit;

        public ListeProduitViewModel()
        {
            BusinessManager bll = BusinessManager.Instance;
            _produits = new ObservableCollection<DetailProduitViewModel>();
            foreach (Products p in bll.GetAllProduit())
            {
                _produits.Add(new DetailProduitViewModel(p));
            }

            if (_produits != null && _produits.Count > 0)
                _selectedProduit = _produits.ElementAt(0);
        }
        
        public ObservableCollection<DetailProduitViewModel> Produits
        {
            get { return _produits; }
            set
            {
                _produits = value;
                OnPropertyChanged("Produits");
            }
        }

        public DetailProduitViewModel SelectedProduit
        {
            get { return _selectedProduit; }
            set
            {
                _selectedProduit = value;
                OnPropertyChanged("SelectedProduit");
            }
        }
        
    }
}
