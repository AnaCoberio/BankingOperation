using System;
using System.Text;
using BankingOperation.Entities;


namespace BankingOperation.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {
            
        }

    }
}
