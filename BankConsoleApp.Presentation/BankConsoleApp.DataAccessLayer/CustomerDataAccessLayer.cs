using BankConsoleApp.DataAccessLayer.Contracts;
using BankConsoleApp.Entities;
using BankConsoleApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BankConsoleApp.DataAccessLayer
{
    public class CustomerDataAccessLayer : ICustomerDataAccessLayer
    {
        #region Private Fields
        private static List<Customer> _Customers;
        #endregion

        #region static Constructor
        static CustomerDataAccessLayer()
        {
            _Customers = new List<Customer>();
        }
        #endregion

        #region Properties
        private static List<Customer> Customers
        {
            get { return _Customers; }
            set { _Customers = value; }
        }
        #endregion

        #region Interface Methods Implementations

        public long AddCustomer(Customer customer)
        {
            try
            {
                Customers.Add(customer);
                return customer.CustomerCode;
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteCustomer(Guid id)
        {
            try
            {
                if (Customers.RemoveAll(x => x.Id == id) > 0)             // RemoveAll returns no. of items those are deletet
                    return true;
                else
                    return false;
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Customer> GetCustomerByCondition(Predicate<Customer> condition)
        {
            try
            {
                List<Customer> customers = new List<Customer>();
                Customers.FindAll(condition).ForEach(obj => customers.Add(obj.Clone() as Customer));
                return customers;
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<Customer> GetCustomers()
        {
            try
            {
                List<Customer> customers = new List<Customer>();
                Customers.ForEach(obj => customers.Add(obj.Clone() as Customer));
                return customers;
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

            // NOTE: If we throw like throw ex; THEN it will overwrite old stack and this will be considered as the origin of exception
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                Customer existingCustomer = Customers.Find(item => item.Id == customer.Id);

                if (existingCustomer != null)
                {
                    existingCustomer.Name = customer.Name;
                    existingCustomer.UserName = customer.UserName;
                    existingCustomer.Password = customer.Password;
                    existingCustomer.Address = customer.Address;
                    existingCustomer.ZipCode = customer.ZipCode;
                    existingCustomer.City = customer.City;
                    existingCustomer.Mobile = customer.Mobile;
                    existingCustomer.DateOfBirth = customer.DateOfBirth;

                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        #endregion


    }
}
