using System;
using System.Collections.Generic;
using System.Text;

namespace FredriksBank.Data
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Account> Accounts { get; set; }
    }
}
