using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CompanyProduct> CompanyProducts { get; set; }
    }
}
