using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COS_WebApp.Models
{
    public class Categories
    {
        product product;

        public Categories(product product)
        {
            this.Product = product;
        }

        public product Product { get => product; set => product = value; }
    }
}