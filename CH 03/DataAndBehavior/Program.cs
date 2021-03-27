using System;

namespace DataAndBehavior
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Product(1, "0001", "Discover Functional JavaScript");
            var book2 = new Product(2, "0002", "Functional React");

            var shoppingCart = new ShoppingCart();
            shoppingCart.AddProduct(book1);
            shoppingCart.AddProduct(book2);

            var cart = shoppingCart.GetCart();

            Console.WriteLine(cart.Count);
            Console.WriteLine(cart[0].Name);
            Console.WriteLine(cart[1].Name);
            Console.WriteLine("App started.");
            Console.ReadKey();
        }
    }
}
