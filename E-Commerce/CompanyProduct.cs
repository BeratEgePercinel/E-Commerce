using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    class CompanyProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
