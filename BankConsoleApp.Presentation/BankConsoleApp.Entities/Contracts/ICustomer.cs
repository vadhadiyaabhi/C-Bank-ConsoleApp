using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp.Entities.Contracts
{
    /// <summary>
    /// Represents Interface for Customer entity
    /// </summary>
    internal interface ICustomer
    {
        #region Properties
        Guid Id { get; set; }

        long CustomerCode { get; set; }

        string UserName { get; set; }

        string Password { get; set; }

        string Name { get; set; }

        DateTime DateOfBirth { get; set; }

        string Address { get; set; }

        string City { get; set; }

        string ZipCode { get; set; }

        string Mobile { get; set; }

        #endregion

    }
}
