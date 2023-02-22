using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    class Order
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string CustomerNameSurname { get; set; }
        public DateTime DeliveryDate { get; set; }
        public List<Bill> Bills { get; set; }
    }
}
