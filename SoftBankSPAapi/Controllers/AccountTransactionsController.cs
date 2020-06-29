using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoftBankSPAapi.Models;
using SoftBankSPAapi.Models.Enum;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SoftBankSPAapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountTransactionsController : ControllerBase
    {
        // GET: api/<AccountTransactionsController>
        [AllowAnonymous]
        [Route("BankStatement")]
        [HttpGet]
        public ActionResult<IEnumerable<AccountTransactionModel>> Get()
        {
            return new List<AccountTransactionModel>()
            {
                new AccountTransactionModel()
                {
                    id = 1,
                    Type = TransactionType.Deposit,
                    Description = "Depósito bancário",
                    Value = -445

                },
                new AccountTransactionModel()
                {
                    id = 2,
                    Type = TransactionType.Transfer,
                    Description = "Transferência bancária",
                    Value = -500

                },
                new AccountTransactionModel()
                {
                    id = 3,
                    Type = TransactionType.BankWithdrawal,
                    Description = "Saque 24 HRS",
                    Value = -150

                },
                new AccountTransactionModel()
                {
                    id = 4,
                    Type = TransactionType.Deposit,
                    Description = "Depósito bancário",
                    Value = 200

                },
                new AccountTransactionModel()
                {
                    id = 5,
                    Type = TransactionType.Payment,
                    Description = "Pagamento nubank",
                    Value = -350

                }
            };
        }

        // GET api/<AccountTransactionsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AccountTransactionsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AccountTransactionsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountTransactionsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
