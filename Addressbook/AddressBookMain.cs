using System;
using System.Collections.Generic;
using System.Text;

namespace Addressbook
{
   public class Addressbook
    {
        public void AddPerson()
        {
            Contact contact= new Contact();
            Console.WriteLine("enter Your Name :");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("enter Your Lastname :");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("enter Your Name :");
            contact.Address = Console.ReadLine();

            Console.WriteLine("enter Your Name :");
            contact.City = Console.ReadLine();

            Console.WriteLine("enter Your Name :");
            contact.State = Console.ReadLine();

            Console.WriteLine("enter Your Name :");
            contact.email = Console.ReadLine();

            Console.WriteLine("enter Your Zip :" );
            Console.WriteLine("Enter Your PhoneNumber");
            List<Contact> Person = new List<Contact>();
            Person.Add(contact);

        }
    }
}
