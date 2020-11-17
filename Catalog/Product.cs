/*
3.Add new class Product with id, title, description, unitPrice, and quantity data members.
4.Add properties to Product class.
5.Implement overloaded constructors for Product class.
6.Override ToString method to Product class.
7.Test Product class funcationality  in Main method.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class Product
    {
        private int id; //DataMembers
        private string title;
        private string description;
        private int unitPrice;
        private int quantity;

        public int ID    //Property
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public int UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        Product() { }   //default Ctor

        public Product(int id, string title, string description, int unitPrice, int quantity)
        {

            this.id = id;
            this.title = title;
            this.description = description;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }

        ~Product() { }   //Desctructor

        public override string ToString()
        {
            //return base.ToString();

            return this.ID + " " + this.Title + " " + this.Description + " " + this.unitPrice + " " + this.Quantity;
        }

    }
}
