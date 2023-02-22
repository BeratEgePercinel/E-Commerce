using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    class CategoryProduct
    {
        public int Id { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }

}
