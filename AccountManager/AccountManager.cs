/* 
18.Add new class AccountManager class.
19.Add Login, Register, ChangePassword static methods to AccountManager class
*/


using CRM;
using System;

namespace Membership
{
    public static class AccountManager
    {
        public static bool Login(string userId, string password)
        {
            bool status = false;
            if (userId == "Namrata" && password == "Bright")
            {
                status = true;
            }
            return status;
        }

        public static bool Register(string loginId, string password, string name, string email,
                                       string contactNumber, string location)
        {
            bool status = false;
            Customer theCustomer = new Customer();

            theCustomer.FullName = name;
            theCustomer.UserId = loginId;
            theCustomer.Password = password;
            theCustomer.Email = email;
            theCustomer.ContactNumber = contactNumber;
            theCustomer.Location = location;

            if (theCustomer != null)
                status = true;
            return status;
        }

        public static bool ChangePassword(string loginId, string existingPassword, string newPassword)
        {
            bool status = false;
            // set new password for userId
            // How do I Set
            // you need make changes into file, database....?
            return status;
        }


        public static bool ForgotPassword(string loginId)
        {
            bool status = false;
            //
            return status;
        }
    }

}
