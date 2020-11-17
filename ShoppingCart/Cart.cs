/*
25.Add new class Cart to project.
26.Add Items collection to Cart class as private member.
27.Add two methods AddtoCart(Item item) and RemoveFromCart(Item item) to Cart class.
28.Add GetAllItems method to Cart class.
*/

using System.Collections.Generic;
namespace ShoppingCart
{
    public class Cart
    {
        private List<Item> items = new List<Item>(); //generic list collection of Items
        public List<Item> Items //Property
        {
            get { return items; }
            set { this.items = value; }
        }

        public void AddToCart(Item item)  //add object inside array
        {
            items.Add(item);
        }
        public void RemoveFromCart(Item item) //remove element from array
        {
            items.Remove(item);
        }
    }
}
