﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
        public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public string ShoppingCartId { get; set; }

    }
}
