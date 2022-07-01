using BankConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp.BusinessLogicLayer.BLLContracts
{
    /// <summary>
    /// Interface that represents bussines logic layer for customers
    /// </summary>
    public interface ICustomersBusinessLogicLayer
    {
        #region Methods
        List<Customer> GetCustomers();

        List<Customer> GetFilteredCustomers(Predicate<Customer> condition);

        long AddCustomer(Customer customer);

        bool UpdateCustomer(Customer customer);

        bool DeleteCustomer(Guid id);
        #endregion
    }
}
