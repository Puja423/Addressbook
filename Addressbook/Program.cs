using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Addressbook
{
    class Program
    {
        public HashSet<Contact> ContactSet;

        AddressBook book;
        public Program()
        {
            ContactSet = new HashSet<Contact>();
            book = new AddressBook();
        }
        static void Main(string[] args)
        {
            Program newProgram = new Program();
            Console.WriteLine("Welcome to the Address Book Program!");
            bool exist = true;
            while (exist)
            {
                string bookInfo;
                HashSet<Contact> ContactSet = new HashSet<Contact>();
                Dictionary<string, HashSet<Contact>> Book = new Dictionary<string, HashSet<Contact>>();
               
                Console.WriteLine("Enter New addressBook");
                bookInfo = Console.ReadLine();
                Console.WriteLine("Select the option. \n1. Add new contact. \n2. Edit existing contact. \n3. Delete existing contact. \n4.Search by city. \n5.Search by state. \n6.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            newProgram.book.AddPerson();
                            Console.WriteLine("Contact added!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the first name of that person: ");
                            newProgram.book.EditContactDetails();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the first name of that Person:");
                            newProgram.book.DeleteContactDetails();
                            Console.WriteLine("count of Person:" + Book.Count);
                            break;
                        }
                    case 4:
                        {
                            SearchContacts.SearchByCity();
                            break;
                        }
                    case 5:
                        {
                            SearchContacts.SearchByState();
                            break;
                        }
                    case 6:
                        {
                            exist = false;
                            break;
                        }
                }
            }
        }
    }
}
    
