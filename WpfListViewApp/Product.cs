﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfListViewApp
{
    internal class Product
    {
        public string Title { get; set; } = "";
        public string Company { get; set; } = "";
        public decimal Price { get; set; }
        public bool IsEmpty { get; set; } = false;
    }
}
