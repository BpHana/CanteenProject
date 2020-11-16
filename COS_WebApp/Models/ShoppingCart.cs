using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COS_WebApp.Models
{
    public class ShoppingCart
    {
        int id;
        string name;
        int quantity;
        double money;
        string img;

        public ShoppingCart()
        {
        }

        public ShoppingCart(int id,  string name, int quantity, double money, string img)
        {
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.Money = money;
            this.Img = img;
        }

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Money { get => money; set => money = value; }
        public int Id { get => id; set => id = value; }
        public string Img { get => img; set => img = value; }

        public void AddItem(int id, string name, int quantity, double money, string img)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Money = money;
            Img = img;
        }
    }
}