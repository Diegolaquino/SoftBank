using SoftBankSPAapi.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftBankSPAapi.Models
{
    public class AccountTransaction
    {
        public int AccountTransactionId { get; set; }

        public Account FromAccount { get; set; }

        public int? FromAccountId { get; set; }

        public Account ToAccount { get; set; }

        public int ToAccountId { get; set; }

        public string Description { get; set; }

        public TransactionType TransactionType { get; set; }
    }
}
