using SoftBankSPAapi.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoftBankSPAapi.Models
{
    [NotMapped]
    public class AccountTransactionModel
    {
        public int id { get; set; }
        public string Description { get; set; }

        public TransactionType Type { get; set; }

        public decimal Value { get; set; }

    }
}
