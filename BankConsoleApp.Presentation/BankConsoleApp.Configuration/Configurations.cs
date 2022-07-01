using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp.Configuration
{
    /// <summary>
    /// Project level configuration setting
    /// </summary>
    public static class Configurations
    {
        /// <summary>
        /// CustomerCode number starts from 1000; Can be incremented by 1
        /// </summary>
        public static long BaseCustomerNumber { get; set; } = 1000; 
    }
}
