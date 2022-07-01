using BankConsoleApp.BusinessLogicLayer.BLLContracts;
using BankConsoleApp.Configuration;
using BankConsoleApp.DataAccessLayer;
using BankConsoleApp.Entities;
using BankConsoleApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp.BusinessLogicLayer
{
    public class CustomersBusinessLogicLayer : ICustomersBusinessLogicLayer
    {
        #region Properties
        private CustomerDataAccessLayer CustomerDataAccess { get; set; }

        #endregion

        #region Constructor
        public CustomersBusinessLogicLayer()
        {
            CustomerDataAccess = new CustomerDataAccessLayer();
        }
        #endregion

        #region Interface Methods
        public long AddCustomer(Customer customer)
        {
            try
            {
                if(CustomerDataAccess.GetCustomers().Count() > 0)
                {
                    customer.CustomerCode = CustomerDataAccess.GetCustomers().Last().CustomerCode + 1;
                }
                else
                {
                    customer.CustomerCode = Configurations.BaseCustomerNumber;
                }
                customer.Id = Guid.NewGuid();
                return CustomerDataAccess.AddCustomer(customer);
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
                return CustomerDataAccess.DeleteCustomer(id);
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
                return CustomerDataAccess.GetCustomers();
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

        public List<Customer> GetFilteredCustomers(Predicate<Customer> condition)
        {
            try
            {
                return CustomerDataAccess.GetCustomerByCondition(condition);
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

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                return CustomerDataAccess.UpdateCustomer(customer);
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
