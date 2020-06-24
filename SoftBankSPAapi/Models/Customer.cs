using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Security.Principal;

namespace SoftBankSPAapi.Models
{
    public class Customer : IUser
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string UserName { get; set; }

        public string Role { get; set; }

        public string Password { get; set; }

        public List<Account> Accounts { get; set; }
    }
}