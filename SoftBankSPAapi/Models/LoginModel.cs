using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftBankSPAapi.Models
{
    public class LoginModel : IUser
    {
        public string UserName { get; set ; }
        public string Role { get; set ; }
        public string Password { get; set; }
    }
}
