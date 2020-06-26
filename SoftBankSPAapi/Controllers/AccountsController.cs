using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftBankSPAapi.Models;
using SoftBankSPAapi.Services;

namespace SoftBankSPAapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            var diego = new Customer() { CustomerId = 1, CPF = "12960405773", Email = "Diegol.aquino@gmail.com", Name = "Diego Aquino", Phone = "21 9 92034654" };
            IEnumerable<Account> accounts = new List<Account>()
            {
                new Account(){ AccountId = 1, AccountNumber = "1234567", AgencyNumber = "1111", Balance = 5000.50M, ContractedProducts = new List<AccountProduct>(), CustomerId = 1, Customer = diego},
                new Account(){ AccountId = 1, AccountNumber = "7654321", AgencyNumber = "2222", Balance = 10000.50M, ContractedProducts = new List<AccountProduct>(), CustomerId = 1, Customer = diego},
                new Account(){ AccountId = 1, AccountNumber = "7777777", AgencyNumber = "3333", Balance = 15000.50M, ContractedProducts = new List<AccountProduct>(), CustomerId = 1, Customer = diego}
            };

            return accounts.ToList();
        }

        
    }
}