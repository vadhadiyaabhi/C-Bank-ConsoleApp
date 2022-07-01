using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using BankConsoleApp.Entities;

namespace BankConsoleApp.Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mainMenuChoise = -1;

            WriteLine("===== Welcome to Console Bank =====");
            do
            {
                WriteLine("\n:::Main Menu:::");
                WriteLine("1: Customers");
                WriteLine("2: Accounts");
                WriteLine("3: Fund Transfer");
                WriteLine("0: Exit");
                WriteLine("Enter Choise");
                int.TryParse(ReadLine(), out mainMenuChoise);

                switch (mainMenuChoise)
                {
                    case 0: break;
                    case 1: Customer(); break;
                    case 2: Account(); break;
                }
            } while (mainMenuChoise != 0);

            WriteLine("\n\nPress Enter to Close the App");
            ReadKey();

        }

        public static void Account()
        {
            
            int accountChoise = -1;
            do
            {
                WriteLine("\n\n:::Account Menu:::");
                WriteLine("1. Create Account");
                WriteLine("2. Update Account");
                WriteLine("3. Delete Account");
                WriteLine("4. Show Accounts");
                WriteLine("0. Back To Main Menu");
                int.TryParse(ReadLine(), out accountChoise);

                switch (accountChoise)
                {
                    case 0: break;
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                }
            } while (accountChoise != 0);
        }

        public static void Customer()
        {

            int custMenuChoise = -1;
            do
            {
                WriteLine("\n\n:::Account Menu:::");
                WriteLine("1. Create Customer");
                WriteLine("2. Update Customer");
                WriteLine("3. Delete Customer");
                WriteLine("4. Show Customers");
                WriteLine("5. Show Customer Details");
                WriteLine("0. Back To Main Menu");
                int.TryParse(ReadLine(), out custMenuChoise);

                switch (custMenuChoise)
                {
                    case 0: break;
                    case 1: CustomersPresentation.CreateCustomer(); break;
                    case 2: break;
                    case 3: CustomersPresentation.DeleteCustomer(); break;
                    case 4: CustomersPresentation.ShowCustomers(); break;
                    case 5: CustomersPresentation.GetFilteredCustomers(); break;
                }
            } while (custMenuChoise != 0);
        }

        
    }
}
