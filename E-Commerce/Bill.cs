﻿using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    class Bill
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
