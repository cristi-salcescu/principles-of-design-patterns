using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAndBehavior
{
    public class ShoppingCart
    {
        private List<Product> productList;

        public ShoppingCart()
        {
            productList = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            productList.Add(product);
        }

        public void RemoveProduct(int productID)
        {
            var product = productList.Single(p => p.ID == productID);
            productList.Remove(product);
        }

        public List<Product> GetCart()
        {
            return productList.ToList();
        }
    }
}
