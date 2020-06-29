using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftBankSPAapi.Models
{
    public class BankStatement
    {
        public BankStatement()
        {

        }
        public DateTime StartDate { get; private set; }

        public DateTime EndtDate { get; private set; }

        public List<AccountTransaction> Transactions { get; private set; }
    }
}
