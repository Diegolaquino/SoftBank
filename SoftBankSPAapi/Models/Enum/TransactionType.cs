﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftBankSPAapi.Models.Enum
{
    public enum TransactionType
    {
        [Display(Name = "Pagamento")]
        Payment = 1,

        [Display(Name ="Transferência")]
        Transfer = 2,

        [Display(Name = "Saque")]
        BankWithdrawal = 3,

        [Display(Name = "Depósito")]
        Deposit = 4
    }
}
