﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitStore
{
    public class Product
    {
        public string ArticleNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public byte[] Photo { get; set; }
        public string Manufacturer { get; set; }
        public decimal Cost { get; set; }
        public int QuantityInStock { get; set; }
        public string Status { get; set; } // "Available" или "Not Available"
    }
}
