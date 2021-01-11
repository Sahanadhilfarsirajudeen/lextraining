using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lextraining_core.Models;

namespace lextraining_core.ViewModels
{
    public class ProductManagerViewModel
    {
            public Product Product { get; set; }
            public IEnumerable<ProductCategory> ProductCategories { get; set; }
      
    }
}
