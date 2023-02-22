using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Code { get; set; }
        public int Price { get; set; }
        public List<Bill> Bills { get; set; }
        public List<CompanyProduct> CompanyProducts { get; set; }
        public List<CategoryProduct> CategoryProducts { get; set; }
    }
}
