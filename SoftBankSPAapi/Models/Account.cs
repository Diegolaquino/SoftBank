using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftBankSPAapi.Models
{
    public class Account
    {
        public int AccountId { get; set; }

        public virtual Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public decimal Balance { get; set; }

        public int AgencyNumber { get; set; }

        public int AccountNumber { get; set; }

        public List<AccountantService> ContractedServices { get; set; }
    }
}
