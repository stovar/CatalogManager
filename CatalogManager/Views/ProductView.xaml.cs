using CatalogManager.Models;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace CatalogManager.Views
{
    /// <summary>
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class ProductView : UserControl
    {

        private CatalogContext _context = new CatalogContext();

        public ProductView()
        {
            InitializeComponent();
       
        }


         private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource categoryViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("categoryViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // categoryViewSource.Source = [generic data source]

            _context.Products.Load();         

            // After the data is loaded call the DbSet<T>.Local property  
            // to use the DbSet<T> as a binding source. 

            categoryViewSource.Source = _context.Products.Local;

        }

       
        private void buttonSaveProduct_Click(object sender, RoutedEventArgs e)
        {
            foreach (var product in _context.Products.Local)
            {
                if (product.Name == null)
                {
                    _context.Products.Remove(product);
                }
            }
     
            _context.SaveChanges();

            this.productDataGrid.Items.Refresh();

        }

     }
}
