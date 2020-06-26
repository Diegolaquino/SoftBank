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
    public class UserAccountController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] LoginModel accountLogin)
        {
            var customers = new List<Customer>() {
                new Customer() { CustomerId = 1, CPF = "12960405773", Email = "Diegol.aquino@gmail.com",
                    Name = "Diego Aquino", Phone = "21 9 92034654", Role = "Admin", UserName = "diegolaquino", Password = "123456789",
                    Accounts = new List<Account>() { new Account() { AccountId = 1, AccountNumber = "5555555", AgencyNumber = "5555", Balance = 5000.50M, ContractedProducts = new List<AccountProduct>(), CustomerId = 1, Customer = null }, } }
            };

            var customer = customers.FirstOrDefault(u => u.UserName == accountLogin.UserName && u.Password == accountLogin.Password);

            if (customer == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos" });
            }

            var token = TokenService.GenerateToken(customer);

            customer.Password = "";

            return new
            {
                user = customer,
                token = token
            };
        }

        [HttpGet]
        [Authorize]
        [Route("Authenticated")]
        public string Authenticated() => String.Format("Autenticado {0}", User.Identity.Name);

        [HttpGet]
        [AllowAnonymous]
        [Route("AccountInformation")]
        public async Task<ActionResult<dynamic>> GetAccountInformation([FromQuery] AccountModel account)
        {
            return new
            {
                customer = "Diego lima de Aquino"
            };
        }
    }
}
