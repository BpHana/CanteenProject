using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COS_WebApp.Models
{
    public class ShoppingCart
    {
        product product;
        int quantity;

        public ShoppingCart(product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

        public product Product { get => product; set => product = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}