/*  
8.Add new class Customer with id, firstname, lastname, email, and contactNumber data members.
9.Add properties to Customer class.
10.Implement overloaded constructors for Customer class.
11.Override ToString method to Customer class.
12.Test Customer class funcationality  in Main method.
*/


// Customer Relationship module
// Namespace: logical collection of .NET Types


namespace CRM
{
    public class Customer
    {
        public string UserId { get; set; }  //AutoProperty
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Location { get; set; }

    }
}

