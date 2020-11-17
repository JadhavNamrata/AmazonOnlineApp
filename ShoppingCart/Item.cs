/*
  21.Add new class Item with id, product, quantity data members.
  22.Add properties to Item class.
  23.Implement overloaded constructors for Item class.
  24.Override ToString method to Item class.
*/
using Catalog;

namespace ShoppingCart
{
    public class Item
    {
        public Product theProduct { get; set; } //Autoproperty
        public int Quantity { get; set; }

        public Item(Product product, int quantity)  //Ctor
        {
            theProduct = product;
            Quantity = quantity;
        }
    }
}
