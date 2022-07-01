using BankConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankConsoleApp.DataAccessLayer.Contracts
{
    /// <summary>
    /// Interface that contains the logic for customer's Data Access Layer
    /// </summary>
    internal interface ICustomerDataAccessLayer
    {
        /// <summary>
        /// returns the list of all customer
        /// </summary>
        /// <returns></returns>
        List<Customer> GetCustomers();
        
        /// <summary>
        /// returns all the customers that mathces to the conditions
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        List<Customer> GetCustomerByCondition(Predicate<Customer> condition);

        /// <summary>
        /// Add new customer
        /// </summary>
        /// <returns></returns>
        long AddCustomer(Customer customer);

        /// <summary>
        /// Update existing customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        bool UpdateCustomer(Customer customer);

        /// <summary>
        /// Delete customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        bool DeleteCustomer(Guid id);
    }
}
