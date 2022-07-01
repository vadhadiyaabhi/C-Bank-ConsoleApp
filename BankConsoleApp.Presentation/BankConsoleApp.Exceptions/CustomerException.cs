using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp.Exceptions
{
    public class CustomerException : ApplicationException
    {
        /// <summary>
        /// Constructor that initializes Exception message
        /// </summary>
        /// <param name="message"></param>
        public CustomerException(string message): base(message)
        {

        }

        /// <summary>
        /// Constructor that initializes Exception message as well as innerException details
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public CustomerException(string message, Exception innerException): base(message, innerException)
        {

        }

        protected CustomerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
