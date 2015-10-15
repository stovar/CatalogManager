using System.Windows;
using System.Data.Entity;
using CatalogManager.ViewModels;


namespace CatalogManager.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private CatalogContext _context = new CatalogContext();

        public MainWindow()
        {
            InitializeComponent();
        }

       //private void Window_Loaded(object sender, RoutedEventArgs e)
       // {

       //     System.Windows.Data.CollectionViewSource categoryViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("categoryViewSource")));
       //     // Load data by setting the CollectionViewSource.Source property:
       //     // categoryViewSource.Source = [generic data source]

       //     _context.Categories.Load();

       //     // After the data is loaded call the DbSet<T>.Local property  
       //     // to use the DbSet<T> as a binding source. 

       //     categoryViewSource.Source = _context.Categories.Local;

       // }

       private void mnuProducts_Click(object sender, RoutedEventArgs e)
       {
           this.mainContentControl.Content = new Views.ProductView();
       }

       private void mnuCategories_Click(object sender, RoutedEventArgs e)
       {
           MessageBox.Show("New");
       }

       private void mnuCatalogManager_Click(object sender, RoutedEventArgs e)
       {
           MessageBox.Show("New");
       }



       //private void buttonSave_Click(object sender, RoutedEventArgs e)
       //{
       //    foreach (var product in _context.Products.Local.ToBindingList())
       //    {
       //        if (product.Name == null)
       //        {
       //            _context.Products.Remove(product);
       //        }
       //    }

       //    _context.SaveChanges();
       //  //  this.categoryDataGrid.Items.Refresh();
       //    this.productsDataGrid.Items.Refresh(); 
       //}

    }
}
