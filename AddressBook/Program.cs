using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            UC3AddressBook book = new UC3AddressBook(); // creating object of class
            string yes = "y";
            string y;

            do
            {
                Console.WriteLine("Welcome to Address Book");
                Console.WriteLine("1.AddNewContact\n2.ShowContact\n3.EditContact\n4.RmoveContact");
                Console.WriteLine("\nEnter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());


                switch (ch)
                {

                    case 1:
                        Console.WriteLine("\nhow many contact you want to add");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            book.GetContactDetails();
                            Console.WriteLine("\n");    //through object accessing method 

                        }
                        break;
                    case 2:
                        book.putDetails();
                        break;

                    case 3:
                        /// Edit Contact
                        book.editContact();
                        break;

                    case 4:
                        /// Remove Contact
                       // book.removeContact();
                        break;

                    default:
                        break;
                }
                Console.WriteLine("do you want to continue? press...y/n");
                y = Console.ReadLine();

            } while (yes == y);

            Console.ReadLine();

        }
    }
}
