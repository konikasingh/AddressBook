using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            UC1AddressBook book = new UC1AddressBook(); // creating object of class

            book.GetContactDetails();   //through object accessing method 
            book.putDetails();
        }
    }
}
