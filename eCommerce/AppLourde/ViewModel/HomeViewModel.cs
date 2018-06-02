using AppLourde.ViewModel.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLourde.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {

        private ListeProduitViewModel _listeProduitViewModel = null;

        public HomeViewModel()
        {
            _listeProduitViewModel = new ListeProduitViewModel();
        }

        public ListeProduitViewModel ListeProduitViewModel
        {
            get { return _listeProduitViewModel; }
            set {
                _listeProduitViewModel = value;
            }
        }

    }
}
