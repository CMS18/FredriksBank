using System;
using System.Collections.Generic;

namespace FredriksBank.Data
{
    public class BankRepository
    {
        private static List<Customer> Customers = new List<Customer>
        {
            new Customer
            {
                Id = 1,
                Name = "Fredrik",
                Accounts = {
                    new Account{
                    AccountId = 100101,
                    Balance = 1000000}
                }
            },
            new Customer
            {
                Id = 1,
                Name = "Albin",
                Accounts = {
                    new Account{
                    AccountId = 100102,
                    Balance = 10000000}
                }
            }
        };
        
        public IList<Customer> GetAllCustomers()
        {
            return Customers;
        }

    }
}
