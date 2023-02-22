using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductCount { get; set; }
        public int CompanyCount { get; set; }
        public List<CategoryProduct> CategoryProducts { get; set; }
    }
}
