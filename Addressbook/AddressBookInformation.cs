using System;
using System.Collections.Generic;
using System.Text;

namespace Addressbook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int PhoneNumber { get; set; }
        public string email { get; set; }

        public static void CreateContact()
        {
            List<Contact> Person = new List<Contact>();
        }

    }
}
