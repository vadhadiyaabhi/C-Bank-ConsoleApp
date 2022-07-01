using BankConsoleApp.Entities;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankConsoleApp.Exceptions;
using BankConsoleApp.BusinessLogicLayer.BLLContracts;
using BankConsoleApp.BusinessLogicLayer;

namespace BankConsoleApp.Presentation
{
    public static class CustomersPresentation
    {
        public static void CreateCustomer()
        {
            try
            {
                Customer customer = new Customer();

                WriteLine("*****Add New Customer*****");
                Write("Enter Name: ");
                customer.Name = ReadLine();
                Write("Enter Address: ");
                customer.Address = ReadLine();
                Write("Enter City: ");
                customer.City = ReadLine();
                Write("Enter ZipCode: ");
                customer.ZipCode = ReadLine();
                Write("Enter Mobile: ");
                customer.Mobile = ReadLine();
                Write("Enter DateOfBirth(MM/dd/YYYY): ");
                customer.DateOfBirth = Convert.ToDateTime(ReadLine());

                ICustomersBusinessLogicLayer customerBusinessLogic = new CustomersBusinessLogicLayer();
                long customerCode = customerBusinessLogic.AddCustomer(customer);
                if(customerCode > 0)
                {
                    WriteLine("Customer crerated successfuly");
                    WriteLine($"Customer Code is: {customerCode}\n");
                }
                else
                {
                    WriteLine("Customer not added\n");
                }
                
            }
            catch (CustomerException ex)
            {
                WriteLine(ex.GetType());
                WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                WriteLine(ex.GetType());
                WriteLine(ex.Message);
            }
            

        }

        public static void ShowCustomers()
        {
            try
            {
                ICustomersBusinessLogicLayer customersBusinessLogic = new CustomersBusinessLogicLayer();
                var customers = customersBusinessLogic.GetCustomers();
                WriteLine("All Cusotmers:  ");
                int i = 0;
                foreach (Customer customer in customers)
                {
                    WriteLine("---------Cusotmer "+ i);
                    WriteLine($"CustomerCode: {customer.CustomerCode}");
                    WriteLine($"Name: {customer.Name}");
                    WriteLine($"Address: {customer.Address}");
                    WriteLine($"Mobile: {customer.Mobile}");
                    WriteLine($"ZipCode: {customer.ZipCode}");
                    WriteLine($"DateOfBirth: {customer.DateOfBirth.Date}");
                    i++;
                }
            }
            catch (CustomerException ex)
            {
                WriteLine(ex.GetType());
                WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                WriteLine(ex.GetType());
                WriteLine(ex.Message);
            }
            
        }

        public static void GetFilteredCustomers()
        {
            try
            {
                ICustomersBusinessLogicLayer customersBusinessLogic = new CustomersBusinessLogicLayer();
                Write("Enter CustomerCode: ");
                long customerCode = Convert.ToInt64(ReadLine());
                var customers = customersBusinessLogic.GetFilteredCustomers(x => x.CustomerCode == customerCode);
                WriteLine("Your Cusotmer's details is:  ");
                foreach (Customer customer in customers)
                {
                    WriteLine($"Name: {customer.Name}");
                    WriteLine($"Address: {customer.Address}");
                    WriteLine($"Mobile: {customer.Mobile}");
                    WriteLine($"ZipCode: {customer.ZipCode}");
                    WriteLine($"DateOfBirth: {customer.DateOfBirth.Date}");
                }
            }
            catch (CustomerException ex)
            {
                WriteLine(ex.GetType());
                WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                WriteLine(ex.GetType());
                WriteLine(ex.Message);
            }
        }

        public static void DeleteCustomer()
        {
            try
            {
                ICustomersBusinessLogicLayer customersBusinessLogic = new CustomersBusinessLogicLayer();
                Write("Enter Customer Code: ");
                long customerCode = Convert.ToInt64(ReadLine());
                var customers = customersBusinessLogic.GetFilteredCustomers(x => x.CustomerCode == customerCode);
                if(customers != null)
                {
                    bool res = customersBusinessLogic.DeleteCustomer(customers[0].Id);
                    if (res)
                    {
                        WriteLine("Customer Deleted SuccessFully");
                    }
                    else
                    {
                        WriteLine("Customer not deleted");
                    }
                }
                else
                {
                    WriteLine("No customer found with given CustomerCode");
                }
            }
            catch (CustomerException ex)
            {
                WriteLine(ex.GetType());
                WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                WriteLine(ex.GetType());
                WriteLine(ex.Message);
            }
        }

        public static void UpdateCustomer()
        {
            try
            {
                ICustomersBusinessLogicLayer customersBusinessLogic = new CustomersBusinessLogicLayer();
                Write("Enter Customer code from below list: ");
                List<long> customersCode = customersBusinessLogic.GetCustomers().Select(x=> x.CustomerCode).ToList();
                foreach(long code in customersCode)
                {
                    WriteLine(code);
                }
                long customerCode = -1;
                do
                {
                    customerCode = Convert.ToInt64(ReadLine());
                    if (customersCode.Contains(customerCode))
                    {
                        Customer customer = new Customer();
                        customer.CustomerCode = customerCode;
                        Write("Enter new Name: ");
                        customer.Name = ReadLine();
                        Write("Enter new Address: ");
                        customer.Address = ReadLine();
                        Write("Enter new City: ");
                        customer.City = ReadLine();
                        Write("Enter new ZipCode: ");
                        customer.ZipCode = ReadLine();
                        Write("Enter new Mobile: ");
                        customer.Mobile = ReadLine();
                        Write("Enter new DateOfBirth(MM/dd/YYYY): ");
                        customer.DateOfBirth = Convert.ToDateTime(ReadLine());
                        bool res = customersBusinessLogic.UpdateCustomer(customer);
                        if (res)
                        {

                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        WriteLine("Please enter valid customer code from above list OR enter 0 to exit");
                    }
                } while (customerCode != 0);
                
            }
            catch (CustomerException ex)
            {
                WriteLine(ex.GetType());
                WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                WriteLine(ex.GetType());
                WriteLine(ex.Message);
            }
        }
    }
}
