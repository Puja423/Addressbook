﻿using System;

namespace Addressbook
{
    class Program
    {
       
            
        AddressBook book;
        public Program()
        {
            book = new AddressBook();
        }
        static void Main(string[] args)
        {
            Program newProgram = new Program();
            Console.WriteLine("Welcome to the Address Book Program!");
            bool exist = true;
            while (exist)
            {
                Console.WriteLine("Select the option. \n1. Add new contact. \n2. Edit existing contact. \n3. Delete existing contact. \n4.Exit");
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
                            break;
                        }
                    case 4:
                        {
                            exist = false;
                            break;
                        }
                }
            }
        }
    }
}
    
