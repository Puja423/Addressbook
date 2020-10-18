﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Addressbook
{


    public class AddressBook
    {
        public ArrayList ContactList = new ArrayList();
        List<Contact> Person = new List<Contact>();
        public void AddPerson()
        {
            Contact contact = new Contact();
            Console.Write("Enter First Name: ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine();
            Console.Write("Enter Address : ");
            contact.Address = Console.ReadLine();
            Console.Write("Enter City : ");
            contact.City = Console.ReadLine();
            Console.Write("Enter State : ");
            contact.State = Console.ReadLine();
            Console.Write("Enter Zip Code : ");
            contact.ZipCode = Console.ReadLine();
            Console.Write("Enter Phone Number : ");
            contact.Phone = Console.ReadLine();
            Console.Write("Enter Email ID : ");
            contact.Email = Console.ReadLine();

            Person.Add(contact);
        }
        public Contact FindPerson(string firstName)
        {
            Contact toFind = Person.Find((person) => person.FirstName == firstName);
            return toFind;

        }
        public void EditContactDetails()
        {
            string firstName = Console.ReadLine();
            Contact editContact = FindPerson(firstName);
            if (editContact == null)
            {
                Console.WriteLine("Not Found :" + firstName);
            }
            else
            {
                Contact EditContactDetails = new Contact();
                Console.Write("Enter First Name: ");
                EditContactDetails.FirstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                EditContactDetails.LastName = Console.ReadLine();
                Console.Write("Enter Address : ");
                EditContactDetails.Address = Console.ReadLine();
                Console.Write("Enter City : ");
                EditContactDetails.City = Console.ReadLine();
                Console.Write("Enter State : ");
                EditContactDetails.State = Console.ReadLine();
                Console.Write("Enter Zip Code : ");
                EditContactDetails.ZipCode = Console.ReadLine();
                Console.Write("Enter Phone Number : ");
                EditContactDetails.Phone = Console.ReadLine();
                Console.Write("Enter Email ID : ");
                EditContactDetails.Email = Console.ReadLine();

            }
        }
        public void DeleteContactDetails()
        {
            string firstName = Console.ReadLine();
            Contact deleteContact = FindPerson(firstName);
            if (deleteContact == null)
            {
                Console.WriteLine("Not Found :" + firstName);
            }
            else
            {
                Person.Remove(deleteContact);
                Console.WriteLine("delete Contact successfully", firstName);
                ContactList.Remove(Person);
            }

        }
    }
}


