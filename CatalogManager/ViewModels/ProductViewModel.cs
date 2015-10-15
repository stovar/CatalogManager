using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CatalogManager.Models;

namespace CatalogManager.ViewModels
{
    class ProductViewModel : INotifyPropertyChanged
    {
        CatalogContext _context = new CatalogContext();

        public ProductViewModel()
        {
            FillProducts();
        }

        private void FillProducts()
        {
            var q = (from a in _context.Products
                     select a).ToList();

            this.Products = q;
        
        }

        private List<Product> _products;
        public List<Product> Products
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
