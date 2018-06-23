using Modele.Entities.Entity;
using Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWeb.Models
{
    public class CategorieModels
    {
        private int _categorieId;
        private bool _categorieActive;
        private string _categorieLabel;

        public CategorieModels(Category p)
        {
            this._categorieId = p.CategoryId;
            this._categorieActive = p.CategoryActive;
            this._categorieLabel = p.CategoryLabel;
        }

        public CategorieModels() { }


        public int CategorieId
        {
            get { return _categorieId; }
            set { _categorieId = value; }
        }

        public bool CategorieActive
        {
            get { return _categorieActive; }
            set { _categorieActive = value; }
        }

        public string CategorieLabel
        {
            get { return _categorieLabel; }
            set { _categorieLabel = value; }
        }
    }
}