using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CatalogManager.Models
{
    public class Category
    {
        //public Category()
        //{
        //    //this.ChildCategories = new ObservableCollection<Category>();
        //    this.Products = new ObservableCollection<Product>();
        //}

        [Key]
        public int CategoryId { get; set; }
        [MaxLength(50), MinLength(2)]
        public string Name { get; set; }
        //public int ParentCategory { get; set; }

        ////public virtual ObservableCollection<Category> ChildCategories { get; set; }
        //public virtual ObservableCollection<Product> Products { get; set; }

    }
}
