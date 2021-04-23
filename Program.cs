using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace PhonebookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the Console Phonebook App!");
            Console.WriteLine("Select Operation");
            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display contact by Number");
            Console.WriteLine("3 View All Contacts");
            Console.WriteLine("4 Search for contacts for a given name");
            Console.WriteLine("Press 'x' to exit");
            var userInput = Console.ReadLine();

            var phoneBook = new Phonebook();

            while (true)
            { 
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact Name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact Number:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);

                        break;
                    case "2":
                        Console.WriteLine("Contact number to search:");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);

                        break;
                    case "3":

                        phoneBook.DisplayAllContact();
                        break;
                    case "4":
                        Console.WriteLine("Name search phrase");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;
                }

                Console.WriteLine("Select Operation");
                userInput = Console.ReadLine();
            }
        }
    }
}
